using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CustomControlInGrid;

namespace Genisis_Code_Project{
    public partial class MyUserControl : XtraUserControl, IEditValue {
        public MyUserControl() {
            InitializeComponent();
        }

        public object EditValue {
            get {
                throw new NotImplementedException();
            }
            set {
                Tuple<string> t = value as Tuple<string>;
                if (t != null) {
                    lblCustomerName.Text = t.Item1;
                }
            }
        }
    }
}
