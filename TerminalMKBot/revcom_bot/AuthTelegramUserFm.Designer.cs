namespace TerminalMKBot
{
    partial class AuthTelegramUserFm
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
            this.phoneEdit = new DevExpress.XtraEditors.TextEdit();
            this.codeEdit = new DevExpress.XtraEditors.TextEdit();
            this.setPhoneBtn = new DevExpress.XtraEditors.SimpleButton();
            this.setCodeActivationBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TerminalMKBot.WaitFm), true, true);
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneEdit
            // 
            this.phoneEdit.EditValue = "380687300860";
            this.phoneEdit.Location = new System.Drawing.Point(36, 30);
            this.phoneEdit.Name = "phoneEdit";
            this.phoneEdit.Properties.MaxLength = 12;
            this.phoneEdit.Size = new System.Drawing.Size(292, 20);
            this.phoneEdit.TabIndex = 0;
            // 
            // codeEdit
            // 
            this.codeEdit.Location = new System.Drawing.Point(36, 75);
            this.codeEdit.Name = "codeEdit";
            this.codeEdit.Size = new System.Drawing.Size(292, 20);
            this.codeEdit.TabIndex = 1;
            // 
            // setPhoneBtn
            // 
            this.setPhoneBtn.Location = new System.Drawing.Point(36, 108);
            this.setPhoneBtn.Name = "setPhoneBtn";
            this.setPhoneBtn.Size = new System.Drawing.Size(143, 23);
            this.setPhoneBtn.TabIndex = 2;
            this.setPhoneBtn.Text = "Указать номер телефона";
            this.setPhoneBtn.Click += new System.EventHandler(this.setPhoneBtn_Click);
            // 
            // setCodeActivationBtn
            // 
            this.setCodeActivationBtn.Location = new System.Drawing.Point(185, 108);
            this.setCodeActivationBtn.Name = "setCodeActivationBtn";
            this.setCodeActivationBtn.Size = new System.Drawing.Size(143, 23);
            this.setCodeActivationBtn.TabIndex = 3;
            this.setCodeActivationBtn.Text = "Указать ключ";
            this.setCodeActivationBtn.Click += new System.EventHandler(this.setCodeActivationBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Номер телефона";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(36, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Код подтверждения";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidationProvider_ValidationFailed);
            this.dxValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.dxValidationProvider_ValidationSucceeded);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(36, 137);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(292, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Отправить сообщение";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // AuthTelegramUserFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 176);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.setCodeActivationBtn);
            this.Controls.Add(this.setPhoneBtn);
            this.Controls.Add(this.codeEdit);
            this.Controls.Add(this.phoneEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthTelegramUserFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthTelegramUserFm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit phoneEdit;
        private DevExpress.XtraEditors.TextEdit codeEdit;
        private DevExpress.XtraEditors.SimpleButton setPhoneBtn;
        private DevExpress.XtraEditors.SimpleButton setCodeActivationBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}