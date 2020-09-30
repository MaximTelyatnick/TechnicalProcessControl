using System.Windows.Forms;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.Drawings;
using TechnicalProcessControl.BLL.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System;
using System.Drawing;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using System.Collections.Generic;

namespace TechnicalProcessControl
{
    public partial class StructuraFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;

        private UsersDTO usersDTO;
        private List<DrawingsDTO> drawingsList = new List<DrawingsDTO>();

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

        private void UserAcces()
        {
            switch (usersDTO.RoleId)
            {
                case 1:
                    //админ

                    break;
                case 2:
                    //технолог


                    break;
                case 3:
                    //конструктор

                    break;
                default:
                    break;
            }


        }


        public StructuraFm(UsersDTO usersDTO)
        {
            InitializeComponent();

            this.usersDTO = usersDTO;

            LoadData(); 
        }

        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();

            splashScreenManager.ShowWaitForm();

            this.drawingsList = drawingService.GetAllDrawings().OrderBy(bdsm => Convert.ToInt32(bdsm.CurrentLevelMenu.Split('.').Last())).ToList();

            drawingsBS.DataSource = drawingsList;

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
            using (StructuraEditFm drawingsEditFm = new StructuraEditFm(usersDTO,userTelegramDTO, operation))
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
                else
                {
                    drawingTreeListGrid.BeginUpdate();
                    LoadData();
                    drawingTreeListGrid.EndUpdate();
                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDrawing(Utils.Operation.Add, new DrawingsDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckStructura())
                return;

            EditDrawing(Utils.Operation.Update, (DrawingsDTO)drawingsBS.Current);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckStructura())
                return;

            if (MessageBox.Show("Удалить элемент структури?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                drawingService = Program.kernel.Get<IDrawingService>();

                drawingTreeListGrid.BeginUpdate();

                if (drawingService.DrawingsDelete(((DrawingsDTO)drawingsBS.Current).Id))
                {
                    LoadData();
                }

                drawingTreeListGrid.EndUpdate();
            }
        }

        //private async void sendMessageBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{

            
        //}

        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
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
            TechProcess001DTO addTechProcessDTO = new TechProcess001DTO();
            addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
            addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
            addTechProcessDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;
            addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;

            using (TechProcess001EditFm techProcess001EditFm = new TechProcess001EditFm(usersDTO,Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
            {
                if (techProcess001EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //techProcess001Edit.Properties.DataSource = drawingService.GetAllTechProcess001();
                    int return_Id = techProcess001EditFm.Return().Id;
                    LoadData();
                    //techProcess001Edit.EditValue = return_Id;
                }
            }
            





            //if (((DrawingsDTO)drawingsBS.Current).TechProcess001Id == null)
            //{
            //    TechProcess001DTO techProcess001DTO = new TechProcess001DTO();
            //    techProcess001DTO.TechProcessName = drawingService.GetLastTechProcess001();
            //    techProcess001DTO.TechProcessPath = @"C:\TechProcess\" + techProcess001DTO.TechProcessName.ToString() + ".xls";

            //    var createTechProcess = drawingService.TechProcess001Create(techProcess001DTO);

            //    if (createTechProcess>0)
            //    {
            //        ((DrawingsDTO)Item).TechProcess001Id = createTechProcess;
            //        ((DrawingsDTO)Item).TechProcess001Path = techProcess001DTO.TechProcessPath;
            //        ((DrawingsDTO)Item).TechProcess001Name = techProcess001DTO.TechProcessName;

            //        drawingService.DrawingsUpdate(((DrawingsDTO)Item));
            //        reportService.CreateTemplateTechProcess001(((DrawingsDTO)Item));
            //        LoadData();
                    
            //    }
            //    else
            //    {
            //        MessageBox.Show("При формировании щаблона техпроцесса возникла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    Process process = new Process();
            //    process.StartInfo.Arguments = "\"" + ((DrawingsDTO)drawingsBS.Current).TechProcess001Path + "\"";
            //    process.StartInfo.FileName = "Excel.exe";
            //    process.Start();
            //}
        }

        private void techProcess001Repository_DoubleClick(object sender, System.EventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).TechProcess001Id != null)
            {
                reportService.OpenExcelFile(((DrawingsDTO)drawingsBS.Current).TechProcess001Path);
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
                using (TestFm testFm = new TestFm(((DrawingsDTO)drawingsBS.Current).TechProcess003Path))
                {
                    if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                    }
                }
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

        private bool CheckStructura()
        {
            if (((DrawingsDTO)drawingsBS.Current).StructuraDisable)
            {
                MessageBox.Show("Структура искллючена из проекта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void replaceDrawingBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckStructura())
                return;
            if (((DrawingsDTO)drawingsBS.Current).DrawingId != null)
            {
                using (DrawingReplaceFm drawingReplaceFm = new DrawingReplaceFm((DrawingsDTO)drawingsBS.Current))
                {
                    if (drawingReplaceFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        drawingTreeListGrid.BeginUpdate();
                        LoadData();
                        drawingTreeListGrid.EndUpdate();
                    }
                    else
                    {
                        drawingTreeListGrid.BeginUpdate();
                        LoadData();
                        drawingTreeListGrid.EndUpdate();
                    }
                }
            }
            else
            {
                MessageBox.Show("Структура не имеет прикрепленного чертежа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addCurrentStructuraBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckStructura())
                return;
            DrawingsDTO addDrawingsDTO = new DrawingsDTO()
            {
                ParentId = ((DrawingsDTO)drawingsBS.Current).Id
            };

            EditDrawing(Utils.Operation.Add, addDrawingsDTO);
        }

        private void drawingTreeListGrid_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            //TreeView view = (TreeView)sender;
            //bool checkErledigt = Convert.ToBoolean(view.GetNodeAt(e.Node, "A"));
            //if (checkErledigt)
            //    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
            //else
            //    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);

            //if (e.Column.FieldName != "Budget") return;

            var item = (DrawingsDTO)drawingTreeListGrid.GetDataRecordByNode(e.Node);

            if (item == null)
                return;


            if (item.StructuraDisable)
            {
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                e.Appearance.BackColor = Color.Gainsboro;
                //e.Appearance.ForeColor = Color.White;
                e.Appearance.FontStyleDelta = FontStyle.Bold;
            }
            else
            {
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
            }



            //if (Convert.ToBoolean(e.Node.GetValue(e.Column.FieldName == "StructuraDisable")))
            //{
            //    e.Appearance.BackColor = Color.FromArgb(80, 255, 0, 255);
            //    e.Appearance.ForeColor = Color.White;
            //    e.Appearance.FontStyleDelta = FontStyle.Bold;
            //}


            //if ((bool)e.Node["StructuraDisable"])
            //{
            //    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
            //}
            //else
            //{
            //    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
            //}

        }

        private void disableBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int rootIndex = drawingTreeListGrid.Nodes.IndexOf(drawingTreeListGrid.FocusedNode);
            //foreach (TreeNode tn in drawingTreeListGrid.Nodes[rootIndex].Nodes)
            //{
            //    MessageBox.Show(tn.Index.ToString(), "Нода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //foreach (TreeListNode node in e.Node.Nodes)
            //{
            //    node.CheckState = e.Node.CheckState;
            //}
            //foreach (TreeListNode node in drawingTreeListGrid..Node.Nodes)
            //    node.CheckState = e.Node.CheckState;


            allNodes(((DrawingsDTO)Item).Id);

            //var childList = drawingTreeListGrid.Nodes.Where(p => p.ParentNode.Id == currentNode.Id).ToList();

            //var childListt =  drawingTreeListGrid.Nodes.ParentNode.GetValue(drawingTreeListGrid.["Id"]);
            //drawingService = Program.kernel.Get<IDrawingService>();

            //if (((DrawingsDTO)Item).StructuraDisable)
            //{
            //    ((DrawingsDTO)Item).StructuraDisable = false;
            //    drawingService.DrawingsUpdate(((DrawingsDTO)Item));
            //    LoadData();
            //}
            //else
            //{
            //    ((DrawingsDTO)Item).StructuraDisable = true;
            //    drawingService.DrawingsUpdate(((DrawingsDTO)Item));
            //    LoadData();
            //}
        }


        public List<DrawingsDTO> GetAllCheldrenByNode()
        {
            

            return null;
        }


        public void allNodes(int id)
        {

            MessageBox.Show(id.ToString(), "айди", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var parent = drawingsList.Where(bdsm => bdsm.ParentId == id);
            foreach (var item in parent)
                allNodes(item.Id);

        }


        public void CopyNodesOperation(TreeList destTreeList)
        {
            if (destTreeList == null)
                throw new ArgumentNullException("destTreeList");
            this.drawingTreeListGrid = destTreeList;
        }

        public void ExecuteNode(TreeListNode node)
        {
            CopyNode(node, drawingTreeListGrid);
        }

        public static void CopyNode(TreeListNode node, TreeList destTreeList)
        {
            object[] values = new object[node.TreeList.Columns.Count];

            for (int i = 0; i < node.TreeList.Columns.Count; i++)
                values[i] = node.GetValue(i);
            TreeListNode newnode = null;
            if (node.ParentNode != null)
                newnode = destTreeList.AppendNode(values, node.ParentNode.Id);
            else
                newnode = destTreeList.AppendNode(values, null);
            newnode.Tag = node.Tag;
        }
    }
}