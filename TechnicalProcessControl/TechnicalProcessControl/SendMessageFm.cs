using System;
using System.Windows.Forms;

namespace TechnicalProcessControl
{
    public partial class SendMessageFm : DevExpress.XtraEditors.XtraForm
    {
        public SendMessageFm()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            this.Close();
        }

        public string Return()
        {
            return messageEdit.Text;
        }
    }
}