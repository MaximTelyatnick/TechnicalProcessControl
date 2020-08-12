namespace TechnicalProcessControl
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
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
            this.tileNavCategory3 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.TechProcess001Item = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem2 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem3 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem4 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem5 = new DevExpress.XtraBars.Navigation.TileNavItem();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane
            // 
            this.tileNavPane.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tileNavPane.Appearance.Options.UseBackColor = true;
            this.tileNavPane.AppearanceHovered.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tileNavPane.AppearanceHovered.Options.UseBackColor = true;
            this.tileNavPane.AppearanceSelected.BackColor = System.Drawing.Color.Indigo;
            this.tileNavPane.AppearanceSelected.Options.UseBackColor = true;
            this.tileNavPane.Buttons.Add(this.contractorBtn);
            this.tileNavPane.Buttons.Add(this.tileNavCategory3);
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
            this.contractorBtn.AppearanceHovered.BackColor = System.Drawing.Color.LightGreen;
            this.contractorBtn.AppearanceHovered.Options.UseBackColor = true;
            this.contractorBtn.AppearanceSelected.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.contractorBtn.AppearanceSelected.ForeColor = System.Drawing.Color.White;
            this.contractorBtn.AppearanceSelected.Options.UseBackColor = true;
            this.contractorBtn.AppearanceSelected.Options.UseForeColor = true;
            this.contractorBtn.Caption = "Чертежи";
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
            this.orderBtn.AppearanceHovered.BackColor = System.Drawing.Color.LightGreen;
            this.orderBtn.AppearanceHovered.Options.UseBackColor = true;
            this.orderBtn.AppearanceSelected.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.orderBtn.AppearanceSelected.ForeColor = System.Drawing.Color.White;
            this.orderBtn.AppearanceSelected.Options.UseBackColor = true;
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
            this.msgBtn.Glyph = global::TechnicalProcessControl.Properties.Resources.mail__1_;
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
            // tileNavCategory3
            // 
            this.tileNavCategory3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.tileNavCategory3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavCategory3.AppearanceHovered.BackColor = System.Drawing.Color.LightGreen;
            this.tileNavCategory3.AppearanceHovered.Options.UseBackColor = true;
            this.tileNavCategory3.AppearanceSelected.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tileNavCategory3.AppearanceSelected.Options.UseBackColor = true;
            this.tileNavCategory3.Caption = "Техпроцессы";
            this.tileNavCategory3.Glyph = ((System.Drawing.Image)(resources.GetObject("tileNavCategory3.Glyph")));
            this.tileNavCategory3.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.TechProcess001Item,
            this.tileNavItem2,
            this.tileNavItem3,
            this.tileNavItem4,
            this.tileNavItem5});
            this.tileNavCategory3.Name = "tileNavCategory3";
            this.tileNavCategory3.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavCategory3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            // 
            // TechProcess001Item
            // 
            this.TechProcess001Item.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechProcess001Item.Appearance.Options.UseFont = true;
            this.TechProcess001Item.Appearance.Options.UseTextOptions = true;
            this.TechProcess001Item.Caption = "Заготовительное производство";
            this.TechProcess001Item.Name = "TechProcess001Item";
            this.TechProcess001Item.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // tileBarItem1
            // 
            this.TechProcess001Item.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Salmon;
            this.TechProcess001Item.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechProcess001Item.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.TechProcess001Item.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TechProcess001Item.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.TechProcess001Item.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.TechProcess001Item.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "Заготовительное производство";
            this.TechProcess001Item.Tile.Elements.Add(tileItemElement1);
            this.TechProcess001Item.Tile.Name = "tileBarItem1";
            // 
            // tileNavItem2
            // 
            this.tileNavItem2.Caption = "Механическая обработка";
            this.tileNavItem2.Name = "tileNavItem2";
            this.tileNavItem2.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // tileBarItem2
            // 
            this.tileNavItem2.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.PeachPuff;
            this.tileNavItem2.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileNavItem2.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavItem2.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "Механическая обработка";
            this.tileNavItem2.Tile.Elements.Add(tileItemElement2);
            this.tileNavItem2.Tile.Name = "tileBarItem2";
            // 
            // tileNavItem3
            // 
            this.tileNavItem3.Caption = "Сборка с использованием сварки";
            this.tileNavItem3.Name = "tileNavItem3";
            this.tileNavItem3.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // tileBarItem3
            // 
            this.tileNavItem3.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Khaki;
            this.tileNavItem3.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileNavItem3.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavItem3.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "Сборка с использованием сварки";
            this.tileNavItem3.Tile.Elements.Add(tileItemElement3);
            this.tileNavItem3.Tile.Name = "tileBarItem3";
            // 
            // tileNavItem4
            // 
            this.tileNavItem4.Caption = "Общая сборка";
            this.tileNavItem4.Name = "tileNavItem4";
            this.tileNavItem4.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // tileBarItem4
            // 
            this.tileNavItem4.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Aquamarine;
            this.tileNavItem4.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileNavItem4.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavItem4.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem4.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "Общая сборка";
            this.tileNavItem4.Tile.Elements.Add(tileItemElement4);
            this.tileNavItem4.Tile.Name = "tileBarItem4";
            // 
            // tileNavItem5
            // 
            this.tileNavItem5.Caption = "Подготовка поверхности и окраска";
            this.tileNavItem5.Name = "tileNavItem5";
            this.tileNavItem5.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // tileBarItem5
            // 
            this.tileNavItem5.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tileNavItem5.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileNavItem5.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavItem5.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem5.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "Подготовка поверхности и окраска";
            this.tileNavItem5.Tile.Elements.Add(tileItemElement5);
            this.tileNavItem5.Tile.Name = "tileBarItem5";
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
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory3;
        private DevExpress.XtraBars.Navigation.TileNavItem TechProcess001Item;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem2;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem3;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem4;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem5;
    }
}