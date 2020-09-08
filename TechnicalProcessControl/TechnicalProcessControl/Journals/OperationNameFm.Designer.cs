namespace TechnicalProcessControl.Journals
{
    partial class OperationNameFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationNameFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.operationGrid = new DevExpress.XtraGrid.GridControl();
            this.operationGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableIdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameRusCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameEngCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameArCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TechnicalProcessControl.WaitFm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addBtn,
            this.editBtn,
            this.deleteBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(990, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
            this.editBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Удалить";
            this.deleteBtn.Id = 3;
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Удалить.ImageOptions.Image")));
            this.deleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Удалить.ImageOptions.LargeImage")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Функции";
            // 
            // operationGrid
            // 
            this.operationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationGrid.Location = new System.Drawing.Point(0, 95);
            this.operationGrid.MainView = this.operationGridView;
            this.operationGrid.Name = "operationGrid";
            this.operationGrid.Size = new System.Drawing.Size(990, 363);
            this.operationGrid.TabIndex = 1;
            this.operationGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.operationGridView});
            // 
            // operationGridView
            // 
            this.operationGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCol,
            this.tableIdCol,
            this.codeCol,
            this.nameRusCol,
            this.nameEngCol,
            this.nameArCol});
            this.operationGridView.GridControl = this.operationGrid;
            this.operationGridView.Name = "operationGridView";
            // 
            // idCol
            // 
            this.idCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCol.AppearanceHeader.Options.UseFont = true;
            this.idCol.Caption = "Номер по/п.";
            this.idCol.FieldName = "Id";
            this.idCol.Name = "idCol";
            this.idCol.Visible = true;
            this.idCol.VisibleIndex = 0;
            // 
            // tableIdCol
            // 
            this.tableIdCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableIdCol.AppearanceHeader.Options.UseFont = true;
            this.tableIdCol.Caption = "ID";
            this.tableIdCol.FieldName = "TableId";
            this.tableIdCol.Name = "tableIdCol";
            this.tableIdCol.Visible = true;
            this.tableIdCol.VisibleIndex = 1;
            // 
            // codeCol
            // 
            this.codeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeCol.AppearanceHeader.Options.UseFont = true;
            this.codeCol.Caption = "Код";
            this.codeCol.FieldName = "Code";
            this.codeCol.Name = "codeCol";
            this.codeCol.Visible = true;
            this.codeCol.VisibleIndex = 2;
            // 
            // nameRusCol
            // 
            this.nameRusCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameRusCol.AppearanceHeader.Options.UseFont = true;
            this.nameRusCol.Caption = "Русский";
            this.nameRusCol.FieldName = "NameRus";
            this.nameRusCol.Name = "nameRusCol";
            this.nameRusCol.Visible = true;
            this.nameRusCol.VisibleIndex = 3;
            // 
            // nameEngCol
            // 
            this.nameEngCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameEngCol.AppearanceHeader.Options.UseFont = true;
            this.nameEngCol.Caption = "Английский";
            this.nameEngCol.FieldName = "NameEng";
            this.nameEngCol.Name = "nameEngCol";
            this.nameEngCol.Visible = true;
            this.nameEngCol.VisibleIndex = 4;
            // 
            // nameArCol
            // 
            this.nameArCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameArCol.AppearanceHeader.Options.UseFont = true;
            this.nameArCol.Caption = "Арабский";
            this.nameArCol.FieldName = "NameAr";
            this.nameArCol.Name = "nameArCol";
            this.nameArCol.Visible = true;
            this.nameArCol.VisibleIndex = 5;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // OperationNameFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 458);
            this.Controls.Add(this.operationGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "OperationNameFm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl operationGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView operationGridView;
        private DevExpress.XtraGrid.Columns.GridColumn idCol;
        private DevExpress.XtraGrid.Columns.GridColumn tableIdCol;
        private DevExpress.XtraGrid.Columns.GridColumn codeCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameRusCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameEngCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameArCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}