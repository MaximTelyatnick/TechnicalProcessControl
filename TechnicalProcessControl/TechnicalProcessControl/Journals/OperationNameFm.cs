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
    public partial class OperationNameFm : DevExpress.XtraEditors.XtraForm
    {
        public IJournalService journalService;
        public BindingSource operationNameBS = new BindingSource();

        public OperationNameFm()
        {
            InitializeComponent();



            splashScreenManager.ShowWaitForm();

            LoadData();

            splashScreenManager.CloseWaitForm();
        }

        private void LoadData()
        {
            journalService = Program.kernel.Get<IJournalService>();
            var operationName = journalService.GetOperationName();
            operationNameBS.DataSource = operationName;
            operationGrid.DataSource = operationNameBS;
        }

        public void EditOperationName(Utils.Operation operation, OperationNameDTO operationNameDTO)
        {
            using (OperationNameEditFm operationNameEditFm = new OperationNameEditFm(operation, operationNameDTO))
            {
                if (operationNameEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    OperationNameDTO return_Id = operationNameEditFm.Return();
                    operationGridView.BeginDataUpdate();
                    LoadData();
                    operationGridView.EndDataUpdate();
                    int rowHandle = operationGridView.LocateByValue("Id", return_Id.Id);
                    operationGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOperationName(Utils.Operation.Add, new OperationNameDTO());

        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOperationName(Utils.Operation.Update, ((OperationNameDTO)operationNameBS.Current));

        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить операцию?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                journalService = Program.kernel.Get<IJournalService>();

                operationGridView.BeginUpdate();
                if (journalService.OperationNameDelete(((OperationNameDTO)operationNameBS.Current).Id))
                    LoadData();
                operationGridView.EndUpdate();
            }
        }
    }
}