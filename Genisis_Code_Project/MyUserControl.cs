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

//Aidan Gill April 2019
//Control to show the Customer Name which is the First Name and Last Name joined
namespace Genesis_Code_Project{
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
        public event EventHandler EditValueChanged;
    }
}
