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
using TechnicalProcessControl.BLL;

namespace TechnicalProcessControl.Drawings
{
    public partial class StructuraEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IDrawingService drawingService;
        private IReportService reportService;
        private IJournalService journalService;

        public Utils.Operation operation;

        private List<DrawingScanDTO> drawingScanList = new List<DrawingScanDTO>();
        private List<DrawingDTO> drawingList = new List<DrawingDTO>();
        private List<DrawingDTO> drawingAllList = new List<DrawingDTO>();

        private UsersDTO usersDTO;

        private bool FormReady = false;

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

        public StructuraEditFm(UsersDTO usersDTO, DrawingsDTO model, Utils.Operation operation)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();
            journalService = Program.kernel.Get<IJournalService>();

            this.operation = operation;
            this.usersDTO = usersDTO;

            splashScreenManager.ShowWaitForm();

            drawingsBS.DataSource = Item = model;
            numberEdit.EditValue = ((DrawingsDTO)Item).DrawingId;

            numberEdit.DataBindings.Add("EditValue", drawingsBS, "DrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            currentLevelMenuEdit.DataBindings.Add("Text", drawingsBS, "CurrentLevelMenu", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityEdit.DataBindings.Add("EditValue", drawingsBS, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityLEdit.DataBindings.Add("EditValue", drawingsBS, "QuantityL", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityREdit.DataBindings.Add("EditValue", drawingsBS, "QuantityR", true, DataSourceUpdateMode.OnPropertyChanged);
            noteEdit.DataBindings.Add("EditValue", drawingsBS, "NoteName", true, DataSourceUpdateMode.OnPropertyChanged);
            dateEdit.DataBindings.Add("EditValue", drawingsBS, "CreateDate", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess001Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess001Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess002Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess002Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess003Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess003Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess004Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess004Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess005Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess005Id", true, DataSourceUpdateMode.OnPropertyChanged);

            drawingList = drawingService.GetAllDrawingActual().ToList();
            drawingAllList = drawingService.GetAllDrawing().ToList();
      
            drawingBS.DataSource = drawingList;
            numberEdit.Properties.DataSource = drawingBS;
            numberEdit.Properties.ValueMember = "Id";
            numberEdit.Properties.DisplayMember = "FullName";
            numberEdit.Properties.NullText = "Немає данних";

            replaceDrawingEdit.DataBindings.Add("EditValue", drawingsBS, "ReplaceDrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            replaceDrawingBS.DataSource = drawingAllList;
            replaceDrawingEdit.Properties.DataSource = replaceDrawingBS;
            replaceDrawingEdit.Properties.ValueMember = "Id";
            replaceDrawingEdit.Properties.DisplayMember = "Number";
            replaceDrawingEdit.Properties.NullText = "Немає данних";

            firstUseDrawingEdit.DataBindings.Add("EditValue", drawingsBS, "OccurrenceId", true, DataSourceUpdateMode.OnPropertyChanged);
            firstUseDrawingBS.DataSource = drawingAllList;
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
                    parentCurrentLevelMenuEdit.EditValue = ((DrawingsDTO)Item).ParentId != null ? ((DrawingsDTO)Item).ParentId : null;
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

            UserAcces();
            FormReady = true;
            //ControlValidation();
            splashScreenManager.CloseWaitForm();
        }


        private void UserAcces()
        {
            switch (usersDTO.RoleId)
            {
                case 1:
                    break;
                case 2:
                    parentCurrentLevelMenuEdit.ReadOnly = true;
                    currentLevelMenuEdit.ReadOnly = true;
                    quantityEdit.ReadOnly = true;
                    quantityLEdit.ReadOnly = true;
                    quantityREdit.ReadOnly = true;
                    replaceDrawingEdit.ReadOnly = true;
                    firstUseDrawingEdit.ReadOnly = true;
                    numberEdit.ReadOnly = true;
                    numberEdit.Properties.Buttons[0].Enabled = false;
                    numberEdit.Properties.Buttons[1].Enabled = false;
                    numberEdit.Properties.Buttons[2].Enabled = false;
                    numberEdit.Properties.Buttons[3].Enabled = false;

                    switch (operation)
                    {
                        case Utils.Operation.Add:

                            break;

                        case Utils.Operation.Update:


                            break;

                        default:
                           
                            break;
                    }
                    break;
                case 3:
                    techProcess001Edit.ReadOnly = true;
                    techProcess001Edit.Properties.Buttons[0].Enabled = false;
                    techProcess001Edit.Properties.Buttons[1].Enabled = false;
                    techProcess001Edit.Properties.Buttons[2].Enabled = false;
                    techProcess001Edit.Properties.Buttons[3].Enabled = false;
                    techProcess002Edit.ReadOnly = true;
                    techProcess002Edit.Properties.Buttons[0].Enabled = false;
                    techProcess002Edit.Properties.Buttons[1].Enabled = false;
                    techProcess002Edit.Properties.Buttons[2].Enabled = false;
                    techProcess002Edit.Properties.Buttons[3].Enabled = false;
                    techProcess003Edit.ReadOnly = true;
                    techProcess003Edit.Properties.Buttons[0].Enabled = false;
                    techProcess003Edit.Properties.Buttons[1].Enabled = false;
                    techProcess003Edit.Properties.Buttons[2].Enabled = false;
                    techProcess003Edit.Properties.Buttons[3].Enabled = false;
                    techProcess004Edit.ReadOnly = true;
                    techProcess004Edit.Properties.Buttons[0].Enabled = false;
                    techProcess004Edit.Properties.Buttons[1].Enabled = false;
                    techProcess004Edit.Properties.Buttons[2].Enabled = false;
                    techProcess004Edit.Properties.Buttons[3].Enabled = false;
                    techProcess005Edit.ReadOnly = true;
                    techProcess005Edit.Properties.Buttons[0].Enabled = false;
                    techProcess005Edit.Properties.Buttons[1].Enabled = false;
                    techProcess005Edit.Properties.Buttons[2].Enabled = false;
                    techProcess005Edit.Properties.Buttons[3].Enabled = false;

                    switch (operation)
                    {
                        case Utils.Operation.Add:
                            
                            break;

                        case Utils.Operation.Update:
                            firstUseDrawingEdit.Properties.ShowDropDown = ShowDropDown.Never;
                            replaceDrawingEdit.Properties.ShowDropDown = ShowDropDown.Never;
                            numberEdit.Properties.ShowDropDown = ShowDropDown.Never;

                            numberEdit.Properties.Buttons[0].Enabled = false;
                            numberEdit.Properties.Buttons[1].Enabled = false;
                            numberEdit.Properties.Buttons[2].Enabled = false;
                            numberEdit.Properties.Buttons[3].Enabled = false;

                            break;

                        default:

                            break;
                    }
                    break;
                default:
                    break;
            }


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
                        MessageBox.Show("Структура з таким номером уже существует!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    if (!CheckStructuraQuantity())
                    {
                        MessageBox.Show("Не коректно указано количество!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Структура з таким номером уже существует!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    if (!CheckStructuraQuantity())
                    {
                        MessageBox.Show("Не коректно указано количество!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }


        private bool CheckStructuraQuantity()
        {
            if ((decimal)quantityEdit.EditValue == 0 && (decimal)quantityREdit.EditValue == 0 && (decimal)quantityLEdit.EditValue == 0)
                return false;
            else if ((decimal)quantityEdit.EditValue != 0 && ((decimal)quantityREdit.EditValue != 0 || (decimal)quantityLEdit.EditValue != 0))
                return false;

            return true;
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



        private void DrawingsEditFm_Load(object sender, EventArgs e)
        {
            if (drawingScanList.Count > 0)
                drawingScanEdit.EditValue = drawingScanList[0].Id;
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



        void CheckTechProcess001()
        {


                object key = numberEdit.EditValue;
                if (key != null)
                {
                    if ((bool)!((DrawingDTO)numberEdit.GetSelectedDataRow()).Assembly)
                    {
                        techProcessPanel.Enabled = true;
                        var selectedIndex = numberEdit.Properties.GetIndexByKeyValue(key);
                        var techProcess001 = drawingService.GetTechProcess001ByDrawingId((int)key);
                        if (techProcess001 != null)
                        {
                            techProcess001BS.DataSource = drawingService.GetAllTechProcess001();
                            techProcess001Edit.EditValue = ((TechProcess001DTO)techProcess001).Id;
                            if ((bool)((TechProcess001DTO)techProcess001).OldTechProcess)
                            {
                                techProcess001Edit.Properties.Buttons[0].Enabled = false;
                                techProcess001Edit.Properties.Buttons[1].Enabled = true;
                                techProcess001Edit.Properties.Buttons[2].Enabled = true;
                                techProcess001Edit.Properties.Buttons[3].Enabled = false;
                                techProcess001Edit.Properties.Buttons[4].Enabled = true;

                            }
                            else
                            {
                                techProcess001Edit.Properties.Buttons[0].Enabled = false;
                                techProcess001Edit.Properties.Buttons[1].Enabled = true;
                                techProcess001Edit.Properties.Buttons[2].Enabled = true;
                                techProcess001Edit.Properties.Buttons[3].Enabled = true;
                                techProcess001Edit.Properties.Buttons[4].Enabled = true;
                            }
                        }
                        else
                        {
                            techProcess001Edit.EditValue = null;
                            techProcess001Edit.Properties.Buttons[0].Enabled = true;
                            techProcess001Edit.Properties.Buttons[1].Enabled = false;
                            techProcess001Edit.Properties.Buttons[2].Enabled = false;
                            techProcess001Edit.Properties.Buttons[3].Enabled = false;
                            techProcess001Edit.Properties.Buttons[4].Enabled = false;
                        }
                    }
                    else
                    {
                        techProcessPanel.Enabled = false;
                    }
                }
                else
                {
                    techProcessPanel.Enabled = false;
                }
            
        }

        private void numberEdit_EditValueChanged(object sender, EventArgs e)
        {
            //if(numberEdit.EditValue == null || numberEdit.EditValue == DBNull.Value)
            //{
            //    MessageBox.Show("Нету чертежа", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    return;
            //}

            if (numberEdit.EditValue != DBNull.Value && numberEdit.EditValue != null && FormReady)
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
                //noteEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow());
                //dateEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).CreateDate.Value.ToShortDateString();

                drawingScanList = drawingService.GetDravingScanById(((DrawingDTO)numberEdit.GetSelectedDataRow()).Id).ToList();
                drawingsScanBS.DataSource = drawingScanList;
                drawingScanEdit.Properties.DataSource = drawingsScanBS;

                if (drawingsScanBS.Count > 0)
                    drawingScanEdit.EditValue = drawingScanList[0].Id;
                else
                    drawingScanEdit.EditValue = null;

                if (!(bool)((DrawingDTO)numberEdit.GetSelectedDataRow()).Assembly)
                {

                    techProcess001Edit.Enabled = true;
                    techProcess002Edit.Enabled = true;
                    techProcess003Edit.Enabled = true;
                    techProcess004Edit.Enabled = true;
                    techProcess005Edit.Enabled = true;

                    var techProcess001 = drawingService.GetTechProcess001ByDrawingId((int)key);
                    var techProcess002 = drawingService.GetTechProcess002ByDrawingId((int)key);
                    var techProcess003 = drawingService.GetTechProcess003ByDrawingId((int)key);
                    var techProcess004 = drawingService.GetTechProcess004ByDrawingId((int)key);
                    var techProcess005 = drawingService.GetTechProcess005ByDrawingId((int)key);

                    //CheckTechProcess001();

                    if (techProcess001 != null)
                    {
                        techProcess001BS.DataSource = drawingService.GetAllTechProcess001();
                        ((DrawingsDTO)Item).TechProcess001Id = ((TechProcess001DTO)techProcess001).Id;
                        if ((bool)((TechProcess001DTO)techProcess001).OldTechProcess)
                        {
                            techProcess001Edit.Properties.Buttons[0].Enabled = false;
                            techProcess001Edit.Properties.Buttons[1].Enabled = false;
                            techProcess001Edit.Properties.Buttons[3].Enabled = false;
                            techProcess001Edit.Properties.Buttons[4].Enabled = true;
                            techProcess001Edit.Properties.Buttons[4].Enabled = true;
                        }
                        else
                        {
                            techProcess001Edit.Properties.Buttons[0].Enabled = true;
                            techProcess001Edit.Properties.Buttons[1].Enabled = true;
                            techProcess001Edit.Properties.Buttons[3].Enabled = true;
                        }
                    }
                    else
                    {
                        //((DrawingsDTO)Item).TechProcess001Id = null;
                        techProcess001Edit.Properties.Buttons[0].Enabled = true;
                        techProcess001Edit.Properties.Buttons[1].Enabled = false;
                        techProcess001Edit.Properties.Buttons[2].Enabled = false;
                        techProcess001Edit.Properties.Buttons[3].Enabled = false;
                        techProcess001Edit.Properties.Buttons[4].Enabled = false;
                    }

                    if (techProcess002 != null)
                    {
                        techProcess002BS.DataSource = drawingService.GetAllTechProcess002();
                        ((DrawingsDTO)Item).TechProcess002Id = ((TechProcess002DTO)techProcess002).Id;
                    }
                    else
                    {
                        ((DrawingsDTO)Item).TechProcess002Id = null;
                    }

                    if (techProcess003 != null)
                    {
                        techProcess003BS.DataSource = drawingService.GetAllTechProcess003();
                        ((DrawingsDTO)Item).TechProcess003Id = ((TechProcess003DTO)techProcess003).Id;
                    }
                    else
                    {
                        ((DrawingsDTO)Item).TechProcess003Id = null;
                    }

                    if (techProcess004 != null)
                    {
                        techProcess004BS.DataSource = drawingService.GetAllTechProcess004();
                        ((DrawingsDTO)Item).TechProcess004Id = ((TechProcess004DTO)techProcess004).Id;
                    }
                    else
                    {
                        ((DrawingsDTO)Item).TechProcess004Id = null;
                    }

                    if (techProcess005 != null)
                    {
                        techProcess005BS.DataSource = drawingService.GetAllTechProcess005();
                        ((DrawingsDTO)Item).TechProcess005Id = ((TechProcess005DTO)techProcess005).Id;
                    }
                    else
                    {
                        ((DrawingsDTO)Item).TechProcess005Id = null;
                    }
                }
                else
                {
                    techProcess001Edit.Enabled = false;
                    techProcess002Edit.Enabled = false;
                    techProcess003Edit.Enabled = false;
                    techProcess004Edit.Enabled = false;
                    techProcess005Edit.Enabled = false;
                }


            }
            else
            {
                techProcess001Edit.EditValue = null;
                techProcess002Edit.EditValue = null;
                techProcess003Edit.EditValue = null;
                techProcess004Edit.EditValue = null;
                techProcess005Edit.EditValue = null;

                techProcess001Edit.Enabled = false;
                techProcess002Edit.Enabled = false;
                techProcess003Edit.Enabled = false;
                techProcess004Edit.Enabled = false;
                techProcess005Edit.Enabled = false;
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
            noteEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).Note;
            dateEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).CreateDate;

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
                case 0: //Додати
                    {
                        //if (numberEdit.EditValue == null || numberEdit.EditValue == DBNull.Value)
                        //{
                        //    MessageBox.Show("Нету чертежа", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //    return;
                        //}
                        break;
                    }
                case 1: //Додати
                    {
                        using (DrawingEditFm drawingEditFm = new DrawingEditFm(usersDTO,new DrawingDTO(), Utils.Operation.Add))
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

                        DrawingDTO updateDrawingDTO = drawingService.GetDrawingById((int)numberEdit.EditValue);

                        using (DrawingEditFm drawingEditFm = new DrawingEditFm(usersDTO, updateDrawingDTO, Utils.Operation.Update))
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
                //case 4://Очистити
                //    {
                //        numberEdit.EditValue = null;
                //        numberEdit.Properties.NullText = "Немає данних";
                //        break;
                //    }
                case 4://Создать ревизию
                    {
                        if (numberEdit.EditValue == DBNull.Value)
                            return;

                        DrawingDTO updateDrawingDTO = drawingService.GetDrawingById((int)numberEdit.EditValue);

                        using (DrawingEditFm drawingEditFm = new DrawingEditFm(usersDTO,updateDrawingDTO, Utils.Operation.Custom))
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
            }
        }

        private void firstUseDrawingEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            journalService = Program.kernel.Get<IJournalService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (DrawingEditFm drawingEditFm = new DrawingEditFm(usersDTO,new DrawingDTO(), Utils.Operation.Add))
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

                        using (DrawingEditFm drawingEditFm = new DrawingEditFm(usersDTO,(DrawingDTO)firstUseDrawingEdit.GetSelectedDataRow(), Utils.Operation.Update))
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
                        using (DrawingEditFm drawingEditFm = new DrawingEditFm(usersDTO,new DrawingDTO(), Utils.Operation.Add))
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

                        using (DrawingEditFm drawingEditFm = new DrawingEditFm(usersDTO,(DrawingDTO)replaceDrawingEdit.GetSelectedDataRow(), Utils.Operation.Update))
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

            if (operation == Utils.Operation.Add)
            {
                if (parentCurrentLevelMenuEdit.EditValue == DBNull.Value)
                    return;


                string getNumber = drawingService.GetMaxStructuraNumber((int)parentCurrentLevelMenuEdit.EditValue);
                ((DrawingsDTO)drawingsBS.DataSource).CurrentLevelMenu = getNumber;
                currentLevelMenuEdit.Text = getNumber;
            }

            dxValidationProvider.Validate((Control)sender);

            //((DrawingsDTO)Item).CurrentLevelMenu = drawingService.GetMaxStructuraNumber((int)parentCurrentLevelMenuEdit.EditValue);

            //parentCurrentLevelMenuEdit.Text = ((DrawingsDTO)parentCurrentLevelMenuEdit.GetSelectedDataRow()).CurrentLevelMenu;
            //GetMaxStructuraNumber
        }

        

        private void techProcess002Edit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            switch (e.Button.Index)
            {
                case 0: //Додати
                    {
                        //////////////////////////////////////////////////////////////////////
                        //Под вопросом 
                        //if (drawingService.CheckDrivingChild((int)((DrawingsDTO)Item).DrawingId))
                        //{
                        //    MessageBox.Show("Сборка содержит узлы, не возможно добавить этот вид техпроцесса", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    return;
                        //}
                        ///////////////////////////////////////////////////////////////////////



                        TechProcess002DTO addTechProcessDTO = new TechProcess002DTO();
                        addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
                        addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;

                        using (TechProcess002EditFm techProcess002EditFm = new TechProcess002EditFm(Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
                        {
                            if (techProcess002EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
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
                        if (drawingService.GetChildDrawings(((DrawingsDTO)Item)).Count() == 0)
                        {
                            MessageBox.Show("Сборка не содержит узлы, не возможно добавить этот вид техпроцесса", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        TechProcess003DTO addTechProcessDTO = new TechProcess003DTO();
                        addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
                        addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;
                        addTechProcessDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;

                        using (TechProcess003EditFm techProcess003EditFm = new TechProcess003EditFm(Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
                        {
                            if (techProcess003EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                //////detailsBS.DataSource = journalService.GetDetails();
                                //techProcess003Edit.Properties.DataSource = drawingService.GetAllTechProcess002();
                                //techProcess003Edit.Properties.ValueMember = "Id";
                                //techProcess003Edit.Properties.DisplayMember = "TechProcessFullName";
                                //techProcess002Edit.Properties.NullText = "Нету записей";

                                //int return_Id = techProcess003EditFm.Return().Id;
                                //techProcess003Edit.EditValue = return_Id;

                                techProcess003Edit.Properties.DataSource = drawingService.GetAllTechProcess003();
                                int return_Id = techProcess003EditFm.Return().Id;
                                techProcess003Edit.EditValue = return_Id;
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
                        if (techProcess003Edit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService = Program.kernel.Get<IDrawingService>();
                            if (drawingService.TechProcess003Delete((int)((DrawingsDTO)Item).TechProcess003Id))
                                drawingService.FileDelete(((DrawingsDTO)Item).TechProcess003Path);
                            techProcess003Edit.EditValue = null;
                            techProcess003Edit.Properties.NullText = "Не добавлен техпроцесс";
                        }

                        break;
                    }

                case 3://Ревизия
                    {
                        if (techProcess003Edit.EditValue == DBNull.Value)
                            return;

                        drawingService = Program.kernel.Get<IDrawingService>();
                        TechProcess003DTO techProcess003OldDTO = drawingService.GetTechProcess003ByDrawingId((int)((DrawingsDTO)Item).DrawingId);
                        TechProcess003DTO addTechProcessRevisionDTO = new TechProcess003DTO();

                        addTechProcessRevisionDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;
                        addTechProcessRevisionDTO.RevisionId = techProcess003OldDTO.RevisionId;
                        addTechProcessRevisionDTO.TechProcessName = techProcess003OldDTO.TechProcessName;
                        addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessRevisionDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;

                        //if (((DrawingsDTO)Item).RevisionName != null)
                        //    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        //else
                        //    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;

                        using (TechProcess003EditFm techProcess003EditFm = new TechProcess003EditFm(Utils.Operation.Custom, addTechProcessRevisionDTO, ((DrawingsDTO)Item), techProcess003OldDTO))
                        {
                            if (techProcess003EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess003Edit.Properties.DataSource = drawingService.GetAllTechProcess001();
                                int return_Id = techProcess003EditFm.Return().Id;
                                techProcess001Edit.EditValue = return_Id;
                            }
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



        


        #region Validation

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);

            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;

        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void currentLevelMenuEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }



        #endregion


        #region TechProcess 001

        private void techProcess001Edit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            switch (e.Button.Index)
            {
                case 0: //Додати
                    {

                        //if (drawingService.CheckDrivingChild((int)((DrawingsDTO)Item).DrawingId))
                        //{
                        //    MessageBox.Show("Сборка содержит узлы, не возможно добавить этот вид техпроцесса", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    return;
                        //}

                        TechProcess001DTO addTechProcessDTO = new TechProcess001DTO();
                        //addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
                        addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;
                        addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;

                        using (TechProcess001EditFm techProcess001EditFm = new TechProcess001EditFm(usersDTO, Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
                        {
                            if (techProcess001EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess001Edit.Properties.DataSource = drawingService.GetAllTechProcess001();
                                int return_Id = techProcess001EditFm.Return().Id;
                                techProcess001Edit.EditValue = return_Id;

                                if ((bool)techProcess001EditFm.Return().OldTechProcess)
                                {
                                    numberEdit.Properties.Buttons[0].Enabled = false;
                                    numberEdit.Properties.Buttons[1].Enabled = false;
                                    numberEdit.Properties.Buttons[3].Enabled = false;
                                }

                            }
                        }
                        break;
                    }
                case 1://Редагувати
                    {
                        if (techProcess001Edit.EditValue == DBNull.Value || techProcess001Edit.EditValue == null)
                            return;

                        TechProcess001DTO techProcess001 = drawingService.GetTechProcess001ByDrawingId((int)((DrawingsDTO)Item).DrawingId);

                        using (TechProcess001EditFm techProcess001EditFm = new TechProcess001EditFm(usersDTO, Utils.Operation.Update, techProcess001))
                        {
                            if (techProcess001EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess001Edit.Properties.DataSource = drawingService.GetAllTechProcess001();
                                int return_Id = techProcess001EditFm.Return().Id;
                                techProcess001Edit.EditValue = return_Id;

                            }
                        }
                        break;
                    }
                case 2://Видалити
                    {
                        if (techProcess001Edit.EditValue == DBNull.Value || techProcess001Edit.EditValue == null)
                            return;

                        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService = Program.kernel.Get<IDrawingService>();
                            //получаем айди ревизии техпроцесса, чтобы потом коректно показать что у техпроцесса есть ревизия
                            var Child = drawingService.GetTechProcess001RevisionByIdFull((int)((DrawingsDTO)Item).TechProcess001Id);

                            //пробуем удалить информацию о техпроцессе в базе, если получается, удаляем файл техпроцесса в файловой БД
                            if (drawingService.TechProcess001Delete((int)((DrawingsDTO)Item).TechProcess001Id))
                                drawingService.FileDelete(((DrawingsDTO)Item).TechProcess001Path);

                            //если у техпроцесса была ревизия, отбражаем её
                            CheckTechProcess001();

                            //if (Child != null)
                            //{
                            //    techProcess001Edit.EditValue = ((TechProcess001DTO)Child).Id;
                            //}
                            //else
                            //{
                            //    techProcess001Edit.EditValue = null;
                            //    techProcess001Edit.Properties.NullText = "Не добавлен техпроцесс";
                            //}
                        }

                        break;
                    }
                case 3://Создать ревизию
                    {
                        if (techProcess001Edit.EditValue == DBNull.Value || techProcess001Edit.EditValue == null)
                            return;

                        drawingService = Program.kernel.Get<IDrawingService>();
                        TechProcess001DTO techProcess001OldDTO = drawingService.GetTechProcess001ByDrawingId((int)((DrawingsDTO)Item).DrawingId);
                        TechProcess001DTO addTechProcessRevisionDTO = new TechProcess001DTO();

                        addTechProcessRevisionDTO = (TechProcess001DTO)techProcess001OldDTO.Clone();

                        addTechProcessRevisionDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;
                        addTechProcessRevisionDTO.RevisionId = techProcess001OldDTO.RevisionId;
                        addTechProcessRevisionDTO.TechProcessName = techProcess001OldDTO.TechProcessName;
                        addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessRevisionDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;

                        //if (((DrawingsDTO)Item).RevisionName != null)
                        //    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        //else
                        //    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;

                        using (TechProcess001EditFm techProcess001EditFm = new TechProcess001EditFm(usersDTO, Utils.Operation.Custom, addTechProcessRevisionDTO, ((DrawingsDTO)Item), techProcess001OldDTO))
                        {
                            if (techProcess001EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess001Edit.Properties.DataSource = drawingService.GetAllTechProcess001();
                                int return_Id = techProcess001EditFm.Return().Id;
                                techProcess001Edit.EditValue = return_Id;
                            }
                        }

                        break;
                    }
                case 4://Ревизия
                    {
                        if (techProcess001Edit.EditValue == DBNull.Value || techProcess001Edit.EditValue == null)
                            return;

                        TechProcess001DTO techProcess001 = drawingService.GetTechProcess001ByIdFull((int)techProcess001Edit.EditValue);

                        TestFm testFm = new TestFm(techProcess001.TechProcessPath);
                        testFm.Show();

                        break;
                    }
            }
        }

        private void techProcess001Edit_EditValueChanged(object sender, EventArgs e)
        {
            CheckTechProcess001();
        }


        #endregion

        private void numberEdit_BeforePopup(object sender, EventArgs e)
        {
            if (numberEdit.EditValue == null || numberEdit.EditValue == DBNull.Value)
            {
                MessageBox.Show("Нету чертежа", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            else
            {
                if (MessageBox.Show("Заменить чертёж?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
                else
                    return;

            }
        }


    }
}