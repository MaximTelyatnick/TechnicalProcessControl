namespace TerminalMKBot
{
    partial class MessagesFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagesFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.checkMessagesBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addUserIdBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteMsgBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.messagesGrid = new DevExpress.XtraGrid.GridControl();
            this.messagesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.readCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.telegramIdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TerminalMKBot.WaitFm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.checkMessagesBtn,
            this.addUserIdBtn,
            this.deleteMsgBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1088, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // checkMessagesBtn
            // 
            this.checkMessagesBtn.Caption = "Отметить все как прочитаные";
            this.checkMessagesBtn.Id = 1;
            this.checkMessagesBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("checkMessagesBtn.ImageOptions.Image")));
            this.checkMessagesBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("checkMessagesBtn.ImageOptions.LargeImage")));
            this.checkMessagesBtn.Name = "checkMessagesBtn";
            this.checkMessagesBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.checkMessagesBtn_ItemClick);
            // 
            // addUserIdBtn
            // 
            this.addUserIdBtn.Caption = "Присвоить идентификатор";
            this.addUserIdBtn.Id = 2;
            this.addUserIdBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addUserIdBtn.ImageOptions.Image")));
            this.addUserIdBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addUserIdBtn.ImageOptions.LargeImage")));
            this.addUserIdBtn.Name = "addUserIdBtn";
            this.addUserIdBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addUserIdBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addUserIdBtn_ItemClick);
            // 
            // deleteMsgBtn
            // 
            this.deleteMsgBtn.Caption = "Удалить";
            this.deleteMsgBtn.Id = 3;
            this.deleteMsgBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteMsgBtn.ImageOptions.Image")));
            this.deleteMsgBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteMsgBtn.ImageOptions.LargeImage")));
            this.deleteMsgBtn.Name = "deleteMsgBtn";
            this.deleteMsgBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteMsgBtn_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.checkMessagesBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.addUserIdBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteMsgBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Методы";
            // 
            // messagesGrid
            // 
            this.messagesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesGrid.Location = new System.Drawing.Point(0, 95);
            this.messagesGrid.MainView = this.messagesGridView;
            this.messagesGrid.Name = "messagesGrid";
            this.messagesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit});
            this.messagesGrid.Size = new System.Drawing.Size(1088, 251);
            this.messagesGrid.TabIndex = 1;
            this.messagesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.messagesGridView});
            // 
            // messagesGridView
            // 
            this.messagesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.textCol,
            this.readCol,
            this.telegramIdCol});
            this.messagesGridView.GridControl = this.messagesGrid;
            this.messagesGridView.Name = "messagesGridView";
            this.messagesGridView.DoubleClick += new System.EventHandler(this.messagesGridView_DoubleClick);
            // 
            // textCol
            // 
            this.textCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCol.AppearanceHeader.Options.UseFont = true;
            this.textCol.AppearanceHeader.Options.UseTextOptions = true;
            this.textCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.textCol.Caption = "Сообщение";
            this.textCol.FieldName = "Text";
            this.textCol.Name = "textCol";
            this.textCol.OptionsColumn.AllowEdit = false;
            this.textCol.OptionsColumn.ReadOnly = true;
            this.textCol.Visible = true;
            this.textCol.VisibleIndex = 0;
            this.textCol.Width = 741;
            // 
            // readCol
            // 
            this.readCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readCol.AppearanceHeader.Options.UseFont = true;
            this.readCol.AppearanceHeader.Options.UseTextOptions = true;
            this.readCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.readCol.Caption = "Прочитано";
            this.readCol.ColumnEdit = this.repositoryItemCheckEdit;
            this.readCol.FieldName = "Read";
            this.readCol.Name = "readCol";
            this.readCol.Visible = true;
            this.readCol.VisibleIndex = 2;
            this.readCol.Width = 104;
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            this.repositoryItemCheckEdit.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit_CheckedChanged);
            // 
            // telegramIdCol
            // 
            this.telegramIdCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telegramIdCol.AppearanceHeader.Options.UseFont = true;
            this.telegramIdCol.Caption = "Идентификатор телеграм";
            this.telegramIdCol.FieldName = "UserTelegramId";
            this.telegramIdCol.Name = "telegramIdCol";
            this.telegramIdCol.OptionsColumn.ReadOnly = true;
            this.telegramIdCol.Visible = true;
            this.telegramIdCol.VisibleIndex = 1;
            this.telegramIdCol.Width = 225;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // MessagesFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 346);
            this.Controls.Add(this.messagesGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MessagesFm";
            this.Text = "Сообщения пользователей";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem checkMessagesBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl messagesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView messagesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn textCol;
        private DevExpress.XtraGrid.Columns.GridColumn readCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarButtonItem addUserIdBtn;
        private DevExpress.XtraGrid.Columns.GridColumn telegramIdCol;
        private DevExpress.XtraBars.BarButtonItem deleteMsgBtn;
    }
}