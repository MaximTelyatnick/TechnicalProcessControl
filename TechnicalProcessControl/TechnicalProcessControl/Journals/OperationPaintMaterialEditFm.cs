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
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.Infrastructure;
using Ninject;

namespace TechnicalProcessControl.Journals
{
    public partial class OperationPaintMaterialEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IJournalService journalService;
        private Utils.Operation operation;
        private BindingSource operationPaintMaterialBS = new BindingSource();
        private OperationPaintMaterialDTO operationPaintMaterialDTO = new OperationPaintMaterialDTO();

        private ObjectBase Item
        {
            get { return operationPaintMaterialBS.Current as ObjectBase; }
            set
            {
                operationPaintMaterialBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public OperationPaintMaterialEditFm(Utils.Operation operation, OperationPaintMaterialDTO operationPaintMaterialDTO)
        {
            InitializeComponent();

            this.operationPaintMaterialDTO = operationPaintMaterialDTO;
            this.operation = operation;

            operationPaintMaterialBS.DataSource = Item = operationPaintMaterialDTO;

            codeEdit.DataBindings.Add("EditValue", operationPaintMaterialBS, "Code", true, DataSourceUpdateMode.OnPropertyChanged);
            typeEdit.DataBindings.Add("EditValue", operationPaintMaterialBS, "Type", true, DataSourceUpdateMode.OnPropertyChanged);
            nameRusEdit.DataBindings.Add("EditValue", operationPaintMaterialBS, "NameRus", true, DataSourceUpdateMode.OnPropertyChanged);
            nameEngEdit.DataBindings.Add("EditValue", operationPaintMaterialBS, "NameEng", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public OperationPaintMaterialDTO Return()
        {
            return ((OperationPaintMaterialDTO)Item);
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            journalService = Program.kernel.Get<IJournalService>();

            if (journalService.CheckOperationPaintMaterial((OperationPaintMaterialDTO)Item))
            {
                MessageBox.Show("такой вид операции покраски уже есть в базе данных!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (operation == Utils.Operation.Add)
            {
                ((OperationPaintMaterialDTO)Item).Id = journalService.OperationPaintMaterialCreate((OperationPaintMaterialDTO)Item);
                journalService.OperationPaintMaterialUpdate((OperationPaintMaterialDTO)Item);
                return true;
            }
            else
            {

                journalService.OperationPaintMaterialUpdate((OperationPaintMaterialDTO)Item);
                return true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
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