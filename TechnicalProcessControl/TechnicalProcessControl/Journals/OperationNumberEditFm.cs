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
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Infrastructure;
using Ninject;

namespace TechnicalProcessControl.Journals
{
    public partial class OperationNumberEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IJournalService journalService;
        private Utils.Operation operation;
        private BindingSource operationNumberBS = new BindingSource();
        private OperationNumberDTO operationNumberDTO = new OperationNumberDTO();

        private ObjectBase Item
        {
            get { return operationNumberBS.Current as ObjectBase; }
            set
            {
                operationNumberBS.DataSource = value;
                value.BeginEdit();
            }
        }
        public OperationNumberEditFm(Utils.Operation operation, OperationNumberDTO operationNumberDTO)
        {
            InitializeComponent();

            this.operationNumberDTO = operationNumberDTO;
            this.operation = operation;

            operationNumberBS.DataSource = Item = operationNumberDTO;

            tableIdEdit.DataBindings.Add("EditValue", operationNumberBS, "TableId", true, DataSourceUpdateMode.OnPropertyChanged);
            operationNumberNameEdit.DataBindings.Add("EditValue", operationNumberBS, "OperationNumberName", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public OperationNumberDTO Return()
        {
            return ((OperationNumberDTO)Item);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            journalService = Program.kernel.Get<IJournalService>();

            if (journalService.CheckOperationNumber((OperationNumberDTO)Item))
            {
                MessageBox.Show("Номер операции с таким именем уже есть в базе данных!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (operation == Utils.Operation.Add)
            {
                ((OperationNumberDTO)Item).Id = journalService.OperationNumberCreate((OperationNumberDTO)Item);
                return true;
            }
            else
            {

                journalService.OperationNumberUpdate((OperationNumberDTO)Item);
                return true;
            }
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
    }
}