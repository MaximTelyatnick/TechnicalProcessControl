namespace TerminalMKBot
{
    partial class ShipmentRoadFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentRoadFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editCashContractorBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.shipmentRoadGrid = new DevExpress.XtraGrid.GridControl();
            this.shipmentRoadGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contractorCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productTypeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loadAreaCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unloadAreaCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.distanceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.updateBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentRoadGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentRoadGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addBtn,
            this.editBtn,
            this.deleteBtn,
            this.editCashContractorBtn,
            this.updateBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1053, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Добавить";
            this.addBtn.Id = 1;
            this.addBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.ImageOptions.Image")));
            this.addBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addBtn.ImageOptions.LargeImage")));
            this.addBtn.Name = "addBtn";
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редактировать";
            this.editBtn.Id = 2;
            this.editBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.ImageOptions.Image")));
            this.editBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editBtn.ImageOptions.LargeImage")));
            this.editBtn.Name = "editBtn";
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Удалить";
            this.deleteBtn.Id = 3;
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.LargeImage")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // editCashContractorBtn
            // 
            this.editCashContractorBtn.Caption = "Изменть цену ";
            this.editCashContractorBtn.Id = 4;
            this.editCashContractorBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editCashContractorBtn.ImageOptions.Image")));
            this.editCashContractorBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editCashContractorBtn.ImageOptions.LargeImage")));
            this.editCashContractorBtn.Name = "editCashContractorBtn";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.updateBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Маршрут";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.editCashContractorBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Функции по контрагенту";
            // 
            // shipmentRoadGrid
            // 
            this.shipmentRoadGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipmentRoadGrid.Location = new System.Drawing.Point(0, 95);
            this.shipmentRoadGrid.MainView = this.shipmentRoadGridView;
            this.shipmentRoadGrid.Name = "shipmentRoadGrid";
            this.shipmentRoadGrid.Size = new System.Drawing.Size(1053, 378);
            this.shipmentRoadGrid.TabIndex = 1;
            this.shipmentRoadGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.shipmentRoadGridView});
            // 
            // shipmentRoadGridView
            // 
            this.shipmentRoadGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.contractorCol,
            this.productTypeCol,
            this.loadAreaCol,
            this.unloadAreaCol,
            this.distanceCol,
            this.priceCol});
            this.shipmentRoadGridView.GridControl = this.shipmentRoadGrid;
            this.shipmentRoadGridView.GroupCount = 1;
            this.shipmentRoadGridView.Name = "shipmentRoadGridView";
            this.shipmentRoadGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.contractorCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // contractorCol
            // 
            this.contractorCol.Caption = "Контрагент";
            this.contractorCol.FieldName = "ContractorName";
            this.contractorCol.Name = "contractorCol";
            this.contractorCol.OptionsColumn.AllowEdit = false;
            this.contractorCol.OptionsColumn.AllowFocus = false;
            this.contractorCol.Visible = true;
            this.contractorCol.VisibleIndex = 0;
            // 
            // productTypeCol
            // 
            this.productTypeCol.Caption = "Вид товара";
            this.productTypeCol.FieldName = "ProductionName";
            this.productTypeCol.Name = "productTypeCol";
            this.productTypeCol.OptionsColumn.AllowEdit = false;
            this.productTypeCol.OptionsColumn.AllowFocus = false;
            this.productTypeCol.Visible = true;
            this.productTypeCol.VisibleIndex = 0;
            // 
            // loadAreaCol
            // 
            this.loadAreaCol.Caption = "Пункт загрузки";
            this.loadAreaCol.FieldName = "LoadAreaName";
            this.loadAreaCol.Name = "loadAreaCol";
            this.loadAreaCol.OptionsColumn.AllowEdit = false;
            this.loadAreaCol.OptionsColumn.AllowFocus = false;
            this.loadAreaCol.Visible = true;
            this.loadAreaCol.VisibleIndex = 1;
            // 
            // unloadAreaCol
            // 
            this.unloadAreaCol.Caption = "Пункт выгрузки";
            this.unloadAreaCol.FieldName = "UnloadAreaName";
            this.unloadAreaCol.Name = "unloadAreaCol";
            this.unloadAreaCol.OptionsColumn.AllowEdit = false;
            this.unloadAreaCol.OptionsColumn.AllowFocus = false;
            this.unloadAreaCol.Visible = true;
            this.unloadAreaCol.VisibleIndex = 2;
            // 
            // distanceCol
            // 
            this.distanceCol.Caption = "Расстояние";
            this.distanceCol.FieldName = "Distance";
            this.distanceCol.Name = "distanceCol";
            this.distanceCol.OptionsColumn.AllowEdit = false;
            this.distanceCol.OptionsColumn.AllowFocus = false;
            this.distanceCol.Visible = true;
            this.distanceCol.VisibleIndex = 3;
            // 
            // priceCol
            // 
            this.priceCol.Caption = "Цена";
            this.priceCol.FieldName = "Rate";
            this.priceCol.Name = "priceCol";
            this.priceCol.OptionsColumn.AllowEdit = false;
            this.priceCol.OptionsColumn.AllowFocus = false;
            this.priceCol.Visible = true;
            this.priceCol.VisibleIndex = 4;
            // 
            // updateBtn
            // 
            this.updateBtn.Caption = "Обновить";
            this.updateBtn.Id = 5;
            this.updateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageOptions.Image")));
            this.updateBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageOptions.LargeImage")));
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateBtn_ItemClick);
            // 
            // ShipmentRoadFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 473);
            this.Controls.Add(this.shipmentRoadGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ShipmentRoadFm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentRoadGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentRoadGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl shipmentRoadGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView shipmentRoadGridView;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem editCashContractorBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn contractorCol;
        private DevExpress.XtraGrid.Columns.GridColumn productTypeCol;
        private DevExpress.XtraGrid.Columns.GridColumn loadAreaCol;
        private DevExpress.XtraGrid.Columns.GridColumn unloadAreaCol;
        private DevExpress.XtraGrid.Columns.GridColumn distanceCol;
        private DevExpress.XtraGrid.Columns.GridColumn priceCol;
        private DevExpress.XtraBars.BarButtonItem updateBtn;
    }
}