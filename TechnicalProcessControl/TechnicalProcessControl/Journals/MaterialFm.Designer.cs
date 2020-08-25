namespace TechnicalProcessControl.Journals
{
    partial class MaterialFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialFm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addMaterialBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editMaterialBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteMaterialBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.materialGrid = new DevExpress.XtraGrid.GridControl();
            this.materialGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.materialCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TechnicalProcessControl.WaitFm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addMaterialBtn,
            this.editMaterialBtn,
            this.deleteMaterialBtn});
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addMaterialBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.editMaterialBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteMaterialBtn)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.Text = "Tools";
            // 
            // addMaterialBtn
            // 
            this.addMaterialBtn.Caption = "Добавить";
            this.addMaterialBtn.Id = 0;
            this.addMaterialBtn.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.addMaterialBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addMaterialBtn.ImageOptions.Image")));
            this.addMaterialBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addMaterialBtn.ImageOptions.LargeImage")));
            this.addMaterialBtn.Name = "addMaterialBtn";
            this.addMaterialBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.addMaterialBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addMaterialBtn_ItemClick);
            // 
            // editMaterialBtn
            // 
            this.editMaterialBtn.Caption = "Изменить";
            this.editMaterialBtn.Id = 1;
            this.editMaterialBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editMaterialBtn.ImageOptions.Image")));
            this.editMaterialBtn.Name = "editMaterialBtn";
            this.editMaterialBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.editMaterialBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editMaterialBtn_ItemClick);
            // 
            // deleteMaterialBtn
            // 
            this.deleteMaterialBtn.Caption = "Удалить";
            this.deleteMaterialBtn.Id = 2;
            this.deleteMaterialBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteMaterialBtn.ImageOptions.Image")));
            this.deleteMaterialBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteMaterialBtn.ImageOptions.LargeImage")));
            this.deleteMaterialBtn.Name = "deleteMaterialBtn";
            this.deleteMaterialBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.deleteMaterialBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteMaterialBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1332, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 445);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1332, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1332, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // materialGrid
            // 
            this.materialGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialGrid.Location = new System.Drawing.Point(0, 47);
            this.materialGrid.MainView = this.materialGridView;
            this.materialGrid.Name = "materialGrid";
            this.materialGrid.Size = new System.Drawing.Size(1332, 398);
            this.materialGrid.TabIndex = 4;
            this.materialGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.materialGridView});
            // 
            // materialGridView
            // 
            this.materialGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.materialCol});
            this.materialGridView.GridControl = this.materialGrid;
            this.materialGridView.Name = "materialGridView";
            // 
            // materialCol
            // 
            this.materialCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialCol.AppearanceHeader.Options.UseFont = true;
            this.materialCol.Caption = "Материал";
            this.materialCol.FieldName = "MaterialName";
            this.materialCol.Name = "materialCol";
            this.materialCol.Visible = true;
            this.materialCol.VisibleIndex = 0;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // MaterialFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 445);
            this.Controls.Add(this.materialGrid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MaterialFm";
            this.ShowIcon = false;
            this.Text = "Матеріали";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addMaterialBtn;
        private DevExpress.XtraBars.BarButtonItem editMaterialBtn;
        private DevExpress.XtraBars.BarButtonItem deleteMaterialBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl materialGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView materialGridView;
        private DevExpress.XtraGrid.Columns.GridColumn materialCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}