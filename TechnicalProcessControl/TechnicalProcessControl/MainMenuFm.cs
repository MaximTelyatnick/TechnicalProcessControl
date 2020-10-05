using System;
using System.ComponentModel;
using System.Windows.Forms;
using Ninject;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System.Timers;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.Journals;
using TechnicalProcessControl.Drawings;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl;
using TechnicalProcessControl.TechnicalProcess;

namespace TechnicalProcessControl
{
    public partial class MainMenuFm : DevExpress.XtraEditors.XtraForm
    {
        private UsersDTO usersDTO;

        public MainMenuFm(UsersDTO usersDTO)
        {
            InitializeComponent();

            //messageWorker = new BackgroundWorker();

            //messageWorker.DoWork += messageWorker_DoWork;

            //controlPanelService = Program.kernel.Get<IControlPanelService>();
            this.usersDTO = usersDTO;
            documentManager.MdiParent = this;
            documentManager.View = new TabbedView();
            userBtn.Caption = usersDTO.Name;


            //telegram user auth


            //CreateTimer(1000);
        }

        public void CreateTimer(int seconds)
        {
           
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
            StructuraFm contractorsFm = new StructuraFm(usersDTO);
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
            TestExcel testFm = new TestExcel();
            testFm.Text = "Тестовая форма";
            testFm.MdiParent = this;
            testFm.Show();
        }

        void messageWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void shipmentRoadBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
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
                    DrawingFm drawingFm = new DrawingFm(usersDTO);
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
                case "TechProcess001Item":
                    TechProcess001Fm techprocess001Fm = new TechProcess001Fm(usersDTO);
                    techprocess001Fm.Text = "Техпроцессы ";
                    techprocess001Fm.MdiParent = this;
                    techprocess001Fm.Show();
                    break;
                case "operationNumberItem":
                    OperationNumberFm operationNumberFm = new OperationNumberFm();
                    operationNumberFm.Show();
                    break;
                case "operationPaintMaterial":
                    OperationPaintMaterialFm operationPaintMaterialFm = new OperationPaintMaterialFm();
                    operationPaintMaterialFm.Show();
                    break;

                    //case "operationNameItem":
                    //    OperationNameFm operationNameFm = new OperationNameFm();
                    //    operationNameFm.Text = "Наименование операций";
                    //    operationNameFm.MdiParent = this;
                    //    operationNameFm.Show();
                    //    break;
                    //case "operationNameItem":
                    //    OperationNameFm operationNameFm = new OperationNameFm();
                    //    operationNameFm.Text = "Наименование операций";
                    //    operationNameFm.MdiParent = this;
                    //    operationNameFm.Show();
                    //    break;
                    //case "operationNameItem":
                    //    OperationNameFm operationNameFm = new OperationNameFm();
                    //    operationNameFm.Text = "Наименование операций";
                    //    operationNameFm.MdiParent = this;
                    //    operationNameFm.Show();
                    //    break;
                    //case "operationNameItem":
                    //    OperationNameFm operationNameFm = new OperationNameFm();
                    //    operationNameFm.Text = "Наименование операций";
                    //    operationNameFm.MdiParent = this;
                    //    operationNameFm.Show();
                    //    break;






            }
        }

        
    }
}