using System.Windows.Forms;
using Ninject;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl
{
    public partial class ProductionFm : DevExpress.XtraEditors.XtraForm
    {
        public IControlPanelService controlPanelService;
        public BindingSource productionBS = new BindingSource();

        public ProductionFm()
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            splashScreenManager.CloseWaitForm();
        }

        private void LoadData()
        {
            controlPanelService = Program.kernel.Get<IControlPanelService>();
            var productions = controlPanelService.GetProduction();
            productionBS.DataSource = productions;
            productionGrid.DataSource = productionBS;
        }

        public void EditProduction(Utils.Operation operation, ProductionDTO productionDTO)
        {
            using (ProductionEditFm productionEditFm = new ProductionEditFm(productionDTO, operation))
            {
                if (productionEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ProductionDTO return_Id = productionEditFm.Return();
                    productionGridView.BeginDataUpdate();
                    LoadData();
                    productionGridView.EndDataUpdate();
                    int rowHandle = productionGridView.LocateByValue("Id", return_Id.Id);
                    productionGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить продукцию?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controlPanelService = Program.kernel.Get<IControlPanelService>();

                productionGridView.BeginUpdate();

                if (controlPanelService.ProductionDelete(((ProductionDTO)productionBS.Current).Id))
                {
                    LoadData();
                }

                productionGridView.EndUpdate();
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditProduction(Utils.Operation.Add, new ProductionDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditProduction(Utils.Operation.Update, (ProductionDTO)productionBS.Current);
        }
    }
}