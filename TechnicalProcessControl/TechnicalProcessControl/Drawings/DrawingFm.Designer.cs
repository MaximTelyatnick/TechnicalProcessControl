namespace TechnicalProcessControl.Drawings
{
    partial class DrawingFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingFm));
            this.drawingRibon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.drawingGrid = new DevExpress.XtraGrid.GridControl();
            this.drawingGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.updateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.typeNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.materialCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weightCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.w2Col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LQuantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TechnicalProcessControl.WaitFm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.drawingRibon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingRibon
            // 
            this.drawingRibon.ExpandCollapseItem.Id = 0;
            this.drawingRibon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.drawingRibon.ExpandCollapseItem,
            this.addBtn,
            this.editBtn,
            this.deleteBtn,
            this.updateBtn});
            this.drawingRibon.Location = new System.Drawing.Point(0, 0);
            this.drawingRibon.MaxItemId = 5;
            this.drawingRibon.Name = "drawingRibon";
            this.drawingRibon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.drawingRibon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.drawingRibon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.drawingRibon.Size = new System.Drawing.Size(1181, 95);
            this.drawingRibon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.updateBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Операции над чертежом";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // drawingGrid
            // 
            this.drawingGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingGrid.Location = new System.Drawing.Point(0, 95);
            this.drawingGrid.MainView = this.drawingGridView;
            this.drawingGrid.Name = "drawingGrid";
            this.drawingGrid.Size = new System.Drawing.Size(1181, 441);
            this.drawingGrid.TabIndex = 1;
            this.drawingGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.drawingGridView});
            // 
            // drawingGridView
            // 
            this.drawingGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.typeNameCol,
            this.numberCol,
            this.detailCol,
            this.materialCol,
            this.weightCol,
            this.thCol,
            this.wCol,
            this.w2Col,
            this.LCol,
            this.quantityCol,
            this.LQuantityCol,
            this.rCol});
            this.drawingGridView.GridControl = this.drawingGrid;
            this.drawingGridView.Name = "drawingGridView";
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Добавить";
            this.addBtn.Id = 1;
            this.addBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.addBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.addBtn.Name = "addBtn";
            this.addBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Изменить";
            this.editBtn.Id = 2;
            this.editBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.editBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.editBtn.Name = "editBtn";
            this.editBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Удалить";
            this.deleteBtn.Id = 3;
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.deleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // updateBtn
            // 
            this.updateBtn.Caption = "Обновить";
            this.updateBtn.Id = 4;
            this.updateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageOptions.Image")));
            this.updateBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageOptions.LargeImage")));
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // typeNameCol
            // 
            this.typeNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeNameCol.AppearanceHeader.Options.UseFont = true;
            this.typeNameCol.Caption = "Тип";
            this.typeNameCol.FieldName = "TypeName";
            this.typeNameCol.Name = "typeNameCol";
            this.typeNameCol.OptionsColumn.AllowEdit = false;
            this.typeNameCol.OptionsColumn.AllowFocus = false;
            this.typeNameCol.Visible = true;
            this.typeNameCol.VisibleIndex = 0;
            // 
            // numberCol
            // 
            this.numberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberCol.AppearanceHeader.Options.UseFont = true;
            this.numberCol.Caption = "Чертеж";
            this.numberCol.FieldName = "Number";
            this.numberCol.Name = "numberCol";
            this.numberCol.OptionsColumn.AllowEdit = false;
            this.numberCol.OptionsColumn.AllowFocus = false;
            this.numberCol.Visible = true;
            this.numberCol.VisibleIndex = 1;
            // 
            // detailCol
            // 
            this.detailCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailCol.AppearanceHeader.Options.UseFont = true;
            this.detailCol.Caption = "Деталь";
            this.detailCol.FieldName = "DetailName";
            this.detailCol.Name = "detailCol";
            this.detailCol.OptionsColumn.AllowEdit = false;
            this.detailCol.OptionsColumn.AllowFocus = false;
            this.detailCol.Visible = true;
            this.detailCol.VisibleIndex = 2;
            // 
            // materialCol
            // 
            this.materialCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialCol.AppearanceHeader.Options.UseFont = true;
            this.materialCol.Caption = "Материал";
            this.materialCol.FieldName = "MaterialName";
            this.materialCol.Name = "materialCol";
            this.materialCol.OptionsColumn.AllowEdit = false;
            this.materialCol.OptionsColumn.AllowFocus = false;
            this.materialCol.Visible = true;
            this.materialCol.VisibleIndex = 3;
            // 
            // weightCol
            // 
            this.weightCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightCol.AppearanceHeader.Options.UseFont = true;
            this.weightCol.Caption = "Вес детали";
            this.weightCol.FieldName = "DetailWeight";
            this.weightCol.Name = "weightCol";
            this.weightCol.OptionsColumn.AllowEdit = false;
            this.weightCol.OptionsColumn.AllowFocus = false;
            this.weightCol.Visible = true;
            this.weightCol.VisibleIndex = 4;
            // 
            // thCol
            // 
            this.thCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thCol.AppearanceHeader.Options.UseFont = true;
            this.thCol.Caption = "TH";
            this.thCol.FieldName = "TH";
            this.thCol.Name = "thCol";
            this.thCol.OptionsColumn.AllowEdit = false;
            this.thCol.OptionsColumn.AllowFocus = false;
            this.thCol.Visible = true;
            this.thCol.VisibleIndex = 5;
            // 
            // wCol
            // 
            this.wCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wCol.AppearanceHeader.Options.UseFont = true;
            this.wCol.Caption = "W";
            this.wCol.FieldName = "W";
            this.wCol.Name = "wCol";
            this.wCol.OptionsColumn.AllowEdit = false;
            this.wCol.OptionsColumn.AllowFocus = false;
            this.wCol.Visible = true;
            this.wCol.VisibleIndex = 6;
            // 
            // w2Col
            // 
            this.w2Col.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.w2Col.AppearanceHeader.Options.UseFont = true;
            this.w2Col.Caption = "W2";
            this.w2Col.FieldName = "W2";
            this.w2Col.Name = "w2Col";
            this.w2Col.OptionsColumn.AllowEdit = false;
            this.w2Col.OptionsColumn.AllowFocus = false;
            this.w2Col.Visible = true;
            this.w2Col.VisibleIndex = 7;
            // 
            // LCol
            // 
            this.LCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCol.AppearanceHeader.Options.UseFont = true;
            this.LCol.Caption = "L";
            this.LCol.FieldName = "L";
            this.LCol.Name = "LCol";
            this.LCol.OptionsColumn.AllowEdit = false;
            this.LCol.OptionsColumn.AllowFocus = false;
            this.LCol.Visible = true;
            this.LCol.VisibleIndex = 8;
            // 
            // quantityCol
            // 
            this.quantityCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityCol.AppearanceHeader.Options.UseFont = true;
            this.quantityCol.Caption = "Количество";
            this.quantityCol.FieldName = "Quantity";
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.OptionsColumn.AllowEdit = false;
            this.quantityCol.OptionsColumn.AllowFocus = false;
            this.quantityCol.Visible = true;
            this.quantityCol.VisibleIndex = 9;
            // 
            // LQuantityCol
            // 
            this.LQuantityCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LQuantityCol.AppearanceHeader.Options.UseFont = true;
            this.LQuantityCol.Caption = "L";
            this.LQuantityCol.FieldName = "QuantityR";
            this.LQuantityCol.Name = "LQuantityCol";
            this.LQuantityCol.OptionsColumn.AllowEdit = false;
            this.LQuantityCol.OptionsColumn.AllowFocus = false;
            this.LQuantityCol.Visible = true;
            this.LQuantityCol.VisibleIndex = 10;
            // 
            // rCol
            // 
            this.rCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rCol.AppearanceHeader.Options.UseFont = true;
            this.rCol.Caption = "R";
            this.rCol.FieldName = "QuantityL";
            this.rCol.Name = "rCol";
            this.rCol.OptionsColumn.AllowEdit = false;
            this.rCol.OptionsColumn.AllowFocus = false;
            this.rCol.Visible = true;
            this.rCol.VisibleIndex = 11;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // DrawingFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 536);
            this.Controls.Add(this.drawingGrid);
            this.Controls.Add(this.drawingRibon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrawingFm";
            this.Text = "Чертежи";
            ((System.ComponentModel.ISupportInitialize)(this.drawingRibon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl drawingRibon;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem updateBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl drawingGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView drawingGridView;
        private DevExpress.XtraGrid.Columns.GridColumn typeNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn numberCol;
        private DevExpress.XtraGrid.Columns.GridColumn detailCol;
        private DevExpress.XtraGrid.Columns.GridColumn materialCol;
        private DevExpress.XtraGrid.Columns.GridColumn weightCol;
        private DevExpress.XtraGrid.Columns.GridColumn thCol;
        private DevExpress.XtraGrid.Columns.GridColumn wCol;
        private DevExpress.XtraGrid.Columns.GridColumn w2Col;
        private DevExpress.XtraGrid.Columns.GridColumn LCol;
        private DevExpress.XtraGrid.Columns.GridColumn quantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn LQuantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn rCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}