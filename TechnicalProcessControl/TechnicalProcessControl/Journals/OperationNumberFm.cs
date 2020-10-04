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
    public partial class OperationNumberFm : DevExpress.XtraEditors.XtraForm
    {
        public IJournalService journalService;
        public BindingSource operationNumberBS = new BindingSource();

        public OperationNumberFm()
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            splashScreenManager.CloseWaitForm();
        }
        
        private void LoadData()
        {
            journalService = Program.kernel.Get<IJournalService>();
            var operationNumber = journalService.GetOperationNumber();
            operationNumberBS.DataSource = operationNumber;
            operationNumberGrid.DataSource = operationNumberBS;
        }

        public void EditOperationNumber(Utils.Operation operation, OperationNumberDTO operationNumberDTO)
        {
            using (OperationNumberEditFm operationNumberEditFm = new OperationNumberEditFm(operation, operationNumberDTO))
            {
                if (operationNumberEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    OperationNumberDTO return_Id = operationNumberEditFm.Return();
                    operationNumberGridView.BeginDataUpdate();
                    LoadData();
                    operationNumberGridView.EndDataUpdate();
                    int rowHandle = operationNumberGridView.LocateByValue("Id", return_Id.Id);
                    operationNumberGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOperationNumber(Utils.Operation.Add, new OperationNumberDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOperationNumber(Utils.Operation.Update, (OperationNumberDTO)operationNumberBS.Current);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить номер операции?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                journalService = Program.kernel.Get<IJournalService>();

                operationNumberGridView.BeginUpdate();
                if (journalService.OperationNumberDelete(((OperationNumberDTO)operationNumberBS.Current).Id))
                    LoadData();
                operationNumberGridView.EndUpdate();
            }
        }
    }
}