using System.Windows.Forms;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.Drawings;

namespace TechnicalProcessControl
{
    public partial class DrawingsFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;

        public BindingSource drawingsBS = new BindingSource();

        

        public DrawingsFm()
        {
            InitializeComponent();

           

            LoadData();

            
        }

        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();

            splashScreenManager.ShowWaitForm();

            drawingsBS.DataSource = drawingService.GetAllDrawings();

            drawingGrid.DataSource = drawingsBS;


            //decreeTreeBS.DataSource = businessTripsService.GetBusinessTripsDecreeByPeriod(beginDate, endDate);
            drawingTreeListGrid.DataSource = drawingsBS;
            drawingTreeListGrid.KeyFieldName = "Id";
            drawingTreeListGrid.ParentFieldName = "ParentId";
            drawingTreeListGrid.ExpandAll();


            splashScreenManager.CloseWaitForm();
        }

        public void EditDrawing(Utils.Operation operation, DrawingsDTO userTelegramDTO)
        {
            using (DrawingsEditFm drawingsEditFm = new DrawingsEditFm(userTelegramDTO, operation))
            {
                if (drawingsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //UsersTelegramDTO return_Id = contractorsEditFm.Return();
                    drawingTreeListGrid.BeginUpdate();
                    LoadData();
                    drawingTreeListGrid.EndUpdate();
                    //int rowHandle = contractorsGridView.LocateByValue("Id", return_Id.Id);
                    //contractorsGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDrawing(Utils.Operation.Add, new DrawingsDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDrawing(Utils.Operation.Update, (DrawingsDTO)drawingsBS.Current);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить пользователя", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //botService = Program.kernel.Get<IBotService>();

                //contractorsGridView.BeginUpdate();

                //if (botService.TelegramUsersDelete(((UsersTelegramDTO)usersTelegramBS.Current).Id))
                //{
                //    LoadData();
                //}

                //contractorsGridView.EndUpdate();
            }
        }

        //private async void sendMessageBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{

            
        //}

        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void sendMessageBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void drawingTreeListGrid_CustomUnboundColumnData(object sender, DevExpress.XtraTreeList.TreeListCustomColumnDataEventArgs e)
        {
            
        }

        private void drawingTreeListGrid_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            var item = (DrawingsDTO)drawingTreeListGrid.GetDataRecordByNode(e.Node);

            if (item == null)
                return;
        
            e.Node.StateImageIndex = (item.ScanId == null) ? 0 : 1;
        }
    }
}