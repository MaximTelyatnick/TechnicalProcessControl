namespace TerminalMKBot
{
    partial class AuthUserPhoneFm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.phoneEdit = new DevExpress.XtraEditors.TextEdit();
            this.setUserPhoneBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Номер телефона";
            // 
            // phoneEdit
            // 
            this.phoneEdit.EditValue = "380687300860";
            this.phoneEdit.Location = new System.Drawing.Point(11, 30);
            this.phoneEdit.Name = "phoneEdit";
            this.phoneEdit.Properties.MaxLength = 12;
            this.phoneEdit.Size = new System.Drawing.Size(292, 20);
            this.phoneEdit.TabIndex = 5;
            this.phoneEdit.ToolTip = "Укажитеномер телефона используемый в телеграм, на него придет код подтерждения.";
            // 
            // setUserPhoneBtn
            // 
            this.setUserPhoneBtn.Location = new System.Drawing.Point(190, 58);
            this.setUserPhoneBtn.Name = "setUserPhoneBtn";
            this.setUserPhoneBtn.Size = new System.Drawing.Size(113, 23);
            this.setUserPhoneBtn.TabIndex = 7;
            this.setUserPhoneBtn.Text = "Отправить";
            this.setUserPhoneBtn.Click += new System.EventHandler(this.setUserPhoneBtn_Click);
            // 
            // AuthUserPhoneFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 97);
            this.Controls.Add(this.setUserPhoneBtn);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.phoneEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthUserPhoneFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit phoneEdit;
        private DevExpress.XtraEditors.SimpleButton setUserPhoneBtn;
    }
}