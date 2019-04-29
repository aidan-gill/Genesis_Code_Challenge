using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace Genesis_Code_Project
{
    
    public partial class frmView_Customer_Screen : Form
    {
        private bool _Canceling;
        private OrderModel.Order _custOrder;
        private GridControl _xGridOrderScreen;

    #region "Properties"

        public OrderModel.Order Order
        {
            get
            {
                return _custOrder;
            }
            set
            {
                if (_custOrder == value) return;
                _custOrder = value;
                UpdateControls();
            }
        }
        public GridControl GridOrderScreen
        {
            get
            {
                return _xGridOrderScreen;
            }
            set
            {
                if (_xGridOrderScreen == value) return;
                _xGridOrderScreen = value;
            }
        }
    #endregion

    #region "Form Controls"
        public frmView_Customer_Screen(OrderModel.Order GridRow, ref GridControl grdOrderScreen)
        {
            try
            {
                InitializeComponent();
                Order = GridRow;
                GridOrderScreen = grdOrderScreen;
                this.Text = string.Format("Edit record #{0}",Order.Id); 
            }
            catch (Exception ex)
            {

                string message = ex.Message + "\n   ::::::::::::: \n" + ex.StackTrace;
                MessageBox.Show(message, "Genesis - frmView_Customer_Screen ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }	
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!_Canceling)
            {
                UpdateDataRow();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateDataRow();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Canceling = true;
            this.Close();
        }

    #endregion


    #region "Code Block"
            private void UpdateControls()
            {
                try
                {
                    txtFirstName.Text = Order.Customer.FirstName;
                    txtLastName.Text = Order.Customer.LastName;
                    
                }
                catch (Exception ex)
                {

                    string message = ex.Message + "\n   ::::::::::::: \n" + ex.StackTrace;
                    MessageBox.Show(message, "Genesis - UpdateControls ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }	
            }
            private void UpdateDataRow()
            {
                try
                {
                    Order.Customer.FirstName = txtFirstName.Text;
                    Order.Customer.LastName = txtLastName.Text;
                    GridOrderScreen.MainView.UpdateCurrentRow();
 
                }
                catch (Exception ex)
                {

                    string message = ex.Message + "\n   ::::::::::::: \n" + ex.StackTrace;
                    MessageBox.Show(message, "Genesis - UpdateDataRow ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }	

            }
        #endregion

    }
}
