namespace TechnicalProcessControl.Settings
{
    partial class StructuraImportFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StructuraImportFm));
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule1 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.importBtn = new DevExpress.XtraBars.BarButtonItem();
            this.clearBaseBtn = new DevExpress.XtraBars.BarButtonItem();
            this.importDrawingScanBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.drawingTreeListGrid = new DevExpress.XtraTreeList.TreeList();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.curentLevelMenuTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.statusTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand12 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.drawingNumberTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.revCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.partNameTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.quantityRCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.quantityLCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.quantityTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.materialNameCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.thTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.wTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.w2TreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ltreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.weightTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.remarksCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.drawingScanCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.treeListBand14 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.weightTotalTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.techProcess001Repository = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.techProcess002Repository = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.techProcess003Repository = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.techProcess004Repository = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.techProcess005Repository = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TechnicalProcessControl.WaitFm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingTreeListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess001Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess002Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess003Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess004Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess005Repository)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.importBtn,
            this.clearBaseBtn,
            this.importDrawingScanBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1167, 95);
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
            // importDrawingScanBtn
            // 
            this.importDrawingScanBtn.Caption = "Импортировать сканы чертежей";
            this.importDrawingScanBtn.Id = 3;
            this.importDrawingScanBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("importDrawingScanBtn.ImageOptions.Image")));
            this.importDrawingScanBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("importDrawingScanBtn.ImageOptions.LargeImage")));
            this.importDrawingScanBtn.Name = "importDrawingScanBtn";
            this.importDrawingScanBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.importDrawingScanBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.clearBaseBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Функции";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.drawingTreeListGrid);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1167, 556);
            this.panelControl1.TabIndex = 1;
            // 
            // drawingTreeListGrid
            // 
            this.drawingTreeListGrid.BandPanelRowHeight = 40;
            this.drawingTreeListGrid.Bands.AddRange(new DevExpress.XtraTreeList.Columns.TreeListBand[] {
            this.treeListBand1,
            this.treeListBand12,
            this.treeListBand2,
            this.treeListBand14});
            this.drawingTreeListGrid.ColumnPanelRowHeight = 80;
            this.drawingTreeListGrid.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.statusTreeCol,
            this.curentLevelMenuTreeCol,
            this.drawingNumberTreeCol,
            this.revCol,
            this.partNameTreeCol,
            this.quantityTreeCol,
            this.thTreeCol,
            this.wTreeCol,
            this.w2TreeCol,
            this.ltreeCol,
            this.weightTreeCol,
            this.weightTotalTreeCol,
            this.drawingScanCol,
            this.quantityRCol,
            this.quantityLCol,
            this.remarksCol,
            this.materialNameCol});
            this.drawingTreeListGrid.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.drawingTreeListGrid.DataSource = null;
            this.drawingTreeListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            treeListFormatRule1.Name = "Format0";
            treeListFormatRule1.Rule = null;
            this.drawingTreeListGrid.FormatRules.Add(treeListFormatRule1);
            this.drawingTreeListGrid.Location = new System.Drawing.Point(2, 2);
            this.drawingTreeListGrid.MinWidth = 100;
            this.drawingTreeListGrid.Name = "drawingTreeListGrid";
            this.drawingTreeListGrid.OptionsCustomization.AllowSort = false;
            this.drawingTreeListGrid.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.TextAndVisual;
            this.drawingTreeListGrid.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Standard;
            this.drawingTreeListGrid.OptionsFind.FindNullPrompt = "Введите текст....";
            this.drawingTreeListGrid.OptionsView.ShowAutoFilterRow = true;
            this.drawingTreeListGrid.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.True;
            this.drawingTreeListGrid.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.drawingTreeListGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.techProcess001Repository,
            this.techProcess002Repository,
            this.techProcess003Repository,
            this.techProcess004Repository,
            this.techProcess005Repository});
            this.drawingTreeListGrid.Size = new System.Drawing.Size(1163, 552);
            this.drawingTreeListGrid.TabIndex = 4;
            this.drawingTreeListGrid.TreeLevelWidth = 12;
            this.drawingTreeListGrid.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
            this.drawingTreeListGrid.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeList;
            // 
            // treeListBand1
            // 
            this.treeListBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListBand1.AppearanceHeader.Options.UseFont = true;
            this.treeListBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListBand1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.treeListBand1.Columns.Add(this.curentLevelMenuTreeCol);
            this.treeListBand1.Columns.Add(this.statusTreeCol);
            this.treeListBand1.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.treeListBand1.Name = "treeListBand1";
            this.treeListBand1.Width = 200;
            // 
            // curentLevelMenuTreeCol
            // 
            this.curentLevelMenuTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.curentLevelMenuTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.curentLevelMenuTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.curentLevelMenuTreeCol.Caption = " - - - - -";
            this.curentLevelMenuTreeCol.FieldName = "CurrentLevelMenu";
            this.curentLevelMenuTreeCol.MinWidth = 200;
            this.curentLevelMenuTreeCol.Name = "curentLevelMenuTreeCol";
            this.curentLevelMenuTreeCol.OptionsColumn.AllowEdit = false;
            this.curentLevelMenuTreeCol.OptionsColumn.AllowFocus = false;
            this.curentLevelMenuTreeCol.Visible = true;
            this.curentLevelMenuTreeCol.VisibleIndex = 0;
            this.curentLevelMenuTreeCol.Width = 200;
            // 
            // statusTreeCol
            // 
            this.statusTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.statusTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.statusTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.statusTreeCol.Caption = "Status";
            this.statusTreeCol.FieldName = "TypeName";
            this.statusTreeCol.MinWidth = 40;
            this.statusTreeCol.Name = "statusTreeCol";
            this.statusTreeCol.OptionsColumn.AllowEdit = false;
            this.statusTreeCol.OptionsColumn.AllowFocus = false;
            this.statusTreeCol.Visible = true;
            this.statusTreeCol.VisibleIndex = 1;
            this.statusTreeCol.Width = 40;
            // 
            // treeListBand12
            // 
            this.treeListBand12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListBand12.AppearanceHeader.Options.UseFont = true;
            this.treeListBand12.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListBand12.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.treeListBand12.Columns.Add(this.drawingNumberTreeCol);
            this.treeListBand12.Columns.Add(this.revCol);
            this.treeListBand12.Columns.Add(this.partNameTreeCol);
            this.treeListBand12.Columns.Add(this.quantityRCol);
            this.treeListBand12.Columns.Add(this.quantityLCol);
            this.treeListBand12.Columns.Add(this.quantityTreeCol);
            this.treeListBand12.Columns.Add(this.materialNameCol);
            this.treeListBand12.Name = "treeListBand12";
            this.treeListBand12.Width = 700;
            // 
            // drawingNumberTreeCol
            // 
            this.drawingNumberTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.drawingNumberTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drawingNumberTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.drawingNumberTreeCol.Caption = "DRAWING NUMBER";
            this.drawingNumberTreeCol.FieldName = "Number";
            this.drawingNumberTreeCol.Name = "drawingNumberTreeCol";
            this.drawingNumberTreeCol.OptionsColumn.AllowEdit = false;
            this.drawingNumberTreeCol.OptionsColumn.AllowFocus = false;
            this.drawingNumberTreeCol.Visible = true;
            this.drawingNumberTreeCol.VisibleIndex = 2;
            this.drawingNumberTreeCol.Width = 100;
            // 
            // revCol
            // 
            this.revCol.AppearanceHeader.Options.UseTextOptions = true;
            this.revCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.revCol.Caption = "REV";
            this.revCol.FieldName = "RevisionName";
            this.revCol.MinWidth = 30;
            this.revCol.Name = "revCol";
            this.revCol.OptionsColumn.AllowEdit = false;
            this.revCol.OptionsColumn.AllowFocus = false;
            this.revCol.Visible = true;
            this.revCol.VisibleIndex = 3;
            this.revCol.Width = 30;
            // 
            // partNameTreeCol
            // 
            this.partNameTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.partNameTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.partNameTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.partNameTreeCol.Caption = "PART NAME";
            this.partNameTreeCol.FieldName = "DetailName";
            this.partNameTreeCol.MinWidth = 150;
            this.partNameTreeCol.Name = "partNameTreeCol";
            this.partNameTreeCol.OptionsColumn.AllowEdit = false;
            this.partNameTreeCol.OptionsColumn.AllowFocus = false;
            this.partNameTreeCol.Visible = true;
            this.partNameTreeCol.VisibleIndex = 4;
            this.partNameTreeCol.Width = 150;
            // 
            // quantityRCol
            // 
            this.quantityRCol.AppearanceHeader.Options.UseTextOptions = true;
            this.quantityRCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantityRCol.Caption = "R";
            this.quantityRCol.FieldName = "QuantityR";
            this.quantityRCol.MinWidth = 30;
            this.quantityRCol.Name = "quantityRCol";
            this.quantityRCol.OptionsColumn.AllowEdit = false;
            this.quantityRCol.OptionsColumn.AllowFocus = false;
            this.quantityRCol.Visible = true;
            this.quantityRCol.VisibleIndex = 5;
            this.quantityRCol.Width = 30;
            // 
            // quantityLCol
            // 
            this.quantityLCol.AppearanceHeader.Options.UseTextOptions = true;
            this.quantityLCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantityLCol.Caption = "L";
            this.quantityLCol.FieldName = "QuantityL";
            this.quantityLCol.MinWidth = 30;
            this.quantityLCol.Name = "quantityLCol";
            this.quantityLCol.OptionsColumn.AllowEdit = false;
            this.quantityLCol.OptionsColumn.AllowFocus = false;
            this.quantityLCol.Visible = true;
            this.quantityLCol.VisibleIndex = 6;
            this.quantityLCol.Width = 30;
            // 
            // quantityTreeCol
            // 
            this.quantityTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.quantityTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantityTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.quantityTreeCol.Caption = "QTY";
            this.quantityTreeCol.FieldName = "Quantity";
            this.quantityTreeCol.MinWidth = 30;
            this.quantityTreeCol.Name = "quantityTreeCol";
            this.quantityTreeCol.OptionsColumn.AllowEdit = false;
            this.quantityTreeCol.OptionsColumn.AllowFocus = false;
            this.quantityTreeCol.Visible = true;
            this.quantityTreeCol.VisibleIndex = 7;
            this.quantityTreeCol.Width = 30;
            // 
            // materialNameCol
            // 
            this.materialNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.materialNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.materialNameCol.Caption = "MATERIAL";
            this.materialNameCol.FieldName = "MaterialName";
            this.materialNameCol.Name = "materialNameCol";
            this.materialNameCol.OptionsColumn.AllowEdit = false;
            this.materialNameCol.OptionsColumn.AllowFocus = false;
            this.materialNameCol.OptionsColumn.AllowMove = false;
            this.materialNameCol.Visible = true;
            this.materialNameCol.VisibleIndex = 8;
            this.materialNameCol.Width = 100;
            // 
            // treeListBand2
            // 
            this.treeListBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListBand2.AppearanceHeader.Options.UseFont = true;
            this.treeListBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListBand2.Caption = "Dim";
            this.treeListBand2.Columns.Add(this.thTreeCol);
            this.treeListBand2.Columns.Add(this.wTreeCol);
            this.treeListBand2.Columns.Add(this.w2TreeCol);
            this.treeListBand2.Columns.Add(this.ltreeCol);
            this.treeListBand2.Columns.Add(this.weightTreeCol);
            this.treeListBand2.Columns.Add(this.remarksCol);
            this.treeListBand2.Columns.Add(this.drawingScanCol);
            this.treeListBand2.Name = "treeListBand2";
            this.treeListBand2.Width = 600;
            // 
            // thTreeCol
            // 
            this.thTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.thTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.thTreeCol.Caption = "TH";
            this.thTreeCol.FieldName = "TH";
            this.thTreeCol.MinWidth = 50;
            this.thTreeCol.Name = "thTreeCol";
            this.thTreeCol.OptionsColumn.AllowEdit = false;
            this.thTreeCol.OptionsColumn.AllowFocus = false;
            this.thTreeCol.Visible = true;
            this.thTreeCol.VisibleIndex = 9;
            this.thTreeCol.Width = 50;
            // 
            // wTreeCol
            // 
            this.wTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.wTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.wTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.wTreeCol.Caption = "W";
            this.wTreeCol.FieldName = "W";
            this.wTreeCol.MinWidth = 50;
            this.wTreeCol.Name = "wTreeCol";
            this.wTreeCol.OptionsColumn.AllowEdit = false;
            this.wTreeCol.OptionsColumn.AllowFocus = false;
            this.wTreeCol.Visible = true;
            this.wTreeCol.VisibleIndex = 10;
            this.wTreeCol.Width = 50;
            // 
            // w2TreeCol
            // 
            this.w2TreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.w2TreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.w2TreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.w2TreeCol.Caption = "W2";
            this.w2TreeCol.FieldName = "W2";
            this.w2TreeCol.MinWidth = 50;
            this.w2TreeCol.Name = "w2TreeCol";
            this.w2TreeCol.OptionsColumn.AllowEdit = false;
            this.w2TreeCol.OptionsColumn.AllowFocus = false;
            this.w2TreeCol.Visible = true;
            this.w2TreeCol.VisibleIndex = 11;
            this.w2TreeCol.Width = 50;
            // 
            // ltreeCol
            // 
            this.ltreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.ltreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ltreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ltreeCol.Caption = "L";
            this.ltreeCol.FieldName = "L";
            this.ltreeCol.MinWidth = 50;
            this.ltreeCol.Name = "ltreeCol";
            this.ltreeCol.OptionsColumn.AllowEdit = false;
            this.ltreeCol.OptionsColumn.AllowFocus = false;
            this.ltreeCol.Visible = true;
            this.ltreeCol.VisibleIndex = 12;
            this.ltreeCol.Width = 50;
            // 
            // weightTreeCol
            // 
            this.weightTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.weightTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.weightTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.weightTreeCol.Caption = "Вес";
            this.weightTreeCol.FieldName = "DetailWeight";
            this.weightTreeCol.Name = "weightTreeCol";
            this.weightTreeCol.OptionsColumn.AllowEdit = false;
            this.weightTreeCol.OptionsColumn.AllowFocus = false;
            this.weightTreeCol.Width = 78;
            // 
            // remarksCol
            // 
            this.remarksCol.AppearanceHeader.Options.UseTextOptions = true;
            this.remarksCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.remarksCol.Caption = "REMARKS";
            this.remarksCol.FieldName = "NoteName";
            this.remarksCol.Name = "remarksCol";
            this.remarksCol.OptionsColumn.AllowEdit = false;
            this.remarksCol.OptionsColumn.AllowFocus = false;
            this.remarksCol.OptionsColumn.AllowMove = false;
            this.remarksCol.Visible = true;
            this.remarksCol.VisibleIndex = 13;
            this.remarksCol.Width = 100;
            // 
            // drawingScanCol
            // 
            this.drawingScanCol.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("drawingScanCol.AppearanceHeader.Image")));
            this.drawingScanCol.AppearanceHeader.Options.UseImage = true;
            this.drawingScanCol.AppearanceHeader.Options.UseTextOptions = true;
            this.drawingScanCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drawingScanCol.Caption = " ";
            this.drawingScanCol.ColumnEdit = this.repositoryItemPictureEdit1;
            this.drawingScanCol.FieldName = "DrawingScan";
            this.drawingScanCol.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.drawingScanCol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("drawingScanCol.ImageOptions.Image")));
            this.drawingScanCol.MinWidth = 30;
            this.drawingScanCol.Name = "drawingScanCol";
            this.drawingScanCol.OptionsColumn.AllowEdit = false;
            this.drawingScanCol.OptionsColumn.AllowFocus = false;
            this.drawingScanCol.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.drawingScanCol.Visible = true;
            this.drawingScanCol.VisibleIndex = 14;
            this.drawingScanCol.Width = 30;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // treeListBand14
            // 
            this.treeListBand14.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListBand14.AppearanceHeader.Options.UseFont = true;
            this.treeListBand14.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListBand14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListBand14.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.treeListBand14.Caption = "Расход сварочных материалов";
            this.treeListBand14.Name = "treeListBand14";
            this.treeListBand14.Visible = false;
            this.treeListBand14.Width = 260;
            // 
            // weightTotalTreeCol
            // 
            this.weightTotalTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.weightTotalTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.weightTotalTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.weightTotalTreeCol.Caption = "Всего";
            this.weightTotalTreeCol.FieldName = "TotalWeight";
            this.weightTotalTreeCol.Name = "weightTotalTreeCol";
            this.weightTotalTreeCol.OptionsColumn.AllowEdit = false;
            this.weightTotalTreeCol.OptionsColumn.AllowFocus = false;
            this.weightTotalTreeCol.Visible = true;
            this.weightTotalTreeCol.VisibleIndex = 11;
            this.weightTotalTreeCol.Width = 65;
            // 
            // techProcess001Repository
            // 
            this.techProcess001Repository.AutoHeight = false;
            this.techProcess001Repository.Name = "techProcess001Repository";
            // 
            // techProcess002Repository
            // 
            this.techProcess002Repository.AutoHeight = false;
            this.techProcess002Repository.Name = "techProcess002Repository";
            // 
            // techProcess003Repository
            // 
            this.techProcess003Repository.AutoHeight = false;
            this.techProcess003Repository.Name = "techProcess003Repository";
            // 
            // techProcess004Repository
            // 
            this.techProcess004Repository.AutoHeight = false;
            this.techProcess004Repository.Name = "techProcess004Repository";
            // 
            // techProcess005Repository
            // 
            this.techProcess005Repository.AutoHeight = false;
            this.techProcess005Repository.Name = "techProcess005Repository";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // StructuraImportFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 651);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StructuraImportFm";
            this.Text = "Импорт структуры";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingTreeListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess001Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess002Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess003Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess004Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess005Repository)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList drawingTreeListGrid;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn curentLevelMenuTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn statusTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand12;
        private DevExpress.XtraTreeList.Columns.TreeListColumn drawingNumberTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn revCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn partNameTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn quantityRCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn quantityLCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn quantityTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn materialNameCol;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn thTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn wTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn w2TreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ltreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn weightTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn remarksCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn drawingScanCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand14;
        private DevExpress.XtraTreeList.Columns.TreeListColumn weightTotalTreeCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit techProcess001Repository;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit techProcess002Repository;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit techProcess003Repository;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit techProcess004Repository;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit techProcess005Repository;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarButtonItem importBtn;
        private DevExpress.XtraBars.BarButtonItem clearBaseBtn;
        private DevExpress.XtraBars.BarButtonItem importDrawingScanBtn;
    }
}