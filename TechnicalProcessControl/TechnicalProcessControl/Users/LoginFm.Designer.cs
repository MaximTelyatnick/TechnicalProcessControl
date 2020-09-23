namespace TechnicalProcessControl
{
    partial class LoginFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFm));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.passEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginEdit = new DevExpress.XtraEditors.TextEdit();
            this.authBtn = new DevExpress.XtraEditors.SimpleButton();
            this.showPasswordEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.passEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Пароль";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Логин";
            // 
            // passEdit
            // 
            this.passEdit.Location = new System.Drawing.Point(12, 74);
            this.passEdit.Name = "passEdit";
            this.passEdit.Properties.UseSystemPasswordChar = true;
            this.passEdit.Size = new System.Drawing.Size(201, 20);
            this.passEdit.TabIndex = 8;
            // 
            // loginEdit
            // 
            this.loginEdit.EditValue = "Admin";
            this.loginEdit.Location = new System.Drawing.Point(12, 29);
            this.loginEdit.Name = "loginEdit";
            this.loginEdit.Properties.MaxLength = 12;
            this.loginEdit.Size = new System.Drawing.Size(201, 20);
            this.loginEdit.TabIndex = 7;
            // 
            // authBtn
            // 
            this.authBtn.Location = new System.Drawing.Point(12, 138);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(201, 23);
            this.authBtn.TabIndex = 11;
            this.authBtn.Text = "Войти";
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // showPasswordEdit
            // 
            this.showPasswordEdit.Location = new System.Drawing.Point(13, 101);
            this.showPasswordEdit.Name = "showPasswordEdit";
            this.showPasswordEdit.Properties.Caption = "Не скрывать пароль";
            this.showPasswordEdit.Size = new System.Drawing.Size(200, 19);
            this.showPasswordEdit.TabIndex = 12;
            this.showPasswordEdit.CheckedChanged += new System.EventHandler(this.showPasswordEdit_CheckedChanged);
            // 
            // LoginFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 174);
            this.Controls.Add(this.showPasswordEdit);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.passEdit);
            this.Controls.Add(this.loginEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginFm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.passEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit passEdit;
        private DevExpress.XtraEditors.TextEdit loginEdit;
        private DevExpress.XtraEditors.SimpleButton authBtn;
        private DevExpress.XtraEditors.CheckEdit showPasswordEdit;
    }
}