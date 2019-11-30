namespace TerminalMKBot
{
    partial class MainMenuFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuFm));
            this.tileNavPane = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.contractorBtn = new DevExpress.XtraBars.Navigation.NavButton();
            this.productionBtn = new DevExpress.XtraBars.Navigation.NavButton();
            this.citiesBtn = new DevExpress.XtraBars.Navigation.NavButton();
            this.shipmentRoadBtn = new DevExpress.XtraBars.Navigation.NavButton();
            this.orderBtn = new DevExpress.XtraBars.Navigation.NavButton();
            this.msgBtn = new DevExpress.XtraBars.Navigation.NavButton();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane
            // 
            this.tileNavPane.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.tileNavPane.Appearance.Options.UseBackColor = true;
            this.tileNavPane.AppearanceHovered.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tileNavPane.AppearanceHovered.Options.UseBackColor = true;
            this.tileNavPane.AppearanceSelected.BackColor = System.Drawing.Color.Indigo;
            this.tileNavPane.AppearanceSelected.Options.UseBackColor = true;
            this.tileNavPane.Buttons.Add(this.contractorBtn);
            this.tileNavPane.Buttons.Add(this.productionBtn);
            this.tileNavPane.Buttons.Add(this.citiesBtn);
            this.tileNavPane.Buttons.Add(this.shipmentRoadBtn);
            this.tileNavPane.Buttons.Add(this.orderBtn);
            this.tileNavPane.Buttons.Add(this.msgBtn);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane.Name = "tileNavPane";
            this.tileNavPane.Size = new System.Drawing.Size(1193, 70);
            this.tileNavPane.TabIndex = 0;
            // 
            // contractorBtn
            // 
            this.contractorBtn.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.contractorBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.contractorBtn.AppearanceSelected.ForeColor = System.Drawing.Color.White;
            this.contractorBtn.AppearanceSelected.Options.UseForeColor = true;
            this.contractorBtn.Caption = "Пользователи";
            this.contractorBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("contractorBtn.Glyph")));
            this.contractorBtn.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.contractorBtn.Name = "contractorBtn";
            this.contractorBtn.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.contractorBtn_ElementClick);
            // 
            // productionBtn
            // 
            this.productionBtn.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.productionBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.productionBtn.AppearanceSelected.ForeColor = System.Drawing.Color.White;
            this.productionBtn.AppearanceSelected.Options.UseForeColor = true;
            this.productionBtn.Caption = "Продукция";
            this.productionBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("productionBtn.Glyph")));
            this.productionBtn.Name = "productionBtn";
            this.productionBtn.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.productionBtn_ElementClick);
            // 
            // citiesBtn
            // 
            this.citiesBtn.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.citiesBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.citiesBtn.AppearanceSelected.ForeColor = System.Drawing.Color.White;
            this.citiesBtn.AppearanceSelected.Options.UseForeColor = true;
            this.citiesBtn.Caption = "Населенные пункты";
            this.citiesBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("citiesBtn.Glyph")));
            this.citiesBtn.Name = "citiesBtn";
            this.citiesBtn.Visible = false;
            // 
            // shipmentRoadBtn
            // 
            this.shipmentRoadBtn.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.shipmentRoadBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.shipmentRoadBtn.AppearanceSelected.ForeColor = System.Drawing.Color.White;
            this.shipmentRoadBtn.AppearanceSelected.Options.UseForeColor = true;
            this.shipmentRoadBtn.Caption = "Маршруты";
            this.shipmentRoadBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("shipmentRoadBtn.Glyph")));
            this.shipmentRoadBtn.Name = "shipmentRoadBtn";
            this.shipmentRoadBtn.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.shipmentRoadBtn_ElementClick);
            // 
            // orderBtn
            // 
            this.orderBtn.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.orderBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.orderBtn.AppearanceSelected.ForeColor = System.Drawing.Color.White;
            this.orderBtn.AppearanceSelected.Options.UseForeColor = true;
            this.orderBtn.Caption = "Заявки";
            this.orderBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("orderBtn.Glyph")));
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Visible = false;
            // 
            // msgBtn
            // 
            this.msgBtn.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.msgBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.msgBtn.Caption = null;
            this.msgBtn.Glyph = global::TerminalMKBot.Properties.Resources.mail__1_;
            this.msgBtn.Name = "msgBtn";
            this.msgBtn.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.msgBtn_ElementClick);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.View = this.tabbedView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "mail.png");
            this.imageCollection.Images.SetKeyName(1, "openmessages.png");
            // 
            // MainMenuFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 499);
            this.Controls.Add(this.tileNavPane);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления ботом Терминал-МК";
            this.Load += new System.EventHandler(this.MainMenuFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane;
        private DevExpress.XtraBars.Navigation.NavButton contractorBtn;
        private DevExpress.XtraBars.Navigation.NavButton productionBtn;
        private DevExpress.XtraBars.Navigation.NavButton orderBtn;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Navigation.NavButton msgBtn;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraBars.Navigation.NavButton citiesBtn;
        private DevExpress.XtraBars.Navigation.NavButton shipmentRoadBtn;
    }
}