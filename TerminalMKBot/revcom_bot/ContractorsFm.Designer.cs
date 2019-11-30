namespace TerminalMKBot
{
    partial class ContractorsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractorsFm));
            this.contractorsRibonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.sendMessageBtn = new DevExpress.XtraBars.BarButtonItem();
            this.updateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.contractorsGrid = new DevExpress.XtraGrid.GridControl();
            this.contractorsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameContractorsCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phoneNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userTelegramIdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TerminalMKBot.WaitFm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.contractorsRibonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contractorsRibonControl
            // 
            this.contractorsRibonControl.ExpandCollapseItem.Id = 0;
            this.contractorsRibonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.contractorsRibonControl.ExpandCollapseItem,
            this.addBtn,
            this.editBtn,
            this.deleteBtn,
            this.sendMessageBtn,
            this.updateBtn});
            this.contractorsRibonControl.Location = new System.Drawing.Point(0, 0);
            this.contractorsRibonControl.MaxItemId = 6;
            this.contractorsRibonControl.Name = "contractorsRibonControl";
            this.contractorsRibonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.contractorsRibonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.contractorsRibonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.contractorsRibonControl.Size = new System.Drawing.Size(988, 95);
            this.contractorsRibonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // sendMessageBtn
            // 
            this.sendMessageBtn.Caption = "Отправить уведомление ";
            this.sendMessageBtn.Id = 4;
            this.sendMessageBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sendMessageBtn.ImageOptions.Image")));
            this.sendMessageBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("sendMessageBtn.ImageOptions.LargeImage")));
            this.sendMessageBtn.Name = "sendMessageBtn";
            this.sendMessageBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.sendMessageBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.sendMessageBtn_ItemClick);
            // 
            // updateBtn
            // 
            this.updateBtn.Caption = "Обновить";
            this.updateBtn.Id = 5;
            this.updateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageOptions.Image")));
            this.updateBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageOptions.LargeImage")));
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
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
            this.ribbonPageGroup1.Text = "Контрагент";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.sendMessageBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Функции";
            // 
            // contractorsGrid
            // 
            this.contractorsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractorsGrid.Location = new System.Drawing.Point(0, 95);
            this.contractorsGrid.MainView = this.contractorsGridView;
            this.contractorsGrid.Name = "contractorsGrid";
            this.contractorsGrid.Size = new System.Drawing.Size(988, 416);
            this.contractorsGrid.TabIndex = 1;
            this.contractorsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.contractorsGridView});
            // 
            // contractorsGridView
            // 
            this.contractorsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameContractorsCol,
            this.nameCol,
            this.phoneNumberCol,
            this.userTelegramIdCol});
            this.contractorsGridView.GridControl = this.contractorsGrid;
            this.contractorsGridView.Name = "contractorsGridView";
            this.contractorsGridView.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.contractorsGridView.OptionsView.ShowAutoFilterRow = true;
            this.contractorsGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.contractorsGridView.OptionsView.ShowGroupPanel = false;
            this.contractorsGridView.OptionsView.ShowIndicator = false;
            // 
            // nameContractorsCol
            // 
            this.nameContractorsCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameContractorsCol.AppearanceHeader.Options.UseFont = true;
            this.nameContractorsCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameContractorsCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameContractorsCol.Caption = "Организация";
            this.nameContractorsCol.FieldName = "NameContractors";
            this.nameContractorsCol.Name = "nameContractorsCol";
            this.nameContractorsCol.OptionsColumn.AllowEdit = false;
            this.nameContractorsCol.OptionsColumn.AllowFocus = false;
            this.nameContractorsCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nameContractorsCol.Visible = true;
            this.nameContractorsCol.VisibleIndex = 0;
            // 
            // nameCol
            // 
            this.nameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCol.AppearanceHeader.Options.UseFont = true;
            this.nameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.Caption = "ФИО пользователя";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 1;
            // 
            // phoneNumberCol
            // 
            this.phoneNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberCol.AppearanceHeader.Options.UseFont = true;
            this.phoneNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.phoneNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.phoneNumberCol.Caption = "Номер телефона";
            this.phoneNumberCol.FieldName = "PhoneNumber";
            this.phoneNumberCol.Name = "phoneNumberCol";
            this.phoneNumberCol.OptionsColumn.AllowEdit = false;
            this.phoneNumberCol.OptionsColumn.AllowFocus = false;
            this.phoneNumberCol.Visible = true;
            this.phoneNumberCol.VisibleIndex = 2;
            // 
            // userTelegramIdCol
            // 
            this.userTelegramIdCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userTelegramIdCol.AppearanceHeader.Options.UseFont = true;
            this.userTelegramIdCol.AppearanceHeader.Options.UseTextOptions = true;
            this.userTelegramIdCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.userTelegramIdCol.Caption = "Идентификатор телеграм";
            this.userTelegramIdCol.FieldName = "UserTelegramId";
            this.userTelegramIdCol.Name = "userTelegramIdCol";
            this.userTelegramIdCol.OptionsColumn.AllowEdit = false;
            this.userTelegramIdCol.OptionsColumn.AllowFocus = false;
            this.userTelegramIdCol.Visible = true;
            this.userTelegramIdCol.VisibleIndex = 3;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // ContractorsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 511);
            this.Controls.Add(this.contractorsGrid);
            this.Controls.Add(this.contractorsRibonControl);
            this.Name = "ContractorsFm";
            this.Text = "Контрагенти";
            ((System.ComponentModel.ISupportInitialize)(this.contractorsRibonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl contractorsRibonControl;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl contractorsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView contractorsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameContractorsCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn phoneNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn userTelegramIdCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarButtonItem sendMessageBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem updateBtn;
    }
}