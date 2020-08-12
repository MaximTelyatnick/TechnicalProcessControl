using System;
using System.Windows.Forms;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.Infrastructure;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl
{
    public partial class ContractorsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBotService botService;

        private Utils.Operation operation;

        private UsersTelegramDTO models;

        private BindingSource telegramUserBS = new BindingSource();

        private BindingSource organisationBS = new BindingSource();

        private ObjectBase Item
        {
            get { return telegramUserBS.Current as ObjectBase; }
            set
            {
                telegramUserBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public ContractorsEditFm(UsersTelegramDTO model, Utils.Operation operation)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            this.operation = operation;

            telegramUserBS.DataSource = Item = model;

            fioEdit.DataBindings.Add("EditValue", telegramUserBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            phoneEdit.DataBindings.Add("EditValue", telegramUserBS, "PhoneNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            registrationDateEdit.DataBindings.Add("EditValue", telegramUserBS, "RegistrationDate", true, DataSourceUpdateMode.OnPropertyChanged);
            telegramIdEdit.DataBindings.Add("EditValue", telegramUserBS, "UserTelegramId", true, DataSourceUpdateMode.OnPropertyChanged);

            organisationEdit.DataBindings.Add("EditValue", telegramUserBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);

            organisationBS.DataSource = botService.GetAllContractors();
            organisationEdit.Properties.DataSource = organisationBS;
            organisationEdit.Properties.ValueMember = "Id";
            organisationEdit.Properties.DisplayMember = "NameContractors";
            organisationEdit.Properties.NullText = "Немає данних";

            rulesEdit.DataBindings.Add("EditValue", telegramUserBS, "Rules", true, DataSourceUpdateMode.OnPropertyChanged);
            rulesEdit.Properties.DataSource = botService.GetAllRules();
            rulesEdit.Properties.ValueMember = "Id";
            rulesEdit.Properties.DisplayMember = "NameRules";
            rulesEdit.Properties.NullText = "Немає данних";


            if (operation == Utils.Operation.Add)
            {
                ((UsersTelegramDTO)Item).RegistrationDate = DateTime.Now;
                ((UsersTelegramDTO)Item).UserTelegramId = 0;
                ((UsersTelegramDTO)Item).CurrentLevelMenu = 0;
                ((UsersTelegramDTO)Item).Rules = 2;
            }

            ControlValidation();
            splashScreenManager.CloseWaitForm();
        }

        public UsersTelegramDTO Return()
        {
            return ((UsersTelegramDTO)Item);
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            try
            {
                botService = Program.kernel.Get<IBotService>();


                if (operation == Utils.Operation.Add)
                {
                    ((UsersTelegramDTO)Item).Id = botService.TelegramUsersCreate((UsersTelegramDTO)Item);
                    return true;
                }
                else
                {

                    botService.TelegramUsersUpdate((UsersTelegramDTO)Item);
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void LoadData()
        {
            botService = Program.kernel.Get<IBotService>();

        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Сохранить?", "подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (SaveItem())
                        {
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Пр сохранение возникла ошибка. " + ex.Message, "Сохранение пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void organisationEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            botService = Program.kernel.Get<IBotService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (OrganisationEditFm organisationEditFm = new OrganisationEditFm(Utils.Operation.Add, new ContractorsDTO()))
                        {
                            if (organisationEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                int return_Id = organisationEditFm.Return();
                                botService = Program.kernel.Get<IBotService>();
                                organisationBS.DataSource = botService.GetAllContractors();
                                organisationEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (organisationEdit.EditValue == DBNull.Value)
                            return;

                        using (OrganisationEditFm organisationEditFm = new OrganisationEditFm(Utils.Operation.Update, (ContractorsDTO)organisationEdit.GetSelectedDataRow()))
                        {
                            if (organisationEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                int return_Id = organisationEditFm.Return();
                                botService = Program.kernel.Get<IBotService>();
                                organisationBS.DataSource = botService.GetAllContractors();
                                organisationEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (organisationEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            botService.ContractorDelete(((ContractorsDTO)organisationEdit.GetSelectedDataRow()).Id);
                            botService = Program.kernel.Get<IBotService>();
                            organisationEdit.Properties.DataSource = botService.GetAllContractors();
                            organisationEdit.EditValue = null;
                            organisationEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        organisationEdit.EditValue = null;
                        organisationEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }
        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }
        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void fioEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void organisationEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void phoneEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void rulesEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void registrationDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}