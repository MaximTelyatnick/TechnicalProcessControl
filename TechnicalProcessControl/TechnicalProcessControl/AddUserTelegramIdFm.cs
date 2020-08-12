using System;
using System.Windows.Forms;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;

namespace TechnicalProcessControl
{
    public partial class AddUserTelegramIdFm : DevExpress.XtraEditors.XtraForm
    {

        private BindingSource telegramUserBS = new BindingSource();

        private IBotService botService;

        private MessagesDTO model = new MessagesDTO();


        //private ObjectBase Item
        //{
        //    get { return telegramUserBS.Current as ObjectBase; }
        //    set
        //    {
        //        telegramUserBS.DataSource = value;
        //        value.BeginEdit();
        //    }
        //}
        public AddUserTelegramIdFm(MessagesDTO model)
        {
            InitializeComponent();

            this.model = model;

            botService = Program.kernel.Get<IBotService>();

            //organisationEdit.DataBindings.Add("EditValue", telegramUserBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);

            telegramUserBS.DataSource = botService.GetAllUsers();
            telegramUserEdit.Properties.DataSource = telegramUserBS;
            telegramUserEdit.Properties.ValueMember = "Id";
            telegramUserEdit.Properties.DisplayMember = "Name";
            telegramUserEdit.Properties.NullText = "Немає данних";


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = ((UsersTelegramDTO)telegramUserEdit.GetSelectedDataRow()).Name;

                UsersTelegramDTO updateUser = ((UsersTelegramDTO)telegramUserEdit.GetSelectedDataRow());
                updateUser.UserTelegramId = model.UserTelegramId;

                botService = Program.kernel.Get<IBotService>();

                botService.TelegramUsersUpdate(updateUser);

                if(MessageBox.Show("Пользователю "+ updateUser.Name + " был присвоен идентификатор "+
                    updateUser.UserTelegramId.ToString()+"\n"+
                    "Отправить пользователю сообщение об успешной регистрации в системе ТерминалМК?", "Инфо", MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult = DialogResult.Abort;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //public UsersTelegramDTO Return()
        //{
        //    return ((UsersTelegramDTO)Item);
        //}
    }
}