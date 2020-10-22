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
        private List<DrawingsDTO> bifferdrawingsList = new List<DrawingsDTO>();

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

            drawingsList = drawingService.GetAllDrawings().OrderBy(bdsm => Convert.ToInt32(bdsm.CurrentLevelMenu.Split('.').Last())).ToList();
            //this.drawingsList = drawingService.GetAllDrawings().ToList();
            drawingsBS.DataSource = drawingsList;
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

                if (drawingService.DrawingsDelete(((DrawingsDTO)drawingsBS.Current).Id))
                {
                    drawingTreeListGrid.BeginUpdate();
                    LoadData();
                    drawingTreeListGrid.EndUpdate();
                }
            }
        }


        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            drawingTreeListGrid.BeginUpdate();
            LoadData();
            drawingTreeListGrid.EndUpdate();
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

        //private void repositoryItemPictureEdit1_DoubleClick(object sender, System.EventArgs e)
        //{
        //    if (((DrawingsDTO)drawingsBS.Current).ScanId != null)
        //    {
        //        //DrawingScanDTO model = drawingService.GetDravingScanById(((DrawingsDTO)drawingsBS.Current).Id);

        //        //string path = Utils.HomePath + @"\Temp";

        //        //System.IO.File.WriteAllBytes(path + model.FileName, model.Scan);

        //        //System.Diagnostics.Process.Start(path + model.FileName);
        //    }
        //}

        #region TechProcess openfiles method's

        private void techProcess001Repository_DoubleClick(object sender, System.EventArgs e)
        {
            
        }

        private void techProcess002Repository_DoubleClick(object sender, System.EventArgs e)
        {if (((DrawingsDTO)drawingsBS.Current).TechProcess001Id != null)
            {
                reportService.OpenExcelFile(((DrawingsDTO)drawingsBS.Current).TechProcess001Path);
            }
            if (((DrawingsDTO)drawingsBS.Current).TechProcess002Id != null)
            {
                reportService.OpenExcelFile(((DrawingsDTO)drawingsBS.Current).TechProcess002Path);
            }
        }

        private void techProcess003Repository_DoubleClick(object sender, System.EventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).TechProcess003Id != null)
            {
                reportService.OpenExcelFile(((DrawingsDTO)drawingsBS.Current).TechProcess003Path);
            }
        }

        private void techProcess004Repository_DoubleClick(object sender, System.EventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).TechProcess004Id != null)
            {
                reportService.OpenExcelFile(((DrawingsDTO)drawingsBS.Current).TechProcess004Path);
            }
        }

        private void techProcess005Repository_DoubleClick(object sender, System.EventArgs e)
        {
            if (((DrawingsDTO)drawingsBS.Current).TechProcess005Id != null)
            {
                reportService.OpenExcelFile(((DrawingsDTO)drawingsBS.Current).TechProcess005Path);
            }
        }

        #endregion




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

            if (item.TechProcess001Id!=null && e.Column.FieldName == "TechProcess001Name")
            {
                switch (item.TechProcess001Type)
                {
                    case 1:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Yellow;

                        break;
                    case 2:

                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Gray;
                        break;
                    case 3:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Green;
                        break;
                    case 4:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Red;
                        break;

                    default:
                        break;
                }
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

            //allNodes(((DrawingsDTO)Item).Id);

            drawingTreeListGrid.BeginUpdate();

            if (((DrawingsDTO)Item).StructuraDisable)
            {
                bifferdrawingsList.Clear();
                GetAllNodes(((DrawingsDTO)Item));
                NodesDisableValueUpdate(bifferdrawingsList, false);
                LoadData();
            }
            else
            {
                bifferdrawingsList.Clear();
                GetAllNodes(((DrawingsDTO)Item));
                NodesDisableValueUpdate(bifferdrawingsList, true);
                LoadData();
            }

            drawingTreeListGrid.EndUpdate();
        }


        public void GetAllNodes(DrawingsDTO drawings)
        {
            bifferdrawingsList.Add(drawings);
            var parent = drawingsList.Where(bdsm => bdsm.ParentId == drawings.Id);
            foreach (var item in parent)
                GetAllNodes(item);
        }

        public void PasteAllNodes(DrawingsDTO targetDrawings,DrawingsDTO pasteDrawings, List<DrawingsDTO> parentPasteDrawingsList)
        {

            drawingService = Program.kernel.Get<IDrawingService>();
            string rootLevelMenu = drawingService.GetMaxStructuraNumber(targetDrawings.Id);
            pasteDrawings.CurrentLevelMenu = rootLevelMenu;
            pasteDrawings.ParentId = targetDrawings.Id;
            pasteDrawings.Id = drawingService.DrawingsCreate(pasteDrawings);

            foreach (var item in parentPasteDrawingsList)
            {
                parentPasteDrawingsList = bifferdrawingsList.Where(bdsm => bdsm.ParentId == item.Id).ToList();
                PasteAllNodes(pasteDrawings,item, parentPasteDrawingsList);
            }
        }

        public void PasteNode(DrawingsDTO targetDrawings, DrawingsDTO pasteDrawings)
        {
            //drawingService = Program.kernel.Get<IDrawingService>();
            //string rootLevelMenu = drawingService.GetMaxStructuraNumber(targetDrawings.Id);

            //foreach (var item in pasteDrawingsList)
            //{

            //}
        }


        public void NodesDisableValueUpdate(List<DrawingsDTO> updateDrawings, bool disableValue)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            splashScreenManager.ShowWaitForm();

            foreach (var item in updateDrawings)
            {
                item.StructuraDisable = disableValue;
                drawingService.DrawingsUpdate(item);

            }

            splashScreenManager.CloseWaitForm();
        }


        
        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            bifferdrawingsList.Clear();
            GetAllNodes(((DrawingsDTO)Item));
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            if (bifferdrawingsList.Count() > 0)
            {
                splashScreenManager.ShowWaitForm();

                drawingTreeListGrid.BeginUpdate();

                DrawingsDTO pasteDrawings = bifferdrawingsList.First();

                List<DrawingsDTO> parentPasteDrawingsList = bifferdrawingsList.Where(bdsm => bdsm.ParentId == pasteDrawings.Id).ToList();
                try
                {
                    PasteAllNodes(((DrawingsDTO)Item), pasteDrawings, parentPasteDrawingsList);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("При вставке сборки возникла ошибка, необходимо перепроверить данные!", "Ошибка вставки сборки", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    splashScreenManager.CloseWaitForm();
                    LoadData();
                    drawingTreeListGrid.EndUpdate();

                    return;
                }
               
                splashScreenManager.CloseWaitForm();

                CheckHardTechProcess((DrawingsDTO)Item);
                CheckEasyTechProcess(pasteDrawings);

                LoadData();

                drawingTreeListGrid.EndUpdate();
            }
            else
            {
                MessageBox.Show("Отсутствуют скопированные сборки!", "Ошибка вставки сборки", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckHardTechProcess(DrawingsDTO drawingsDTO)
        {
            if(drawingsDTO.TechProcess003Id!=null)
                MessageBox.Show("Необходимо изменение техпроцесса "+ drawingsDTO.TechProcess003Name + "!", "Предпреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (drawingsDTO.TechProcess004Id != null)
                MessageBox.Show("Необходимо изменение техпроцесса " + drawingsDTO.TechProcess004Name + "!", "Предпреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CheckEasyTechProcess(DrawingsDTO drawingsDTO)
        {
            if (drawingsDTO.TechProcess001Id != null)
                MessageBox.Show("Необходимо изменение техпроцесса " + drawingsDTO.TechProcess001Name + "!", "Предпреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (drawingsDTO.TechProcess002Id != null)
                MessageBox.Show("Необходимо изменение техпроцесса " + drawingsDTO.TechProcess002Name + "!", "Предпреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (drawingsDTO.TechProcess005Id != null)
                MessageBox.Show("Необходимо изменение техпроцесса " + drawingsDTO.TechProcess005Name + "!", "Предпреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void удалитьСборкуToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void showTechProcessBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (techProcessBand.Visible == true)
            {
                techProcessBand.Visible = false;
                showTechProcessBtn.ImageOptions.Image = imageCollection.Images[2];
                showTechProcessBtn.Caption = "Отобразить техпроцессы";
            }
            else
            {
                techProcessBand.Visible = true;
                showTechProcessBtn.ImageOptions.Image = imageCollection.Images[3];
                showTechProcessBtn.Caption = "Не отображать техпроцессы";
            }
        }
    }
}