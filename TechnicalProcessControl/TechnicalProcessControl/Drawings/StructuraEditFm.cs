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
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Infrastructure;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using DevExpress.XtraEditors.Controls;
using TechnicalProcessControl.Journals;
using TechnicalProcessControl.TechnicalProcess;

namespace TechnicalProcessControl.Drawings
{
    public partial class StructuraEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IDrawingService drawingService;
        private IReportService reportService;
        private IJournalService journalService;

        private Utils.Operation operation;

        private List<DrawingScanDTO> drawingScanList = new List<DrawingScanDTO>();
        private List<DrawingDTO> drawingList = new List<DrawingDTO>();

        private UsersTelegramDTO models;

        private BindingSource drawingBS = new BindingSource();
        private BindingSource replaceDrawingBS = new BindingSource();
        private BindingSource firstUseDrawingBS = new BindingSource();
        private BindingSource drawingsBS = new BindingSource();
        private BindingSource drawingsScanBS = new BindingSource();
        private BindingSource techProcess001BS = new BindingSource();
        private BindingSource techProcess002BS = new BindingSource();
        private BindingSource techProcess003BS = new BindingSource();
        private BindingSource techProcess004BS = new BindingSource();
        private BindingSource techProcess005BS = new BindingSource();
        private BindingSource parentCurrentLevelMenuEditBS = new BindingSource();
        private BindingSource typeBS = new BindingSource();
        private BindingSource detailsBS = new BindingSource();
        private BindingSource materialsBS = new BindingSource();
        private BindingSource curentLevelMenuBS = new BindingSource();

        private ObjectBase Item
        {
            get { return drawingsBS.Current as ObjectBase; }
            set
            {
                drawingsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public StructuraEditFm(DrawingsDTO model, Utils.Operation operation)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();
            journalService = Program.kernel.Get<IJournalService>();

            this.operation = operation;

            splashScreenManager.ShowWaitForm();

            drawingsBS.DataSource = Item = model;

            

            //currentLevelMenuEdit.DataBindings.Add("EditValue", drawingsBS, "CurrentLevelMenu", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityEdit.DataBindings.Add("EditValue", drawingsBS, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityLEdit.DataBindings.Add("EditValue", drawingsBS, "QuantityL", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityREdit.DataBindings.Add("EditValue", drawingsBS, "QuantityR", true, DataSourceUpdateMode.OnPropertyChanged);
            replaceDrawingEdit.DataBindings.Add("EditValue", drawingsBS, "ReplaceDrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            firstUseDrawingEdit.DataBindings.Add("EditValue", drawingsBS, "OccurrenceId", true, DataSourceUpdateMode.OnPropertyChanged);
            
            currentLevelMenuEdit.DataBindings.Add("EditValue", drawingsBS, "currentLevelMenu", true, DataSourceUpdateMode.OnPropertyChanged);

            techProcess001Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess001Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess002Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess002Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess003Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess003Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess004Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess004Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess005Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess005Id", true, DataSourceUpdateMode.OnPropertyChanged);

            drawingList = drawingService.GetAllDrawing().ToList();

            numberEdit.DataBindings.Add("EditValue", drawingsBS, "DrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingBS.DataSource = drawingList;
            numberEdit.Properties.DataSource = drawingBS;
            numberEdit.Properties.ValueMember = "Id";
            numberEdit.Properties.DisplayMember = "Number";
            numberEdit.Properties.NullText = "Немає данних";


            replaceDrawingBS.DataSource = drawingList;
            replaceDrawingEdit.Properties.DataSource = replaceDrawingBS;
            replaceDrawingEdit.Properties.ValueMember = "Id";
            replaceDrawingEdit.Properties.DisplayMember = "Number";
            replaceDrawingEdit.Properties.NullText = "Немає данних";

            
            firstUseDrawingBS.DataSource = drawingList;
            firstUseDrawingEdit.Properties.DataSource = firstUseDrawingBS;
            firstUseDrawingEdit.Properties.ValueMember = "Id";
            firstUseDrawingEdit.Properties.DisplayMember = "Number";
            firstUseDrawingEdit.Properties.NullText = "Немає данних";


            parentCurrentLevelMenuEditBS.DataSource = drawingService.GetShortDrawing();
            parentCurrentLevelMenuEdit.Properties.DataSource = parentCurrentLevelMenuEditBS;
            parentCurrentLevelMenuEdit.Properties.ValueMember = "Id";
            parentCurrentLevelMenuEdit.Properties.DisplayMember = "CurrentLevelMenu";
            parentCurrentLevelMenuEdit.Properties.NullText = "Немає данних";

            techProcess001BS.DataSource = drawingService.GetAllTechProcess001();
            techProcess001Edit.Properties.DataSource = techProcess001BS;
            techProcess001Edit.Properties.ValueMember = "Id";
            techProcess001Edit.Properties.DisplayMember = "TechProcessFullName";
            techProcess001Edit.Properties.NullText = "Немає данних";

            techProcess002BS.DataSource = drawingService.GetAllTechProcess002();
            techProcess002Edit.Properties.DataSource = techProcess002BS;
            techProcess002Edit.Properties.ValueMember = "Id";
            techProcess002Edit.Properties.DisplayMember = "TechProcessFullName";
            techProcess002Edit.Properties.NullText = "Немає данних";

            techProcess003BS.DataSource = drawingService.GetAllTechProcess003();
            techProcess003Edit.Properties.DataSource = techProcess003BS;
            techProcess003Edit.Properties.ValueMember = "Id";
            techProcess003Edit.Properties.DisplayMember = "TechProcessFullName";
            techProcess003Edit.Properties.NullText = "Немає данних";

            techProcess004BS.DataSource = drawingService.GetAllTechProcess004();
            techProcess004Edit.Properties.DataSource = techProcess004BS;
            techProcess004Edit.Properties.ValueMember = "Id";
            techProcess004Edit.Properties.DisplayMember = "TechProcessFullName";
            techProcess004Edit.Properties.NullText = "Немає данних";

            techProcess005BS.DataSource = drawingService.GetAllTechProcess005();
            techProcess005Edit.Properties.DataSource = techProcess005BS;
            techProcess005Edit.Properties.ValueMember = "Id";
            techProcess005Edit.Properties.DisplayMember = "TechProcessFullName";
            techProcess005Edit.Properties.NullText = "Немає данних";

            drawingScanList = drawingService.GetDravingScanById(((DrawingsDTO)Item).DrawingId).ToList();
            drawingsScanBS.DataSource = drawingScanList;
            drawingScanEdit.Properties.DataSource = drawingsScanBS;
            drawingScanEdit.Properties.ValueMember = "Id";
            drawingScanEdit.Properties.DisplayMember = "FileName";
            drawingScanEdit.Properties.NullText = "Немає данних";


            switch (operation)
            {
                case Utils.Operation.Add:

                    //parentCurrentLevelMenuEdit.DataBindings.Add("EditValue", drawingsBS, "ParentId", true, DataSourceUpdateMode.OnPropertyChanged);
                    techProcessPanel.Enabled = false;
                    break;

                case Utils.Operation.Update:
                    parentCurrentLevelMenuEdit.DataBindings.Add("EditValue", drawingsBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);

                    techProcessPanel.Enabled = true;
                    parentCurrentLevelMenuEdit.ReadOnly = true;
                    currentLevelMenuEdit.ReadOnly = true;

                    break;

                default:
                    MessageBox.Show("При завантаженні форми " + this.Text + " виникла помилка. ", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }



            //ControlValidation();
            splashScreenManager.CloseWaitForm();
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            try
            {
                drawingService = Program.kernel.Get<IDrawingService>();
                reportService = Program.kernel.Get<IReportService>();


                if (operation == Utils.Operation.Add)
                {

                    if (drawingService.CheckStructuraName((DrawingsDTO)Item))
                    {
                        MessageBox.Show("Структура з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    

                    ((DrawingsDTO)Item).ParentId = (int?)parentCurrentLevelMenuEdit.EditValue;
                    ((DrawingsDTO)Item).Id = drawingService.DrawingsCreate((DrawingsDTO)Item);
                    return true;
                }
                else
                {

                    if (drawingService.CheckStructuraName((DrawingsDTO)Item))
                    {
                        MessageBox.Show("Структура з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    
                    drawingService.DrawingsUpdate((DrawingsDTO)Item);
                    //if (drawingScanDTO != null)
                    //{
                    //    if (drawingScanDTO.Scan == null && drawingScanDTO.Id > 0)
                    //    {
                    //        drawingService.DrawingScanDelete(drawingScanDTO.Id);
                    //        ((DrawingsDTO)Item).ScanId = null;
                    //    }
                    //    else if (drawingScanDTO.Scan != null && drawingScanDTO.Id == 0)
                    //    {
                    //        drawingScanDTO.DrawingId = ((DrawingsDTO)Item).Id;
                    //        ((DrawingsDTO)Item).ScanId = drawingService.DrawingScanCreate(drawingScanDTO);
                    //    }
                    //    else
                    //    {
                    //        drawingService.DrawingScanUpdate(drawingScanDTO);
                    //    }
                    //}

                    //String updateTemplate = "";

                    //if (((DrawingsDTO)Item).TechProcess001Id != null)
                    //    if (!reportService.UpdateTemplateTechProcess001((DrawingsDTO)Item))
                    //        updateTemplate += "При оновленні шаблону " + ((DrawingsDTO)Item).TechProcess001Name + " виникла помилка!\n";
                    //if (((DrawingsDTO)Item).TechProcess002Id != null)
                    //    if (!reportService.UpdateTemplateTechProcess002((DrawingsDTO)Item))
                    //        updateTemplate += "При оновленні шаблону " + ((DrawingsDTO)Item).TechProcess002Name + " виникла помилка!\n"; ;
                    //if (((DrawingsDTO)Item).TechProcess003Id != null)
                    //    if (!reportService.UpdateTemplateTechProcess003((DrawingsDTO)Item))
                    //        updateTemplate = false;
                    //if (((DrawingsDTO)Item).TechProcess004Id != null)
                    //    if (!reportService.UpdateTemplateTechProcess004((DrawingsDTO)Item))
                    //        updateTemplate = false;
                    //if (((DrawingsDTO)Item).TechProcess005Id != null)
                    //    if (!reportService.UpdateTemplateTechProcess005((DrawingsDTO)Item))
                    //        updateTemplate = false;


                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("При сохранении возникла ошибка. " + ex.Message, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        //    switch (operation)
        //    {
        //        case Utils.Operation.Add:
        //            if (contractorsService.CheckAgreementOrderNumber((DateTime)((AgreementOrderDTO)Item).AgreementOrderDate, ((AgreementOrderDTO)Item).AgreementOrderNumber))
        //            {
        //                MessageBox.Show("рахунок з номером " + ((AgreementOrderDTO)Item).AgreementOrderNumber + " вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                agreemtnOrderNumberEdit.Text = contractorsService.GetAgreementOrderLastNumber((DateTime)((AgreementOrderDTO)Item).AgreementOrderDate).ToString();

        //                //((AgreementOrderDTO)Item).AgreementOrderNumber = contractorsService.GetAgreementOrderLastNumber((DateTime)((AgreementOrderDTO)Item).AgreementOrderDate);
        //                return false;
        //            }

        //            if (agreementOrderScanDTO.Scan != null)
        //                ((AgreementOrderDTO)Item).AgreementOrderScanId = contractorsService.AgreementOrderScanCreate(agreementOrderScanDTO);

        //            ((AgreementOrderDTO)Item).ResponsibleId = userTasksDTO.UserId;
        //            ((AgreementOrderDTO)Item).Id = contractorsService.AgreementOrderCreate((AgreementOrderDTO)Item);

        //            break;
        //        case Utils.Operation.Update:
        //            ((AgreementOrderDTO)Item).ResponsibleId = userTasksDTO.UserId;

        //            if (agreementOrderScanDTO != null)
        //            {
        //                if (agreementOrderScanDTO.Scan == null && agreementOrderScanDTO.Id > 0)
        //                {
        //                    contractorsService.AgreementOrderScanDelete(agreementOrderScanDTO.Id);
        //                    ((AgreementOrderDTO)Item).AgreementOrderScanId = null;
        //                }
        //                else if (agreementOrderScanDTO.Scan != null && agreementOrderScanDTO.Id == 0)
        //                {
        //                    ((AgreementOrderDTO)Item).AgreementOrderScanId = contractorsService.AgreementOrderScanCreate(agreementOrderScanDTO);
        //                }
        //                else
        //                {
        //                    contractorsService.AgreementsOrderScanUpdate(agreementOrderScanDTO);
        //                }
        //            }

        //            contractorsService.AgreementsOrderUpdate((AgreementOrderDTO)Item);
        //            break;

        //        default:
        //            break;
        //    }
        //    return true;
        //}
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }










}





        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При сохранение возникла ошибка. " + ex.Message, "Сохранение чертежа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            DrawingScanDTO drawingScanDTO = new DrawingScanDTO();

            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            if (filePath.Length > 0)
            {
                byte[] scan = System.IO.File.ReadAllBytes(@filePath);
                drawingScanDTO.DrawingId = ((DrawingsDTO)Item).Id;
                drawingScanDTO.Scan = scan;
                drawingScanDTO.FileName = fileName;

                try
                {
                    int drawingScanId = drawingService.DrawingScanCreate(drawingScanDTO);
                    drawingScanList.Add(drawingScanDTO);
                    drawingScanEdit.EditValue = drawingScanId;
                    drawingScanEdit.Text = drawingScanDTO.FileName;

                    Bitmap bitmap = new Bitmap(filePath);
                    pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                    pictureEdit.EditValue = bitmap;
                    //fileNameTbox.EditValue = fileName;
                }
                catch (Exception  ex)
                {
                    MessageBox.Show("При добавлении скана возникла ошибка. " + ex.Message, "Сохранение чертежа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
                return;

            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            DrawingScanDTO drawingScanDTO = (DrawingScanDTO)drawingScanEdit.GetSelectedDataRow();
            try
            {
                drawingService.DrawingScanDelete(drawingScanDTO.Id);
                drawingScanList = drawingService.GetDravingScanById(((DrawingsDTO)Item).Id).ToList();
                drawingsScanBS.DataSource = drawingScanList;
                if (drawingScanList.Count > 0)
                {
                    drawingScanEdit.EditValue = drawingScanList[0].Id;
                }
                else
                {
                    drawingScanEdit.EditValue = null;
                    pictureEdit.EditValue = null;
                    //fileNameTbox.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При добавлении скана возникла ошибка. " + ex.Message, "Сохранение чертежа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            DrawingScanDTO drawingScanDTO = (DrawingScanDTO)drawingScanEdit.GetSelectedDataRow();
            if (drawingScanDTO != null)
            {
                string puth = Utils.HomePath + @"\Temp";
                System.IO.File.WriteAllBytes(puth + drawingScanDTO.FileName, drawingScanDTO.Scan);
                System.Diagnostics.Process.Start(puth + drawingScanDTO.FileName);
            }
        }

        private void drawingScanEdit_EditValueChanged(object sender, EventArgs e)
        {

            DrawingScanDTO drawingScanDTO = (DrawingScanDTO)drawingScanEdit.GetSelectedDataRow();

            if (drawingScanDTO != null)
            {
                int stratIndex = drawingScanDTO.FileName.IndexOf('.');
                string typeFile = drawingScanDTO.FileName.Substring(stratIndex);

                switch (typeFile)
                {
                    default:
                        //Bitmap bitmap = new Bitmap(drawingScanDTO.Scan);
                        ImageConverter ic = new ImageConverter();

                        Image img = (Image)ic.ConvertFrom(drawingScanDTO.Scan);

                        Bitmap bitmap1 = new Bitmap(img);

                        pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                        pictureEdit.EditValue = bitmap1;
                        //fileNameTbox.EditValue = drawingScanDTO.FileName;
                        break;
                }
            }
            else
                pictureEdit.EditValue = null;
        }

        private void drawingScanEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {

        }

        private void DrawingsEditFm_Load(object sender, EventArgs e)
        {
            if (drawingScanList.Count > 0)
                drawingScanEdit.EditValue = drawingScanList[0].Id;
        }

        private void DeleteFileJournalDocument()
        {
            //documentGridView.BeginDataUpdate();
            //// delete directory document
            //homePath = ((AgreementDocumentsDTO)documentsBS.Current).URL;
            //if (File.Exists(homePath))
            //    File.Delete(homePath);
            ////else MessageBox.Show("Ім'я папки не існує! Видалення папки не можливе!");
            //documentGridView.EndDataUpdate();
        }

        

        

        

        private void pictureEdit_Click(object sender, EventArgs e)
        {
            DrawingScanDTO drawingScanDTO = (DrawingScanDTO)drawingScanEdit.GetSelectedDataRow();
            if (drawingScanDTO != null)
            {
                string puth = Utils.HomePath + @"\Temp";
                System.IO.File.WriteAllBytes(puth + drawingScanDTO.FileName, drawingScanDTO.Scan);
                System.Diagnostics.Process.Start(puth + drawingScanDTO.FileName);
            }
        }

        private void pictureEdit_EditValueChanged(object sender, EventArgs e)
        {
            //DrawingScanDTO drawingScanDTO = (DrawingScanDTO)drawingScanEdit.GetSelectedDataRow();
            //if (drawingScanDTO != null)
            //{
            //    string puth = Utils.HomePath + @"\Temp";
            //    System.IO.File.WriteAllBytes(puth + drawingScanDTO.FileName, drawingScanDTO.Scan);
            //    System.Diagnostics.Process.Start(puth + drawingScanDTO.FileName);
            //}
        }

        private void numberEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (numberEdit.EditValue != DBNull.Value && numberEdit.EditValue != null)
            {
                object key = numberEdit.EditValue;
                var selectedIndex = numberEdit.Properties.GetIndexByKeyValue(key);
                materialEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).MaterialName;
                detailEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).DetailName;
                wEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).W;
                w2Edit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).W2;
                lEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).L;
                thEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).TH;
                weightEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).DetailWeight;
                typeEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).TypeName;

                drawingScanList = drawingService.GetDravingScanById(((DrawingDTO)numberEdit.GetSelectedDataRow()).Id).ToList();
                drawingsScanBS.DataSource = drawingScanList;
                drawingScanEdit.Properties.DataSource = drawingsScanBS;

                if (drawingsScanBS.Count > 0)
                    drawingScanEdit.EditValue = drawingScanList[0].Id;
                else
                    drawingScanEdit.EditValue = null;
            }

            
        }

        private void numberEditPatheticCrutch()
        {
            object key = numberEdit.EditValue;
            var selectedIndex = numberEdit.Properties.GetIndexByKeyValue(key);
            materialEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).MaterialName;
            detailEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).DetailName;
            wEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).W;
            w2Edit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).W2;
            lEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).L;
            thEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).TH;
            weightEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).DetailWeight;
            typeEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).TypeName;

            drawingScanList = drawingService.GetDravingScanById(((DrawingDTO)numberEdit.GetSelectedDataRow()).Id).ToList();
            drawingsScanBS.DataSource = drawingScanList;
            drawingScanEdit.Properties.DataSource = drawingsScanBS;

            if (drawingsScanBS.Count > 0)
                drawingScanEdit.EditValue = drawingScanList[0].Id;
            else
                drawingScanEdit.EditValue = null;
        }

        private void numberEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            journalService = Program.kernel.Get<IJournalService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (DrawingEditFm drawingEditFm = new DrawingEditFm(new DrawingDTO(), Utils.Operation.Add))
                        {
                            if (drawingEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                DrawingDTO return_Id = drawingEditFm.Return();
                                drawingBS.DataSource = drawingService.GetAllDrawing();
                                numberEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (numberEdit.EditValue == DBNull.Value)
                            return;

                        using (DrawingEditFm drawingEditFm = new DrawingEditFm((DrawingDTO)numberEdit.GetSelectedDataRow(), Utils.Operation.Update))
                        {
                            if (drawingEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                DrawingDTO return_Id = drawingEditFm.Return();
                                drawingBS.DataSource = drawingService.GetAllDrawing();
                                numberEdit.EditValue = return_Id.Id;
                                numberEditPatheticCrutch();
                                //numberEdit.RefreshEditValue();

                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (numberEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService.DrawingDelete(((DrawingDTO)numberEdit.GetSelectedDataRow()).Id);
                            numberEdit.Properties.DataSource = drawingService.GetAllDrawing();
                            numberEdit.EditValue = null;
                            numberEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        numberEdit.EditValue = null;
                        numberEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void firstUseDrawingEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            journalService = Program.kernel.Get<IJournalService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (DrawingEditFm drawingEditFm = new DrawingEditFm(new DrawingDTO(), Utils.Operation.Add))
                        {
                            if (drawingEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                DrawingDTO return_Id = drawingEditFm.Return();
                                firstUseDrawingBS.DataSource = drawingService.GetAllDrawing();
                                firstUseDrawingEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (numberEdit.EditValue == DBNull.Value)
                            return;

                        using (DrawingEditFm drawingEditFm = new DrawingEditFm((DrawingDTO)firstUseDrawingEdit.GetSelectedDataRow(), Utils.Operation.Update))
                        {
                            if (drawingEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                DrawingDTO return_Id = drawingEditFm.Return();
                                firstUseDrawingBS.DataSource = drawingService.GetAllDrawing();
                                firstUseDrawingEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (numberEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService.DrawingDelete(((DrawingDTO)firstUseDrawingEdit.GetSelectedDataRow()).Id);
                            firstUseDrawingEdit.Properties.DataSource = drawingService.GetAllDrawing();
                            firstUseDrawingEdit.EditValue = null;
                            firstUseDrawingEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        firstUseDrawingEdit.EditValue = null;
                        firstUseDrawingEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void replaceDrawingEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            journalService = Program.kernel.Get<IJournalService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (DrawingEditFm drawingEditFm = new DrawingEditFm(new DrawingDTO(), Utils.Operation.Add))
                        {
                            if (drawingEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                DrawingDTO return_Id = drawingEditFm.Return();
                                replaceDrawingBS.DataSource = drawingService.GetAllDrawing();
                                replaceDrawingEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (numberEdit.EditValue == DBNull.Value)
                            return;

                        using (DrawingEditFm drawingEditFm = new DrawingEditFm((DrawingDTO)replaceDrawingEdit.GetSelectedDataRow(), Utils.Operation.Update))
                        {
                            if (drawingEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                DrawingDTO return_Id = drawingEditFm.Return();
                                replaceDrawingBS.DataSource = drawingService.GetAllDrawing();
                                replaceDrawingEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (numberEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService.DrawingDelete(((DrawingDTO)replaceDrawingEdit.GetSelectedDataRow()).Id);
                            replaceDrawingEdit.Properties.DataSource = drawingService.GetAllDrawing();
                            replaceDrawingEdit.EditValue = null;
                            replaceDrawingEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        replaceDrawingEdit.EditValue = null;
                        replaceDrawingEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void parentCurrentLevelMenuEdit_EditValueChanged(object sender, EventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();

            if (parentCurrentLevelMenuEdit.EditValue == DBNull.Value || (DrawingsDTO)parentCurrentLevelMenuEdit.GetSelectedDataRow() == null)
                return;

            //((DrawingsDTO)Item).CurrentLevelMenu = drawingService.GetMaxStructuraNumber((DrawingsDTO)parentCurrentLevelMenuEdit.GetSelectedDataRow());
            currentLevelMenuEdit.Text = drawingService.GetMaxStructuraNumber((DrawingsDTO)parentCurrentLevelMenuEdit.GetSelectedDataRow());
            //parentCurrentLevelMenuEdit.Text = ((DrawingsDTO)parentCurrentLevelMenuEdit.GetSelectedDataRow()).CurrentLevelMenu;
            //GetMaxStructuraNumber
        }

        private void techProcess001Edit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            switch (e.Button.Index)
            {
                case 0: //Додати
                    {

                        if (drawingService.CheckDrivingChild((int)((DrawingsDTO)Item).DrawingId))
                        {
                            MessageBox.Show("Сборка содержит узлы, не возможно добавить этот вид техпроцесса", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        TechProcess001DTO addTechProcessDTO = new TechProcess001DTO();
                        addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
                        addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;

                        using (TechProcess001EditFm techProcess001EditFm = new TechProcess001EditFm(Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
                        {
                            if (techProcess001EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                ////detailsBS.DataSource = journalService.GetDetails();
                                techProcess001Edit.Properties.DataSource = drawingService.GetAllTechProcess001();
                                techProcess001Edit.Properties.ValueMember = "Id";
                                techProcess001Edit.Properties.DisplayMember = "TechProcessFullName";
                                techProcess001Edit.Properties.NullText = "Нету записей";

                                int return_Id = techProcess001EditFm.Return().Id;
                                techProcess001Edit.EditValue = return_Id;



                            }
                        }
                        break;
                    }
                case 1://Редагувати
                    {
                        //if (organisationEdit.EditValue == DBNull.Value)
                        //    return;

                        //using (OrganisationEditFm organisationEditFm = new OrganisationEditFm(Utils.Operation.Update, (ContractorsDTO)organisationEdit.GetSelectedDataRow()))
                        //{
                        //    if (organisationEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        int return_Id = organisationEditFm.Return();
                        //        botService = Program.kernel.Get<IBotService>();
                        //        organisationBS.DataSource = botService.GetAllContractors();
                        //        organisationEdit.EditValue = return_Id;
                        //    }
                        //}
                        break;
                    }
                case 2://Видалити
                    {
                        if (techProcess001Edit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService = Program.kernel.Get<IDrawingService>();
                            if (drawingService.TechProcess001Delete((int)((DrawingsDTO)Item).TechProcess001Id))
                                drawingService.FileDelete(((DrawingsDTO)Item).TechProcess001Path);
                            techProcess001Edit.EditValue = null;
                            techProcess001Edit.Properties.NullText = "Не добавлен техпроцесс";
                        }

                        break;
                    }
            }
        }

        private void techProcess002Edit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            switch (e.Button.Index)
            {
                case 0: //Додати
                    {

                        if (drawingService.CheckDrivingChild((int)((DrawingsDTO)Item).DrawingId))
                        {
                            MessageBox.Show("Сборка содержит узлы, не возможно добавить этот вид техпроцесса", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        TechProcess002DTO addTechProcessDTO = new TechProcess002DTO();
                        addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
                        addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;

                        using (TechProcess002EditFm techProcess002EditFm = new TechProcess002EditFm(Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
                        {
                            if (techProcess002EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                ////detailsBS.DataSource = journalService.GetDetails();
                                techProcess002Edit.Properties.DataSource = drawingService.GetAllTechProcess002();
                                techProcess002Edit.Properties.ValueMember = "Id";
                                techProcess002Edit.Properties.DisplayMember = "TechProcessFullName";
                                techProcess002Edit.Properties.NullText = "Нету записей";

                                int return_Id = techProcess002EditFm.Return().Id;
                                techProcess002Edit.EditValue = return_Id;



                            }
                        }
                        break;
                    }
                case 1://Редагувати
                    {
                        //if (organisationEdit.EditValue == DBNull.Value)
                        //    return;

                        //using (OrganisationEditFm organisationEditFm = new OrganisationEditFm(Utils.Operation.Update, (ContractorsDTO)organisationEdit.GetSelectedDataRow()))
                        //{
                        //    if (organisationEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        int return_Id = organisationEditFm.Return();
                        //        botService = Program.kernel.Get<IBotService>();
                        //        organisationBS.DataSource = botService.GetAllContractors();
                        //        organisationEdit.EditValue = return_Id;
                        //    }
                        //}
                        break;
                    }
                case 2://Видалити
                    {
                        if (techProcess002Edit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService = Program.kernel.Get<IDrawingService>();
                            if (drawingService.TechProcess002Delete((int)((DrawingsDTO)Item).TechProcess002Id))
                                drawingService.FileDelete(((DrawingsDTO)Item).TechProcess002Path);
                            techProcess002Edit.EditValue = null;
                            techProcess002Edit.Properties.NullText = "Не добавлен техпроцесс";
                        }

                        break;
                    }
                    //case 4://Очистити
                    //    {
                    //        organisationEdit.EditValue = null;
                    //        organisationEdit.Properties.NullText = "Немає данних";
                    //        break;
                    //    }
            }
        }

        private void techProcess003Edit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            switch (e.Button.Index)
            {
                case 0: //Додати
                    {
                        var lst = drawingService.GetChildDrawings(((DrawingsDTO)Item));

                        if (drawingService.GetChildDrawings(((DrawingsDTO)Item)).Count() == 0)
                        {
                            MessageBox.Show("Сборка не содержит узлы, не возможно добавить этот вид техпроцесса", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        TechProcess002DTO addTechProcessDTO = new TechProcess002DTO();
                        addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
                        addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;

                        using (TechProcess002EditFm techProcess002EditFm = new TechProcess002EditFm(Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
                        {
                            if (techProcess002EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                ////detailsBS.DataSource = journalService.GetDetails();
                                techProcess002Edit.Properties.DataSource = drawingService.GetAllTechProcess002();
                                techProcess002Edit.Properties.ValueMember = "Id";
                                techProcess002Edit.Properties.DisplayMember = "TechProcessFullName";
                                techProcess002Edit.Properties.NullText = "Нету записей";

                                int return_Id = techProcess002EditFm.Return().Id;
                                techProcess002Edit.EditValue = return_Id;



                            }
                        }
                        break;
                    }
                case 1://Редагувати
                    {
                        //if (organisationEdit.EditValue == DBNull.Value)
                        //    return;

                        //using (OrganisationEditFm organisationEditFm = new OrganisationEditFm(Utils.Operation.Update, (ContractorsDTO)organisationEdit.GetSelectedDataRow()))
                        //{
                        //    if (organisationEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        int return_Id = organisationEditFm.Return();
                        //        botService = Program.kernel.Get<IBotService>();
                        //        organisationBS.DataSource = botService.GetAllContractors();
                        //        organisationEdit.EditValue = return_Id;
                        //    }
                        //}
                        break;
                    }
                case 2://Видалити
                    {
                        if (techProcess002Edit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService = Program.kernel.Get<IDrawingService>();
                            if (drawingService.TechProcess002Delete((int)((DrawingsDTO)Item).TechProcess002Id))
                                drawingService.FileDelete(((DrawingsDTO)Item).TechProcess002Path);
                            techProcess002Edit.EditValue = null;
                            techProcess002Edit.Properties.NullText = "Не добавлен техпроцесс";
                        }

                        break;
                    }
                    //case 4://Очистити
                    //    {
                    //        organisationEdit.EditValue = null;
                    //        organisationEdit.Properties.NullText = "Немає данних";
                    //        break;
                    //    }
            }
        }
    }
}