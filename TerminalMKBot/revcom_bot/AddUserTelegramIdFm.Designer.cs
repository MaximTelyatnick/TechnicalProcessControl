namespace TerminalMKBot
{
    partial class AddUserTelegramIdFm
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
            this.telegramUserEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameContractorsCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phoneNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userTelegramIdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.telegramUserEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // telegramUserEdit
            // 
            this.telegramUserEdit.Location = new System.Drawing.Point(12, 39);
            this.telegramUserEdit.Name = "telegramUserEdit";
            this.telegramUserEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.telegramUserEdit.Properties.PopupView = this.gridLookUpEdit1View;
            this.telegramUserEdit.Size = new System.Drawing.Size(436, 20);
            this.telegramUserEdit.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameCol,
            this.nameContractorsCol,
            this.phoneNumberCol,
            this.userTelegramIdCol});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "Пользователь";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            // 
            // nameContractorsCol
            // 
            this.nameContractorsCol.Caption = "Организация";
            this.nameContractorsCol.FieldName = "NameContractors";
            this.nameContractorsCol.Name = "nameContractorsCol";
            this.nameContractorsCol.Visible = true;
            this.nameContractorsCol.VisibleIndex = 1;
            // 
            // phoneNumberCol
            // 
            this.phoneNumberCol.Caption = "Телефон";
            this.phoneNumberCol.FieldName = "PhoneNumber";
            this.phoneNumberCol.Name = "phoneNumberCol";
            this.phoneNumberCol.Visible = true;
            this.phoneNumberCol.VisibleIndex = 2;
            // 
            // userTelegramIdCol
            // 
            this.userTelegramIdCol.Caption = "Идентификатор телеграм";
            this.userTelegramIdCol.FieldName = "UserTelegramId";
            this.userTelegramIdCol.Name = "userTelegramIdCol";
            this.userTelegramIdCol.Visible = true;
            this.userTelegramIdCol.VisibleIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Пользователь";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(373, 65);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(292, 65);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Присвоить";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddUserTelegramIdFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 99);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.telegramUserEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserTelegramIdFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление идентификатора пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.telegramUserEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit telegramUserEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameContractorsCol;
        private DevExpress.XtraGrid.Columns.GridColumn phoneNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn userTelegramIdCol;
    }
}