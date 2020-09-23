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
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl
{
    public partial class LoginFm : DevExpress.XtraEditors.XtraForm
    {
        public IUserService usersService;

        public LoginFm()
        {
            InitializeComponent();

            loginEdit.Text = Properties.Settings.Default.Login;
            passEdit.Text = Properties.Settings.Default.Password;
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            usersService = Program.kernel.Get<IUserService>();
            var user = usersService.CheckUser(loginEdit.Text, passEdit.Text);
            if (user != null)
            {
                using (MainMenuFm tmainMenuFm = new MainMenuFm((UsersDTO)user))
                {
                    if (tmainMenuFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                        
                    }
                    else if (tmainMenuFm.ShowDialog() == System.Windows.Forms.DialogResult.Retry)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else 
                    {
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль не совпадают", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showPasswordEdit_CheckedChanged(object sender, EventArgs e)
        {
            passEdit.Properties.UseSystemPasswordChar = !showPasswordEdit.Checked;
        }

        private void LoginFm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Login = loginEdit.Text;
            Properties.Settings.Default.Password = passEdit.Text;
            Properties.Settings.Default.Save();
        }
    }
}