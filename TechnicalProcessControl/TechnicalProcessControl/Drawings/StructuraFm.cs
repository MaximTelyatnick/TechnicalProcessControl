using System.Windows.Forms;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.Drawings;
using TechnicalProcessControl.BLL.Infrastructure;
using System.Diagnostics;

namespace TechnicalProcessControl
{
    public partial class StructuraFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;

        public BindingSource drawingsBS = new BindingSource();

        private ObjectBase Item
        {
            get { return drawingsBS.Current as ObjectBase; }
            set
            {
                drawingsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public StructuraFm()
        {
            InitializeComponent();
            LoadData(); 
        }

        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();

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
            using (StructuraEditFm drawingsEditFm = new StructuraEditFm(userTelegramDTO, operation))
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
            if (MessageBox.Show("Удалить элемент структури?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                drawingService = Program.kernel.Get<IDrawingService>();

                drawingTreeListGrid.BeginUpdate();

                if (drawingService.DrawingsDelete(((DrawingsDTO)drawingsBS.Current).Id))
                {
                    LoadData();
                }

                drawingTreeListGrid.EndUpdate();

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
            var item = (DrawingsDTO)drawingTreeListGrid.GetDataRecordByNode(e.Node);

            if (item == null)
                return;

            if (item.ScanId != 0)
                e.Value = imageCollection.Images[0];
            else
                e.Value = imageCollection.Images[1];
        }

        private void drawingTreeListGrid_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            var item = (DrawingsDTO)drawingTreeListGrid.GetDataRecordByNode(e.Node);

            if (item == null)
                return;
        
            e.Node.StateImageIndex = (item.ScanId == null) ? 0 : 1;

            //if (agreementOrdersBS.Count > 1)
            //{
            //    AgreementOrderJournalDTO item = (AgreementOrderJournalDTO)agreementOrdersBS[e.ListSourceRowIndex];

            //    if (e.Column == scanCol && e.IsGetData)
            //    {
            //        if (item.AgreementOrderScanId != null)
            //            e.Value = imageCollection.Images[0];
            //        else
            //            e.Value = imageCollection.Images[1];
            //    }
            //}

        }

        private void drawingTreeListGrid_DoubleClick(object sender, System.EventArgs e)
        {

        }

        private void repositoryItemPictureEdit1_DoubleClick(object sender, System.EventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).ScanId != null)
            {
                //DrawingScanDTO model = drawingService.GetDravingScanById(((DrawingsDTO)drawingsBS.Current).Id);

                //string path = Utils.HomePath + @"\Temp";

                //System.IO.File.WriteAllBytes(path + model.FileName, model.Scan);

                //System.Diagnostics.Process.Start(path + model.FileName);
            }
        }

        private void addTechProcess001Btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(((DrawingsDTO)drawingsBS.Current).TechProcess001Id == null)
            {
                TechProcess001DTO techProcess001DTO = new TechProcess001DTO();
                techProcess001DTO.TechProcessName = drawingService.GetLastTechProcess001();
                techProcess001DTO.TechProcessPath = @"C:\TechProcess\" + techProcess001DTO.TechProcessName.ToString() + ".xls";

                var createTechProcess = drawingService.TechProcess001Create(techProcess001DTO);

                if (createTechProcess>0)
                {
                    ((DrawingsDTO)Item).TechProcess001Id = createTechProcess;
                    ((DrawingsDTO)Item).TechProcess001Path = techProcess001DTO.TechProcessPath;
                    ((DrawingsDTO)Item).TechProcess001Name = techProcess001DTO.TechProcessName;

                    drawingService.DrawingsUpdate(((DrawingsDTO)Item));
                    reportService.CreateTemplateTechProcess001(((DrawingsDTO)Item));
                    LoadData();
                    
                }
                else
                {
                    MessageBox.Show("При формировании щаблона техпроцесса возникла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Process process = new Process();
                process.StartInfo.Arguments = "\"" + ((DrawingsDTO)drawingsBS.Current).TechProcess001Path + "\"";
                process.StartInfo.FileName = "Excel.exe";
                process.Start();
            }
        }

        private void techProcess001Repository_DoubleClick(object sender, System.EventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).TechProcess001Id != null)
            {
                using (TestFm testFm = new TestFm(((DrawingsDTO)drawingsBS.Current).TechProcess001Path))
                {
                    if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //////detailsBS.DataSource = journalService.GetDetails();
                        //techProcess001Edit.Properties.DataSource = drawingService.GetAllTechProcess001();
                        //techProcess001Edit.Properties.ValueMember = "Id";
                        //techProcess001Edit.Properties.DisplayMember = "TechProcessFullName";
                        //techProcess001Edit.Properties.NullText = "Нету записей";

                        //int return_Id = techProcess001EditFm.Return().Id;
                        //techProcess001Edit.EditValue = return_Id;



                    }
                }
            }
        }

        private void techProcess002Repository_DoubleClick(object sender, System.EventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).TechProcess002Id != null)
            {
                Process process = new Process();
                process.StartInfo.Arguments = "\"" + ((DrawingsDTO)drawingsBS.Current).TechProcess002Path + "\"";
                process.StartInfo.FileName = "Excel.exe";
                process.Start();
            }
        }

        private void techProcess003Repository_DoubleClick(object sender, System.EventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).TechProcess003Id != null)
            {
                Process process = new Process();
                process.StartInfo.Arguments = "\"" + ((DrawingsDTO)drawingsBS.Current).TechProcess003Path + "\"";
                process.StartInfo.FileName = "Excel.exe";
                process.Start();
            }
        }

        private void techProcess004Repository_DoubleClick(object sender, System.EventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).TechProcess004Id != null)
            {
                Process process = new Process();
                process.StartInfo.Arguments = "\"" + ((DrawingsDTO)drawingsBS.Current).TechProcess004Path + "\"";
                process.StartInfo.FileName = "Excel.exe";
                process.Start();
            }
        }

        private void techProcess005Repository_DoubleClick(object sender, System.EventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).TechProcess005Id != null)
            {
                Process process = new Process();
                process.StartInfo.Arguments = "\"" + ((DrawingsDTO)drawingsBS.Current).TechProcess005Path + "\"";
                process.StartInfo.FileName = "Excel.exe";
                process.Start();
            }
        }

        private void addTechProcess002Btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).TechProcess002Id == null)
            {
                TechProcess002DTO techProcess002DTO = new TechProcess002DTO();
                techProcess002DTO.TechProcessName = drawingService.GetLastTechProcess002();
                techProcess002DTO.TechProcessPath = @"C:\TechProcess\" + techProcess002DTO.TechProcessName.ToString() + ".xls";

                var createTechProcess = drawingService.TechProcess002Create(techProcess002DTO);

                if (createTechProcess > 0)
                {
                    ((DrawingsDTO)Item).TechProcess002Id = createTechProcess;
                    ((DrawingsDTO)Item).TechProcess002Path = techProcess002DTO.TechProcessPath;
                    ((DrawingsDTO)Item).TechProcess002Name = techProcess002DTO.TechProcessName;

                    drawingService.DrawingsUpdate(((DrawingsDTO)Item));
                    reportService.CreateTemplateTechProcess002(((DrawingsDTO)Item));
                    LoadData();

                }
                else
                {
                    MessageBox.Show("При формировании щаблона техпроцесса возникла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                Process process = new Process();
                process.StartInfo.Arguments = "\"" + ((DrawingsDTO)drawingsBS.Current).TechProcess002Path + "\"";
                process.StartInfo.FileName = "Excel.exe";
                process.Start();
            }
        }
    }
}