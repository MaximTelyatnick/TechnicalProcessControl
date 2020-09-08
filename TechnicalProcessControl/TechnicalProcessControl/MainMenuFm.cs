using System;
using System.ComponentModel;
using System.Windows.Forms;
using Ninject;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System.Timers;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.Journals;
using TechnicalProcessControl.Drawings;

namespace TechnicalProcessControl
{
    public partial class MainMenuFm : DevExpress.XtraEditors.XtraForm
    {
        private IControlPanelService controlPanelService;
        private BackgroundWorker messageWorker = new BackgroundWorker();


        private int telegramApiId = 1090023;
        private string telegramApiHash = "3651d2c505bed6f082a7314219c848f6";
        private string userPhone;
        private string userCode;
        private string hash;
        bool isValidate;
        private System.Timers.Timer messageCheckTimer;

        public MainMenuFm()
        {
            InitializeComponent();

            //messageWorker = new BackgroundWorker();

            //messageWorker.DoWork += messageWorker_DoWork;

            //controlPanelService = Program.kernel.Get<IControlPanelService>();
            documentManager.MdiParent = this;
            documentManager.View = new TabbedView();


            //telegram user auth


            //CreateTimer(1000);
        }

        public void CreateTimer(int seconds)
        {
            if (messageCheckTimer == null)
            {
                messageCheckTimer = new System.Timers.Timer();
                messageCheckTimer.AutoReset = false; // Чтобы операции удаления не перекрывались
                messageCheckTimer.Interval = 1000;
                //messageCheckTimer.Elapsed += OnTimedEvent;
                messageCheckTimer.Enabled = true;

                messageCheckTimer.Start();
            }
        }

        //public async void OnTimedEvent(Object source, ElapsedEventArgs e)
        //{
        //    messageCheckTimer.Stop();

        //    controlPanelService = Program.kernel.Get<IControlPanelService>();

        //    try
        //    {

        //        if (controlPanelService.CheckMessages())
        //            msgBtn.Glyph = imageCollection.Images[1];
        //        else
        //            msgBtn.Glyph = imageCollection.Images[0];

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ошибка" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        throw;
        //    }

        //    messageCheckTimer.Start();

        //}

        private void contractorBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            StructuraFm contractorsFm = new StructuraFm();
            contractorsFm.Text = "Структура";
            contractorsFm.MdiParent = this;
            contractorsFm.Show();
        }

        private void productionBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ProductionFm productionFm = new ProductionFm();
            productionFm.Text = "Продукция";
            productionFm.MdiParent = this;
            productionFm.Show();
        }

        private void navButton2_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            //TestFm testFm = new TestFm();
            //testFm.Text = "Тестовая форма";
            //testFm.MdiParent = this;
            //testFm.Show();
        }

        void messageWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void shipmentRoadBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ShipmentRoadFm shipmentRoadFm = new ShipmentRoadFm();
            shipmentRoadFm.Text = "Маршруты";
            shipmentRoadFm.MdiParent = this;
            shipmentRoadFm.Show();
        }

        private void msgBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {


        }

        private void MainMenuFm_Load(object sender, EventArgs e)
        {
            //await client.ConnectAsync();


        }

        private void menuNavPane_TileClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
        
            string path = Utils.HomePath;

            switch (e.Element.Name)
            {
                case "materialItem":
                    MaterialFm materialFm = new MaterialFm();
                    materialFm.Text = "Материалы";
                    materialFm.MdiParent = this;
                    materialFm.Show();
                    break;
                case "detailItem":
                    DetailFm detailFm = new DetailFm();
                    detailFm.Text = "Детали";
                    detailFm.MdiParent = this;
                    detailFm.Show();
                    break;
                case "drawingItem":
                    DrawingFm drawingFm = new DrawingFm();
                    drawingFm.Text = "Чертежи";
                    drawingFm.MdiParent = this;
                    drawingFm.Show();
                    break;
                case "operationNameItem":
                    OperationNameFm operationNameFm = new OperationNameFm();
                    operationNameFm.Text = "Наименование операций";
                    operationNameFm.MdiParent = this;
                    operationNameFm.Show();
                    break;



            }
        }

        
    }
}