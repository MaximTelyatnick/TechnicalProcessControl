namespace TechnicalProcessControl.Settings
{
    partial class DrawingScanImportFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingScanImportFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.importBtn = new DevExpress.XtraBars.BarButtonItem();
            this.clearBaseBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.scanDrawingGrid = new DevExpress.XtraGrid.GridControl();
            this.scanDrawingGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.drawingScanNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.drawingScanPathCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TechnicalProcessControl.WaitFm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanDrawingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanDrawingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.importBtn,
            this.clearBaseBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1116, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // importBtn
            // 
            this.importBtn.Caption = "Импортировать";
            this.importBtn.Id = 1;
            this.importBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("importBtn.ImageOptions.Image")));
            this.importBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("importBtn.ImageOptions.LargeImage")));
            this.importBtn.Name = "importBtn";
            this.importBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.importBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.importBtn_ItemClick);
            // 
            // clearBaseBtn
            // 
            this.clearBaseBtn.Caption = "Очистить базу";
            this.clearBaseBtn.Id = 2;
            this.clearBaseBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearBaseBtn.ImageOptions.Image")));
            this.clearBaseBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("clearBaseBtn.ImageOptions.LargeImage")));
            this.clearBaseBtn.Name = "clearBaseBtn";
            this.clearBaseBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.clearBaseBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearBaseBtn_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.importBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.clearBaseBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Функции";
            // 
            // scanDrawingGrid
            // 
            this.scanDrawingGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanDrawingGrid.Location = new System.Drawing.Point(0, 95);
            this.scanDrawingGrid.MainView = this.scanDrawingGridView;
            this.scanDrawingGrid.Name = "scanDrawingGrid";
            this.scanDrawingGrid.Size = new System.Drawing.Size(1116, 363);
            this.scanDrawingGrid.TabIndex = 1;
            this.scanDrawingGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.scanDrawingGridView});
            // 
            // scanDrawingGridView
            // 
            this.scanDrawingGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.drawingScanNameCol,
            this.drawingScanPathCol});
            this.scanDrawingGridView.GridControl = this.scanDrawingGrid;
            this.scanDrawingGridView.Name = "scanDrawingGridView";
            // 
            // drawingScanNameCol
            // 
            this.drawingScanNameCol.Caption = "Наименование файла";
            this.drawingScanNameCol.FieldName = "FileName";
            this.drawingScanNameCol.Name = "drawingScanNameCol";
            this.drawingScanNameCol.Visible = true;
            this.drawingScanNameCol.VisibleIndex = 0;
            this.drawingScanNameCol.Width = 245;
            // 
            // drawingScanPathCol
            // 
            this.drawingScanPathCol.Caption = "Путь к файлу";
            this.drawingScanPathCol.FieldName = "FileNamePath";
            this.drawingScanPathCol.Name = "drawingScanPathCol";
            this.drawingScanPathCol.Visible = true;
            this.drawingScanPathCol.VisibleIndex = 1;
            this.drawingScanPathCol.Width = 726;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // DrawingScanImportFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 458);
            this.Controls.Add(this.scanDrawingGrid);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrawingScanImportFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт сканов чертежей";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanDrawingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanDrawingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl scanDrawingGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView scanDrawingGridView;
        private DevExpress.XtraBars.BarButtonItem importBtn;
        private DevExpress.XtraBars.BarButtonItem clearBaseBtn;
        private DevExpress.XtraGrid.Columns.GridColumn drawingScanNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn drawingScanPathCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}