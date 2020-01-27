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
    public partial class MessagesFm : DevExpress.XtraEditors.XtraForm
    {
        public IControlPanelService controlPanelService;
        public BindingSource messagesBS = new BindingSource();
        public TelegramClient client;

        public List<MessagesDTO> messagesList = new List<MessagesDTO>();
        public MessagesFm(TelegramClient client)
        {

            InitializeComponent();

            this.client = client;

            splashScreenManager.ShowWaitForm();

            LoadData();

            splashScreenManager.CloseWaitForm();
        }

        private void LoadData()
        {
            controlPanelService = Program.kernel.Get<IControlPanelService>();
            messagesBS.DataSource = controlPanelService.GetMessages();
            messagesGrid.DataSource = messagesBS;
        }

        private void checkMessagesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            messagesGridView.PostEditor();

            splashScreenManager.ShowWaitForm();

            messagesList = ((List<MessagesDTO>)messagesBS.DataSource).ToList();

            foreach (var item in messagesList)
            {
                if (!item.Read)
                    item.Read = true;
            }

            //messagesList = ((List<MessagesDTO>)messagesBS.DataSource).ToList();

            controlPanelService.MessagesUpdateRange(messagesList);

            splashScreenManager.CloseWaitForm();

        }

        private async void addUserIdBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (AddUserTelegramIdFm addUserTelegramIdFm = new AddUserTelegramIdFm((MessagesDTO)messagesBS.Current))
            {
                if (addUserTelegramIdFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    controlPanelService.MessagesUpdate((MessagesDTO)messagesBS.Current);

                    var result = await client.GetContactsAsync();

                    var user = result.Users
                        .Where(x => x.GetType() == typeof(TLUser))
                        .Cast<TLUser>()
                        .FirstOrDefault(x => x.Id == (int)((MessagesDTO)messagesBS.Current).UserTelegramId);

                    if (user != null)
                        await client.SendMessageAsync(new TLInputPeerUser() { UserId = (int)((MessagesDTO)messagesBS.Current).UserTelegramId }, "Вы зарегистрированы в системе, для использования чат бота перейдите по ссылке https://t.me/terminalmktestbot?start ");
                    else
                        MessageBox.Show("Вказаний користувач відсутній у ваших контактах. Додайте користувача до списку ваших контактів" , "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //UsersTelegramDTO return_Id = contractorsEditFm.Return();
                    //contractorsGridView.BeginDataUpdate();
                    //LoadData();
                    //contractorsGridView.EndDataUpdate();
                    //int rowHandle = contractorsGridView.LocateByValue("Id", return_Id.Id);
                    //contractorsGridView.FocusedRowHandle = rowHandle;

                }
                else if (addUserTelegramIdFm.ShowDialog() == System.Windows.Forms.DialogResult.Abort)
                {

                }
            }
        }




        private void deleteMsgBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить сообщение", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controlPanelService = Program.kernel.Get<IControlPanelService>();

                messagesGridView.BeginUpdate();

                if (controlPanelService.MessagesDelete(((MessagesDTO)messagesBS.Current).Id))
                {
                    LoadData();
                }

                messagesGridView.EndUpdate();
            }
        }

        private void repositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            MessagesDTO updateMessage = new MessagesDTO()
            { Id = ((MessagesDTO)messagesBS.Current).Id,
             Read = !((MessagesDTO)messagesBS.Current).Read,
              Text = ((MessagesDTO)messagesBS.Current).Text,
               UserTelegramId = ((MessagesDTO)messagesBS.Current).UserTelegramId
            };

            controlPanelService.MessagesUpdate(updateMessage);

            LoadData();
        }

        private void messagesGridView_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(((MessagesDTO)messagesBS.Current).Text, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}