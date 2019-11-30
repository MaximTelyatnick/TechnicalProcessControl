namespace TerminalMKBot
{
    partial class SendMessageFm
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
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.sendBtn = new DevExpress.XtraEditors.SimpleButton();
            this.messageEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.messageEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(177, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Сообщение для пользователя";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(481, 121);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Отменить";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(400, 121);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 20;
            this.sendBtn.Text = "Отправить";
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // messageEdit
            // 
            this.messageEdit.EditValue = "";
            this.messageEdit.Location = new System.Drawing.Point(12, 31);
            this.messageEdit.Name = "messageEdit";
            this.messageEdit.Properties.MaxLength = 150;
            this.messageEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.messageEdit.Size = new System.Drawing.Size(544, 84);
            this.messageEdit.TabIndex = 7;
            this.messageEdit.ToolTip = "Данный текст будет отправлен пользователю";
            // 
            // SendMessageFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 153);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.messageEdit);
            this.Name = "SendMessageFm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.messageEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton sendBtn;
        private DevExpress.XtraEditors.MemoEdit messageEdit;
    }
}