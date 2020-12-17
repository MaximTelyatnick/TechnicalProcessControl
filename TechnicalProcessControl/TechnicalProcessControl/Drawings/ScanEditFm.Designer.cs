namespace TechnicalProcessControl.Drawings
{
    partial class ScanEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanEditFm));
            this.assemblyCheckEdit = new System.Windows.Forms.CheckBox();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.drawingScanEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.showBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.openFileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.numberEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fileNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.addScanBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deleteScanBtn = new DevExpress.XtraEditors.SimpleButton();
            this.drawingNumberEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.revisionDrawingCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.assemblyCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.materialNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.w2Col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailWeightCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noteCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingScanEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // assemblyCheckEdit
            // 
            this.assemblyCheckEdit.AutoSize = true;
            this.assemblyCheckEdit.Location = new System.Drawing.Point(352, -46);
            this.assemblyCheckEdit.Name = "assemblyCheckEdit";
            this.assemblyCheckEdit.Size = new System.Drawing.Size(59, 17);
            this.assemblyCheckEdit.TabIndex = 154;
            this.assemblyCheckEdit.Text = "без ТП";
            this.assemblyCheckEdit.UseVisualStyleBackColor = true;
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.Red;
            this.validateLbl.Appearance.Options.UseFont = true;
            this.validateLbl.Appearance.Options.UseForeColor = true;
            this.validateLbl.Location = new System.Drawing.Point(10, 627);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(240, 14);
            this.validateLbl.TabIndex = 153;
            this.validateLbl.Text = "Невозможно сохранить скан чертежа";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.drawingScanEdit);
            this.panelControl2.Controls.Add(this.clearBtn);
            this.panelControl2.Controls.Add(this.showBtn);
            this.panelControl2.Controls.Add(this.pictureEdit);
            this.panelControl2.Controls.Add(this.openFileBtn);
            this.panelControl2.Location = new System.Drawing.Point(0, -1);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1097, 529);
            this.panelControl2.TabIndex = 145;
            // 
            // drawingScanEdit
            // 
            this.drawingScanEdit.Location = new System.Drawing.Point(10, 537);
            this.drawingScanEdit.Name = "drawingScanEdit";
            this.drawingScanEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.drawingScanEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drawingScanEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileName", "Имя файла")});
            this.drawingScanEdit.Size = new System.Drawing.Size(433, 18);
            this.drawingScanEdit.TabIndex = 25;
            // 
            // clearBtn
            // 
            this.clearBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.ImageOptions.Image")));
            this.clearBtn.Location = new System.Drawing.Point(379, 561);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(29, 23);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.ToolTip = "Выберите файл для удаления";
            // 
            // showBtn
            // 
            this.showBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("showBtn.ImageOptions.Image")));
            this.showBtn.Location = new System.Drawing.Point(414, 561);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(30, 23);
            this.showBtn.TabIndex = 23;
            this.showBtn.ToolTip = "Открыть файл в обозревателе";
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(10, 5);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.AccessibleDescription = "";
            this.pictureEdit.Properties.AllowDisposeImage = true;
            this.pictureEdit.Properties.NullText = "Не добавлено файл";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Size = new System.Drawing.Size(1082, 519);
            this.pictureEdit.TabIndex = 22;
            // 
            // openFileBtn
            // 
            this.openFileBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("openFileBtn.ImageOptions.Image")));
            this.openFileBtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.openFileBtn.Location = new System.Drawing.Point(344, 561);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(29, 23);
            this.openFileBtn.TabIndex = 4;
            this.openFileBtn.ToolTip = "Вибрати файл для добавления";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(1009, 623);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 144;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(928, 623);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 143;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // numberEdit
            // 
            this.numberEdit.Location = new System.Drawing.Point(18, -23);
            this.numberEdit.Name = "numberEdit";
            this.numberEdit.Size = new System.Drawing.Size(393, 20);
            this.numberEdit.TabIndex = 130;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, -44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 14);
            this.labelControl2.TabIndex = 125;
            this.labelControl2.Text = "Номер чертежа";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(507, 537);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 14);
            this.labelControl1.TabIndex = 155;
            this.labelControl1.Text = "Номер чертежа";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 538);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 14);
            this.labelControl3.TabIndex = 157;
            this.labelControl3.Text = "Наименование файла";
            // 
            // fileNameEdit
            // 
            this.fileNameEdit.Location = new System.Drawing.Point(10, 557);
            this.fileNameEdit.Name = "fileNameEdit";
            this.fileNameEdit.Size = new System.Drawing.Size(491, 20);
            this.fileNameEdit.TabIndex = 158;
            // 
            // addScanBtn
            // 
            this.addScanBtn.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("addScanBtn.Appearance.Image")));
            this.addScanBtn.Appearance.Options.UseImage = true;
            this.addScanBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.addScanBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addScanBtn.ImageOptions.Image")));
            this.addScanBtn.Location = new System.Drawing.Point(297, 583);
            this.addScanBtn.Name = "addScanBtn";
            this.addScanBtn.Size = new System.Drawing.Size(100, 23);
            this.addScanBtn.TabIndex = 159;
            this.addScanBtn.Text = "Добавить";
            this.addScanBtn.Click += new System.EventHandler(this.addScanBtn_Click);
            // 
            // deleteScanBtn
            // 
            this.deleteScanBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.deleteScanBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.deleteScanBtn.Location = new System.Drawing.Point(403, 583);
            this.deleteScanBtn.Name = "deleteScanBtn";
            this.deleteScanBtn.Size = new System.Drawing.Size(98, 23);
            this.deleteScanBtn.TabIndex = 160;
            this.deleteScanBtn.Text = "Удалить";
            this.deleteScanBtn.Click += new System.EventHandler(this.deleteScanBtn_Click);
            // 
            // drawingNumberEdit
            // 
            this.drawingNumberEdit.Location = new System.Drawing.Point(507, 556);
            this.drawingNumberEdit.Name = "drawingNumberEdit";
            this.drawingNumberEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drawingNumberEdit.Properties.PopupFormMinSize = new System.Drawing.Size(700, 0);
            this.drawingNumberEdit.Properties.PopupFormSize = new System.Drawing.Size(700, 0);
            this.drawingNumberEdit.Properties.PopupView = this.gridLookUpEdit1View;
            this.drawingNumberEdit.Size = new System.Drawing.Size(585, 20);
            this.drawingNumberEdit.TabIndex = 161;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.numberCol,
            this.revisionDrawingCol,
            this.assemblyCol,
            this.detailCol,
            this.materialNameCol,
            this.thCol,
            this.lCol,
            this.wCol,
            this.w2Col,
            this.detailWeightCol,
            this.dateCol,
            this.noteCol});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // numberCol
            // 
            this.numberCol.Caption = "Номер чертежа";
            this.numberCol.FieldName = "Number";
            this.numberCol.Name = "numberCol";
            this.numberCol.Visible = true;
            this.numberCol.VisibleIndex = 0;
            this.numberCol.Width = 150;
            // 
            // revisionDrawingCol
            // 
            this.revisionDrawingCol.Caption = "Ревизия";
            this.revisionDrawingCol.FieldName = "RevisionName";
            this.revisionDrawingCol.Name = "revisionDrawingCol";
            this.revisionDrawingCol.Visible = true;
            this.revisionDrawingCol.VisibleIndex = 1;
            // 
            // assemblyCol
            // 
            this.assemblyCol.Caption = "Тип чертежа";
            this.assemblyCol.FieldName = "AssemblyName";
            this.assemblyCol.Name = "assemblyCol";
            this.assemblyCol.Visible = true;
            this.assemblyCol.VisibleIndex = 2;
            // 
            // detailCol
            // 
            this.detailCol.Caption = "Деталь";
            this.detailCol.FieldName = "DetailName";
            this.detailCol.Name = "detailCol";
            this.detailCol.Visible = true;
            this.detailCol.VisibleIndex = 3;
            this.detailCol.Width = 60;
            // 
            // materialNameCol
            // 
            this.materialNameCol.Caption = "Материал";
            this.materialNameCol.FieldName = "MaterialName";
            this.materialNameCol.Name = "materialNameCol";
            this.materialNameCol.Visible = true;
            this.materialNameCol.VisibleIndex = 4;
            this.materialNameCol.Width = 50;
            // 
            // thCol
            // 
            this.thCol.Caption = "TH";
            this.thCol.FieldName = "TH";
            this.thCol.Name = "thCol";
            this.thCol.Visible = true;
            this.thCol.VisibleIndex = 5;
            this.thCol.Width = 23;
            // 
            // lCol
            // 
            this.lCol.Caption = "L";
            this.lCol.FieldName = "L";
            this.lCol.Name = "lCol";
            this.lCol.Visible = true;
            this.lCol.VisibleIndex = 6;
            this.lCol.Width = 23;
            // 
            // wCol
            // 
            this.wCol.Caption = "W";
            this.wCol.FieldName = "W";
            this.wCol.Name = "wCol";
            this.wCol.Visible = true;
            this.wCol.VisibleIndex = 7;
            this.wCol.Width = 23;
            // 
            // w2Col
            // 
            this.w2Col.Caption = "W2";
            this.w2Col.FieldName = "W2";
            this.w2Col.Name = "w2Col";
            this.w2Col.Visible = true;
            this.w2Col.VisibleIndex = 8;
            this.w2Col.Width = 23;
            // 
            // detailWeightCol
            // 
            this.detailWeightCol.Caption = "Вес";
            this.detailWeightCol.FieldName = "DetailWeight";
            this.detailWeightCol.Name = "detailWeightCol";
            this.detailWeightCol.Visible = true;
            this.detailWeightCol.VisibleIndex = 9;
            this.detailWeightCol.Width = 32;
            // 
            // dateCol
            // 
            this.dateCol.Caption = "Дата";
            this.dateCol.FieldName = "CreateDate";
            this.dateCol.Name = "dateCol";
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 10;
            // 
            // noteCol
            // 
            this.noteCol.Caption = "Приметка";
            this.noteCol.FieldName = "Note";
            this.noteCol.Name = "noteCol";
            this.noteCol.Visible = true;
            this.noteCol.VisibleIndex = 11;
            // 
            // ScanEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 653);
            this.Controls.Add(this.drawingNumberEdit);
            this.Controls.Add(this.deleteScanBtn);
            this.Controls.Add(this.addScanBtn);
            this.Controls.Add(this.fileNameEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.assemblyCheckEdit);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.numberEdit);
            this.Controls.Add(this.labelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScanEditFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование скана";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingScanEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox assemblyCheckEdit;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LookUpEdit drawingScanEdit;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.SimpleButton showBtn;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.SimpleButton openFileBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.TextEdit numberEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit fileNameEdit;
        private DevExpress.XtraEditors.SimpleButton addScanBtn;
        private DevExpress.XtraEditors.SimpleButton deleteScanBtn;
        private DevExpress.XtraEditors.GridLookUpEdit drawingNumberEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn numberCol;
        private DevExpress.XtraGrid.Columns.GridColumn revisionDrawingCol;
        private DevExpress.XtraGrid.Columns.GridColumn assemblyCol;
        private DevExpress.XtraGrid.Columns.GridColumn detailCol;
        private DevExpress.XtraGrid.Columns.GridColumn materialNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn thCol;
        private DevExpress.XtraGrid.Columns.GridColumn lCol;
        private DevExpress.XtraGrid.Columns.GridColumn wCol;
        private DevExpress.XtraGrid.Columns.GridColumn w2Col;
        private DevExpress.XtraGrid.Columns.GridColumn detailWeightCol;
        private DevExpress.XtraGrid.Columns.GridColumn dateCol;
        private DevExpress.XtraGrid.Columns.GridColumn noteCol;
    }
}