using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.Journals
{
    public partial class MaterialFm : DevExpress.XtraEditors.XtraForm
    {
        public IJournalService journalService;
        public BindingSource materialsBS = new BindingSource();

        public MaterialFm()
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            splashScreenManager.CloseWaitForm();
        }

        private void LoadData()
        {
            journalService = Program.kernel.Get<IJournalService>();
            var productions = journalService.GetMaterials();
            materialsBS.DataSource = productions;
            materialGrid.DataSource = materialsBS;
        }
        public void EditMaterial(Utils.Operation operation, MaterialsDTO materialsDTO)
        {
            using (MaterialEditFm materialEditFm = new MaterialEditFm(operation, materialsDTO))
            {
                if (materialEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MaterialsDTO return_Id = materialEditFm.Return();
                    materialGridView.BeginDataUpdate();
                    LoadData();
                    materialGridView.EndDataUpdate();
                    int rowHandle = materialGridView.LocateByValue("Id", return_Id.Id);
                    materialGridView.FocusedRowHandle = rowHandle;

                }
            }
        }


        private void addMaterialBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditMaterial(Utils.Operation.Add, new MaterialsDTO());
        }

        private void editMaterialBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditMaterial(Utils.Operation.Update, ((MaterialsDTO)materialsBS.Current));
        }

        private void deleteMaterialBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить материал?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                journalService = Program.kernel.Get<IJournalService>();

                materialGridView.BeginUpdate();
                if (journalService.MaterialsDelete(((MaterialsDTO)materialsBS.Current).Id))
                    LoadData();
                materialGridView.EndUpdate();
            }
        }
    }
}