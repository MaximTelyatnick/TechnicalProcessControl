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

        private void addMaterialBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}