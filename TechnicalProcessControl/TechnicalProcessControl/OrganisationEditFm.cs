using System;
using System.Windows.Forms;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Infrastructure;
using Ninject;

namespace TechnicalProcessControl
{
    public partial class OrganisationEditFm : DevExpress.XtraEditors.XtraForm
    {

        private IBotService botService;

        private Utils.Operation operation;

        private ContractorsDTO model;

        private BindingSource contractorBS = new BindingSource();

        private ObjectBase Item
        {
            get { return contractorBS.Current as ObjectBase; }
            set
            {
                contractorBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public OrganisationEditFm(Utils.Operation operation, ContractorsDTO model)
        {
            InitializeComponent();

            this.operation = operation;

            contractorBS.DataSource = Item = model;

            contractorEdit.DataBindings.Add("EditValue", contractorBS, "NameContractors", true, DataSourceUpdateMode.OnPropertyChanged);

            if (operation == Utils.Operation.Update)
            {
                contractorEdit.EditValue = ((ContractorsDTO)Item).NameContractors;
            }
            else
            {
                contractorEdit.EditValue = null;
                Item = model;

            }
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            botService = Program.kernel.Get<IBotService>();
                if (operation == Utils.Operation.Add)
                {
                    ((ContractorsDTO)Item).Id = botService.ContractorCreate((ContractorsDTO)Item);
                    return true;
                }
                else
                {

                botService.ContractorUpdate((ContractorsDTO)Item);
                    return true;
                } 
        }

        public int Return()
        {
            return ((ContractorsDTO)Item).Id;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    MessageBox.Show("При сохранении возникла ошибка. " + ex.Message, "Сохранение контрагента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void contractorEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}