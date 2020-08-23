namespace TechnicalProcessControl.Journals
{
    partial class DetailFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailFm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addDetailBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editDetailbtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteDetailBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.detailsGrid = new DevExpress.XtraGrid.GridControl();
            this.detailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.detailCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TechnicalProcessControl.WaitFm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridView)).BeginInit();
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
            this.addDetailBtn,
            this.editDetailbtn,
            this.deleteDetailBtn});
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(243, 132);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addDetailBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.editDetailbtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteDetailBtn)});
            this.bar2.Offset = 1;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.Text = "Tools";
            // 
            // addDetailBtn
            // 
            this.addDetailBtn.Caption = "Добавить";
            this.addDetailBtn.Id = 0;
            this.addDetailBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addDetailBtn.ImageOptions.Image")));
            this.addDetailBtn.Name = "addDetailBtn";
            this.addDetailBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.addDetailBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addDetailBtn_ItemClick);
            // 
            // editDetailbtn
            // 
            this.editDetailbtn.Caption = "Редактировать";
            this.editDetailbtn.Id = 1;
            this.editDetailbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editDetailbtn.ImageOptions.Image")));
            this.editDetailbtn.Name = "editDetailbtn";
            this.editDetailbtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.editDetailbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editDetailbtn_ItemClick);
            // 
            // deleteDetailBtn
            // 
            this.deleteDetailBtn.Caption = "Удалить";
            this.deleteDetailBtn.Id = 2;
            this.deleteDetailBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteDetailBtn.ImageOptions.Image")));
            this.deleteDetailBtn.Name = "deleteDetailBtn";
            this.deleteDetailBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.deleteDetailBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteDetailBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(897, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 384);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(897, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 337);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(897, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 337);
            // 
            // detailsGrid
            // 
            this.detailsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGrid.Location = new System.Drawing.Point(0, 47);
            this.detailsGrid.MainView = this.detailsGridView;
            this.detailsGrid.Name = "detailsGrid";
            this.detailsGrid.Size = new System.Drawing.Size(897, 337);
            this.detailsGrid.TabIndex = 4;
            this.detailsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.detailsGridView});
            // 
            // detailsGridView
            // 
            this.detailsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.detailCol});
            this.detailsGridView.GridControl = this.detailsGrid;
            this.detailsGridView.Name = "detailsGridView";
            // 
            // detailCol
            // 
            this.detailCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailCol.AppearanceHeader.Options.UseFont = true;
            this.detailCol.Caption = "Наименование детали";
            this.detailCol.FieldName = "DetailName";
            this.detailCol.Name = "detailCol";
            this.detailCol.Visible = true;
            this.detailCol.VisibleIndex = 0;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // DetailFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 384);
            this.Controls.Add(this.detailsGrid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailFm";
            this.Text = "Детали";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addDetailBtn;
        private DevExpress.XtraBars.BarButtonItem editDetailbtn;
        private DevExpress.XtraBars.BarButtonItem deleteDetailBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl detailsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView detailsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn detailCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}