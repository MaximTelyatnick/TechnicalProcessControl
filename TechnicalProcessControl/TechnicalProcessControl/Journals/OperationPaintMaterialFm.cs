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
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.Journals
{
    public partial class OperationPaintMaterialFm : DevExpress.XtraEditors.XtraForm
    {
        public IJournalService journalService;
        public BindingSource operationPaintMaterialBS = new BindingSource();

        public OperationPaintMaterialFm()
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            splashScreenManager.CloseWaitForm();
        }


        private void LoadData()
        {
            journalService = Program.kernel.Get<IJournalService>();
            var operationNumber = journalService.GetOperationPaintMaterial();
            operationPaintMaterialBS.DataSource = operationNumber;
            paintMaterialGrid.DataSource = operationPaintMaterialBS;
        }

        public void EditOperationPaintMaterial(Utils.Operation operation, OperationPaintMaterialDTO operationPaintMaterialDTO)
        {
            using (OperationPaintMaterialEditFm operationPaintMaterialEditFm = new OperationPaintMaterialEditFm(operation, operationPaintMaterialDTO))
            {
                if (operationPaintMaterialEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    OperationPaintMaterialDTO return_Id = operationPaintMaterialEditFm.Return();
                    paintMaterialGridView.BeginDataUpdate();
                    LoadData();
                    paintMaterialGridView.EndDataUpdate();
                    int rowHandle = paintMaterialGridView.LocateByValue("Id", return_Id.Id);
                    paintMaterialGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOperationPaintMaterial(Utils.Operation.Add, new OperationPaintMaterialDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOperationPaintMaterial(Utils.Operation.Update, (OperationPaintMaterialDTO)operationPaintMaterialBS.Current);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить операцию?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                journalService = Program.kernel.Get<IJournalService>();

                paintMaterialGridView.BeginUpdate();
                if (journalService.OperationPaintMaterialDelete(((OperationPaintMaterialDTO)operationPaintMaterialBS.Current).Id))
                    LoadData();
                paintMaterialGridView.EndUpdate();
            }
        }
    }
}