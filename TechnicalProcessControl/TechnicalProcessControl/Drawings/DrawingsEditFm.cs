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

namespace TechnicalProcessControl.Drawings
{
    public partial class DrawingsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IDrawingService drawingService;
        private IReportService reportService;
        private IJournalService journalService;

        private Utils.Operation operation;

        private List<DrawingScanDTO> drawingScanList = new List<DrawingScanDTO>();

        private UsersTelegramDTO models;

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

        public DrawingsEditFm(DrawingsDTO model, Utils.Operation operation)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();
            journalService = Program.kernel.Get<IJournalService>();

            this.operation = operation;

            drawingsBS.DataSource = Item = model;

            materialEdit.DataBindings.Add("EditValue", drawingsBS, "MaterialId", true, DataSourceUpdateMode.OnPropertyChanged);
            wEdit.DataBindings.Add("EditValue", drawingsBS, "W", true, DataSourceUpdateMode.OnPropertyChanged);
            w2Edit.DataBindings.Add("EditValue", drawingsBS, "W2", true, DataSourceUpdateMode.OnPropertyChanged);
            lEdit.DataBindings.Add("EditValue", drawingsBS, "L", true, DataSourceUpdateMode.OnPropertyChanged);
            thEdit.DataBindings.Add("EditValue", drawingsBS, "TH", true, DataSourceUpdateMode.OnPropertyChanged);
            weightEdit.DataBindings.Add("EditValue", drawingsBS, "DetailWeight", true, DataSourceUpdateMode.OnPropertyChanged);
            numberEdit.DataBindings.Add("EditValue", drawingsBS, "Number", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityEdit.DataBindings.Add("EditValue", drawingsBS, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            currentLevelMenuEdit.DataBindings.Add("EditValue", drawingsBS, "CurrentLevelMenu", true, DataSourceUpdateMode.OnPropertyChanged);
            detailEdit.DataBindings.Add("EditValue", drawingsBS, "DetailId", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess001Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess001Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess002Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess002Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess003Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess003Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess004Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess004Id", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcess005Edit.DataBindings.Add("EditValue", drawingsBS, "TechProcess005Id", true, DataSourceUpdateMode.OnPropertyChanged);

            detailsBS.DataSource = journalService.GetDetails();
            detailEdit.Properties.DataSource = detailsBS;
            detailEdit.Properties.ValueMember = "Id";
            detailEdit.Properties.DisplayMember = "DetailName";
            detailEdit.Properties.NullText = "Немає данних";

            typeBS.DataSource = drawingService.GetType();
            typeEdit.Properties.DataSource = typeBS;
            typeEdit.Properties.ValueMember = "Id";
            typeEdit.Properties.DisplayMember = "TypeName";
            typeEdit.Properties.NullText = "Немає данних";

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

            materialsBS.DataSource = journalService.GetMaterials();
            materialEdit.Properties.DataSource = materialsBS;
            materialEdit.Properties.ValueMember = "Id";
            materialEdit.Properties.DisplayMember = "MaterialName";
            materialEdit.Properties.NullText = "Немає данних";


            if (operation == Utils.Operation.Add)
            {
                //parentCurrentLevelMenuEdit.DataBindings.Add("EditValue", drawingsBS, "ParentId", true, DataSourceUpdateMode.OnPropertyChanged);
                //((UsersTelegramDTO)Item).RegistrationDate = DateTime.Now;
                //((UsersTelegramDTO)Item).UserTelegramId = 0;
                //((UsersTelegramDTO)Item).CurrentLevelMenu = 0;
                //((UsersTelegramDTO)Item).Rules = 2;
            }
            else
            {
                //parentCurrentLevelMenuEdit.DataBindings.Add("EditValue", drawingsBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            switch (operation)
            {
                case Utils.Operation.Add:

                    parentCurrentLevelMenuEdit.DataBindings.Add("EditValue", drawingsBS, "ParentId", true, DataSourceUpdateMode.OnPropertyChanged);
                    //drawingScanDTO = new DrawingScanDTO();
                    break;

                case Utils.Operation.Update:
                    parentCurrentLevelMenuEdit.DataBindings.Add("EditValue", drawingsBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);

                    drawingScanList = drawingService.GetDravingScanById(((DrawingsDTO)Item).Id).ToList();
                    drawingsScanBS.DataSource = drawingScanList;
                    drawingScanEdit.Properties.DataSource = drawingsScanBS;
                    drawingScanEdit.Properties.ValueMember = "Id";
                    drawingScanEdit.Properties.DisplayMember = "FileName";
                    drawingScanEdit.Properties.NullText = "Немає данних";

                    //if (drawingScanList.Count > 0)
                    //    drawingScanEdit.EditValue = drawingScanList[0].Id;



                    //if (drawingScanDTO != null)
                    //{
                    //    int stratIndex = drawingScanDTO.FileName.IndexOf('.');
                    //    string typeFile = drawingScanDTO.FileName.Substring(stratIndex);

                        //    switch (typeFile)
                        //    {
                        //        //case ".pdf":
                        //        //    pictureEdit.Image = imageCollection.Images[1];
                        //        //    pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        //        //    break;
                        //        default:
                        //            //Bitmap bitmap = new Bitmap(drawingScanDTO.Scan);
                        //            ImageConverter ic = new ImageConverter();

                        //            Image img = (Image)ic.ConvertFrom(drawingScanDTO.Scan);

                        //            Bitmap bitmap1 = new Bitmap(img);

                        //            pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                        //            pictureEdit.EditValue = bitmap1;
                        //            fileNameTbox.EditValue = drawingScanDTO.FileName;

                        //            //pictureEdit.Image = Image.FromStream(drawingScanDTO.Scan);
                        //            //pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        //            break;
                        //    }

                        //    fileNameTbox.EditValue = drawingScanDTO.FileName;

                        //    byte[] scan = System.IO.File.ReadAllBytes(@filePath);

                        //    drawingScanDTO.Scan = scan;
                        //    drawingScanDTO.FileName = fileName;
                        //}
                        //else
                        //    return;

                        //try
                        //{
                        //    Bitmap bitmap = new Bitmap(filePath);
                        //    pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                        //    pictureEdit.EditValue = bitmap;
                        //    fileNameTbox.EditValue = fileName;
                        //}

                        //}
                    break;

                default:
                    MessageBox.Show("При завантаженні форми " + this.Text + " виникла помилка. ", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }



            //ControlValidation();
            //splashScreenManager.CloseWaitForm();
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
                    ((DrawingsDTO)Item).Id = drawingService.DrawingCreate((DrawingsDTO)Item);
                    return true;
                    //if (drawingScanDTO.Scan != null)
                    //{
                    //    drawingScanDTO.DrawingId = ((DrawingsDTO)Item).Id;
                    //    ((DrawingsDTO)Item).ScanId = drawingService.DrawingScanCreate(drawingScanDTO);

                    //}
                }
                else
                {

                    drawingService.DrawingUpdate((DrawingsDTO)Item);
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

                    String updateTemplate = "";

                    if (((DrawingsDTO)Item).TechProcess001Id != null)
                        if (!reportService.UpdateTemplateTechProcess001((DrawingsDTO)Item))
                            updateTemplate += "При оновленні шаблону " + ((DrawingsDTO)Item).TechProcess001Name + " виникла помилка!\n";
                    if (((DrawingsDTO)Item).TechProcess002Id != null)
                        if (!reportService.UpdateTemplateTechProcess002((DrawingsDTO)Item))
                            updateTemplate += "При оновленні шаблону " + ((DrawingsDTO)Item).TechProcess002Name + " виникла помилка!\n"; ;
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
        }

        private void drawingScanEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {

        }

        private void DrawingsEditFm_Load(object sender, EventArgs e)
        {
            if (drawingScanList.Count > 0)
                drawingScanEdit.EditValue = drawingScanList[0].Id;
        }

        private void techProcess001Edit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (TechProcess001EditFm techProcess001EditFm = new TechProcess001EditFm(new TechProcess001DTO(), (DrawingsDTO)Item))
                        {
                            if (techProcess001EditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                //detailsBS.DataSource = journalService.GetDetails();
                                techProcess001Edit.Properties.DataSource = drawingService.GetAllTechProcess001();
                                techProcess001Edit.Properties.ValueMember = "Id";
                                techProcess001Edit.Properties.DisplayMember = "TechProcessFullName";
                                techProcess001Edit.Properties.NullText = "Немає данних";


                                int return_Id = techProcess001EditFm.Return().Id;
                                techProcess001Edit.EditValue = return_Id;


                               
                            }
                        }
                        break;
                    }
                //case 2://Редагувати
                //    {
                //        if (organisationEdit.EditValue == DBNull.Value)
                //            return;

                //        using (OrganisationEditFm organisationEditFm = new OrganisationEditFm(Utils.Operation.Update, (ContractorsDTO)organisationEdit.GetSelectedDataRow()))
                //        {
                //            if (organisationEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //            {
                //                int return_Id = organisationEditFm.Return();
                //                botService = Program.kernel.Get<IBotService>();
                //                organisationBS.DataSource = botService.GetAllContractors();
                //                organisationEdit.EditValue = return_Id;
                //            }
                //        }
                //        break;
                //    }
                //case 3://Видалити
                //    {
                //        if (organisationEdit.EditValue == DBNull.Value)
                //            return;

                //        if (MessageBox.Show("Удалить?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //        {
                //            botService.ContractorDelete(((ContractorsDTO)organisationEdit.GetSelectedDataRow()).Id);
                //            botService = Program.kernel.Get<IBotService>();
                //            organisationEdit.Properties.DataSource = botService.GetAllContractors();
                //            organisationEdit.EditValue = null;
                //            organisationEdit.Properties.NullText = "Немає данних";
                //        }

                //        break;
                //    }
                //case 4://Очистити
                //    {
                //        organisationEdit.EditValue = null;
                //        organisationEdit.Properties.NullText = "Немає данних";
                //        break;
                //    }
            }
        }

        private void detailEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            journalService = Program.kernel.Get<IJournalService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (DetailsEditFm detailsEditFm = new DetailsEditFm(Utils.Operation.Add, new DetailsDTO()))
                        {
                            if (detailsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                DetailsDTO return_Id =detailsEditFm.Return();
                                detailsBS.DataSource = journalService.GetMaterials(); ;
                                detailEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (detailEdit.EditValue == DBNull.Value)
                            return;

                        using (DetailsEditFm detailsEditFm = new DetailsEditFm(Utils.Operation.Update, (DetailsDTO)detailEdit.GetSelectedDataRow()))
                        {
                            if (detailsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                DetailsDTO return_Id = detailsEditFm.Return();
                                detailsBS.DataSource = journalService.GetDetails();
                                detailEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (detailEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            journalService.DetailDelete(((DetailsDTO)detailEdit.GetSelectedDataRow()).Id);
                            detailEdit.Properties.DataSource = journalService.GetDetails();
                            detailEdit.EditValue = null;
                            detailEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        detailEdit.EditValue = null;
                        detailEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void materialEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            journalService = Program.kernel.Get<IJournalService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (MaterialEditFm materialEditFm = new MaterialEditFm(Utils.Operation.Add ,new MaterialsDTO()))
                        {
                            if (materialEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                MaterialsDTO return_Id = materialEditFm.Return();
                                materialsBS.DataSource = journalService.GetMaterials();
                                materialEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (materialEdit.EditValue == DBNull.Value)
                            return;

                        using (MaterialEditFm materialEditFm = new MaterialEditFm(Utils.Operation.Update, (MaterialsDTO)materialEdit.GetSelectedDataRow()))
                        {
                            if (materialEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                MaterialsDTO return_Id = materialEditFm.Return();
                                materialsBS.DataSource = journalService.GetMaterials();
                                materialEdit.EditValue = return_Id.Id;
                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (materialEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            journalService.MaterialsDelete(((MaterialsDTO)materialEdit.GetSelectedDataRow()).Id);
                            materialEdit.Properties.DataSource = journalService.GetDetails();
                            materialEdit.EditValue = null;
                            materialEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        materialEdit.EditValue = null;
                        materialEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }
    }
}