namespace TechnicalProcessControl.TechnicalProcess
{
    partial class TechProcess001Fm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechProcess001Fm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.techProcessTreeListGrid = new DevExpress.XtraTreeList.TreeList();
            this.numberCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dateCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.techProcessCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.techProcessFullNameCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.drawingCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.fullPathCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TechnicalProcessControl.WaitFm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcessTreeListGrid)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(1191, 95);
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
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редактировать";
            this.editBtn.Id = 2;
            this.editBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.ImageOptions.Image")));
            this.editBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editBtn.ImageOptions.LargeImage")));
            this.editBtn.Name = "editBtn";
            this.editBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Удалить";
            this.deleteBtn.Id = 3;
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.LargeImage")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.ribbonPageGroup1.Text = "Техпроцес";
            // 
            // techProcessTreeListGrid
            // 
            this.techProcessTreeListGrid.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.numberCol,
            this.dateCol,
            this.techProcessCol,
            this.techProcessFullNameCol,
            this.drawingCol,
            this.fullPathCol,
            this.treeListColumn1});
            this.techProcessTreeListGrid.DataSource = null;
            this.techProcessTreeListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.techProcessTreeListGrid.Location = new System.Drawing.Point(0, 95);
            this.techProcessTreeListGrid.Name = "techProcessTreeListGrid";
            this.techProcessTreeListGrid.Size = new System.Drawing.Size(1191, 423);
            this.techProcessTreeListGrid.TabIndex = 3;
            // 
            // numberCol
            // 
            this.numberCol.Caption = "Номер техпроцесса";
            this.numberCol.FieldName = "TechProcessName";
            this.numberCol.Name = "numberCol";
            this.numberCol.Visible = true;
            this.numberCol.VisibleIndex = 0;
            // 
            // dateCol
            // 
            this.dateCol.Caption = "Дата";
            this.dateCol.FieldName = "CreateDate";
            this.dateCol.Name = "dateCol";
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 1;
            // 
            // techProcessCol
            // 
            this.techProcessCol.Caption = "Номер техпроцесса";
            this.techProcessCol.FieldName = "TechProcessName";
            this.techProcessCol.Name = "techProcessCol";
            this.techProcessCol.Visible = true;
            this.techProcessCol.VisibleIndex = 2;
            // 
            // techProcessFullNameCol
            // 
            this.techProcessFullNameCol.Caption = "Название техпроцесса (полное)";
            this.techProcessFullNameCol.FieldName = "TechProcessFullName";
            this.techProcessFullNameCol.Name = "techProcessFullNameCol";
            this.techProcessFullNameCol.Visible = true;
            this.techProcessFullNameCol.VisibleIndex = 3;
            // 
            // drawingCol
            // 
            this.drawingCol.Caption = "Номер чертежа";
            this.drawingCol.FieldName = "DrawingNumber";
            this.drawingCol.Name = "drawingCol";
            this.drawingCol.Visible = true;
            this.drawingCol.VisibleIndex = 4;
            // 
            // fullPathCol
            // 
            this.fullPathCol.Caption = "Путь к файлу";
            this.fullPathCol.FieldName = "TechProcessPath";
            this.fullPathCol.Name = "fullPathCol";
            this.fullPathCol.Visible = true;
            this.fullPathCol.VisibleIndex = 5;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Номер чертежа с ревизией";
            this.treeListColumn1.FieldName = "DrawingNumberWithRevision";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 6;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // TechProcess001Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 518);
            this.Controls.Add(this.techProcessTreeListGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TechProcess001Fm";
            this.Text = "Заготовительное производство";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcessTreeListGrid)).EndInit();
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
        private DevExpress.XtraTreeList.TreeList techProcessTreeListGrid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn numberCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn dateCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn techProcessCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn techProcessFullNameCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn drawingCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn fullPathCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}