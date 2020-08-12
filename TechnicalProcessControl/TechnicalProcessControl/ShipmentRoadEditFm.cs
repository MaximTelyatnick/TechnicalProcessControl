using System;
using System.Windows.Forms;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.Infrastructure;
using Ninject;

namespace TechnicalProcessControl
{
    public partial class ShipmentRoadEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBotService botService;
        private IControlPanelService controlPanelService;

        private Utils.Operation operation;

        private RoutesDTO models;

        private BindingSource routesBS = new BindingSource();

        private BindingSource organisationBS = new BindingSource();
        private BindingSource loadAreaBS = new BindingSource();
        private BindingSource uploadAreaBS = new BindingSource();
        private BindingSource productionBS = new BindingSource();

        private ObjectBase Item
        {
            get { return routesBS.Current as ObjectBase; }
            set
            {
                routesBS.DataSource = value;
                value.BeginEdit();
            }
        }
        public ShipmentRoadEditFm(RoutesDTO model, Utils.Operation operation)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            this.operation = operation;

            routesBS.DataSource = Item = model;

            organisationEdit.DataBindings.Add("EditValue", routesBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);
            productionEdit.DataBindings.Add("EditValue", routesBS, "ProductionId", true, DataSourceUpdateMode.OnPropertyChanged);
            loadAreaEdit.DataBindings.Add("EditValue", routesBS, "LoadAreaId", true, DataSourceUpdateMode.OnPropertyChanged);
            uploadAreaEdit.DataBindings.Add("EditValue", routesBS, "UnloadAreaId", true, DataSourceUpdateMode.OnPropertyChanged);
            distanceEdit.DataBindings.Add("EditValue", routesBS, "Distance", true, DataSourceUpdateMode.OnPropertyChanged);
            priceEdit.DataBindings.Add("EditValue", routesBS, "Rate", true, DataSourceUpdateMode.OnPropertyChanged);
            //organisationEdit.DataBindings.Add("EditValue", telegramUserBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);

            organisationBS.DataSource = botService.GetAllContractors();
            organisationEdit.Properties.DataSource = organisationBS;
            organisationEdit.Properties.ValueMember = "Id";
            organisationEdit.Properties.DisplayMember = "NameContractors";
            organisationEdit.Properties.NullText = "Немає данних";

            //rulesEdit.DataBindings.Add("EditValue", telegramUserBS, "Rules", true, DataSourceUpdateMode.OnPropertyChanged);
            productionBS.DataSource = controlPanelService.GetProduction();
            productionEdit.Properties.DataSource = productionBS;
            productionEdit.Properties.ValueMember = "Id";
            productionEdit.Properties.DisplayMember = "FullName";
            productionEdit.Properties.NullText = "Немає данних";

            loadAreaBS.DataSource = botService.GetAllCity();
            loadAreaEdit.Properties.DataSource = loadAreaBS;
            loadAreaEdit.Properties.ValueMember = "Id";
            loadAreaEdit.Properties.DisplayMember = "Name";
            loadAreaEdit.Properties.NullText = "Немає данних";

            uploadAreaBS.DataSource = botService.GetAllCity();
            uploadAreaEdit.Properties.DataSource = uploadAreaBS;
            uploadAreaEdit.Properties.ValueMember = "Id";
            uploadAreaEdit.Properties.DisplayMember = "Name";
            uploadAreaEdit.Properties.NullText = "Немає данних";


            //if (operation == Utils.Operation.Add)
            //{
            //    ((UsersTelegramDTO)Item).RegistrationDate = DateTime.Now;
            //    ((UsersTelegramDTO)Item).UserTelegramId = 0;
            //    ((UsersTelegramDTO)Item).CurrentLevelMenu = 0;
            //    ((UsersTelegramDTO)Item).Rules = 2;
            //}

            //ControlValidation();
            splashScreenManager.CloseWaitForm();
        }

        private void LoadData()
        {
            botService = Program.kernel.Get<IBotService>();
            controlPanelService = Program.kernel.Get<IControlPanelService>();
        }

        public RoutesDTO Return()
        {
            return ((RoutesDTO)Item);
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            try
            {
                botService = Program.kernel.Get<IBotService>();


                if (operation == Utils.Operation.Add)
                {
                    ((RoutesDTO)Item).Id = botService.RouteCreate((RoutesDTO)Item);
                    return true;
                }
                else
                {

                    botService.RouteUpdate((RoutesDTO)Item);
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

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
                    MessageBox.Show("При сохранении возникла ошибка. " + ex.Message, "Сохранение маршрута", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void productionEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            botService = Program.kernel.Get<IBotService>();
            controlPanelService = Program.kernel.Get<IControlPanelService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (ProductionEditFm productionEditFm = new ProductionEditFm(new ProductionDTO(),Utils.Operation.Add))
                        {
                            if (productionEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                ProductionDTO return_Id = productionEditFm.Return();
                                controlPanelService = Program.kernel.Get<IControlPanelService>();
                                productionBS.DataSource = controlPanelService.GetProduction();
                                productionEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (productionEdit.EditValue == DBNull.Value)
                            return;

                        using (ProductionEditFm productionEditFm = new ProductionEditFm((ProductionDTO)productionEdit.GetSelectedDataRow(), Utils.Operation.Update))
                        {
                            if (productionEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                ProductionDTO return_Id = productionEditFm.Return();
                                controlPanelService = Program.kernel.Get<IControlPanelService>();
                                productionBS.DataSource = controlPanelService.GetProduction();
                                productionEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (productionEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            controlPanelService = Program.kernel.Get<IControlPanelService>();
                            controlPanelService.ProductionDelete(((ProductionDTO)productionEdit.GetSelectedDataRow()).Id);
                            productionEdit.Properties.DataSource = controlPanelService.GetProduction();
                            productionEdit.EditValue = null;
                            productionEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        productionEdit.EditValue = null;
                        productionEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
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

        private void organisationEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void productionEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void loadAreaEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void uploadAreaEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void distanceEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void priceEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }
    }
}