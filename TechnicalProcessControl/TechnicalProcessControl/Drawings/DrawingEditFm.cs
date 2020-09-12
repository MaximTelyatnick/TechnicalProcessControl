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
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.Infrastructure;
using TechnicalProcessControl.BLL.ModelsDTO;
using Ninject;
using DevExpress.XtraEditors.Controls;
using TechnicalProcessControl.Journals;

namespace TechnicalProcessControl.Drawings
{
    public partial class DrawingEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IDrawingService drawingService;
        private IJournalService journalService;

        private Utils.Operation operation;

        private BindingSource drawingBS = new BindingSource();
        private BindingSource typeBS = new BindingSource();
        private BindingSource detailsBS = new BindingSource();
        private BindingSource materialsBS = new BindingSource();
        private BindingSource drawingScanBS = new BindingSource();
        private BindingSource revisionBS = new BindingSource();

        private DrawingDTO drawingRevisionDTO = new DrawingDTO();
        private List<DrawingScanDTO> drawingScanList = new List<DrawingScanDTO>();
        private List<DrawingScanDTO> drawingScanDeleteList = new List<DrawingScanDTO>();

        private ObjectBase Item
        {
            get { return drawingBS.Current as ObjectBase; }
            set
            {
                drawingBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public DrawingEditFm(DrawingDTO model, Utils.Operation operation)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();
            journalService = Program.kernel.Get<IJournalService>();

            this.operation = operation;

            drawingScanBS.DataSource = drawingScanList;
            drawingScanGrid.DataSource = drawingScanBS;

            drawingBS.DataSource = Item = model;

            numberEdit.DataBindings.Add("EditValue", drawingBS, "Number", true, DataSourceUpdateMode.OnPropertyChanged);
            materialEdit.DataBindings.Add("EditValue", drawingBS, "MaterialId", true, DataSourceUpdateMode.OnPropertyChanged);
            typeEdit.DataBindings.Add("EditValue", drawingBS, "TypeId", true, DataSourceUpdateMode.OnPropertyChanged);
            wEdit.DataBindings.Add("EditValue", drawingBS, "W", true, DataSourceUpdateMode.OnPropertyChanged);
            w2Edit.DataBindings.Add("EditValue", drawingBS, "W2", true, DataSourceUpdateMode.OnPropertyChanged);
            lEdit.DataBindings.Add("EditValue", drawingBS, "L", true, DataSourceUpdateMode.OnPropertyChanged);
            thEdit.DataBindings.Add("EditValue", drawingBS, "TH", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityEdit.DataBindings.Add("EditValue", drawingBS, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityREdit.DataBindings.Add("EditValue", drawingBS, "QuantityR", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityLEdit.DataBindings.Add("EditValue", drawingBS, "QuantityL", true, DataSourceUpdateMode.OnPropertyChanged);
            weightEdit.DataBindings.Add("EditValue", drawingBS, "DetailWeight", true, DataSourceUpdateMode.OnPropertyChanged);
            revisionEdit.DataBindings.Add("EditValue", drawingBS, "RevisionId", true, DataSourceUpdateMode.OnPropertyChanged);
            dateEdit.DataBindings.Add("EditValue", drawingBS, "CreateDate", true, DataSourceUpdateMode.OnPropertyChanged);
            noteEdit.DataBindings.Add("EditValue", drawingBS, "Note", true, DataSourceUpdateMode.OnPropertyChanged);

            detailEdit.DataBindings.Add("EditValue", drawingBS, "DetailId", true, DataSourceUpdateMode.OnPropertyChanged);

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

            materialsBS.DataSource = journalService.GetMaterials();
            materialEdit.Properties.DataSource = materialsBS;
            materialEdit.Properties.ValueMember = "Id";
            materialEdit.Properties.DisplayMember = "MaterialName";
            materialEdit.Properties.NullText = "Немає данних";

            revisionBS.DataSource = drawingService.GetRevisions();
            revisionEdit.Properties.DataSource = revisionBS;
            revisionEdit.Properties.ValueMember = "Id";
            revisionEdit.Properties.DisplayMember = "Symbol";
            revisionEdit.Properties.NullText = "";


            if (operation == Utils.Operation.Add)
            {
                dateEdit.EditValue = DateTime.Now;
            }
            else if(operation == Utils.Operation.Update)
            {
                LoadScanDrawing();
            }
            else if (operation == Utils.Operation.Custom)
            {
                drawingRevisionDTO = (DrawingDTO)model.Clone();

                Item.BeginEdit();

                ((DrawingDTO)Item).Id = 0;
                ((DrawingDTO)Item).ParentId = null;
                ((DrawingDTO)Item).Note = "";

                if (((DrawingDTO)Item).RevisionId != null)
                    ((DrawingDTO)Item).RevisionId++;
                else
                    ((DrawingDTO)Item).RevisionId = 1;

                Item.EndEdit();

                LoadScanDrawing();
            }

            ControlValidation();

        }

        private void LoadScanDrawing()
        {
            drawingScanList = drawingService.GetDravingScanById(((DrawingDTO)Item).Id).ToList();
            drawingScanBS.DataSource = drawingScanList;
            drawingScanGrid.DataSource = drawingScanBS;
        }

        public DrawingDTO Return()
        {
            return (DrawingDTO)Item;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить?", "подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveDrawing())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При сохранение возникла ошибка. " + ex.Message, "Сохранение пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            //try
            //{
            //    journalService = Program.kernel.Get<IJournalService>();


            //    if (operation == Utils.Operation.Add)
            //    {
            //        ((ProductionDTO)Item).Id = controlPanelService.ProductionCreate((ProductionDTO)Item);
            //        return true;
            //    }
            //    else
            //    {

            //        controlPanelService.ProductionUpdate((ProductionDTO)Item);
            //        return true;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("При сохранении возникла ошибка. " + ex.Message, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            return true;

        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            drawingScanGridView.BeginDataUpdate();

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
                drawingScanDTO.Id = 0;
                drawingScanDTO.Scan = scan;
                drawingScanDTO.FileName = fileName;

                try
                {
                    //int drawingScanId = drawingService.DrawingScanCreate(drawingScanDTO);
                    //drawingScanList.Add(drawingScanDTO);
                    //drawingScanEdit.EditValue = drawingScanId;
                    //drawingScanEdit.Text = drawingScanDTO.FileName;

                    //Bitmap bitmap = new Bitmap(filePath);
                    //pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                    //pictureEdit.EditValue = bitmap;
                    //fileNameTbox.EditValue = fileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При добавлении скана возникла ошибка. " + ex.Message, "Сохранение чертежа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                return;

            drawingScanList.Add(drawingScanDTO);
            drawingScanBS.DataSource = drawingScanList;
            drawingScanGrid.DataSource = drawingScanBS;

            drawingScanGridView.EndDataUpdate();
        }

        private void drawingScanGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (drawingScanList.Count > 0)
            {
                DrawingScanDTO drawingScanDTO = (DrawingScanDTO)drawingScanGridView.GetFocusedRow();

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
        }

        private void pictureEdit_Click(object sender, EventArgs e)
        {
            DrawingScanDTO drawingScanDTO = (DrawingScanDTO)drawingScanGridView.GetFocusedRow();
            if (drawingScanDTO != null)
            {
                string puth = Utils.HomePath + @"\Temp";
                System.IO.File.WriteAllBytes(puth + drawingScanDTO.FileName, drawingScanDTO.Scan);
                System.Diagnostics.Process.Start(puth + drawingScanDTO.FileName);
            }
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            drawingScanGridView.PostEditor();
            drawingScanGridView.BeginDataUpdate();

            if(((DrawingScanDTO)drawingScanGridView.GetFocusedRow()).Id != 0)
                drawingScanDeleteList.Add((DrawingScanDTO)drawingScanGridView.GetFocusedRow());
            drawingScanList.Remove((DrawingScanDTO)drawingScanGridView.GetFocusedRow());

            drawingScanBS.DataSource = drawingScanList;
            drawingScanGrid.DataSource = drawingScanBS;

            drawingScanGridView.EndDataUpdate();
        }

        private bool SaveDrawing()
        {
            this.Item.EndEdit();

            //if (FindDublicate((BusinessTripsDecreeDTO)this.Item))
            //{
            //    MessageBox.Show("Наказ з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}

            //if (businessTripsBS.Count == 0)
            //{
            //    MessageBox.Show("Необхідно додати посвідчення до наказу!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}

            try
            {
                if (drawingScanDeleteList.Count > 0)
                {
                    drawingService = Program.kernel.Get<IDrawingService>();
                    foreach (var item in drawingScanDeleteList)
                    {
                        drawingService.DrawingScanDelete(item.Id);
                    }
                    
                }

                if (operation == Utils.Operation.Add)
                {
                    drawingService = Program.kernel.Get<IDrawingService>();

                    ((DrawingDTO)Item).Id = drawingService.DrawingCreate((DrawingDTO)Item);

                    var createList = drawingScanList.Select(s => new DrawingScanDTO()
                    {
                        Id = 0,
                        DrawingId = ((DrawingDTO)Item).Id,
                        FileName = s.FileName,
                        Scan = s.Scan,
                        Status = 1
                    }).ToList();

                    foreach (var item in createList)
                    {
                        drawingService.DrawingScanCreate(item);
                    }

                    return true;
                }
                else if (operation == Utils.Operation.Update)
                {
                    drawingService = Program.kernel.Get<IDrawingService>();
                    drawingService.DrawingUpdate((DrawingDTO)Item);

                    var createList = drawingScanList.Where(bdsm => bdsm.Id == 0).Select(s => new DrawingScanDTO()
                    {
                        
                        DrawingId = ((DrawingDTO)Item).Id,
                        FileName = s.FileName,
                        Scan = s.Scan,
                        Status = 1
                    }).ToList();

                    foreach (var item in createList)
                    {
                        drawingService.DrawingScanCreate(item);
                    }

                    return true;
                }
                else if(operation == Utils.Operation.Custom)
                {
                    drawingService = Program.kernel.Get<IDrawingService>();

                    ((DrawingDTO)Item).Id = drawingService.DrawingCreate((DrawingDTO)Item);

                    if (((DrawingDTO)Item).Id > 0)
                    {

                        var createList = drawingScanList.Where(bdsm => bdsm.Id == 0).Select(s => new DrawingScanDTO()
                        {

                            DrawingId = ((DrawingDTO)Item).Id,
                            FileName = s.FileName,
                            Scan = s.Scan,
                            Status = 1
                        }).ToList();

                        foreach (var item in createList)
                        {
                            drawingService.DrawingScanCreate(item);
                        }

                        drawingRevisionDTO.ParentId = ((DrawingDTO)Item).Id;

                        if(drawingService.DrawingUpdate((DrawingDTO)Item))
                        {
                            drawingService.ReplaceDrawingIdInStructura(drawingRevisionDTO.Id,((DrawingDTO)Item).Id);
                        }


                    }

                    return true;
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                                DetailsDTO return_Id = detailsEditFm.Return();
                                detailsBS.DataSource = journalService.GetDetails();
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
                        using (MaterialEditFm materialEditFm = new MaterialEditFm(Utils.Operation.Add, new MaterialsDTO()))
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
                            materialEdit.Properties.DataSource = journalService.GetMaterials();
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

        private void deletBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            drawingScanGridView.PostEditor();
            drawingScanGridView.BeginDataUpdate();

            if (((DrawingScanDTO)drawingScanGridView.GetFocusedRow()).Id != 0)
                drawingScanDeleteList.Add((DrawingScanDTO)drawingScanGridView.GetFocusedRow());
            drawingScanList.Remove((DrawingScanDTO)drawingScanGridView.GetFocusedRow());

            drawingScanBS.DataSource = drawingScanList;
            drawingScanGrid.DataSource = drawingScanBS;

            drawingScanGridView.EndDataUpdate();
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }

        private void numberEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void detailEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void materialEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void wEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void w2Edit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void thEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void lEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void weightEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void revisionEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {   
                case 1://Очистити
                    {
                        revisionEdit.EditValue = null;
                        revisionEdit.Properties.NullText = "";
                        break;
                    }
            }
        }

        //purposeEdit.EditValue = null;
        //                purposeEdit.Properties.NullText = "Немає данних";
        //                break;
    }
}