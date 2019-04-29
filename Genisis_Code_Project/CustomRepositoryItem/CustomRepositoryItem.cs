﻿// Developer Express Code Central Example:
// How to put a custom UserControl in a GridView cell
// 
// This example demonstrates how a custom UserControl can be used as an in-place
// editor in GridView, TreeList, Ribbon and Vertical Grid. As described in the
// http://www.devexpress.com/scid=A128 Knowledge Base, it is not possible to just
// place a control within a cell, because cells are not controls. When a cell's
// editor is not activated, its content is drawn via a painter. So, in our example,
// we have created a painter to draw the entire UserControl's content. All cells in
// GridView will be drawn using this painter until an end-user clicks a cell. In
// this case, an actual instance of the UserControl class will be created. Controls
// inherited from the BaseEdit class are drawn via their painters, other controls
// are drawn via the DrawToBitmap function. In case of 3rd-party controls, you need
// to draw them manually. If you want to use your custom control in GridView or
// other controls, you need to implement the IEditValue interface in it.
// 
// See
// also: http://www.devexpress.com/scid=E2198
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3051

// Developer Express Code Central Example:
// How to put a custom UserControl in a GridView cell
// 
// This example demonstrates how a custom UserControl can be used as an in-place
// editor in GridView. As described in the http://www.devexpress.com/scid=A128
// Knowledge Base, it is not possible to just place a control within a cell,
// because cells are not controls. When a cell's editor is not activated, its
// content is drawn via a painter. So, in our example, we have created a painter to
// draw the entire UserControl's content. All cells in GridView will be drawn using
// this painter until an end-user clicks a cell. In this case, an actual instance
// of the UserControl class will be created. Controls inherited from the BaseEdit
// class are drawn via their painters, other controls are drawn via the
// DrawToBitmap function. In case of 3rd-party controls, you need to draw them
// manually. If you want to use your custom control in GridView or other controls,
// you need to implement the IEditValue interface in it.
// 
// See also:
// http://www.devexpress.com/scid=E2198
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3051

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Mask;

namespace CustomControlInGrid
{
    [UserRepositoryItem("Register")]
    class CustomRepositoryItem : RepositoryItem
    {
        private static readonly object drawControlInit = new object();
        private static readonly object editorControlInit = new object();
        private static readonly object controlTypeChanged = new object();
        public event EventHandler ControlTypeChanged
        {
            add { this.Events.AddHandler(controlTypeChanged, value); }
            remove { this.Events.RemoveHandler(controlTypeChanged, value); }
        }
        public event EventHandler EditorControlInitialized
        {
            add { this.Events.AddHandler(editorControlInit, value); }
            remove { this.Events.RemoveHandler(editorControlInit, value); }
        }
        public event EventHandler DrawControlInitialized
        {
            add { this.Events.AddHandler(drawControlInit, value); }
            remove { this.Events.RemoveHandler(drawControlInit, value); }
        }
        UserControl _drawControl;
        internal UserControl DrawControl
        {
            get
            {
                if (_drawControl == null)
                {
                    if (ControlType == null)
                        return null;
                    ConstructorInfo cConstructor = ControlType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance | BindingFlags.NonPublic, null, new Type[] { }, null);
                    _drawControl = cConstructor.Invoke(null) as UserControl;
                    if (cConstructor == null)
                        return null;
                    OnDrawControlInitialized();

                }
                return _drawControl;
            }
        }
        UserControl _editorControl;
        internal UserControl EditorControl
        {
            get
            {
                if (_editorControl == null)
                {
                    if (ControlType == null)
                        return null;
                    ConstructorInfo cConstructor = ControlType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance | BindingFlags.NonPublic, null, new Type[] { }, null);
                    if (cConstructor == null)
                        return null;
                    _editorControl = cConstructor.Invoke(null) as UserControl;
                    _editorControl.Dock = DockStyle.Fill;
                    OnEditorControlInitialized();
                }
                return _editorControl;
            }
        }

        Type _controlType;
        public Type ControlType
        {
            get { return _controlType; }
            set
            {
                if (_controlType == value)
                    return;
                _controlType = value;
                _drawControl = null;
                _editorControl = null;
                this.OnControlTypeChanged();
                this.OnPropertiesChanged();
            }
        }
        void OnControlTypeChanged()
        {
            if ((OwnerEdit as CustomControl) != null)
                (OwnerEdit as CustomControl).UpdateControls();
            EventHandler handler = (EventHandler)this.Events[controlTypeChanged];
            if (handler != null) handler(this, EventArgs.Empty);

        }
        void OnEditorControlInitialized()
        {
            EventHandler handler = (EventHandler)this.Events[editorControlInit];
            if (handler != null) handler(_editorControl, EventArgs.Empty);

        }
        void OnDrawControlInitialized()
        {
            EventHandler handler = (EventHandler)this.Events[drawControlInit];
            if (handler != null) handler(_drawControl, EventArgs.Empty);

        }

        static CustomRepositoryItem()
        {
            Register();
        }
        public CustomRepositoryItem()
            : base()
        {
        }
        internal const string EditorName = "CustomControl";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(CustomControl),
                typeof(CustomRepositoryItem), typeof(CustomControlViewInfo),
                new CustomControlPainter(), true, null));
        }
        public override string EditorTypeName
        {
            get { return EditorName; }
        }
        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            CustomRepositoryItem rItem = item as CustomRepositoryItem;
            if (rItem != null)
            {
                Events.AddHandler(drawControlInit, rItem.Events[drawControlInit]);
                Events.AddHandler(editorControlInit, rItem.Events[editorControlInit]);
                Events.AddHandler(controlTypeChanged, rItem.Events[controlTypeChanged]);
                ControlType = rItem.ControlType;
            }

        }
        public override void ResetEvents()
        {
            base.ResetEvents();
        }

        protected override bool NeededKeysContains(Keys key) {
            switch (key) {
                case Keys.F2:
                case Keys.A:
                case Keys.Add:
                case Keys.B:
                case Keys.Back:
                case Keys.C:
                case Keys.Clear:
                case Keys.D:
                case Keys.D0:
                case Keys.D1:
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9:
                case Keys.Decimal:
                case Keys.Delete:
                case Keys.Divide:
                case Keys.E:
                case Keys.End:
                case Keys.F:
                case Keys.F20:
                case Keys.G:
                case Keys.H:
                case Keys.Home:
                case Keys.I:
                case Keys.Insert:
                case Keys.J:
                case Keys.K:
                case Keys.L:
                case Keys.Left:
                case Keys.M:
                case Keys.Multiply:
                case Keys.N:
                case Keys.NumPad0:
                case Keys.NumPad1:
                case Keys.NumPad2:
                case Keys.NumPad3:
                case Keys.NumPad4:
                case Keys.NumPad5:
                case Keys.NumPad6:
                case Keys.NumPad7:
                case Keys.NumPad8:
                case Keys.NumPad9:
                case Keys.Alt:
                case (Keys.RButton | Keys.ShiftKey):
                case Keys.O:
                case Keys.Oem8:
                case Keys.OemBackslash:
                case Keys.OemCloseBrackets:
                case Keys.Oemcomma:
                case Keys.OemMinus:
                case Keys.OemOpenBrackets:
                case Keys.OemPeriod:
                case Keys.OemPipe:
                case Keys.Oemplus:
                case Keys.OemQuestion:
                case Keys.OemQuotes:
                case Keys.OemSemicolon:
                case Keys.Oemtilde:
                case Keys.P:
                case Keys.Q:
                case Keys.R:
                case Keys.Right:
                case Keys.S:
                case Keys.Space:
                case Keys.Subtract:
                case Keys.T:
                case Keys.U:
                case Keys.V:
                case Keys.W:
                case Keys.X:
                case Keys.Y:
                case Keys.Z:
                    return true;
            }
            return base.NeededKeysContains(key);
        }

    }
}
