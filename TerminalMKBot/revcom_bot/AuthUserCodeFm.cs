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

namespace TerminalMKBot
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