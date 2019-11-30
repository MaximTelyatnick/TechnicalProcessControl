namespace TerminalMKBot
{
    partial class AuthUserCodeFm
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
            this.setUserCodeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.codeEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.codeEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // setUserCodeBtn
            // 
            this.setUserCodeBtn.Location = new System.Drawing.Point(190, 62);
            this.setUserCodeBtn.Name = "setUserCodeBtn";
            this.setUserCodeBtn.Size = new System.Drawing.Size(113, 23);
            this.setUserCodeBtn.TabIndex = 10;
            this.setUserCodeBtn.Text = "Отправить";
            this.setUserCodeBtn.Click += new System.EventHandler(this.setUserCodeBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Телеграм код";
            // 
            // codeEdit
            // 
            this.codeEdit.EditValue = "";
            this.codeEdit.Location = new System.Drawing.Point(12, 34);
            this.codeEdit.Name = "codeEdit";
            this.codeEdit.Properties.MaxLength = 12;
            this.codeEdit.Size = new System.Drawing.Size(292, 20);
            this.codeEdit.TabIndex = 8;
            this.codeEdit.ToolTip = "Укажитеномер телефона используемый в телеграм, на него придет код подтерждения.";
            // 
            // AuthUserCodeFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 100);
            this.Controls.Add(this.setUserCodeBtn);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.codeEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthUserCodeFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.codeEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton setUserCodeBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit codeEdit;
    }
}