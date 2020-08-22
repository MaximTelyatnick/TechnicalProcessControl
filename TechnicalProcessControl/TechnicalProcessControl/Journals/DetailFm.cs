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
            var productions = journalService.GetMaterials();
            detailsBS.DataSource = productions;
            detailsGrid.DataSource = detailsBS;
        }
    }
}