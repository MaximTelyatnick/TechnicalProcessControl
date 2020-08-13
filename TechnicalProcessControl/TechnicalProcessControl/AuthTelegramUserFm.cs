using System;
using System.Linq;
using System.Windows.Forms;

namespace TechnicalProcessControl
{
    public partial class AuthTelegramUserFm : DevExpress.XtraEditors.XtraForm
    {

        
        
        public AuthTelegramUserFm()
        {
            InitializeComponent();

            

            //phoneEdit.Properties.Mask.EditMask = "+380687300860";
            //phoneEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            //phoneEdit.Properties.Mask.SaveLiteral = false;
            //phoneEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            //this.phoneEdit.TabIndex = 10;

        }

        private void setPhoneBtn_Click(object sender, EventArgs e)
        {
            splashScreenManager.ShowWaitForm();

            
            //hash = await client.SendCodeRequestAsync(phoneNumber);

            splashScreenManager.CloseWaitForm();

        }

        private void setCodeActivationBtn_Click(object sender, EventArgs e)
        {
            try
            {
               

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
            //this.setCodeActivationBtn.Enabled = false;
            //this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            //isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            //this.setCodeActivationBtn.Enabled = isValidate;
            //this.validateLbl.Visible = !isValidate;
        }



        private void phoneEdit_EditValueChanged(object sender, EventArgs e)
        {

            //if (phoneEdit.Text.Count() == 12)
            //    setCodeActivationBtn.Enabled = true;
            //else
            //    setCodeActivationBtn.Enabled = false;
            //dxValidationProvider.Validate((Control)sender);
        }

        private void AuthTelegramUserFm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            
            //await client.SendMessageAsync(new TLInputPeerUser() { UserId = 626463505 }, "Test");
        }
    }
}