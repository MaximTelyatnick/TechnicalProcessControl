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
using TerminalMK.BLL.Interfaces;
using Ninject;
using TerminalMK.BLL.ModelsDTO;

namespace TerminalMKBot
{
    public partial class ShipmentRoadFm : DevExpress.XtraEditors.XtraForm
    {
        public static IBotService botService;

        public BindingSource routesBS = new BindingSource();
        public ShipmentRoadFm()
        {
            InitializeComponent();

            LoadData();
        }

        public void LoadData()
        {
            botService = Program.kernel.Get<IBotService>();

            routesBS.DataSource = botService.GetAllRoutes();

            shipmentRoadGrid.DataSource = routesBS;
        }


        public void EditRoute(Utils.Operation operation, RoutesDTO routesDTO)
        {
            using (ShipmentRoadEditFm shipmentRoadEditFm  = new ShipmentRoadEditFm(routesDTO, operation))
            {
                if (shipmentRoadEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    RoutesDTO return_Id = shipmentRoadEditFm.Return();
                    shipmentRoadGridView.BeginDataUpdate();
                    LoadData();
                    shipmentRoadGridView.EndDataUpdate();
                    int rowHandle = shipmentRoadGridView.LocateByValue("Id", return_Id.Id);
                    shipmentRoadGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditRoute(Utils.Operation.Add, new RoutesDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditRoute(Utils.Operation.Update, (RoutesDTO)routesBS.Current);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить маршрут", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                botService = Program.kernel.Get<IBotService>();

                shipmentRoadGridView.BeginUpdate();

                if (botService.RouteDelete(((RoutesDTO)routesBS.Current).Id))
                {
                    LoadData();
                }

                shipmentRoadGridView.EndUpdate();
            }
        }

        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}