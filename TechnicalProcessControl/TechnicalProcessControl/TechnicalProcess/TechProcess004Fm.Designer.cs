namespace TechnicalProcessControl.TechnicalProcess
{
    partial class TechProcess004Fm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechProcess004Fm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.techProcessTreeListGrid = new DevExpress.XtraTreeList.TreeList();
            this.numberCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dateCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.techProcessFullNameCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.drawingCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fullPathCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcessTreeListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.deleteBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(854, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Удалить";
            this.deleteBtn.Id = 1;
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.LargeImage")));
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
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Функции";
            // 
            // techProcessTreeListGrid
            // 
            this.techProcessTreeListGrid.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.numberCol,
            this.dateCol,
            this.techProcessFullNameCol,
            this.drawingCol,
            this.fullPathCol,
            this.treeListColumn1});
            this.techProcessTreeListGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.techProcessTreeListGrid.DataSource = null;
            this.techProcessTreeListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.techProcessTreeListGrid.Location = new System.Drawing.Point(0, 95);
            this.techProcessTreeListGrid.Name = "techProcessTreeListGrid";
            this.techProcessTreeListGrid.OptionsView.ShowAutoFilterRow = true;
            this.techProcessTreeListGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit});
            this.techProcessTreeListGrid.Size = new System.Drawing.Size(854, 315);
            this.techProcessTreeListGrid.TabIndex = 5;
            this.techProcessTreeListGrid.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.techProcessTreeListGrid_NodeCellStyle);
            this.techProcessTreeListGrid.DoubleClick += new System.EventHandler(this.techProcessTreeListGrid_DoubleClick);
            // 
            // numberCol
            // 
            this.numberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberCol.AppearanceHeader.Options.UseFont = true;
            this.numberCol.Caption = "Номер техпроцесса";
            this.numberCol.FieldName = "TechProcessName";
            this.numberCol.Name = "numberCol";
            this.numberCol.OptionsColumn.AllowEdit = false;
            this.numberCol.OptionsColumn.AllowFocus = false;
            this.numberCol.Visible = true;
            this.numberCol.VisibleIndex = 0;
            // 
            // dateCol
            // 
            this.dateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCol.AppearanceHeader.Options.UseFont = true;
            this.dateCol.Caption = "Дата";
            this.dateCol.FieldName = "CreateDate";
            this.dateCol.Name = "dateCol";
            this.dateCol.OptionsColumn.AllowEdit = false;
            this.dateCol.OptionsColumn.AllowFocus = false;
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 1;
            // 
            // techProcessFullNameCol
            // 
            this.techProcessFullNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.techProcessFullNameCol.AppearanceHeader.Options.UseFont = true;
            this.techProcessFullNameCol.Caption = "Ревизия";
            this.techProcessFullNameCol.FieldName = "RivisionName";
            this.techProcessFullNameCol.Name = "techProcessFullNameCol";
            this.techProcessFullNameCol.OptionsColumn.AllowEdit = false;
            this.techProcessFullNameCol.OptionsColumn.AllowFocus = false;
            this.techProcessFullNameCol.Visible = true;
            this.techProcessFullNameCol.VisibleIndex = 2;
            // 
            // drawingCol
            // 
            this.drawingCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawingCol.AppearanceHeader.Options.UseFont = true;
            this.drawingCol.Caption = "Номер чертежа";
            this.drawingCol.ColumnEdit = this.repositoryItemTextEdit;
            this.drawingCol.FieldName = "DrawingNumber";
            this.drawingCol.Name = "drawingCol";
            this.drawingCol.OptionsColumn.AllowEdit = false;
            this.drawingCol.OptionsColumn.AllowFocus = false;
            this.drawingCol.Visible = true;
            this.drawingCol.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit
            // 
            this.repositoryItemTextEdit.AutoHeight = false;
            this.repositoryItemTextEdit.Name = "repositoryItemTextEdit";
            // 
            // fullPathCol
            // 
            this.fullPathCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullPathCol.AppearanceHeader.Options.UseFont = true;
            this.fullPathCol.Caption = "Путь к файлу";
            this.fullPathCol.FieldName = "TechProcessPath";
            this.fullPathCol.Name = "fullPathCol";
            this.fullPathCol.OptionsColumn.AllowEdit = false;
            this.fullPathCol.OptionsColumn.AllowFocus = false;
            this.fullPathCol.Visible = true;
            this.fullPathCol.VisibleIndex = 4;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListColumn1.AppearanceHeader.Options.UseFont = true;
            this.treeListColumn1.Caption = "Номер чертежа с ревизией";
            this.treeListColumn1.FieldName = "DrawingNumberWithRevision";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.OptionsColumn.AllowFocus = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 5;
            // 
            // TechProcess004Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 410);
            this.Controls.Add(this.techProcessTreeListGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TechProcess004Fm";
            this.Text = "Сборка";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcessTreeListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraTreeList.TreeList techProcessTreeListGrid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn numberCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn dateCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn techProcessFullNameCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn drawingCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn fullPathCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}