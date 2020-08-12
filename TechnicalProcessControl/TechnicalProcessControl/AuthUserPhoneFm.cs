using System;
using System.Windows.Forms;

namespace TechnicalProcessControl
{
    public partial class AuthUserPhoneFm : DevExpress.XtraEditors.XtraForm
    {
        public AuthUserPhoneFm()
        {
            InitializeComponent();
        }

        private void setUserPhoneBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            this.Close();
        }

        public string Return()
        {
            return phoneEdit.Text;
        }
    }
}