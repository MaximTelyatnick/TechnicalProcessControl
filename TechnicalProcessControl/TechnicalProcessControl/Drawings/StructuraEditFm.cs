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
using System.IO;
using DevExpress.XtraSplashScreen;

namespace TechnicalProcessControl.Drawings
{
    public partial class StructuraEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IDrawingService drawingService;
        private IReportService reportService;
        private IJournalService journalService;
        private ITechProcessService techProcessService;

        private SplashScreenManager splashScreenManager;

        public Utils.Operation operation;

        private List<DrawingScanDTO> drawingScanList = new List<DrawingScanDTO>();
        private List<DrawingDTO> drawingList = new List<DrawingDTO>();
        private List<DrawingDTO> drawingAllList = new List<DrawingDTO>();

        private UsersDTO usersDTO;

        private bool FormReady = false;
        private bool TechProcess001Ready = false;
        private bool TechProcess002Ready = false;
        private bool TechProcess003Ready = false;
        private bool TechProcess004Ready = false;
        private bool TechProcess005Ready = false;
        private bool DrawingReady = false;

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

            splashScreenManager = new SplashScreenManager(this, typeof(WaitFm), true, true);

            drawingService = Program.kernel.Get<IDrawingService>();
            journalService = Program.kernel.Get<IJournalService>();
            techProcessService = Program.kernel.Get<ITechProcessService>();

            this.operation = operation;
            this.usersDTO = usersDTO;

            splashScreenManager.ShowWaitForm();

            drawingsBS.DataSource = Item = model;
            //numberEdit.EditValue = ((DrawingsDTO)Item).DrawingId;

            numberEdit.DataBindings.Add("EditValue", drawingsBS, "DrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            currentLevelMenuEdit.DataBindings.Add("Text", drawingsBS, "CurrentLevelMenu", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityEdit.DataBindings.Add("EditValue", drawingsBS, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityLEdit.DataBindings.Add("EditValue", drawingsBS, "QuantityL", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityREdit.DataBindings.Add("EditValue", drawingsBS, "QuantityR", true, DataSourceUpdateMode.OnPropertyChanged);
            //noteEdit.DataBindings.Add("EditValue", drawingsBS, "NoteName", true, DataSourceUpdateMode.OnPropertyChanged);
            //dateEdit.DataBindings.Add("EditValue", drawingsBS, "CreateDate", true, DataSourceUpdateMode.OnPropertyChanged);
            //techProcess001Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess001Id", true, DataSourceUpdateMode.OnPropertyChanged);
            //techProcess002Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess002Id", true, DataSourceUpdateMode.OnPropertyChanged);
            //techProcess003Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess003Id", true, DataSourceUpdateMode.OnPropertyChanged);
            //techProcess004Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess004Id", true, DataSourceUpdateMode.OnPropertyChanged);
            //techProcess005Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess005Id", true, DataSourceUpdateMode.OnPropertyChanged);

            drawingList = drawingService.GetAllDrawingActual().ToList();
            drawingAllList = drawingService.GetAllDrawing().ToList();
      
            drawingBS.DataSource = drawingList;
            numberEdit.Properties.DataSource = drawingBS;
            numberEdit.Properties.ValueMember = "Id";
            numberEdit.Properties.DisplayMember = "FullName";
            numberEdit.Properties.NullText = "";

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

            parentCurrentLevelMenuEditBS.DataSource = drawingService.GetDrawingsSimple();
            parentCurrentLevelMenuEdit.Properties.DataSource = parentCurrentLevelMenuEditBS;
            parentCurrentLevelMenuEdit.Properties.ValueMember = "Id";
            parentCurrentLevelMenuEdit.Properties.DisplayMember = "CurrentLevelMenu";
            parentCurrentLevelMenuEdit.Properties.NullText = "Немає данних";

            techProcess001BS.DataSource = techProcessService.GetAllTechProcess001();
            techProcess001Edit.Properties.DataSource = techProcess001BS;
            techProcess001Edit.Properties.ValueMember = "Id";
            techProcess001Edit.Properties.DisplayMember = "TechProcessFullName";
            techProcess001Edit.Properties.NullText = "";

            techProcess002BS.DataSource = techProcessService.GetAllTechProcess002();
            techProcess002Edit.Properties.DataSource = techProcess002BS;
            techProcess002Edit.Properties.ValueMember = "Id";
            techProcess002Edit.Properties.DisplayMember = "TechProcessFullName";
            techProcess002Edit.Properties.NullText = "";

            techProcess003BS.DataSource = techProcessService.GetAllTechProcess003();
            techProcess003Edit.Properties.DataSource = techProcess003BS;
            techProcess003Edit.Properties.ValueMember = "Id";
            techProcess003Edit.Properties.DisplayMember = "TechProcessFullName";
            techProcess003Edit.Properties.NullText = "";

            techProcess004BS.DataSource = techProcessService.GetAllTechProcess004();
            techProcess004Edit.Properties.DataSource = techProcess004BS;
            techProcess004Edit.Properties.ValueMember = "Id";
            techProcess004Edit.Properties.DisplayMember = "TechProcessFullName";
            techProcess004Edit.Properties.NullText = "";

            techProcess005BS.DataSource = techProcessService.GetAllTechProcess005();
            techProcess005Edit.Properties.DataSource = techProcess005BS;
            techProcess005Edit.Properties.ValueMember = "Id";
            techProcess005Edit.Properties.DisplayMember = "TechProcessFullName";
            techProcess005Edit.Properties.NullText = "";

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
            if (numberEdit.EditValue != DBNull.Value && numberEdit.EditValue != null && TechProcess001Ready)
            {
                var techProcess001 = techProcessService.GetTechProcess001ByDrawingId((int)numberEdit.EditValue);
                if (techProcess001 != null)
                {
                    techProcess001BS.DataSource = techProcessService.GetAllTechProcess001();
                    //techProcess001Edit.EditValue = ((TechProcess001DTO)techProcess001).Id;
                    if ((bool)((TechProcess001DTO)techProcess001).OldTechProcess)
                    {
                        techProcess001Edit.Properties.Buttons[0].Enabled = false;
                        techProcess001Edit.Properties.Buttons[1].Enabled = true;
                        techProcess001Edit.Properties.Buttons[2].Enabled = true;
                        techProcess001Edit.Properties.Buttons[3].Enabled = false;
                        techProcess001Edit.Properties.Buttons[4].Enabled = true;
                        techProcess001Edit.Properties.Buttons[5].Enabled = true;


                    }
                    else
                    {
                        techProcess001Edit.Properties.Buttons[0].Enabled = false;
                        techProcess001Edit.Properties.Buttons[1].Enabled = true;
                        techProcess001Edit.Properties.Buttons[2].Enabled = true;
                        techProcess001Edit.Properties.Buttons[3].Enabled = true;
                        techProcess001Edit.Properties.Buttons[4].Enabled = true;
                        techProcess001Edit.Properties.Buttons[5].Enabled = true;
                    }
                }
                else
                {
                    techProcess001Edit.Properties.Buttons[0].Enabled = true;
                    techProcess001Edit.Properties.Buttons[1].Enabled = false;
                    techProcess001Edit.Properties.Buttons[2].Enabled = false;
                    techProcess001Edit.Properties.Buttons[3].Enabled = false;
                    techProcess001Edit.Properties.Buttons[4].Enabled = false;
                    techProcess001Edit.Properties.Buttons[5].Enabled = false;
                }
            }
        }

        void CheckTechProcess002()
        {
            if (numberEdit.EditValue != DBNull.Value && numberEdit.EditValue != null && TechProcess001Ready)
            {
                var techProcess002 = techProcessService.GetTechProcess002ByDrawingId((int)numberEdit.EditValue);
                if (techProcess002 != null)
                {
                    techProcess002BS.DataSource = techProcessService.GetAllTechProcess002();
                    //techProcess001Edit.EditValue = ((TechProcess001DTO)techProcess001).Id;
                    if ((bool)((TechProcess002DTO)techProcess002).OldTechProcess)
                    {
                        techProcess002Edit.Properties.Buttons[0].Enabled = false;
                        techProcess002Edit.Properties.Buttons[1].Enabled = true;
                        techProcess002Edit.Properties.Buttons[2].Enabled = true;
                        techProcess002Edit.Properties.Buttons[3].Enabled = false;
                        techProcess002Edit.Properties.Buttons[4].Enabled = true;
                        techProcess002Edit.Properties.Buttons[5].Enabled = true;


                    }
                    else
                    {
                        techProcess002Edit.Properties.Buttons[0].Enabled = false;
                        techProcess002Edit.Properties.Buttons[1].Enabled = true;
                        techProcess002Edit.Properties.Buttons[2].Enabled = true;
                        techProcess002Edit.Properties.Buttons[3].Enabled = true;
                        techProcess002Edit.Properties.Buttons[4].Enabled = true;
                        techProcess002Edit.Properties.Buttons[5].Enabled = true;
                    }
                }
                else
                {
                    techProcess002Edit.Properties.Buttons[0].Enabled = true;
                    techProcess002Edit.Properties.Buttons[1].Enabled = false;
                    techProcess002Edit.Properties.Buttons[2].Enabled = false;
                    techProcess002Edit.Properties.Buttons[3].Enabled = false;
                    techProcess002Edit.Properties.Buttons[4].Enabled = false;
                    techProcess002Edit.Properties.Buttons[5].Enabled = false;
                }
            }
        }

        void CheckTechProcess003()
        {
            if (numberEdit.EditValue != DBNull.Value && numberEdit.EditValue != null && TechProcess001Ready)
            {
                var techProcess003 = drawingService.GetTechProcess003ByDrawingId((int)numberEdit.EditValue);
                if (techProcess003 != null)
                {
                    techProcess003BS.DataSource = drawingService.GetAllTechProcess003();
                    //techProcess001Edit.EditValue = ((TechProcess001DTO)techProcess001).Id;
                    if ((bool)((TechProcess003DTO)techProcess003).OldTechProcess)
                    {
                        techProcess003Edit.Properties.Buttons[0].Enabled = false;
                        techProcess003Edit.Properties.Buttons[1].Enabled = true;
                        techProcess003Edit.Properties.Buttons[2].Enabled = true;
                        techProcess003Edit.Properties.Buttons[3].Enabled = false;
                        techProcess003Edit.Properties.Buttons[4].Enabled = true;
                        techProcess003Edit.Properties.Buttons[5].Enabled = true;


                    }
                    else
                    {
                        techProcess003Edit.Properties.Buttons[0].Enabled = false;
                        techProcess003Edit.Properties.Buttons[1].Enabled = true;
                        techProcess003Edit.Properties.Buttons[2].Enabled = true;
                        techProcess003Edit.Properties.Buttons[3].Enabled = true;
                        techProcess003Edit.Properties.Buttons[4].Enabled = true;
                        techProcess003Edit.Properties.Buttons[5].Enabled = true;
                    }
                }
                else
                {
                    techProcess003Edit.Properties.Buttons[0].Enabled = true;
                    techProcess003Edit.Properties.Buttons[1].Enabled = false;
                    techProcess003Edit.Properties.Buttons[2].Enabled = false;
                    techProcess003Edit.Properties.Buttons[3].Enabled = false;
                    techProcess003Edit.Properties.Buttons[4].Enabled = false;
                    techProcess003Edit.Properties.Buttons[5].Enabled = false;
                }
            }
        }

        void CheckTechProcess004()
        {
            if (numberEdit.EditValue != DBNull.Value && numberEdit.EditValue != null && TechProcess001Ready)
            {
                var techProcess004 = drawingService.GetTechProcess004ByDrawingId((int)numberEdit.EditValue);
                if (techProcess004 != null)
                {
                    techProcess004BS.DataSource = drawingService.GetAllTechProcess004();
                    //techProcess001Edit.EditValue = ((TechProcess001DTO)techProcess001).Id;
                    if ((bool)((TechProcess004DTO)techProcess004).OldTechProcess)
                    {
                        techProcess004Edit.Properties.Buttons[0].Enabled = false;
                        techProcess004Edit.Properties.Buttons[1].Enabled = true;
                        techProcess004Edit.Properties.Buttons[2].Enabled = true;
                        techProcess004Edit.Properties.Buttons[3].Enabled = false;
                        techProcess004Edit.Properties.Buttons[4].Enabled = true;
                        techProcess004Edit.Properties.Buttons[5].Enabled = true;


                    }
                    else
                    {
                        techProcess004Edit.Properties.Buttons[0].Enabled = false;
                        techProcess004Edit.Properties.Buttons[1].Enabled = true;
                        techProcess004Edit.Properties.Buttons[2].Enabled = true;
                        techProcess004Edit.Properties.Buttons[3].Enabled = true;
                        techProcess004Edit.Properties.Buttons[4].Enabled = true;
                        techProcess004Edit.Properties.Buttons[5].Enabled = true;
                    }
                }
                else
                {
                    techProcess004Edit.Properties.Buttons[0].Enabled = true;
                    techProcess004Edit.Properties.Buttons[1].Enabled = false;
                    techProcess004Edit.Properties.Buttons[2].Enabled = false;
                    techProcess004Edit.Properties.Buttons[3].Enabled = false;
                    techProcess004Edit.Properties.Buttons[4].Enabled = false;
                    techProcess004Edit.Properties.Buttons[5].Enabled = false;
                }
            }
        }

        void CheckTechProcess005()
        {
            if (numberEdit.EditValue != DBNull.Value && numberEdit.EditValue != null && TechProcess001Ready)
            {
                var techProcess005 = drawingService.GetTechProcess005ByDrawingId((int)numberEdit.EditValue);
                if (techProcess005 != null)
                {
                    techProcess005BS.DataSource = drawingService.GetAllTechProcess005();
                    //techProcess001Edit.EditValue = ((TechProcess001DTO)techProcess001).Id;
                    if ((bool)((TechProcess005DTO)techProcess005).OldTechProcess)
                    {
                        techProcess005Edit.Properties.Buttons[0].Enabled = false;
                        techProcess005Edit.Properties.Buttons[1].Enabled = true;
                        techProcess005Edit.Properties.Buttons[2].Enabled = true;
                        techProcess005Edit.Properties.Buttons[3].Enabled = false;
                        techProcess005Edit.Properties.Buttons[4].Enabled = true;
                        techProcess005Edit.Properties.Buttons[5].Enabled = true;


                    }
                    else
                    {
                        techProcess005Edit.Properties.Buttons[0].Enabled = false;
                        techProcess005Edit.Properties.Buttons[1].Enabled = true;
                        techProcess005Edit.Properties.Buttons[2].Enabled = true;
                        techProcess005Edit.Properties.Buttons[3].Enabled = true;
                        techProcess005Edit.Properties.Buttons[4].Enabled = true;
                        techProcess005Edit.Properties.Buttons[5].Enabled = true;
                    }
                }
                else
                {
                    techProcess005Edit.Properties.Buttons[0].Enabled = true;
                    techProcess005Edit.Properties.Buttons[1].Enabled = false;
                    techProcess005Edit.Properties.Buttons[2].Enabled = false;
                    techProcess005Edit.Properties.Buttons[3].Enabled = false;
                    techProcess005Edit.Properties.Buttons[4].Enabled = false;
                    techProcess005Edit.Properties.Buttons[5].Enabled = false;
                }
            }
        }


        private void numberEdit_EditValueChanged(object sender, EventArgs e)
        {
            //if (numberEdit.EditValue != DBNull.Value && numberEdit.EditValue != null && FormReady)
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
                dateEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).CreateDate.Value.ToShortDateString();
                weightEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).DetailWeight;
                typeEdit.EditValue = ((DrawingDTO)numberEdit.GetSelectedDataRow()).TypeName;
                assemblyEditCheck.Checked = (bool)((DrawingDTO)numberEdit.GetSelectedDataRow()).Assembly;
                //var ggg = ((DrawingDTO)numberEdit.GetSelectedDataRow()).Note.ToString();
                noteEdit.Text = ((DrawingDTO)numberEdit.GetSelectedDataRow()).Note!=null? ((DrawingDTO)numberEdit.GetSelectedDataRow()).Note.ToString():"";
                

                drawingScanList = drawingService.GetDravingScanById(((DrawingDTO)numberEdit.GetSelectedDataRow()).Id).ToList();
                drawingsScanBS.DataSource = drawingScanList;
                drawingScanEdit.Properties.DataSource = drawingsScanBS;

                if (drawingsScanBS.Count > 0)
                    drawingScanEdit.EditValue = drawingScanList[0].Id;
                else
                    drawingScanEdit.EditValue = null;

                if (!(bool)((DrawingDTO)numberEdit.GetSelectedDataRow()).Assembly)
                {
                    techProcessPanel.Enabled = true;
                    techProcess001Edit.Enabled = true;
                    techProcess002Edit.Enabled = true;
                    techProcess003Edit.Enabled = true;
                    techProcess004Edit.Enabled = true;
                    techProcess005Edit.Enabled = true;

                    var techProcess001 = techProcessService.GetTechProcess001ByDrawingId((int)key);
                    var techProcess002 = techProcessService.GetTechProcess002ByDrawingId((int)key);
                    var techProcess003 = techProcessService.GetTechProcess003ByDrawingId((int)key);
                    var techProcess004 = techProcessService.GetTechProcess004ByDrawingId((int)key);
                    var techProcess005 = techProcessService.GetTechProcess005ByDrawingId((int)key);

                    //TechProcess001Ready = false;
                    if (techProcess001 != null)
                    {


                        techProcess001BS.DataSource = techProcessService.GetAllTechProcess001();
                        techProcess001Edit.EditValue = ((TechProcess001DTO)techProcess001).Id;
                        //((DrawingsDTO)Item).TechProcess001Id = ((TechProcess001DTO)techProcess001).Id;
                        if ((bool)((TechProcess001DTO)techProcess001).OldTechProcess)
                        {
                            techProcess001Edit.Properties.Buttons[0].Enabled = false;
                            techProcess001Edit.Properties.Buttons[1].Enabled = true;
                            techProcess001Edit.Properties.Buttons[2].Enabled = true;
                            techProcess001Edit.Properties.Buttons[3].Enabled = false;
                            techProcess001Edit.Properties.Buttons[4].Enabled = true;
                            techProcess001Edit.Properties.Buttons[5].Enabled = true;
                        }
                        else
                        {
                            techProcess001Edit.Properties.Buttons[0].Enabled = false;
                            techProcess001Edit.Properties.Buttons[1].Enabled = true;
                            techProcess001Edit.Properties.Buttons[2].Enabled = true;
                            techProcess001Edit.Properties.Buttons[3].Enabled = true;
                            techProcess001Edit.Properties.Buttons[4].Enabled = true;
                            techProcess001Edit.Properties.Buttons[5].Enabled = true;
                        }
                    }
                    else
                    {
                        techProcess001Edit.EditValue = null;
                        //((DrawingsDTO)Item).TechProcess001Id = null;
                        techProcess001Edit.Properties.Buttons[0].Enabled = true;
                        techProcess001Edit.Properties.Buttons[1].Enabled = false;
                        techProcess001Edit.Properties.Buttons[2].Enabled = false;
                        techProcess001Edit.Properties.Buttons[3].Enabled = false;
                        techProcess001Edit.Properties.Buttons[4].Enabled = false;
                        techProcess001Edit.Properties.Buttons[5].Enabled = false;
                    }
                    TechProcess001Ready = true; ;


                    if (techProcess002 != null)
                    {
                        techProcess002BS.DataSource = techProcessService.GetAllTechProcess002();
                        techProcess002Edit.EditValue = ((TechProcess002DTO)techProcess002).Id;
                        //((DrawingsDTO)Item).TechProcess001Id = ((TechProcess001DTO)techProcess001).Id;
                        if ((bool)((TechProcess002DTO)techProcess002).OldTechProcess)
                        {
                            techProcess002Edit.Properties.Buttons[0].Enabled = false;
                            techProcess002Edit.Properties.Buttons[1].Enabled = true;
                            techProcess002Edit.Properties.Buttons[2].Enabled = true;
                            techProcess002Edit.Properties.Buttons[3].Enabled = false;
                            techProcess002Edit.Properties.Buttons[4].Enabled = true;
                            techProcess002Edit.Properties.Buttons[5].Enabled = true;
                        }
                        else
                        {
                            techProcess002Edit.Properties.Buttons[0].Enabled = false;
                            techProcess002Edit.Properties.Buttons[1].Enabled = true;
                            techProcess002Edit.Properties.Buttons[2].Enabled = true;
                            techProcess002Edit.Properties.Buttons[3].Enabled = true;
                            techProcess002Edit.Properties.Buttons[4].Enabled = true;
                            techProcess002Edit.Properties.Buttons[5].Enabled = true;
                        }
                    }
                    else
                    {
                        techProcess002Edit.EditValue = null;
                        //((DrawingsDTO)Item).TechProcess001Id = null;
                        techProcess002Edit.Properties.Buttons[0].Enabled = true;
                        techProcess002Edit.Properties.Buttons[1].Enabled = false;
                        techProcess002Edit.Properties.Buttons[2].Enabled = false;
                        techProcess002Edit.Properties.Buttons[3].Enabled = false;
                        techProcess002Edit.Properties.Buttons[4].Enabled = false;
                        techProcess002Edit.Properties.Buttons[5].Enabled = false;
                    }

                    if (techProcess003 != null)
                    {
                        techProcess003BS.DataSource = drawingService.GetAllTechProcess003();
                        techProcess003Edit.EditValue = ((TechProcess003DTO)techProcess003).Id;
                        //((DrawingsDTO)Item).TechProcess001Id = ((TechProcess001DTO)techProcess001).Id;
                        if ((bool)((TechProcess003DTO)techProcess003).OldTechProcess)
                        {
                            techProcess003Edit.Properties.Buttons[0].Enabled = false;
                            techProcess003Edit.Properties.Buttons[1].Enabled = true;
                            techProcess003Edit.Properties.Buttons[2].Enabled = true;
                            techProcess003Edit.Properties.Buttons[3].Enabled = false;
                            techProcess003Edit.Properties.Buttons[4].Enabled = true;
                            techProcess003Edit.Properties.Buttons[5].Enabled = true;
                        }
                        else
                        {
                            techProcess003Edit.Properties.Buttons[0].Enabled = false;
                            techProcess003Edit.Properties.Buttons[1].Enabled = true;
                            techProcess003Edit.Properties.Buttons[2].Enabled = true;
                            techProcess003Edit.Properties.Buttons[3].Enabled = true;
                            techProcess003Edit.Properties.Buttons[4].Enabled = true;
                            techProcess003Edit.Properties.Buttons[5].Enabled = true;
                        }
                    }
                    else
                    {
                        techProcess003Edit.EditValue = null;
                        //((DrawingsDTO)Item).TechProcess001Id = null;
                        techProcess003Edit.Properties.Buttons[0].Enabled = true;
                        techProcess003Edit.Properties.Buttons[1].Enabled = false;
                        techProcess003Edit.Properties.Buttons[2].Enabled = false;
                        techProcess003Edit.Properties.Buttons[3].Enabled = false;
                        techProcess003Edit.Properties.Buttons[4].Enabled = false;
                        techProcess003Edit.Properties.Buttons[5].Enabled = false;
                    }

                    if (techProcess004 != null)
                    {
                        techProcess004BS.DataSource = drawingService.GetAllTechProcess004();
                        techProcess004Edit.EditValue = ((TechProcess004DTO)techProcess004).Id;
                        //((DrawingsDTO)Item).TechProcess001Id = ((TechProcess001DTO)techProcess001).Id;
                        if ((bool)((TechProcess004DTO)techProcess004).OldTechProcess)
                        {
                            techProcess004Edit.Properties.Buttons[0].Enabled = false;
                            techProcess004Edit.Properties.Buttons[1].Enabled = true;
                            techProcess004Edit.Properties.Buttons[2].Enabled = true;
                            techProcess004Edit.Properties.Buttons[3].Enabled = false;
                            techProcess004Edit.Properties.Buttons[4].Enabled = true;
                            techProcess004Edit.Properties.Buttons[5].Enabled = true;
                        }
                        else
                        {
                            techProcess004Edit.Properties.Buttons[0].Enabled = false;
                            techProcess004Edit.Properties.Buttons[1].Enabled = true;
                            techProcess004Edit.Properties.Buttons[2].Enabled = true;
                            techProcess004Edit.Properties.Buttons[3].Enabled = true;
                            techProcess004Edit.Properties.Buttons[4].Enabled = true;
                            techProcess004Edit.Properties.Buttons[5].Enabled = true;
                        }
                    }
                    else
                    {
                        techProcess004Edit.EditValue = null;
                        //((DrawingsDTO)Item).TechProcess001Id = null;
                        techProcess004Edit.Properties.Buttons[0].Enabled = true;
                        techProcess004Edit.Properties.Buttons[1].Enabled = false;
                        techProcess004Edit.Properties.Buttons[2].Enabled = false;
                        techProcess004Edit.Properties.Buttons[3].Enabled = false;
                        techProcess004Edit.Properties.Buttons[4].Enabled = false;
                        techProcess004Edit.Properties.Buttons[5].Enabled = false;
                    }

                    if (techProcess005 != null)
                    {
                        techProcess005BS.DataSource = drawingService.GetAllTechProcess005();
                        techProcess005Edit.EditValue = ((TechProcess005DTO)techProcess005).Id;
                        //((DrawingsDTO)Item).TechProcess001Id = ((TechProcess001DTO)techProcess001).Id;
                        if ((bool)((TechProcess005DTO)techProcess005).OldTechProcess)
                        {
                            techProcess005Edit.Properties.Buttons[0].Enabled = false;
                            techProcess005Edit.Properties.Buttons[1].Enabled = true;
                            techProcess005Edit.Properties.Buttons[2].Enabled = true;
                            techProcess005Edit.Properties.Buttons[3].Enabled = false;
                            techProcess005Edit.Properties.Buttons[4].Enabled = true;
                            techProcess005Edit.Properties.Buttons[5].Enabled = true;
                        }
                        else
                        {
                            techProcess005Edit.Properties.Buttons[0].Enabled = false;
                            techProcess005Edit.Properties.Buttons[1].Enabled = true;
                            techProcess005Edit.Properties.Buttons[2].Enabled = true;
                            techProcess005Edit.Properties.Buttons[3].Enabled = true;
                            techProcess005Edit.Properties.Buttons[4].Enabled = true;
                            techProcess005Edit.Properties.Buttons[5].Enabled = true;
                        }
                    }
                    else
                    {
                        techProcess005Edit.EditValue = null;
                        //((DrawingsDTO)Item).TechProcess001Id = null;
                        techProcess005Edit.Properties.Buttons[0].Enabled = true;
                        techProcess005Edit.Properties.Buttons[1].Enabled = false;
                        techProcess005Edit.Properties.Buttons[2].Enabled = false;
                        techProcess005Edit.Properties.Buttons[3].Enabled = false;
                        techProcess005Edit.Properties.Buttons[4].Enabled = false;
                        techProcess005Edit.Properties.Buttons[5].Enabled = false;
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
            else
            {
                //CheckTechProcess001();
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
                            numberEdit.Properties.NullText = "";
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
            techProcessService = Program.kernel.Get<ITechProcessService>();
            switch (e.Button.Index)
            {
                case 0: //Додати
                    {

                        //if (drawingService.CheckDrivingChild((int)((DrawingsDTO)Item).DrawingId))
                        //{
                        //    MessageBox.Show("Сборка содержит узлы, не возможно добавить этот вид техпроцесса", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    return;
                        //}

                        TechProcess002DTO addTechProcessDTO = new TechProcess002DTO();
                        //addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
                        addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;
                        addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;

                        using (TechProcess002EditFm techProcess002EditFm = new TechProcess002EditFm(usersDTO, Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
                        {
                            if (techProcess002EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess002Edit.Properties.DataSource = techProcessService.GetAllTechProcess002();
                                int return_Id = techProcess002EditFm.Return().Id;
                                techProcess002Edit.EditValue = return_Id;

                                if ((bool)techProcess002EditFm.Return().OldTechProcess)
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
                        if (techProcess002Edit.EditValue == DBNull.Value || techProcess002Edit.EditValue == null)
                            return;

                        TechProcess002DTO techProcess002 = techProcessService.GetTechProcess002ByDrawingId((int)((DrawingsDTO)Item).DrawingId);

                        using (TechProcess002EditFm techProcess002EditFm = new TechProcess002EditFm(usersDTO, Utils.Operation.Update, techProcess002))
                        {
                            if (techProcess002EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess002Edit.Properties.DataSource = techProcessService.GetAllTechProcess002();
                                int return_Id = techProcess002EditFm.Return().Id;
                                techProcess002Edit.EditValue = return_Id;

                            }
                        }
                        break;
                    }
                case 2://Видалити
                    {
                        if (techProcess002Edit.EditValue == DBNull.Value || techProcess002Edit.EditValue == null)
                            return;

                        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            techProcessService = Program.kernel.Get<ITechProcessService>();
                            //получаем айди ревизии техпроцесса, чтобы потом коректно показать что у техпроцесса есть ревизия
                            var Child = techProcessService.GetTechProcess002RevisionByIdFull((int)techProcess002Edit.EditValue);

                            //пробуем удалить информацию о техпроцессе в базе, если получается, удаляем файл техпроцесса в файловой БД
                            if (techProcessService.TechProcess002Delete((int)techProcess002Edit.EditValue))
                                MessageBox.Show("Техпроцесс был успешно удалён!", "Потверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("При удалении техпроцесса возникла ошибка, возможно файл техпроцесса открыт в проводнике!", "Потверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //если у техпроцесса была ревизия, отбражаем её
                            //CheckTechProcess001();

                            if (Child != null)
                            {
                                techProcess002Edit.EditValue = ((TechProcess002DTO)Child).Id;
                            }
                            else
                            {
                                techProcess002Edit.EditValue = null;
                                techProcess002Edit.Properties.NullText = "";
                            }
                        }

                        break;
                    }
                case 3://Создать ревизию
                    {
                        //if (techProcess002Edit.EditValue == DBNull.Value || techProcess002Edit.EditValue == null)
                        //    return;

                        //drawingService = Program.kernel.Get<IDrawingService>();
                        //TechProcess002DTO techProcess002OldDTO = drawingService.GetTechProcess002ByDrawingId((int)((DrawingsDTO)Item).DrawingId);
                        //TechProcess002DTO addTechProcessRevisionDTO = new TechProcess002DTO();

                        //addTechProcessRevisionDTO = (TechProcess002DTO)techProcess002OldDTO.Clone();

                        //addTechProcessRevisionDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;
                        //addTechProcessRevisionDTO.RevisionId = techProcess002OldDTO.RevisionId;
                        //addTechProcessRevisionDTO.TechProcessName = techProcess002OldDTO.TechProcessName;
                        //addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        //addTechProcessRevisionDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;

                        ////if (((DrawingsDTO)Item).RevisionName != null)
                        ////    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        ////else
                        ////    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;

                        //using (TechProcess002EditFm techProcess002EditFm = new TechProcess002EditFm(usersDTO, Utils.Operation.Custom, addTechProcessRevisionDTO, ((DrawingsDTO)Item), techProcess002OldDTO))
                        //{
                        //    if (techProcess002EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        techProcess002Edit.Properties.DataSource = drawingService.GetAllTechProcess002();
                        //        int return_Id = techProcess002EditFm.Return().Id;
                        //        techProcess002Edit.EditValue = return_Id;
                        //    }
                        //}

                        break;
                    }
                case 4://просмотр
                    {
                        if (techProcess002Edit.EditValue == DBNull.Value || techProcess002Edit.EditValue == null)
                            return;

                        TechProcess002DTO techProcess002 = drawingService.GetTechProcess002ByIdFull((int)techProcess002Edit.EditValue);

                        TestFm testFm = new TestFm(techProcess002.TechProcessPath);
                        testFm.Show();

                        break;
                    }
                case 5://убрать привязку
                    {
                        if (techProcess002Edit.EditValue == DBNull.Value || techProcess002Edit.EditValue == null)
                            return;
                        if (MessageBox.Show("Отвязать техпроцесс от чертежа?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<TechProcess002DTO> techProcessWithRevision = drawingService.GetAllTechProcess002RevisionWithActualTechprocess((int)techProcess002Edit.EditValue).ToList();

                            foreach (var item in techProcessWithRevision)
                            {
                                item.CopyDrawingId = item.DrawingId;
                                item.DrawingId = null;
                                item.TypeId = 2;
                                drawingService.TechProcess002Update(item);
                            }

                            techProcess002Edit.EditValue = null;
                            techProcess002Edit.Properties.NullText = "";
                        }

                        break;
                    }
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

                        string ggg = Properties.Settings.Default.UserDirectoryPath;

                        if (Properties.Settings.Default.UserDirectoryPath == "" && !Directory.Exists(Properties.Settings.Default.UserDirectoryPath))
                        {
                            MessageBox.Show("В настройках не указан путь к базе техпроцессов или указанная папка не существует!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


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
                            var Child = drawingService.GetTechProcess001RevisionByIdFull((int)techProcess001Edit.EditValue);

                            //пробуем удалить информацию о техпроцессе в базе, если получается, удаляем файл техпроцесса в файловой БД
                            if (drawingService.TechProcess001Delete((int)techProcess001Edit.EditValue))
                                MessageBox.Show("Техпроцесс был успешно удалён!", "Потверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("При удалении техпроцесса возникла ошибка, возможно файл техпроцесса открыт в проводнике!", "Потверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //если у техпроцесса была ревизия, отбражаем её
                            //CheckTechProcess001();

                            if (Child != null)
                            {
                                techProcess001Edit.EditValue = ((TechProcess001DTO)Child).Id;
                            }
                            else
                            {
                                techProcess001Edit.EditValue = null;
                                techProcess001Edit.Properties.NullText = "";
                            }
                        }

                        break;
                    }
                case 3://Создать ревизию
                    {
                        //if (techProcess001Edit.EditValue == DBNull.Value || techProcess001Edit.EditValue == null)
                        //    return;

                        //drawingService = Program.kernel.Get<IDrawingService>();
                        //TechProcess001DTO techProcess001OldDTO = drawingService.GetTechProcess001ByDrawingId((int)((DrawingsDTO)Item).DrawingId);
                        //TechProcess001DTO addTechProcessRevisionDTO = new TechProcess001DTO();

                        //addTechProcessRevisionDTO = (TechProcess001DTO)techProcess001OldDTO.Clone();

                        //addTechProcessRevisionDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;
                        //addTechProcessRevisionDTO.RevisionId = techProcess001OldDTO.RevisionId;
                        //addTechProcessRevisionDTO.TechProcessName = techProcess001OldDTO.TechProcessName;
                        //addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        //addTechProcessRevisionDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;

                        ////if (((DrawingsDTO)Item).RevisionName != null)
                        ////    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        ////else
                        ////    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;

                        //using (TechProcess001EditFm techProcess001EditFm = new TechProcess001EditFm(usersDTO, Utils.Operation.Custom, addTechProcessRevisionDTO, ((DrawingsDTO)Item), techProcess001OldDTO))
                        //{
                        //    if (techProcess001EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        techProcess001Edit.Properties.DataSource = drawingService.GetAllTechProcess001();
                        //        int return_Id = techProcess001EditFm.Return().Id;
                        //        techProcess001Edit.EditValue = return_Id;
                        //    }
                        //}

                        break;
                    }
                case 4://просмотр
                    {
                        if (techProcess001Edit.EditValue == DBNull.Value || techProcess001Edit.EditValue == null)
                            return;

                        TechProcess001DTO techProcess001 = drawingService.GetTechProcess001ByIdFull((int)techProcess001Edit.EditValue);

                        TestFm testFm = new TestFm(techProcess001.TechProcessPath);
                        testFm.Show();

                        break;
                    }
                case 5://убрать привязку
                    {
                        if (techProcess001Edit.EditValue == DBNull.Value || techProcess001Edit.EditValue == null)
                            return;
                        if (MessageBox.Show("Отвязать техпроцесс от чертежа?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<TechProcess001DTO> techProcessWithRevision = drawingService.GetAllTechProcess001RevisionWithActualTechprocess((int)techProcess001Edit.EditValue).ToList();

                            foreach (var item in techProcessWithRevision)
                            {
                                item.CopyDrawingId = item.DrawingId;
                                item.DrawingId = null;
                                item.TypeId = 2;
                                drawingService.TechProcess001Update(item);
                            }

                            techProcess001Edit.EditValue = null;
                            techProcess001Edit.Properties.NullText = "";
                        }

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
            //if (numberEdit.EditValue == null || numberEdit.EditValue == DBNull.Value)
            //{
            //    MessageBox.Show("Нету чертежа", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    return;
            //}
            //else
            //{
            //    if (MessageBox.Show("Заменить чертёж?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {

            //    }
            //    else
            //        return;

            //}
        }

        private void techProcess002Edit_EditValueChanged(object sender, EventArgs e)
        {
            CheckTechProcess002();
        }

        #region TechProcess 003

        private void techProcess003Edit_ButtonClick(object sender, ButtonPressedEventArgs e)
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

                        TechProcess003DTO addTechProcessDTO = new TechProcess003DTO();
                        //addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
                        addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;
                        addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;

                        using (TechProcess003EditFm techProcess003EditFm = new TechProcess003EditFm(usersDTO, Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
                        {
                            if (techProcess003EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess003Edit.Properties.DataSource = drawingService.GetAllTechProcess003();
                                int return_Id = techProcess003EditFm.Return().Id;
                                techProcess003Edit.EditValue = return_Id;

                                if ((bool)techProcess003EditFm.Return().OldTechProcess)
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
                        if (techProcess003Edit.EditValue == DBNull.Value || techProcess003Edit.EditValue == null)
                            return;

                        TechProcess003DTO techProcess003 = drawingService.GetTechProcess003ByDrawingId((int)((DrawingsDTO)Item).DrawingId);

                        using (TechProcess003EditFm techProcess003EditFm = new TechProcess003EditFm(usersDTO, Utils.Operation.Update, techProcess003))
                        {
                            if (techProcess003EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess003Edit.Properties.DataSource = drawingService.GetAllTechProcess003();
                                int return_Id = techProcess003EditFm.Return().Id;
                                techProcess003Edit.EditValue = return_Id;

                            }
                        }
                        break;
                    }
                case 2://Видалити
                    {
                        if (techProcess003Edit.EditValue == DBNull.Value || techProcess003Edit.EditValue == null)
                            return;

                        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService = Program.kernel.Get<IDrawingService>();
                            //получаем айди ревизии техпроцесса, чтобы потом коректно показать что у техпроцесса есть ревизия
                            var Child = drawingService.GetTechProcess003RevisionByIdFull((int)techProcess003Edit.EditValue);

                            //пробуем удалить информацию о техпроцессе в базе, если получается, удаляем файл техпроцесса в файловой БД
                            if (drawingService.TechProcess003Delete((int)techProcess003Edit.EditValue))
                                MessageBox.Show("Техпроцесс был успешно удалён!", "Потверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("При удалении техпроцесса возникла ошибка, возможно файл техпроцесса открыт в проводнике!", "Потверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //если у техпроцесса была ревизия, отбражаем её
                            //CheckTechProcess001();

                            if (Child != null)
                            {
                                techProcess003Edit.EditValue = ((TechProcess003DTO)Child).Id;
                            }
                            else
                            {
                                techProcess003Edit.EditValue = null;
                                techProcess003Edit.Properties.NullText = "";
                            }
                        }

                        break;
                    }
                case 3://Создать ревизию
                    {
                        //if (techProcess003Edit.EditValue == DBNull.Value || techProcess003Edit.EditValue == null)
                        //    return;

                        //drawingService = Program.kernel.Get<IDrawingService>();
                        //TechProcess003DTO techProcess003OldDTO = drawingService.GetTechProcess003ByDrawingId((int)((DrawingsDTO)Item).DrawingId);
                        //TechProcess003DTO addTechProcessRevisionDTO = new TechProcess003DTO();

                        //addTechProcessRevisionDTO = (TechProcess003DTO)techProcess003OldDTO.Clone();

                        //addTechProcessRevisionDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;
                        //addTechProcessRevisionDTO.RevisionId = techProcess003OldDTO.RevisionId;
                        //addTechProcessRevisionDTO.TechProcessName = techProcess003OldDTO.TechProcessName;
                        //addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        //addTechProcessRevisionDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;

                        ////if (((DrawingsDTO)Item).RevisionName != null)
                        ////    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        ////else
                        ////    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;

                        //using (TechProcess003EditFm techProcess003EditFm = new TechProcess003EditFm(usersDTO, Utils.Operation.Custom, addTechProcessRevisionDTO, ((DrawingsDTO)Item), techProcess003OldDTO))
                        //{
                        //    if (techProcess003EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        techProcess003Edit.Properties.DataSource = drawingService.GetAllTechProcess003();
                        //        int return_Id = techProcess003EditFm.Return().Id;
                        //        techProcess003Edit.EditValue = return_Id;
                        //    }
                        //}

                        break;
                    }
                case 4://просмотр
                    {
                        if (techProcess003Edit.EditValue == DBNull.Value || techProcess003Edit.EditValue == null)
                            return;

                        TechProcess003DTO techProcess003 = drawingService.GetTechProcess003ByIdFull((int)techProcess003Edit.EditValue);

                        TestFm testFm = new TestFm(techProcess003.TechProcessPath);
                        testFm.Show();

                        break;
                    }
                case 5://убрать привязку
                    {
                        if (techProcess003Edit.EditValue == DBNull.Value || techProcess003Edit.EditValue == null)
                            return;
                        if (MessageBox.Show("Отвязать техпроцесс от чертежа?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<TechProcess003DTO> techProcessWithRevision = drawingService.GetAllTechProcess003RevisionWithActualTechprocess((int)techProcess003Edit.EditValue).ToList();

                            foreach (var item in techProcessWithRevision)
                            {
                                item.CopyDrawingId = item.DrawingId;
                                item.DrawingId = null;
                                item.TypeId = 2;
                                drawingService.TechProcess003Update(item);
                            }

                            techProcess003Edit.EditValue = null;
                            techProcess003Edit.Properties.NullText = "";
                        }

                        break;
                    }
            }
        }


        #endregion

        private void techProcess003Edit_EditValueChanged(object sender, EventArgs e)
        {
            CheckTechProcess003();
        }

        private void techProcess004Edit_EditValueChanged(object sender, EventArgs e)
        {
            CheckTechProcess004();
        }

        private void techProcess005Edit_EditValueChanged(object sender, EventArgs e)
        {
            CheckTechProcess005();
        }

        private void techProcess004Edit_ButtonClick(object sender, ButtonPressedEventArgs e)
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

                        TechProcess004DTO addTechProcessDTO = new TechProcess004DTO();
                        //addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
                        addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;
                        addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;

                        using (TechProcess004EditFm techProcess004EditFm = new TechProcess004EditFm(usersDTO, Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
                        {
                            if (techProcess004EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess004Edit.Properties.DataSource = drawingService.GetAllTechProcess004();
                                int return_Id = techProcess004EditFm.Return().Id;
                                techProcess004Edit.EditValue = return_Id;

                                if ((bool)techProcess004EditFm.Return().OldTechProcess)
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
                        if (techProcess004Edit.EditValue == DBNull.Value || techProcess004Edit.EditValue == null)
                            return;

                        TechProcess004DTO techProcess004 = drawingService.GetTechProcess004ByDrawingId((int)((DrawingsDTO)Item).DrawingId);

                        using (TechProcess004EditFm techProcess004EditFm = new TechProcess004EditFm(usersDTO, Utils.Operation.Update, techProcess004))
                        {
                            if (techProcess004EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess004Edit.Properties.DataSource = drawingService.GetAllTechProcess004();
                                int return_Id = techProcess004EditFm.Return().Id;
                                techProcess004Edit.EditValue = return_Id;

                            }
                        }
                        break;
                    }
                case 2://Видалити
                    {
                        if (techProcess004Edit.EditValue == DBNull.Value || techProcess004Edit.EditValue == null)
                            return;

                        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService = Program.kernel.Get<IDrawingService>();
                            //получаем айди ревизии техпроцесса, чтобы потом коректно показать что у техпроцесса есть ревизия
                            var Child = drawingService.GetTechProcess004RevisionByIdFull((int)techProcess004Edit.EditValue);

                            //пробуем удалить информацию о техпроцессе в базе, если получается, удаляем файл техпроцесса в файловой БД
                            if (drawingService.TechProcess004Delete((int)techProcess004Edit.EditValue))
                                MessageBox.Show("Техпроцесс был успешно удалён!", "Потверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("При удалении техпроцесса возникла ошибка, возможно файл техпроцесса открыт в проводнике!", "Потверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //если у техпроцесса была ревизия, отбражаем её
                            //CheckTechProcess001();

                            if (Child != null)
                            {
                                techProcess004Edit.EditValue = ((TechProcess004DTO)Child).Id;
                            }
                            else
                            {
                                techProcess004Edit.EditValue = null;
                                techProcess004Edit.Properties.NullText = "";
                            }
                        }

                        break;
                    }
                case 3://Создать ревизию
                    {
                        //if (techProcess004Edit.EditValue == DBNull.Value || techProcess004Edit.EditValue == null)
                        //    return;

                        //drawingService = Program.kernel.Get<IDrawingService>();
                        //TechProcess004DTO techProcess004OldDTO = drawingService.GetTechProcess004ByDrawingId((int)((DrawingsDTO)Item).DrawingId);
                        //TechProcess004DTO addTechProcessRevisionDTO = new TechProcess004DTO();

                        //addTechProcessRevisionDTO = (TechProcess004DTO)techProcess004OldDTO.Clone();

                        //addTechProcessRevisionDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;
                        //addTechProcessRevisionDTO.RevisionId = techProcess004OldDTO.RevisionId;
                        //addTechProcessRevisionDTO.TechProcessName = techProcess004OldDTO.TechProcessName;
                        //addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        //addTechProcessRevisionDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;

                        ////if (((DrawingsDTO)Item).RevisionName != null)
                        ////    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        ////else
                        ////    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;

                        //using (TechProcess004EditFm techProcess004EditFm = new TechProcess004EditFm(usersDTO, Utils.Operation.Custom, addTechProcessRevisionDTO, ((DrawingsDTO)Item), techProcess004OldDTO))
                        //{
                        //    if (techProcess004EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        techProcess004Edit.Properties.DataSource = drawingService.GetAllTechProcess004();
                        //        int return_Id = techProcess004EditFm.Return().Id;
                        //        techProcess004Edit.EditValue = return_Id;
                        //    }
                        //}

                        break;
                    }
                case 4://просмотр
                    {
                        if (techProcess004Edit.EditValue == DBNull.Value || techProcess004Edit.EditValue == null)
                            return;

                        TechProcess004DTO techProcess004 = drawingService.GetTechProcess004ByIdFull((int)techProcess004Edit.EditValue);

                        TestFm testFm = new TestFm(techProcess004.TechProcessPath);
                        testFm.Show();

                        break;
                    }
                case 5://убрать привязку
                    {
                        if (techProcess004Edit.EditValue == DBNull.Value || techProcess004Edit.EditValue == null)
                            return;
                        if (MessageBox.Show("Отвязать техпроцесс от чертежа?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<TechProcess004DTO> techProcessWithRevision = drawingService.GetAllTechProcess004RevisionWithActualTechprocess((int)techProcess004Edit.EditValue).ToList();

                            foreach (var item in techProcessWithRevision)
                            {
                                item.CopyDrawingId = item.DrawingId;
                                item.DrawingId = null;
                                item.TypeId = 2;
                                drawingService.TechProcess004Update(item);
                            }

                            techProcess004Edit.EditValue = null;
                            techProcess004Edit.Properties.NullText = "";
                        }

                        break;
                    }
            }
        }

        private void techProcess005Edit_ButtonClick(object sender, ButtonPressedEventArgs e)
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

                        string ggg = Properties.Settings.Default.UserDirectoryPath;

                        if (Properties.Settings.Default.UserDirectoryPath == "" && !Directory.Exists(Properties.Settings.Default.UserDirectoryPath))
                        {
                            MessageBox.Show("В настройках не указан путь к базе техпроцессов или указанная папка не существует!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                        TechProcess005DTO addTechProcessDTO = new TechProcess005DTO();
                        //addTechProcessDTO.DrawingsId = ((DrawingsDTO)Item).Id;
                        addTechProcessDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        addTechProcessDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;
                        addTechProcessDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;

                        using (TechProcess005EditFm techProcess005EditFm = new TechProcess005EditFm(usersDTO, Utils.Operation.Add, addTechProcessDTO, ((DrawingsDTO)Item)))
                        {
                            if (techProcess005EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess005Edit.Properties.DataSource = drawingService.GetAllTechProcess005();
                                int return_Id = techProcess005EditFm.Return().Id;
                                techProcess005Edit.EditValue = return_Id;

                                if ((bool)techProcess005EditFm.Return().OldTechProcess)
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
                        if (techProcess005Edit.EditValue == DBNull.Value || techProcess005Edit.EditValue == null)
                            return;

                        TechProcess005DTO techProcess005 = drawingService.GetTechProcess005ByDrawingId((int)((DrawingsDTO)Item).DrawingId);

                        using (TechProcess005EditFm techProcess005EditFm = new TechProcess005EditFm(usersDTO, Utils.Operation.Update, techProcess005))
                        {
                            if (techProcess005EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                techProcess005Edit.Properties.DataSource = drawingService.GetAllTechProcess005();
                                int return_Id = techProcess005EditFm.Return().Id;
                                techProcess005Edit.EditValue = return_Id;

                            }
                        }
                        break;
                    }
                case 2://Видалити
                    {
                        if (techProcess005Edit.EditValue == DBNull.Value || techProcess005Edit.EditValue == null)
                            return;

                        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            drawingService = Program.kernel.Get<IDrawingService>();
                            //получаем айди ревизии техпроцесса, чтобы потом коректно показать что у техпроцесса есть ревизия
                            var Child = drawingService.GetTechProcess005RevisionByIdFull((int)techProcess005Edit.EditValue);

                            //пробуем удалить информацию о техпроцессе в базе, если получается, удаляем файл техпроцесса в файловой БД
                            if (drawingService.TechProcess005Delete((int)techProcess005Edit.EditValue))
                                MessageBox.Show("Техпроцесс был успешно удалён!", "Потверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("При удалении техпроцесса возникла ошибка, возможно файл техпроцесса открыт в проводнике!", "Потверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //если у техпроцесса была ревизия, отбражаем её
                            //CheckTechProcess001();

                            if (Child != null)
                            {
                                techProcess005Edit.EditValue = ((TechProcess005DTO)Child).Id;
                            }
                            else
                            {
                                techProcess005Edit.EditValue = null;
                                techProcess005Edit.Properties.NullText = "";
                            }
                        }

                        break;
                    }
                case 3://Создать ревизию
                    {
                        //if (techProcess005Edit.EditValue == DBNull.Value || techProcess005Edit.EditValue == null)
                        //    return;

                        //drawingService = Program.kernel.Get<IDrawingService>();
                        //TechProcess005DTO techProcess005OldDTO = drawingService.GetTechProcess005ByDrawingId((int)((DrawingsDTO)Item).DrawingId);
                        //TechProcess005DTO addTechProcessRevisionDTO = new TechProcess005DTO();

                        //addTechProcessRevisionDTO = (TechProcess005DTO)techProcess005OldDTO.Clone();

                        //addTechProcessRevisionDTO.DrawingId = ((DrawingsDTO)Item).DrawingId;
                        //addTechProcessRevisionDTO.RevisionId = techProcess005OldDTO.RevisionId;
                        //addTechProcessRevisionDTO.TechProcessName = techProcess005OldDTO.TechProcessName;
                        //addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        //addTechProcessRevisionDTO.DrawingNumberWithRevision = ((DrawingsDTO)Item).NumberWithRevisionName;

                        ////if (((DrawingsDTO)Item).RevisionName != null)
                        ////    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;
                        ////else
                        ////    addTechProcessRevisionDTO.DrawingNumber = ((DrawingsDTO)Item).Number;

                        //using (TechProcess005EditFm techProcess005EditFm = new TechProcess005EditFm(usersDTO, Utils.Operation.Custom, addTechProcessRevisionDTO, ((DrawingsDTO)Item), techProcess005OldDTO))
                        //{
                        //    if (techProcess005EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        techProcess005Edit.Properties.DataSource = drawingService.GetAllTechProcess005();
                        //        int return_Id = techProcess005EditFm.Return().Id;
                        //        techProcess005Edit.EditValue = return_Id;
                        //    }
                        //}

                        break;
                    }
                case 4://просмотр
                    {
                        if (techProcess005Edit.EditValue == DBNull.Value || techProcess005Edit.EditValue == null)
                            return;

                        TechProcess005DTO techProcess005 = drawingService.GetTechProcess005ByIdFull((int)techProcess005Edit.EditValue);

                        TestFm testFm = new TestFm(techProcess005.TechProcessPath);
                        testFm.Show();

                        break;
                    }
                case 5://убрать привязку
                    {
                        if (techProcess005Edit.EditValue == DBNull.Value || techProcess005Edit.EditValue == null)
                            return;
                        if (MessageBox.Show("Отвязать техпроцесс от чертежа?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<TechProcess005DTO> techProcessWithRevision = drawingService.GetAllTechProcess005RevisionWithActualTechprocess((int)techProcess005Edit.EditValue).ToList();

                            foreach (var item in techProcessWithRevision)
                            {
                                item.CopyDrawingId = item.DrawingId;
                                item.DrawingId = null;
                                item.TypeId = 2;
                                drawingService.TechProcess005Update(item);
                            }

                            techProcess005Edit.EditValue = null;
                            techProcess005Edit.Properties.NullText = "";
                        }

                        break;
                    }
            }
        }
    }
}