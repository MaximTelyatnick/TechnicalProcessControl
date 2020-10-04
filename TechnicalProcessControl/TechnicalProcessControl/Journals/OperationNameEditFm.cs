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
    public partial class OperationNameEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IJournalService journalService;

        private Utils.Operation operation;

        private BindingSource operationNameBS = new BindingSource();

        private OperationNameDTO materialsDTO = new OperationNameDTO();

        private ObjectBase Item
        {
            get { return operationNameBS.Current as ObjectBase; }
            set
            {
                operationNameBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public OperationNameEditFm(Utils.Operation operation, OperationNameDTO operationNameDTO)
        {
            InitializeComponent();

            this.materialsDTO = materialsDTO;
            this.operation = operation;

            operationNameBS.DataSource = Item = operationNameDTO;

            idEdit.DataBindings.Add("EditValue", operationNameBS, "TableId", true, DataSourceUpdateMode.OnPropertyChanged);
            codeEdit.DataBindings.Add("EditValue", operationNameBS, "Code", true, DataSourceUpdateMode.OnPropertyChanged);
            nameRusEdit.DataBindings.Add("EditValue", operationNameBS, "NameRus", true, DataSourceUpdateMode.OnPropertyChanged);
            nameEngEdit.DataBindings.Add("EditValue", operationNameBS, "NameEng", true, DataSourceUpdateMode.OnPropertyChanged);
            nameArabEdit.DataBindings.Add("EditValue", operationNameBS, "NameAr", true, DataSourceUpdateMode.OnPropertyChanged);

            //if (operation == Utils.Operation.Update)
            //{
            //    materialEdit.EditValue = ((MaterialsDTO)Item).MaterialName;
            //}
            //else
            //{
            //    materialEdit.EditValue = null;
            //    Item = materialsDTO;

            //}
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            journalService = Program.kernel.Get<IJournalService>();

            if (journalService.CheckOperationName((OperationNameDTO)Item))
            {
                MessageBox.Show("Наименовании операции с таким именем уже есть в базе данных!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (operation == Utils.Operation.Add)
            {
                ((OperationNameDTO)Item).Id = journalService.OperationNameCreate((OperationNameDTO)Item);
                return true;
            }
            else
            {

                journalService.OperationNameUpdate((OperationNameDTO)Item);
                return true;
            }
        }

        public OperationNameDTO Return()
        {
            return ((OperationNameDTO)Item);
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