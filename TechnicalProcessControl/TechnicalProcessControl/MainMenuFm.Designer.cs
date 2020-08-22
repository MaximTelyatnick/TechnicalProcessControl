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
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            this.tileNavPane = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.contractorBtn = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileNavCategory3 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.TechProcess001Item = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem2 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem3 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem4 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem5 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavCategory4 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.materialItem = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem6 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem7 = new DevExpress.XtraBars.Navigation.TileNavItem();
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
            this.tileNavPane.Buttons.Add(this.tileNavCategory4);
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
            // 
            // 
            this.TechProcess001Item.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Salmon;
            this.TechProcess001Item.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechProcess001Item.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.TechProcess001Item.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TechProcess001Item.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.TechProcess001Item.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.TechProcess001Item.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.Text = "Заготовительное производство";
            this.TechProcess001Item.Tile.Elements.Add(tileItemElement9);
            this.TechProcess001Item.Tile.Name = "tileBarItem1";
            // 
            // tileNavItem2
            // 
            this.tileNavItem2.Caption = "Механическая обработка";
            this.tileNavItem2.Name = "tileNavItem2";
            this.tileNavItem2.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // 
            // 
            this.tileNavItem2.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.PeachPuff;
            this.tileNavItem2.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileNavItem2.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavItem2.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement10.Text = "Механическая обработка";
            this.tileNavItem2.Tile.Elements.Add(tileItemElement10);
            this.tileNavItem2.Tile.Name = "tileBarItem2";
            // 
            // tileNavItem3
            // 
            this.tileNavItem3.Caption = "Сборка с использованием сварки";
            this.tileNavItem3.Name = "tileNavItem3";
            this.tileNavItem3.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // 
            // 
            this.tileNavItem3.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Khaki;
            this.tileNavItem3.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileNavItem3.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavItem3.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement11.Text = "Сборка с использованием сварки";
            this.tileNavItem3.Tile.Elements.Add(tileItemElement11);
            this.tileNavItem3.Tile.Name = "tileBarItem3";
            // 
            // tileNavItem4
            // 
            this.tileNavItem4.Caption = "Общая сборка";
            this.tileNavItem4.Name = "tileNavItem4";
            this.tileNavItem4.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // 
            // 
            this.tileNavItem4.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Aquamarine;
            this.tileNavItem4.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileNavItem4.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavItem4.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem4.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement12.Text = "Общая сборка";
            this.tileNavItem4.Tile.Elements.Add(tileItemElement12);
            this.tileNavItem4.Tile.Name = "tileBarItem4";
            // 
            // tileNavItem5
            // 
            this.tileNavItem5.Caption = "Подготовка поверхности и окраска";
            this.tileNavItem5.Name = "tileNavItem5";
            this.tileNavItem5.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // 
            // 
            this.tileNavItem5.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tileNavItem5.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileNavItem5.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavItem5.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem5.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement13.Text = "Подготовка поверхности и окраска";
            this.tileNavItem5.Tile.Elements.Add(tileItemElement13);
            this.tileNavItem5.Tile.Name = "tileBarItem5";
            // 
            // tileNavCategory4
            // 
            this.tileNavCategory4.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.tileNavCategory4.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavCategory4.AppearanceHovered.BackColor = System.Drawing.Color.LightGreen;
            this.tileNavCategory4.AppearanceHovered.Options.UseBackColor = true;
            this.tileNavCategory4.AppearanceSelected.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tileNavCategory4.AppearanceSelected.Options.UseBackColor = true;
            this.tileNavCategory4.Caption = "Справочники";
            this.tileNavCategory4.Glyph = ((System.Drawing.Image)(resources.GetObject("tileNavCategory4.Glyph")));
            this.tileNavCategory4.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.materialItem,
            this.tileNavItem6,
            this.tileNavItem7});
            this.tileNavCategory4.Name = "tileNavCategory4";
            this.tileNavCategory4.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavCategory4.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavCategory4.TileClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.tileNavCategory4_TileClick);
            // 
            // materialItem
            // 
            this.materialItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.materialItem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialItem.Appearance.Options.UseFont = true;
            this.materialItem.Caption = "Материалы";
            this.materialItem.Name = "materialItem";
            this.materialItem.OwnerCollection = this.tileNavCategory4.Items;
            // 
            // 
            // 
            this.materialItem.Tile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.materialItem.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.materialItem.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialItem.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.materialItem.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.materialItem.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.materialItem.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.materialItem.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement14.Text = "Материалы";
            this.materialItem.Tile.Elements.Add(tileItemElement14);
            this.materialItem.Tile.Name = "tileBarItem1";
            // 
            // tileNavItem6
            // 
            this.tileNavItem6.Caption = "Сканы чертежей";
            this.tileNavItem6.Name = "tileNavItem6";
            this.tileNavItem6.OwnerCollection = this.tileNavCategory4.Items;
            // 
            // 
            // 
            this.tileNavItem6.Tile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavItem6.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tileNavItem6.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileNavItem6.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavItem6.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem6.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement15.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement15.Text = "Сканы чертежей";
            this.tileNavItem6.Tile.Elements.Add(tileItemElement15);
            this.tileNavItem6.Tile.Name = "tileBarItem2";
            // 
            // tileNavItem7
            // 
            this.tileNavItem7.Caption = "Детали";
            this.tileNavItem7.Name = "tileNavItem7";
            this.tileNavItem7.OwnerCollection = this.tileNavCategory4.Items;
            // 
            // 
            // 
            this.tileNavItem7.Tile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavItem7.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tileNavItem7.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileNavItem7.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavItem7.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem7.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement16.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement16.Text = "Детали";
            this.tileNavItem7.Tile.Elements.Add(tileItemElement16);
            this.tileNavItem7.Tile.Name = "tileBarItem3";
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
            this.Text = "TechProcessControl";
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
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory3;
        private DevExpress.XtraBars.Navigation.TileNavItem TechProcess001Item;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem2;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem3;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem4;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem5;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory4;
        private DevExpress.XtraBars.Navigation.TileNavItem materialItem;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem6;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem7;
    }
}