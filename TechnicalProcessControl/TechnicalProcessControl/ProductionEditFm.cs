using System;
using System.Windows.Forms;
using TechnicalProcessControl.BLL.Infrastructure;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.ModelsDTO;
using Ninject;

namespace TechnicalProcessControl
{
    public partial class ProductionEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IControlPanelService controlPanelService;

        private Utils.Operation operation;

        private ProductionDTO models;

        private BindingSource productionBS = new BindingSource();
        private ObjectBase Item
        {
            get { return productionBS.Current as ObjectBase; }
            set
            {
                productionBS.DataSource = value;
                value.BeginEdit();
            }
        }
        public ProductionEditFm(ProductionDTO model, Utils.Operation operation)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            this.operation = operation;

            productionBS.DataSource = Item = model;

            providerEdit.DataBindings.Add("EditValue", productionBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            productionTypeEdit.DataBindings.Add("EditValue", productionBS, "type", true, DataSourceUpdateMode.OnPropertyChanged);
            descriptionEdit.DataBindings.Add("EditValue", productionBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged);

            ControlValidation();
            splashScreenManager.CloseWaitForm();
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            try
            {
                controlPanelService = Program.kernel.Get<IControlPanelService>();


                if (operation == Utils.Operation.Add)
                {
                    ((ProductionDTO)Item).Id = controlPanelService.ProductionCreate((ProductionDTO)Item);
                    return true;
                }
                else
                {

                    controlPanelService.ProductionUpdate((ProductionDTO)Item);
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("При сохранении возникла ошибка. " + ex.Message, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public ProductionDTO Return()
        {
            return ((ProductionDTO)Item);
        }

        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void providerEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void productionTypeEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void descriptionEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}