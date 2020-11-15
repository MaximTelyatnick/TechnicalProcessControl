namespace TechnicalProcessControl
{
    partial class settingsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsFm));
            this.settangsTab = new DevExpress.XtraTab.XtraTabControl();
            this.databaseTab = new DevExpress.XtraTab.XtraTabPage();
            this.importTab = new DevExpress.XtraTab.XtraTabPage();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand12 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.techProcessBand = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.techProcessPropBand = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.weldingMaterialBand = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.gasMaterialBand = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.paintMaterialBand = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.laborIntensityBand = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand14 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.checkPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.existingWorkflowFileEdit = new DevExpress.XtraEditors.TextEdit();
            this.addExistingWorkflowBtn = new DevExpress.XtraEditors.SimpleButton();
            this.importFromExcelBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.settangsTab)).BeginInit();
            this.settangsTab.SuspendLayout();
            this.importTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPanelControl)).BeginInit();
            this.checkPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingWorkflowFileEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // settangsTab
            // 
            this.settangsTab.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.settangsTab.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.settangsTab.Location = new System.Drawing.Point(0, 0);
            this.settangsTab.Name = "settangsTab";
            this.settangsTab.SelectedTabPage = this.databaseTab;
            this.settangsTab.Size = new System.Drawing.Size(1032, 350);
            this.settangsTab.TabIndex = 1;
            this.settangsTab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.databaseTab,
            this.importTab});
            // 
            // databaseTab
            // 
            this.databaseTab.Appearance.Header.Options.UseTextOptions = true;
            this.databaseTab.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.databaseTab.Name = "databaseTab";
            this.databaseTab.Size = new System.Drawing.Size(588, 344);
            this.databaseTab.TabPageWidth = 100;
            this.databaseTab.Text = "База данных";
            // 
            // importTab
            // 
            this.importTab.Appearance.Header.Options.UseTextOptions = true;
            this.importTab.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.importTab.Controls.Add(this.checkPanelControl);
            this.importTab.Name = "importTab";
            this.importTab.Size = new System.Drawing.Size(912, 344);
            this.importTab.TabPageWidth = 100;
            this.importTab.Text = "Імпорт";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(863, 356);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Сохранить";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(944, 356);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Отмена";
            // 
            // treeListBand1
            // 
            this.treeListBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListBand1.AppearanceHeader.Options.UseFont = true;
            this.treeListBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListBand1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.treeListBand1.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.treeListBand1.Name = "treeListBand1";
            this.treeListBand1.Width = 200;
            // 
            // treeListBand12
            // 
            this.treeListBand12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListBand12.AppearanceHeader.Options.UseFont = true;
            this.treeListBand12.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListBand12.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.treeListBand12.Name = "treeListBand12";
            this.treeListBand12.Width = 700;
            // 
            // treeListBand2
            // 
            this.treeListBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeListBand2.AppearanceHeader.Options.UseFont = true;
            this.treeListBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListBand2.Caption = "Dim";
            this.treeListBand2.Name = "treeListBand2";
            this.treeListBand2.Width = 600;
            // 
            // techProcessBand
            // 
            this.techProcessBand.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.techProcessBand.AppearanceHeader.Options.UseFont = true;
            this.techProcessBand.AppearanceHeader.Options.UseTextOptions = true;
            this.techProcessBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.techProcessBand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.techProcessBand.Caption = "Code of the second group of technological process number";
            this.techProcessBand.Name = "techProcessBand";
            this.techProcessBand.OptionsBand.AllowMove = false;
            this.techProcessBand.Width = 1000;
            // 
            // techProcessPropBand
            // 
            this.techProcessPropBand.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.techProcessPropBand.AppearanceHeader.Options.UseFont = true;
            this.techProcessPropBand.AppearanceHeader.Options.UseTextOptions = true;
            this.techProcessPropBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.techProcessPropBand.Caption = "Параметры заготовки";
            this.techProcessPropBand.MinWidth = 300;
            this.techProcessPropBand.Name = "techProcessPropBand";
            this.techProcessPropBand.Width = 490;
            // 
            // weldingMaterialBand
            // 
            this.weldingMaterialBand.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weldingMaterialBand.AppearanceHeader.Options.UseFont = true;
            this.weldingMaterialBand.AppearanceHeader.Options.UseTextOptions = true;
            this.weldingMaterialBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.weldingMaterialBand.Caption = "Расход сварочных материалов, кг";
            this.weldingMaterialBand.MinWidth = 600;
            this.weldingMaterialBand.Name = "weldingMaterialBand";
            this.weldingMaterialBand.Width = 957;
            // 
            // gasMaterialBand
            // 
            this.gasMaterialBand.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gasMaterialBand.AppearanceHeader.Options.UseFont = true;
            this.gasMaterialBand.AppearanceHeader.Options.UseTextOptions = true;
            this.gasMaterialBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gasMaterialBand.Caption = "Расход технических газов";
            this.gasMaterialBand.Name = "gasMaterialBand";
            this.gasMaterialBand.Width = 350;
            // 
            // paintMaterialBand
            // 
            this.paintMaterialBand.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paintMaterialBand.AppearanceHeader.Options.UseFont = true;
            this.paintMaterialBand.AppearanceHeader.Options.UseTextOptions = true;
            this.paintMaterialBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paintMaterialBand.Caption = "Расход лакокрасочных материалов, кг";
            this.paintMaterialBand.Name = "paintMaterialBand";
            this.paintMaterialBand.Width = 1615;
            // 
            // laborIntensityBand
            // 
            this.laborIntensityBand.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laborIntensityBand.AppearanceHeader.Options.UseFont = true;
            this.laborIntensityBand.AppearanceHeader.Options.UseTextOptions = true;
            this.laborIntensityBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.laborIntensityBand.Caption = "Трудоемкость";
            this.laborIntensityBand.Name = "laborIntensityBand";
            this.laborIntensityBand.Width = 601;
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
            // checkPanelControl
            // 
            this.checkPanelControl.Controls.Add(this.importFromExcelBtn);
            this.checkPanelControl.Controls.Add(this.labelControl8);
            this.checkPanelControl.Controls.Add(this.existingWorkflowFileEdit);
            this.checkPanelControl.Controls.Add(this.addExistingWorkflowBtn);
            this.checkPanelControl.Location = new System.Drawing.Point(14, 11);
            this.checkPanelControl.Name = "checkPanelControl";
            this.checkPanelControl.Size = new System.Drawing.Size(890, 63);
            this.checkPanelControl.TabIndex = 115;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 9);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 13);
            this.labelControl8.TabIndex = 113;
            this.labelControl8.Text = "Файл xls:";
            // 
            // existingWorkflowFileEdit
            // 
            this.existingWorkflowFileEdit.Location = new System.Drawing.Point(57, 6);
            this.existingWorkflowFileEdit.Name = "existingWorkflowFileEdit";
            this.existingWorkflowFileEdit.Size = new System.Drawing.Size(609, 20);
            this.existingWorkflowFileEdit.TabIndex = 112;
            // 
            // addExistingWorkflowBtn
            // 
            this.addExistingWorkflowBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addExistingWorkflowBtn.ImageOptions.Image")));
            this.addExistingWorkflowBtn.Location = new System.Drawing.Point(672, 5);
            this.addExistingWorkflowBtn.Name = "addExistingWorkflowBtn";
            this.addExistingWorkflowBtn.Size = new System.Drawing.Size(81, 21);
            this.addExistingWorkflowBtn.TabIndex = 111;
            this.addExistingWorkflowBtn.Text = "Добавить";
            // 
            // importFromExcelBtn
            // 
            this.importFromExcelBtn.Location = new System.Drawing.Point(759, 5);
            this.importFromExcelBtn.Name = "importFromExcelBtn";
            this.importFromExcelBtn.Size = new System.Drawing.Size(126, 22);
            this.importFromExcelBtn.TabIndex = 114;
            this.importFromExcelBtn.Text = "Начать импорт";
            this.importFromExcelBtn.Click += new System.EventHandler(this.importFromExcelBtn_Click);
            // 
            // settingsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 390);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.settangsTab);
            this.Name = "settingsFm";
            this.Text = "settingsFm";
            ((System.ComponentModel.ISupportInitialize)(this.settangsTab)).EndInit();
            this.settangsTab.ResumeLayout(false);
            this.importTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkPanelControl)).EndInit();
            this.checkPanelControl.ResumeLayout(false);
            this.checkPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingWorkflowFileEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl settangsTab;
        private DevExpress.XtraTab.XtraTabPage databaseTab;
        private DevExpress.XtraTab.XtraTabPage importTab;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand12;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand2;
        private DevExpress.XtraTreeList.Columns.TreeListBand techProcessBand;
        private DevExpress.XtraTreeList.Columns.TreeListBand techProcessPropBand;
        private DevExpress.XtraTreeList.Columns.TreeListBand weldingMaterialBand;
        private DevExpress.XtraTreeList.Columns.TreeListBand gasMaterialBand;
        private DevExpress.XtraTreeList.Columns.TreeListBand paintMaterialBand;
        private DevExpress.XtraTreeList.Columns.TreeListBand laborIntensityBand;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand14;
        private DevExpress.XtraEditors.PanelControl checkPanelControl;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit existingWorkflowFileEdit;
        private DevExpress.XtraEditors.SimpleButton addExistingWorkflowBtn;
        private DevExpress.XtraEditors.SimpleButton importFromExcelBtn;
    }
}