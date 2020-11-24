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
using TechnicalProcessControl.CustomView;

namespace TechnicalProcessControl
{
    public partial class StructuraFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IJournalService journalService;
        public static IReportService reportService;

        private UsersDTO usersDTO;
        private List<DrawingsDTO> drawingsList = new List<DrawingsDTO>();
        private List<DrawingsDTO> bifferdrawingsList = new List<DrawingsDTO>();
        private List<ColorsDTO> colorsPalleteStructura = new List<ColorsDTO>();
        private List<ColorsDTO> colorsPalleteDrawing = new List<ColorsDTO>();
        private List<ColorsDTO> colorsPalleteMaterial = new List<ColorsDTO>();
        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();

        private int viewType = 0;
        private bool materialShow = false;


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
                    
                    generalButtonRibbon.Enabled = true;
                    functionButtonRibbon.Enabled = true;
                    copyPasteMenuStrip.Enabled = true;

                    break;
                case 2:
                    generalButtonRibbon.Enabled = true;
                    functionButtonRibbon.Enabled = true;
                    copyPasteMenuStrip.Enabled = true;
                    //технолог

                    break;
                case 3:
                    generalButtonRibbon.Enabled = true;
                    functionButtonRibbon.Enabled = true;
                    copyPasteMenuStrip.Enabled = true;
                    break;
                //конструктор
                case 4:
                    generalButtonRibbon.Enabled = false;
                    functionButtonRibbon.Enabled = false;
                    copyPasteMenuStrip.Enabled = false;
                    //админ

                    break;
                default:
                    break;
            }


        }


        public StructuraFm(UsersDTO usersDTO)
        {
            InitializeComponent();

            this.usersDTO = usersDTO;

            LoadLocalSetting();
            LoadData();

            UserAcces();
            LoadColorsPallete();
        }

        public void LoadLocalSetting()
        {
            viewType = Properties.Settings.Default.ViewType;
        }

        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();
            splashScreenManager.ShowWaitForm();

            var drawingsListInfo = drawingService.GetAllDrawingsProc().OrderBy(bdsm => Convert.ToInt32(bdsm.CurrentLevelMenu.Split('.').Last())).ToList();
            drawingsList = ConvertList(drawingsListInfo);
            drawingsBS.DataSource = drawingsList;
            drawingTreeListGrid.DataSource = drawingsBS;
            drawingTreeListGrid.KeyFieldName = "Id";
            drawingTreeListGrid.ParentFieldName = "ParentId";
            drawingTreeListGrid.ExpandAll();

            splashScreenManager.CloseWaitForm(); 
        }

        public List<DrawingsDTO> ConvertList(List<DrawingsInfoDTO> data)
        {
            List<DrawingsDTO> returnList = new List<DrawingsDTO>();
            foreach (var item in data)
            {
                DrawingsDTO temp = new DrawingsDTO()
                {
                    Id = item.Id,
                    Assembly = item.Assembly,
                    CreateDate = item.CreateDate,
                    CurrentLevelMenu = item.CurrentLevelMenu,
                    CurrentLevelMenuColorId = item.CurrentLevelMenuColorId,
                    CurrentLevelMenuColorName = item.CurrentLevelMenuColorName,
                    DetailName = item.DetailName,
                    DetailWeight = item.DetailWeight,
                    DilKapci2K = item.DilKapci2K,
                    DilKapci2KTotal = item.DilKapci2KTotal,
                    DilKapci880 = item.DilKapci880,
                    DilKapci880Total = item.DilKapci880Total,
                    DilKapci881 = item.DilKapci881,
                    DilKapci881Total = item.DilKapci881Total,
                    DrawingColorId = item.DrawingColorId,
                    DrawingColorName = item.DrawingColorName,
                    DrawingId = item.DrawingId,
                    EnamelKapci6030 = item.EnamelKapci6030,
                    EnamelKapci6030Total = item.EnamelKapci6030Total,
                    EnamelKapci641 = item.EnamelKapci641,
                    EnamelKapci641Total = item.EnamelKapci641Total,
                    EnamelKapci670 = item.EnamelKapci670,
                    EnamelKapci670Total = item.EnamelKapci670Total,

                    GasArCO2 = item.GasArCO2,
                    GasArCO2Total = item.GasArCO2Total,
                    GasAr = item.GasAr,
                    GasArTotal = item.GasArTotal,
                    GasCO3 = item.GasCO3,
                    GasCO3Total = item.GasCO3Total,
                    GasN2 = item.GasN2,
                    GasN2Total = item.GasN2Total,
                    GasNature = item.GasNature,
                    GasNatureTotal = item.GasNatureTotal,
                    GasO2 = item.GasO2,
                    GasO2Total = item.GasO2Total,
                    HardKapci126 = item.HardKapci126,
                    HardKapci126Total = item.HardKapci126Total,
                    HardKapci2KMS651 = item.HardKapci2KMS651,
                    HardKapci2KMS651Total = item.HardKapci2KMS651Total,
                    HardKapci881 = item.HardKapci881,
                    HardKapci881Total = item.HardKapci881Total,
                    HardKapciHs6055 = item.HardKapciHs6055,
                    HardKapciHs6055Total = item.HardKapciHs6055Total,
                    HardKapciPEPutty = item.HardKapciPEPutty,
                    HardKapciPEPuttyTotal = item.HardKapciPEPuttyTotal,
                    LaborIntensity001 = item.LaborIntensity001,
                    LaborIntensity001Total = item.LaborIntensity001Total,
                    L = item.L,
                    LaborIntensity002 = item.LaborIntensity002,
                    LaborIntensity002Total = item.LaborIntensity002Total,
                    LaborIntensity003 = item.LaborIntensity003,
                    LaborIntensity003Total = item.LaborIntensity003Total,
                    LaborIntensity004 = item.LaborIntensity004,
                    LaborIntensity004Total = item.LaborIntensity004Total,
                    LaborIntensity005 = item.LaborIntensity005,
                    LaborIntensity005Total = item.LaborIntensity005Total,
                    LaborIntensityGeneral = item.LaborIntensityGeneral,
                    LaborIntensityGeneralTotal = item.LaborIntensityGeneralTotal,
                    MaterialColorId = item.MaterialColorId,
                    MaterialColorName = item.MaterialColorName,
                    MaterialName = item.MaterialName,
                    NoteName = item.NoteName,
                    Number = item.Number,
                    NumberWithRevisionName = item.NumberWithRevisionName,
                    OccurrenceId = item.OccurrenceId,
                    ParentId = item.ParentId,
                    ParentName = item.ParentName,
                    PrimerKapci125 = item.PrimerKapci125,
                    PrimerKapci125Total = item.PrimerKapci125Total,
                    PrimerKapci633 = item.PrimerKapci633,
                    PrimerKapci633Total = item.PrimerKapci633Total,
                    PuttyKapci350 = item.PuttyKapci350,
                    PuttyKapci350Total = item.PuttyKapci350Total,
                    Quantity = item.Quantity,
                    QuantityL = item.QuantityL,
                    QuantityR = item.QuantityR,
                    ReplaceDrawingId = item.ReplaceDrawingId,
                    Revision001 = item.Revision001,
                    Revision002 = item.Revision002,
                    Revision003 = item.Revision003,
                    Revision004 = item.Revision004,
                    Revision005 = item.Revision005,
                    RevisionName = item.RevisionName,
                    ScanId = item.ScanId,
                    StructuraDisable = item.StructuraDisable,
                    TechProcess001Id = item.TechProcess001Id,
                    TechProcess001Name = item.TechProcess001Name,
                    TechProcess001Old = item.TechProcess001Old,
                    TechProcess001Path = item.TechProcess001Path,
                    TechProcess001PathOld = item.TechProcess001PathOld,
                    TechProcess001Type = item.TechProcess001Type,
                    TechProcess002Id = item.TechProcess002Id,
                    TechProcess002Name = item.TechProcess002Name,
                    TechProcess002Old = item.TechProcess002Old,
                    TechProcess002Path = item.TechProcess002Path,
                    TechProcess002PathOld = item.TechProcess002PathOld,
                    TechProcess002Type = item.TechProcess002Type,
                    TechProcess003Id = item.TechProcess003Id,
                    TechProcess003Name = item.TechProcess003Name,
                    TechProcess003Old = item.TechProcess003Old,
                    TechProcess003Path = item.TechProcess003Path,
                    TechProcess003PathOld = item.TechProcess003PathOld,
                    TechProcess003Type = item.TechProcess003Type,
                    TechProcess004Id = item.TechProcess004Id,
                    TechProcess004Name = item.TechProcess004Name,
                    TechProcess004Old = item.TechProcess004Old,
                    TechProcess004Path = item.TechProcess004Path,
                    TechProcess004PathOld = item.TechProcess004PathOld,
                    TechProcess004Type = item.TechProcess004Type,
                    TechProcess005Id = item.TechProcess005Id,
                    TechProcess005Name = item.TechProcess005Name,
                    TechProcess005Old = item.TechProcess005Old,
                    TechProcess005Path = item.TechProcess005Path,
                    TechProcess005PathOld = item.TechProcess005PathOld,
                    TechProcess005Type = item.TechProcess005Type,
                    TH = item.TH,
                    TypeName = item.TypeName,
                    UniversalSikaflex527 = item.UniversalSikaflex527,
                    UniversalSikaflex527Total = item.UniversalSikaflex527Total,
                    W = item.W,
                    W2 = item.W2,
                    Welding10 = item.Welding10,
                    Welding10Total = item.Welding10Total,
                    Welding12 = item.Welding12,
                    Welding12Total = item.Welding12Total,
                    Welding16 = item.Welding16,
                    Welding16Total = item.Welding16Total,
                    Welding20 = item.Welding20,
                    Welding20Steel = item.Welding20Steel,
                    Welding20SteelTotal = item.Welding20SteelTotal,
                    Welding20Total = item.Welding20Total,
                    WeldingElektrod = item.WeldingElektrod,
                    WeldingElektrodTotal = item.WeldingElektrodTotal
                };

                returnList.Add(temp);

            }

            return returnList;
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
                if (((DrawingsDTO)drawingsBS.Current).TechProcess001Id != null)
                {
                    reportService.OpenExcelFile(((DrawingsDTO)drawingsBS.Current).TechProcess001Path);
                }
                if (((DrawingsDTO)drawingsBS.Current).TechProcess002Id != null)
                {
                    reportService.OpenExcelFile(((DrawingsDTO)drawingsBS.Current).TechProcess002Path);
                }
            
        }

        private void techProcess002Repository_DoubleClick(object sender, System.EventArgs e)
        {
                if (((DrawingsDTO)drawingsBS.Current).TechProcess001Id != null)
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

            //if (view.Val(e.RowHandle, "ColorName") != null)
            //{
            //    string currentRowColor = gv.GetRowCellValue(e.RowHandle, "ColorName").ToString();
            //    e.Appearance.BackColor = Color.FromName(currentRowColor);
            //}

            //bool checkErledigt = Convert.ToBoolean(view.GetNodeAt(e.Node, "A"));
            //if (checkErledigt)
            //    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
            //else
            //    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);

            //if (e.Column.FieldName != "Budget") return;
            //TreeView view = (TreeView)sender;
            //if (view.C(e.RowHandle, "ColorName") != null)
            //{
            //    string currentRowColor = gv.GetRowCellValue(e.RowHandle, "ColorName").ToString();
            //    e.Appearance.BackColor = Color.FromName(currentRowColor);
            //}

            //drawingTreeListGrid.PostEditor();
            //drawingTreeListGrid.BeginUpdate();

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

            if (item.TechProcess001Id != null && e.Column.FieldName == "TechProcess001Name")
            {
                switch (item.TechProcess001Type)
                {
                    case 1:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Black;

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
                    case 5:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Orange;
                        break;

                    default:
                        break;
                }
            }

            if (item.TechProcess002Id != null && e.Column.FieldName == "TechProcess002Name")
            {
                switch (item.TechProcess002Type)
                {
                    case 1:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Black;

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
                    case 5:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Orange;
                        break;

                    default:
                        break;
                }
            }

            if (item.TechProcess003Id != null && e.Column.FieldName == "TechProcess003Name")
            {
                switch (item.TechProcess003Type)
                {
                    case 1:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Black;

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
                    case 5:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Orange;
                        break;

                    default:
                        break;
                }
            }

            if (item.CurrentLevelMenuColorId != null && e.Column.FieldName == "CurrentLevelMenu")
            {
                e.Appearance.BackColor = Color.FromName(item.CurrentLevelMenuColorName);
            }
            if (item.DrawingColorId != null && (e.Column.FieldName == "Number" || e.Column.FieldName == "RevisionName"))
            {
                e.Appearance.BackColor = Color.FromName(item.DrawingColorName);
            }
            if (item.MaterialColorId != null && e.Column.FieldName == "DetailName")
            {
                e.Appearance.BackColor = Color.FromName(item.MaterialColorName);
            }

            //drawingTreeListGrid.EndUpdate();

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
                        LoadData();
                

                drawingTreeListGrid.EndUpdate();
            }
        }

        private void showTechProcessBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (techProcessBand.Visible == true)
            {
                drawingTreeListGrid.Columns[6].OptionsColumn.AllowEdit = false;
                drawingTreeListGrid.Columns[7].OptionsColumn.AllowEdit = false;
                drawingTreeListGrid.Columns[8].OptionsColumn.AllowEdit = false;
                drawingTreeListGrid.Columns[9].OptionsColumn.AllowEdit = false;
                drawingTreeListGrid.Columns[10].OptionsColumn.AllowEdit = false;
                drawingTreeListGrid.Columns[6].OptionsColumn.AllowFocus = false;
                drawingTreeListGrid.Columns[7].OptionsColumn.AllowFocus = false;
                drawingTreeListGrid.Columns[8].OptionsColumn.AllowFocus = false;
                drawingTreeListGrid.Columns[9].OptionsColumn.AllowFocus = false;
                drawingTreeListGrid.Columns[10].OptionsColumn.AllowFocus = false;
                //techProcess001Repository.DoubleClick -= techProcess001Repository_DoubleClick;

                techProcessBand.Visible = false;
                showTechProcessBtn.ImageOptions.Image = imageCollection.Images[2];
                showTechProcessBtn.Caption = "Отобразить техпроцессы";
            }
            else
            {
                drawingTreeListGrid.Columns[6].OptionsColumn.AllowEdit = true;
                drawingTreeListGrid.Columns[7].OptionsColumn.AllowEdit = true;
                drawingTreeListGrid.Columns[8].OptionsColumn.AllowEdit = true;
                drawingTreeListGrid.Columns[9].OptionsColumn.AllowEdit = true;
                drawingTreeListGrid.Columns[10].OptionsColumn.AllowEdit = true;
                drawingTreeListGrid.Columns[6].OptionsColumn.AllowFocus = true;
                drawingTreeListGrid.Columns[7].OptionsColumn.AllowFocus = true;
                drawingTreeListGrid.Columns[8].OptionsColumn.AllowFocus = true;
                drawingTreeListGrid.Columns[9].OptionsColumn.AllowFocus = true;
                drawingTreeListGrid.Columns[10].OptionsColumn.AllowFocus = true;
                //techProcess001Repository.DoubleClick += techProcess001Repository_DoubleClick;

                techProcessBand.Visible = true;
                showTechProcessBtn.ImageOptions.Image = imageCollection.Images[3];
                showTechProcessBtn.Caption = "Не отображать техпроцессы";
            }
        }

        private void выделитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadColorsPallete()
        {

            journalService = Program.kernel.Get<IJournalService>();
            colorsPallete = journalService.GetColors().ToList();

            ToolStripMenuItem[] MenuItemStructuraColor = new ToolStripMenuItem[colorsPallete.Count()];
            ToolStripMenuItem[] MenuItemDrawingColor = new ToolStripMenuItem[colorsPallete.Count()];
            ToolStripMenuItem[] MenuItemDetailColor = new ToolStripMenuItem[colorsPallete.Count()];

            for (int i = 0; i < colorsPallete.Count; i++)
            {
                //ToolStripMenuItem MenuItem = new ToolStripMenuItem()
                //{
                //    Text = colorsPallete[i].NameRus.ToString(),
                //    Image = Rgb2Bitmap(colorsPallete[i].Code.ToString()),
                //    ToolTipText = colorsPallete[i].NameRus.ToString(),
                //    Tag = colorsPallete[i].Id
                //};
                //MenuItemStructuraColor[i] = MenuItem;
                //MenuItemDrawingColor[i] = MenuItem;
                //MenuItemDetailColor[i] = MenuItem;

                ToolStripMenuItem MenuItem = new ToolStripMenuItem()
                {
                    Text = colorsPallete[i].NameRus.ToString(),
                    Image = Rgb2Bitmap(colorsPallete[i].Code.ToString()),
                    ToolTipText = colorsPallete[i].NameEng.ToString(),
                    Tag = colorsPallete[i].Id
                };

                //MenuItemStructuraColor[i] = MenuItem;
                //MenuItemDrawingColor[i] = MenuItem;
                //MenuItemDetailColor[i] = MenuItem;

                colorMenu.Items.Add(MenuItem);


                

                



                //copyPasteMenuStrip.Items[3].Add(MenuItem);
            }

            //toolStripMenuItem3.DropDown.Items.AddRange(MenuItemStructuraColor);
            //toolStripMenuItem2.DropDown.Items.AddRange(MenuItemDrawingColor);

            //copyPasteMenuStrip.Items

            //drawingColorToolStripMenuItem.DropDown.Items.AddRange(MenuItemDrawingColor);
            //copyPasteMenuStrip.Items.Add(drawingColorToolStripMenuItem);
            // detailColorToolStripMenuItem.DropDown.Items.AddRange(MenuItemDetailColor);
            //this.toolStripMenuItem2.DropDownItems.AddRange(MenuItemDetailColor);
            //toolStripMenuItem3.DropDownItems.AddRange(MenuItemDetailColor);
            //copyPasteMenuStrip.Items.Add(detailColorToolStripMenuItem);
            //structuraColorToolStripMenuItem.DropDownItems.AddRange(MenuItemStructuraColor);
            //copyPasteMenuStrip.Items.Add(structuraColorToolStripMenuItem);
            //copyPasteMenuStrip.D

        }

        public Bitmap Rgb2Bitmap(string HtmlRgb)
        {
            Bitmap bitmap = new Bitmap(16, 16);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml(HtmlRgb));
            graphics.FillRectangle(brush, 0, 0, 16, 16);
            return bitmap;
        }

        private void structuraColorToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DrawingsDTO updateModel = ((DrawingsDTO)drawingsBS.Current);
            var per = Convert.ToInt16(e.ClickedItem.Tag);
            updateModel.CurrentLevelMenuColorId = Convert.ToInt16(e.ClickedItem.Tag);
            ((DrawingsDTO)drawingsBS.Current).CurrentLevelMenuColorName = e.ClickedItem.ToolTipText;
            drawingsBS.EndEdit();
            drawingService.DrawingsUpdate(updateModel);
        }

        private void drawingColorToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DrawingsDTO updateModel = ((DrawingsDTO)drawingsBS.Current);
            var per = Convert.ToInt16(e.ClickedItem.Tag);
            updateModel.DrawingColorId = Convert.ToInt16(e.ClickedItem.Tag);
            drawingTreeListGrid.Update();
            ((DrawingsDTO)drawingsBS.Current).DrawingColorName = e.ClickedItem.ToolTipText;
            drawingService.DrawingsUpdate(((DrawingsDTO)Item));
        }

        private void detailColorToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DrawingsDTO updateModel = ((DrawingsDTO)drawingsBS.Current);
            var per = Convert.ToInt16(e.ClickedItem.Tag);
            updateModel.MaterialColorId = Convert.ToInt16(e.ClickedItem.Tag);
            ((DrawingsDTO)drawingsBS.Current).MaterialColorName = e.ClickedItem.ToolTipText;
            drawingService.DrawingsUpdate(updateModel);
        }

        private void StructuraFm_Load(object sender, EventArgs e)
        {
            techProcessPropBand.Visible = false;
            gasMaterialBand.Visible = false;
            weldingMaterialBand.Visible = false;
            paintMaterialBand.Visible = false;
            materialShow = false;

            showTechProcessBtn.ImageOptions.Image = imageCollection.Images[3];
            showTechProcessBtn.Caption = "Не отображать техпроцессы";
            showLaborIntensityBtn.ImageOptions.Image = imageCollection.Images[3];
            showLaborIntensityBtn.Caption = "Не отображать трудоёмкость";
            showMaterialBtn.ImageOptions.Image = imageCollection.Images[2];
            showMaterialBtn.Caption = "Отобразить материалы";
        }

        private void showLaborIntensityBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (laborIntensityBand.Visible == true)
            {
                laborIntensityBand.Visible = false;
                showLaborIntensityBtn.ImageOptions.Image = imageCollection.Images[2];
                showLaborIntensityBtn.Caption = "Отобразить трудоёмкость";

            }
            else
            {
                laborIntensityBand.Visible = true;
                showLaborIntensityBtn.ImageOptions.Image = imageCollection.Images[3];
                showLaborIntensityBtn.Caption = "Не отображать трудоёмкость";
            }
        }

        private void showMaterialBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (techProcessPropBand.Visible == true)
            {
                techProcessPropBand.Visible = false;
                gasMaterialBand.Visible = false;
                weldingMaterialBand.Visible = false;
                paintMaterialBand.Visible = false;
                materialShow = false;
                showMaterialBtn.ImageOptions.Image = imageCollection.Images[2];
                showMaterialBtn.Caption = "Отобразить материалы";

                drawingTreeListGrid.BeginUpdate();
                LoadData();
                drawingTreeListGrid.EndUpdate();

            }
            else
            {
                techProcessPropBand.Visible = true;
                gasMaterialBand.Visible = true;
                weldingMaterialBand.Visible = true;
                paintMaterialBand.Visible = true;
                materialShow = true;
                showMaterialBtn.ImageOptions.Image = imageCollection.Images[3];
                showMaterialBtn.Caption = "Не отображать материалы";
                drawingTreeListGrid.BeginUpdate();
                
                drawingTreeListGrid.EndUpdate();
            }
        }

        private void showNodeStatBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!drawingTreeListGrid.OptionsView.ShowRowFooterSummary)
            {
                drawingTreeListGrid.BeginUpdate();

                drawingTreeListGrid.OptionsView.ShowRowFooterSummary = true;
                LoadData();
                showNodeStatBtn.Caption = "Скрыть информацию по сборкам";
                drawingTreeListGrid.EndUpdate();
            }
            else
            {
                drawingTreeListGrid.BeginUpdate();
                drawingTreeListGrid.OptionsView.ShowRowFooterSummary = false;
                LoadData();
                showNodeStatBtn.Caption = "Отобразить информацию по сборкам";
                drawingTreeListGrid.EndUpdate();
            }
        }


        //убрать нули
        private void drawingTreeListGrid_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Quantity" || e.Column.FieldName == "QuantityR" || e.Column.FieldName == "QuantityL" || e.Column.FieldName == "L"
                || e.Column.FieldName == "W" || e.Column.FieldName == "W2" || e.Column.FieldName == "TH" || e.Column.FieldName == "Welding20Steel"
                || e.Column.FieldName == "Welding10" || e.Column.FieldName == "Welding12" || e.Column.FieldName == "Welding16" || e.Column.FieldName == "Welding20"
                || e.Column.FieldName == "GasArCO2" || e.Column.FieldName == "GasCO3" || e.Column.FieldName == "GasAr" || e.Column.FieldName == "WeldingElektrod"
                || e.Column.FieldName == "GasO2" || e.Column.FieldName == "GasNature" || e.Column.FieldName == "GasN2" || e.Column.FieldName == "HardKapci881"
                || e.Column.FieldName == "HardKapciHs6055" || e.Column.FieldName == "HardKapci126" || e.Column.FieldName == "HardKapciPEPutty" || e.Column.FieldName == "HardKapci2KMS651"
                || e.Column.FieldName == "DilKapci881" || e.Column.FieldName == "DilKapci2K" || e.Column.FieldName == "DilKapci880" || e.Column.FieldName == "PrimerKapci125"
                || e.Column.FieldName == "PrimerKapci633" || e.Column.FieldName == "EnamelKapci641" || e.Column.FieldName == "EnamelKapci670" || e.Column.FieldName == "EnamelKapci6030"
                || e.Column.FieldName == "UniversalSikaflex527"|| e.Column.FieldName == "PuttyKapci350" || e.Column.FieldName == "LaborIntensity001"
                || e.Column.FieldName == "LaborIntensity002"|| e.Column.FieldName == "LaborIntensity003"|| e.Column.FieldName == "LaborIntensity004"
                || e.Column.FieldName == "LaborIntensity005"|| e.Column.FieldName == "LaborIntensityGeneral"
                || e.Column.FieldName == "Welding20SteelTotal"
                || e.Column.FieldName == "Welding10Total" || e.Column.FieldName == "Welding12Total" || e.Column.FieldName == "Welding16Total" || e.Column.FieldName == "Welding20Total"
                || e.Column.FieldName == "GasArCO2Total" || e.Column.FieldName == "GasCO3Total" || e.Column.FieldName == "GasArTotal" || e.Column.FieldName == "WeldingElektrodTotal"
                || e.Column.FieldName == "GasO2Total" || e.Column.FieldName == "GasNatureTotal" || e.Column.FieldName == "GasN2Total" || e.Column.FieldName == "HardKapci881Total"
                || e.Column.FieldName == "HardKapciHs6055Total" || e.Column.FieldName == "HardKapci126Total" || e.Column.FieldName == "HardKapciPEPuttyTotal" || e.Column.FieldName == "HardKapci2KMS651Total"
                || e.Column.FieldName == "DilKapci881Total" || e.Column.FieldName == "DilKapci2KTotal" || e.Column.FieldName == "DilKapci880Total" || e.Column.FieldName == "PrimerKapci125Total"
                || e.Column.FieldName == "PrimerKapci633Total" || e.Column.FieldName == "EnamelKapci641Total" || e.Column.FieldName == "EnamelKapci670Total" || e.Column.FieldName == "EnamelKapci6030Total"
                || e.Column.FieldName == "UniversalSikaflex527Total" || e.Column.FieldName == "PuttyKapci350Total" || e.Column.FieldName == "LaborIntensity001Total"
                || e.Column.FieldName == "LaborIntensity002Total" || e.Column.FieldName == "LaborIntensity003Total" || e.Column.FieldName == "LaborIntensity004Total"
                || e.Column.FieldName == "LaborIntensity005Total" || e.Column.FieldName == "LaborIntensityGeneralTotal")
                if (Convert.ToDouble(e.Value) == 0D)
                    e.DisplayText = string.Empty;
        }
    }
}