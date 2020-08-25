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
    public partial class DetailFm : DevExpress.XtraEditors.XtraForm
    {
        public IJournalService journalService;
        public BindingSource detailsBS = new BindingSource();

        public DetailFm()
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            splashScreenManager.CloseWaitForm();
        }

        private void LoadData()
        {
            journalService = Program.kernel.Get<IJournalService>();
            var productions = journalService.GetDetails();
            detailsBS.DataSource = productions;
            detailsGrid.DataSource = detailsBS;
        }

        public void EditDetail(Utils.Operation operation, DetailsDTO detailsDTO)
        {
            using (DetailsEditFm detailsEditFm = new DetailsEditFm(operation, detailsDTO))
            {
                if (detailsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DetailsDTO return_Id = detailsEditFm.Return();
                    detailsGridView.BeginDataUpdate();
                    LoadData();
                    detailsGridView.EndDataUpdate();
                    int rowHandle = detailsGridView.LocateByValue("Id", return_Id.Id);
                    detailsGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void addDetailBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDetail(Utils.Operation.Add, new DetailsDTO());
        }

        private void editDetailbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDetail(Utils.Operation.Update, (DetailsDTO)detailsBS.Current);
        }

        private void deleteDetailBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить продукцию?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                journalService = Program.kernel.Get<IJournalService>();

                detailsGridView.BeginUpdate();
                if (journalService.DetailDelete(((DetailsDTO)detailsBS.Current).Id))
                    LoadData();
                detailsGridView.EndUpdate();
            }
        }
    }
}