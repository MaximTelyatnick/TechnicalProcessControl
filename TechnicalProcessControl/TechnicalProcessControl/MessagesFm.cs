using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;


namespace TechnicalProcessControl
{
    public partial class MessagesFm : DevExpress.XtraEditors.XtraForm
    {
        public IControlPanelService controlPanelService;
        public BindingSource messagesBS = new BindingSource();

        public List<MessagesDTO> messagesList = new List<MessagesDTO>();
        public MessagesFm()
        {

            InitializeComponent();


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

        private void addUserIdBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (AddUserTelegramIdFm addUserTelegramIdFm = new AddUserTelegramIdFm((MessagesDTO)messagesBS.Current))
            {
                if (addUserTelegramIdFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    controlPanelService.MessagesUpdate((MessagesDTO)messagesBS.Current);

                    
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