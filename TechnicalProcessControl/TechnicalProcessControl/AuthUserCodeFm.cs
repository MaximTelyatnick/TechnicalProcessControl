using System;
using System.Windows.Forms;

namespace TechnicalProcessControl
{
    public partial class AuthUserCodeFm : DevExpress.XtraEditors.XtraForm
    {
        public AuthUserCodeFm()
        {
            InitializeComponent();
        }

        private void setUserCodeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            this.Close();
        }

        public string Return()
        {
            return codeEdit.Text;
        }
    }
}