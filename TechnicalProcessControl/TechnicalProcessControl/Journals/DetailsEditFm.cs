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
    public partial class DetailsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IJournalService journalService;

        private Utils.Operation operation;

        private BindingSource detailsBS = new BindingSource();

        private DetailsDTO detailsDTO = new DetailsDTO();

        private ObjectBase Item
        {
            get { return detailsBS.Current as ObjectBase; }
            set
            {
                detailsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public DetailsEditFm(Utils.Operation operation, DetailsDTO detailsDTO)
        {
            InitializeComponent();

            this.detailsDTO = detailsDTO;
            this.operation = operation;

            detailsBS.DataSource = Item = detailsDTO;

            detailEdit.DataBindings.Add("EditValue", detailsBS, "DetailName", true, DataSourceUpdateMode.OnPropertyChanged);

            if (operation == Utils.Operation.Update)
            {
                detailEdit.EditValue = ((DetailsDTO)Item).DetailName;
            }
            else
            {
                detailEdit.EditValue = null;
                Item = detailsDTO;

            }
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            journalService = Program.kernel.Get<IJournalService>();

            if (journalService.CheckDetailName((DetailsDTO)Item))
            {
                MessageBox.Show("Деталь с таким именем уже есть в базе данных!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (operation == Utils.Operation.Add)
            {
                ((DetailsDTO)Item).Id = journalService.DetailCreate((DetailsDTO)Item);
                return true;
            }
            else
            {

                journalService.DetailsUpdate((DetailsDTO)Item);
                return true;
            }
        }

        public DetailsDTO Return()
        {
            return ((DetailsDTO)Item);
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