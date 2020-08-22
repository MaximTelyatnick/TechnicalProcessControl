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
using TechnicalProcessControl.BLL.Infrastructure;
using TechnicalProcessControl.BLL.ModelsDTO;
using Ninject;

namespace TechnicalProcessControl.Journals
{
    public partial class MaterialEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IJournalService journalService;

        private Utils.Operation operation;

        private BindingSource materialsBS = new BindingSource();

        private MaterialsDTO materialsDTO = new MaterialsDTO();

        private ObjectBase Item
        {
            get { return materialsBS.Current as ObjectBase; }
            set
            {
                materialsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public MaterialEditFm(Utils.Operation operation, MaterialsDTO materialsDTO)
        {
            InitializeComponent();

            this.materialsDTO = materialsDTO;
            this.operation = operation;

            materialsBS.DataSource = Item = materialsDTO;

            materialEdit.DataBindings.Add("EditValue", materialsBS, "MaterialName", true, DataSourceUpdateMode.OnPropertyChanged);

            if (operation == Utils.Operation.Update)
            {
                materialEdit.EditValue = ((MaterialsDTO)Item).MaterialName;
            }
            else
            {
                materialEdit.EditValue = null;
                Item = materialsDTO;

            }
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            journalService = Program.kernel.Get<IJournalService>();

            if(journalService.CheckMaterialName((MaterialsDTO)Item))
            {
                MessageBox.Show("Материал с таким именем уже есть в базе данных!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (operation == Utils.Operation.Add)
            {
                ((ContractorsDTO)Item).Id = journalService.MaterialsCreate((MaterialsDTO)Item);
                return true;
            }
            else
            {

                journalService.MaterialsUpdate((MaterialsDTO)Item);
                return true;
            }
        }

        public int Return()
        {
            return ((MaterialsDTO)Item).Id;
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