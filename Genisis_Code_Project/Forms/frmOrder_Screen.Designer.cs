namespace Genesis_Code_Project
{
    partial class frmOrder_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder_Screen));
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldReferenceNumber1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderValue1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.PVGOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomerFirstName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.grdOrders = new DevExpress.XtraGrid.GridControl();
            this.grdOrdersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnViewCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(OrderMod.Order);
            // 
            // fieldReferenceNumber1
            // 
            this.fieldReferenceNumber1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldReferenceNumber1.AreaIndex = 0;
            this.fieldReferenceNumber1.FieldName = "ReferenceNumber";
            this.fieldReferenceNumber1.Name = "fieldReferenceNumber1";
            // 
            // fieldOrderValue1
            // 
            this.fieldOrderValue1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOrderValue1.AreaIndex = 1;
            this.fieldOrderValue1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldOrderValue1.FieldName = "OrderValue";
            this.fieldOrderValue1.Name = "fieldOrderValue1";
            // 
            // PVGOrderDate
            // 
            this.PVGOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.PVGOrderDate.AreaIndex = 2;
            this.PVGOrderDate.Caption = "Ord Date";
            this.PVGOrderDate.CellFormat.FormatString = "dd MMM YYYY";
            this.PVGOrderDate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.PVGOrderDate.FieldName = "OrderDate";
            this.PVGOrderDate.Name = "PVGOrderDate";
            // 
            // fieldCustomerFirstName
            // 
            this.fieldCustomerFirstName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCustomerFirstName.AreaIndex = 3;
            this.fieldCustomerFirstName.Caption = "Customer Name";
            this.fieldCustomerFirstName.FieldName = "Customer.LastName";
            this.fieldCustomerFirstName.Name = "fieldCustomerFirstName";
            // 
            // grdOrders
            // 
            this.grdOrders.DataSource = typeof(OrderModel.Order);
            this.grdOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrders.Location = new System.Drawing.Point(0, 0);
            this.grdOrders.MainView = this.grdOrdersView;
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnViewCustomer});
            this.grdOrders.Size = new System.Drawing.Size(773, 407);
            this.grdOrders.TabIndex = 2;
            this.grdOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdOrdersView});
            // 
            // grdOrdersView
            // 
            this.grdOrdersView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grdOrdersView.Appearance.OddRow.Options.UseBackColor = true;
            this.grdOrdersView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grdOrdersView.Appearance.Row.Options.UseBackColor = true;
            this.grdOrdersView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCustomerId,
            this.colReferenceNumber,
            this.colOrderValue,
            this.colOrderDate,
            this.colFirstName,
            this.colLastName,
            this.colEdit});
            this.grdOrdersView.GridControl = this.grdOrders;
            this.grdOrdersView.Name = "grdOrdersView";
            this.grdOrdersView.OptionsBehavior.AllowIncrementalSearch = true;
            this.grdOrdersView.OptionsFilter.UseNewCustomFilterDialog = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            // 
            // colReferenceNumber
            // 
            this.colReferenceNumber.FieldName = "ReferenceNumber";
            this.colReferenceNumber.Name = "colReferenceNumber";
            this.colReferenceNumber.OptionsColumn.AllowEdit = false;
            this.colReferenceNumber.Visible = true;
            this.colReferenceNumber.VisibleIndex = 0;
            this.colReferenceNumber.Width = 127;
            // 
            // colOrderValue
            // 
            this.colOrderValue.DisplayFormat.FormatString = "#0.00";
            this.colOrderValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOrderValue.FieldName = "OrderValue";
            this.colOrderValue.Name = "colOrderValue";
            this.colOrderValue.OptionsColumn.AllowEdit = false;
            this.colOrderValue.Visible = true;
            this.colOrderValue.VisibleIndex = 1;
            this.colOrderValue.Width = 126;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.OptionsColumn.AllowEdit = false;
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 2;
            this.colOrderDate.Width = 184;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "Customer.FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowEdit = false;
            this.colFirstName.Width = 165;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "Customer.LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Width = 148;
            // 
            // colEdit
            // 
            this.colEdit.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("colEdit.AppearanceCell.Image")));
            this.colEdit.AppearanceCell.Options.HighPriority = true;
            this.colEdit.AppearanceCell.Options.UseImage = true;
            this.colEdit.Caption = "View";
            this.colEdit.ColumnEdit = this.btnViewCustomer;
            this.colEdit.Name = "colEdit";
            this.colEdit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 3;
            this.colEdit.Width = 397;
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCustomer.Appearance.Image")));
            this.btnViewCustomer.Appearance.Options.UseImage = true;
            this.btnViewCustomer.AutoHeight = false;
            this.btnViewCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnViewCustomer.LookAndFeel.SkinName = "Seven Classic";
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmOrder_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 407);
            this.Controls.Add(this.grdOrders);
            this.Name = "frmOrder_Screen";
            this.Text = "frmOrder_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView grdOrdersView;
        private DevExpress.XtraPivotGrid.PivotGridField fieldReferenceNumber1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderValue1;
        private DevExpress.XtraPivotGrid.PivotGridField PVGOrderDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomerFirstName;
        
        
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderValue;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        public DevExpress.XtraGrid.GridControl grdOrders;
        public System.Windows.Forms.BindingSource ordersBindingSource;
    }
}