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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingFm));
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule1 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            this.drawingRibon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.updateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.drawingGrid = new DevExpress.XtraGrid.GridControl();
            this.drawingGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.drawingTreeListGrid = new DevExpress.XtraTreeList.TreeList();
            this.treeListBand12 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.drawingNumberTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.revisionCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.partNameTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.drawingMaterialCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.statusTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ltreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.wTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.w2TreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.thTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.weightTreeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.drawingScanCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.treeListBand14 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand15 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.techProcess001Repository = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.techProcess002Repository = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.techProcess003Repository = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.techProcess004Repository = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.techProcess005Repository = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drawingRibon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingTreeListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess001Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess002Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess003Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess004Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess005Repository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
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
            this.editBtn.Caption = "Изменить";
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
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.LargeImage")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // updateBtn
            // 
            this.updateBtn.Caption = "Обновить";
            this.updateBtn.Id = 4;
            this.updateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageOptions.Image")));
            this.updateBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageOptions.LargeImage")));
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.updateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateBtn_ItemClick);
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
            this.ribbonPageGroup1.Text = "Операции над чертежом";
            // 
            // drawingGrid
            // 
            this.drawingGrid.Location = new System.Drawing.Point(0, 196);
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
            // drawingTreeListGrid
            // 
            this.drawingTreeListGrid.BandPanelRowHeight = 40;
            this.drawingTreeListGrid.Bands.AddRange(new DevExpress.XtraTreeList.Columns.TreeListBand[] {
            this.treeListBand12,
            this.treeListBand14,
            this.treeListBand15});
            this.drawingTreeListGrid.ColumnPanelRowHeight = 80;
            this.drawingTreeListGrid.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.statusTreeCol,
            this.drawingNumberTreeCol,
            this.revisionCol,
            this.drawingMaterialCol,
            this.partNameTreeCol,
            this.thTreeCol,
            this.wTreeCol,
            this.w2TreeCol,
            this.ltreeCol,
            this.weightTreeCol,
            this.drawingScanCol});
            this.drawingTreeListGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawingTreeListGrid.DataSource = null;
            this.drawingTreeListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            treeListFormatRule1.Name = "Format0";
            treeListFormatRule1.Rule = null;
            this.drawingTreeListGrid.FormatRules.Add(treeListFormatRule1);
            this.drawingTreeListGrid.Location = new System.Drawing.Point(0, 95);
            this.drawingTreeListGrid.Name = "drawingTreeListGrid";
            this.drawingTreeListGrid.OptionsFind.AlwaysVisible = true;
            this.drawingTreeListGrid.OptionsFind.FindNullPrompt = "Введите текст....";
            this.drawingTreeListGrid.OptionsView.ShowAutoFilterRow = true;
            this.drawingTreeListGrid.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.True;
            this.drawingTreeListGrid.OptionsView.ShowSummaryFooter = true;
            this.drawingTreeListGrid.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.drawingTreeListGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.techProcess001Repository,
            this.techProcess002Repository,
            this.techProcess003Repository,
            this.techProcess004Repository,
            this.techProcess005Repository});
            this.drawingTreeListGrid.Size = new System.Drawing.Size(1181, 441);
            this.drawingTreeListGrid.TabIndex = 4;
            this.drawingTreeListGrid.TreeLevelWidth = 12;
            this.drawingTreeListGrid.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
            this.drawingTreeListGrid.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeList;
            this.drawingTreeListGrid.CustomUnboundColumnData += new DevExpress.XtraTreeList.CustomColumnDataEventHandler(this.drawingTreeListGrid_CustomUnboundColumnData);
            // 
            // treeListBand12
            // 
            this.treeListBand12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListBand12.AppearanceHeader.Options.UseFont = true;
            this.treeListBand12.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListBand12.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.treeListBand12.Caption = "Чертеж";
            this.treeListBand12.Columns.Add(this.drawingNumberTreeCol);
            this.treeListBand12.Columns.Add(this.revisionCol);
            this.treeListBand12.Columns.Add(this.partNameTreeCol);
            this.treeListBand12.Columns.Add(this.drawingMaterialCol);
            this.treeListBand12.Columns.Add(this.statusTreeCol);
            this.treeListBand12.Columns.Add(this.ltreeCol);
            this.treeListBand12.Columns.Add(this.wTreeCol);
            this.treeListBand12.Columns.Add(this.w2TreeCol);
            this.treeListBand12.Columns.Add(this.thTreeCol);
            this.treeListBand12.Columns.Add(this.weightTreeCol);
            this.treeListBand12.Columns.Add(this.drawingScanCol);
            this.treeListBand12.Name = "treeListBand12";
            this.treeListBand12.Width = 561;
            // 
            // drawingNumberTreeCol
            // 
            this.drawingNumberTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.drawingNumberTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drawingNumberTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.drawingNumberTreeCol.Caption = "Номер чертежа";
            this.drawingNumberTreeCol.FieldName = "Number";
            this.drawingNumberTreeCol.Name = "drawingNumberTreeCol";
            this.drawingNumberTreeCol.OptionsColumn.AllowEdit = false;
            this.drawingNumberTreeCol.OptionsColumn.AllowFocus = false;
            this.drawingNumberTreeCol.Visible = true;
            this.drawingNumberTreeCol.VisibleIndex = 0;
            this.drawingNumberTreeCol.Width = 199;
            // 
            // revisionCol
            // 
            this.revisionCol.Caption = "Ревизия";
            this.revisionCol.FieldName = "RevisionName";
            this.revisionCol.Name = "revisionCol";
            this.revisionCol.Visible = true;
            this.revisionCol.VisibleIndex = 1;
            // 
            // partNameTreeCol
            // 
            this.partNameTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.partNameTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.partNameTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.partNameTreeCol.Caption = "Название детали";
            this.partNameTreeCol.FieldName = "DetailName";
            this.partNameTreeCol.Name = "partNameTreeCol";
            this.partNameTreeCol.OptionsColumn.AllowEdit = false;
            this.partNameTreeCol.OptionsColumn.AllowFocus = false;
            this.partNameTreeCol.Visible = true;
            this.partNameTreeCol.VisibleIndex = 2;
            this.partNameTreeCol.Width = 145;
            // 
            // drawingMaterialCol
            // 
            this.drawingMaterialCol.Caption = "Материал";
            this.drawingMaterialCol.FieldName = "MaterialName";
            this.drawingMaterialCol.Name = "drawingMaterialCol";
            this.drawingMaterialCol.Visible = true;
            this.drawingMaterialCol.VisibleIndex = 3;
            // 
            // statusTreeCol
            // 
            this.statusTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.statusTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.statusTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.statusTreeCol.Caption = "Комплект";
            this.statusTreeCol.FieldName = "TypeName";
            this.statusTreeCol.Name = "statusTreeCol";
            this.statusTreeCol.OptionsColumn.AllowEdit = false;
            this.statusTreeCol.OptionsColumn.AllowFocus = false;
            this.statusTreeCol.Visible = true;
            this.statusTreeCol.VisibleIndex = 4;
            this.statusTreeCol.Width = 121;
            // 
            // ltreeCol
            // 
            this.ltreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.ltreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ltreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ltreeCol.Caption = "L";
            this.ltreeCol.FieldName = "L";
            this.ltreeCol.Name = "ltreeCol";
            this.ltreeCol.OptionsColumn.AllowEdit = false;
            this.ltreeCol.OptionsColumn.AllowFocus = false;
            this.ltreeCol.Visible = true;
            this.ltreeCol.VisibleIndex = 5;
            this.ltreeCol.Width = 130;
            // 
            // wTreeCol
            // 
            this.wTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.wTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.wTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.wTreeCol.Caption = "W";
            this.wTreeCol.FieldName = "W";
            this.wTreeCol.Name = "wTreeCol";
            this.wTreeCol.OptionsColumn.AllowEdit = false;
            this.wTreeCol.OptionsColumn.AllowFocus = false;
            this.wTreeCol.Visible = true;
            this.wTreeCol.VisibleIndex = 6;
            this.wTreeCol.Width = 135;
            // 
            // w2TreeCol
            // 
            this.w2TreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.w2TreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.w2TreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.w2TreeCol.Caption = "W2";
            this.w2TreeCol.FieldName = "W2";
            this.w2TreeCol.Name = "w2TreeCol";
            this.w2TreeCol.OptionsColumn.AllowEdit = false;
            this.w2TreeCol.OptionsColumn.AllowFocus = false;
            this.w2TreeCol.Visible = true;
            this.w2TreeCol.VisibleIndex = 7;
            this.w2TreeCol.Width = 144;
            // 
            // thTreeCol
            // 
            this.thTreeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.thTreeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thTreeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.thTreeCol.Caption = "TH";
            this.thTreeCol.FieldName = "TH";
            this.thTreeCol.Name = "thTreeCol";
            this.thTreeCol.OptionsColumn.AllowEdit = false;
            this.thTreeCol.OptionsColumn.AllowFocus = false;
            this.thTreeCol.Visible = true;
            this.thTreeCol.VisibleIndex = 8;
            this.thTreeCol.Width = 127;
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
            this.weightTreeCol.Visible = true;
            this.weightTreeCol.VisibleIndex = 9;
            this.weightTreeCol.Width = 162;
            // 
            // drawingScanCol
            // 
            this.drawingScanCol.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.drawingScanCol.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("drawingScanCol.AppearanceHeader.Image")));
            this.drawingScanCol.AppearanceHeader.Options.UseForeColor = true;
            this.drawingScanCol.AppearanceHeader.Options.UseImage = true;
            this.drawingScanCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drawingScanCol.Caption = " ";
            this.drawingScanCol.ColumnEdit = this.repositoryItemPictureEdit1;
            this.drawingScanCol.FieldName = "DrawingScan";
            this.drawingScanCol.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.drawingScanCol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("drawingScanCol.ImageOptions.Image")));
            this.drawingScanCol.Name = "drawingScanCol";
            this.drawingScanCol.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.drawingScanCol.Visible = true;
            this.drawingScanCol.VisibleIndex = 10;
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
            // treeListBand15
            // 
            this.treeListBand15.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListBand15.AppearanceHeader.Options.UseFont = true;
            this.treeListBand15.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListBand15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListBand15.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.treeListBand15.Caption = "Расход лакокрасочных материалов";
            this.treeListBand15.Name = "treeListBand15";
            this.treeListBand15.RowCount = 2;
            this.treeListBand15.Visible = false;
            this.treeListBand15.Width = 130;
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
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(16, 16);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.IsDpiAware = DevExpress.Utils.DefaultBoolean.True;
            this.imageCollection.InsertGalleryImage("picturebox_16x16.png", "images/toolbox%20items/picturebox_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/toolbox%20items/picturebox_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "picturebox_16x16.png");
            this.imageCollection.InsertGalleryImage("removepivotfield_16x16.png", "images/spreadsheet/removepivotfield_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/spreadsheet/removepivotfield_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "removepivotfield_16x16.png");
            // 
            // DrawingFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 536);
            this.Controls.Add(this.drawingTreeListGrid);
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
            ((System.ComponentModel.ISupportInitialize)(this.drawingTreeListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess001Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess002Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess003Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess004Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techProcess005Repository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
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
        private DevExpress.XtraTreeList.TreeList drawingTreeListGrid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn drawingNumberTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn partNameTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn statusTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ltreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn wTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn w2TreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn thTreeCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn weightTreeCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit techProcess001Repository;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit techProcess002Repository;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit techProcess003Repository;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit techProcess004Repository;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit techProcess005Repository;
        private DevExpress.XtraTreeList.Columns.TreeListColumn revisionCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn drawingMaterialCol;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand12;
        private DevExpress.XtraTreeList.Columns.TreeListColumn drawingScanCol;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand14;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand15;
    }
}