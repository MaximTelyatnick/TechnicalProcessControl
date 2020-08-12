namespace TechnicalProcessControl
{
    partial class ProductionFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionFm));
            this.productionRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.productionGrid = new DevExpress.XtraGrid.GridControl();
            this.productionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descriptionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TechnicalProcessControl.WaitFm), true, true);
            this.updateBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.productionRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productionRibbon
            // 
            this.productionRibbon.ExpandCollapseItem.Id = 0;
            this.productionRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.productionRibbon.ExpandCollapseItem,
            this.addBtn,
            this.editBtn,
            this.deleteBtn,
            this.updateBtn});
            this.productionRibbon.Location = new System.Drawing.Point(0, 0);
            this.productionRibbon.MaxItemId = 5;
            this.productionRibbon.Name = "productionRibbon";
            this.productionRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.productionRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.productionRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.productionRibbon.Size = new System.Drawing.Size(1162, 95);
            this.productionRibbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Добавить";
            this.addBtn.Id = 1;
            this.addBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.ImageOptions.Image")));
            this.addBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addBtn.ImageOptions.LargeImage")));
            this.addBtn.Name = "addBtn";
            this.addBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
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
            this.ribbonPageGroup1.Text = "Продукция";
            // 
            // productionGrid
            // 
            this.productionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionGrid.Location = new System.Drawing.Point(0, 95);
            this.productionGrid.MainView = this.productionGridView;
            this.productionGrid.Name = "productionGrid";
            this.productionGrid.Size = new System.Drawing.Size(1162, 304);
            this.productionGrid.TabIndex = 1;
            this.productionGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productionGridView});
            // 
            // productionGridView
            // 
            this.productionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameCol,
            this.typeCol,
            this.descriptionCol});
            this.productionGridView.GridControl = this.productionGrid;
            this.productionGridView.GroupCount = 1;
            this.productionGridView.Name = "productionGridView";
            this.productionGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.nameCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // nameCol
            // 
            this.nameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCol.AppearanceHeader.Options.UseFont = true;
            this.nameCol.Caption = "Поставщик";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            // 
            // typeCol
            // 
            this.typeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCol.AppearanceHeader.Options.UseFont = true;
            this.typeCol.Caption = "Тип битума";
            this.typeCol.FieldName = "Type";
            this.typeCol.Name = "typeCol";
            this.typeCol.OptionsColumn.AllowEdit = false;
            this.typeCol.OptionsColumn.AllowFocus = false;
            this.typeCol.Visible = true;
            this.typeCol.VisibleIndex = 0;
            // 
            // descriptionCol
            // 
            this.descriptionCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionCol.AppearanceHeader.Options.UseFont = true;
            this.descriptionCol.Caption = "Описание";
            this.descriptionCol.FieldName = "Description";
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.OptionsColumn.AllowEdit = false;
            this.descriptionCol.OptionsColumn.AllowFocus = false;
            this.descriptionCol.Visible = true;
            this.descriptionCol.VisibleIndex = 1;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // updateBtn
            // 
            this.updateBtn.Caption = "Обновить";
            this.updateBtn.Id = 4;
            this.updateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageOptions.Image")));
            this.updateBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageOptions.LargeImage")));
            this.updateBtn.Name = "updateBtn";
            // 
            // ProductionFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 399);
            this.Controls.Add(this.productionGrid);
            this.Controls.Add(this.productionRibbon);
            this.Name = "ProductionFm";
            ((System.ComponentModel.ISupportInitialize)(this.productionRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl productionRibbon;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl productionGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView productionGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn typeCol;
        private DevExpress.XtraGrid.Columns.GridColumn descriptionCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarButtonItem updateBtn;
    }
}