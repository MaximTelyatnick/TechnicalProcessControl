using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TLSharp.Core;
using TeleSharp.TL;

namespace TerminalMKBot
{
    public partial class AuthTelegramUserFm : DevExpress.XtraEditors.XtraForm
    {
        TelegramClient client;

        int telegramApiId = 1090023;
        string telegramApiHash = "3651d2c505bed6f082a7314219c848f6";
        string hash;
        bool isValidate;
        FileSessionStore sessionStore;
        public AuthTelegramUserFm()
        {
            InitializeComponent();

            sessionStore = new TLSharp.Core.FileSessionStore();
            client = new TelegramClient(telegramApiId, telegramApiHash, sessionStore, "session");

            //phoneEdit.Properties.Mask.EditMask = "+380687300860";
            //phoneEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            //phoneEdit.Properties.Mask.SaveLiteral = false;
            //phoneEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            //this.phoneEdit.TabIndex = 10;

            client.ConnectAsync();
        }

        private async void setPhoneBtn_Click(object sender, EventArgs e)
        {
            splashScreenManager.ShowWaitForm();

            await client.ConnectAsync();

            string phoneNumber = phoneEdit.Text.ToString();

            if (!client.IsUserAuthorized())
            {
                var hashKey = await client.SendCodeRequestAsync(phoneNumber);
                //TLUser myuser = await client.MakeAuthAsync("+********", hashKey, TelegramSendedCode);
            }
            //hash = await client.SendCodeRequestAsync(phoneNumber);

            splashScreenManager.CloseWaitForm();

        }

        private void setCodeActivationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!client.IsUserAuthorized())
                {
                    var user = client.MakeAuthAsync(phoneEdit.Text.ToString(), hash.ToString(), codeEdit.Text);
                    if (user != null)
                    {
                        MessageBox.Show("Вы прошли авторизацию. ", "Авторизаця", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    //TLUser myuser = await client.MakeAuthAsync("+********", hashKey, TelegramSendedCode);
                }

                //var user = client.MakeAuthAsync(phoneEdit.Text.ToString(), hash.ToString(), codeEdit.Text);
                //if(user!=null)
                //{
                //    MessageBox.Show("Вы прошли авторизацию. ", "Авторизаця", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}
            }
            catch (Exception)
            {

                throw;
            }
            

           
        }

        //private async void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    var result = await client.GetContactsAsync();

        //    var user = result.Users.Where(x => x.GetType() == typeof(TLUser))
        //        .Cast<TLUser>()
        //        .FirstOrDefault(x => x.Phone == "380687300860");

        //    await client.SendMessageAsync(new TLInputPeerUser() { UserId = user.Id }, "Test");
        //}

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.setCodeActivationBtn.Enabled = false;
            //this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            //isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.setCodeActivationBtn.Enabled = isValidate;
            //this.validateLbl.Visible = !isValidate;
        }



        private void phoneEdit_EditValueChanged(object sender, EventArgs e)
        {

            if (phoneEdit.Text.Count() == 12)
                setCodeActivationBtn.Enabled = true;
            else
                setCodeActivationBtn.Enabled = false;
            //dxValidationProvider.Validate((Control)sender);
        }

        private void AuthTelegramUserFm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            await client.SendMessageAsync(new TLInputPeerUser() { UserId = 626463505 }, "Test");
        }
    }
}