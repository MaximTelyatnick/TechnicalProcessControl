using System.Windows.Forms;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;


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

        public void EditUserTelegram(Utils.Operation operation, UsersTelegramDTO userTelegramDTO)
        {
            using (ContractorsEditFm contractorsEditFm = new ContractorsEditFm(userTelegramDTO, operation))
            {
                if (contractorsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    UsersTelegramDTO return_Id = contractorsEditFm.Return();
                    //contractorsGridView.BeginDataUpdate();
                    //LoadData();
                    //contractorsGridView.EndDataUpdate();
                    //int rowHandle = contractorsGridView.LocateByValue("Id", return_Id.Id);
                    //contractorsGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditUserTelegram(Utils.Operation.Add, new UsersTelegramDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //EditUserTelegram(Utils.Operation.Update, (UsersTelegramDTO)usersTelegramBS.Current);
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
    }
}