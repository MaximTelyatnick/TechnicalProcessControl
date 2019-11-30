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
using TerminalMK.BLL.Interfaces;
using Ninject;
using TerminalMK.BLL.ModelsDTO;
using TLSharp.Core;
using TeleSharp.TL;

namespace TerminalMKBot
{
    public partial class ContractorsFm : DevExpress.XtraEditors.XtraForm
    {
        public static IBotService botService;

        public BindingSource usersTelegramBS = new BindingSource();

        public TelegramClient client;

        public ContractorsFm(TelegramClient client)
        {
            InitializeComponent();

            this.client = client;

            LoadData();

            
        }

        public void LoadData()
        {
            botService = Program.kernel.Get<IBotService>();

            splashScreenManager.ShowWaitForm();

            usersTelegramBS.DataSource = botService.GetAllUsers();

            contractorsGrid.DataSource = usersTelegramBS;

            splashScreenManager.CloseWaitForm();
        }

        public void EditUserTelegram(Utils.Operation operation, UsersTelegramDTO userTelegramDTO)
        {
            using (ContractorsEditFm contractorsEditFm = new ContractorsEditFm(userTelegramDTO, operation))
            {
                if (contractorsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    UsersTelegramDTO return_Id = contractorsEditFm.Return();
                    contractorsGridView.BeginDataUpdate();
                    LoadData();
                    contractorsGridView.EndDataUpdate();
                    int rowHandle = contractorsGridView.LocateByValue("Id", return_Id.Id);
                    contractorsGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditUserTelegram(Utils.Operation.Add, new UsersTelegramDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditUserTelegram(Utils.Operation.Update, (UsersTelegramDTO)usersTelegramBS.Current);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить пользователя", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                botService = Program.kernel.Get<IBotService>();

                contractorsGridView.BeginUpdate();

                if (botService.TelegramUsersDelete(((UsersTelegramDTO)usersTelegramBS.Current).Id))
                {
                    LoadData();
                }

                contractorsGridView.EndUpdate();
            }
        }

        private async void sendMessageBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string sendMessage = "";

            using (SendMessageFm sendMessageFm = new SendMessageFm())
            {
                if (sendMessageFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    sendMessage = sendMessageFm.Return();
            }

            await client.SendMessageAsync(new TLInputPeerUser() { UserId = (int)((UsersTelegramDTO)usersTelegramBS.Current).UserTelegramId }, sendMessage);
        }

        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}