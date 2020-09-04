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
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl
{
    public partial class TechProcess001EditFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;

        private BindingSource drawingsBS = new BindingSource();
        private BindingSource drawingBS = new BindingSource();
        private BindingSource revisionBS = new BindingSource();
        private BindingSource techProcessBS = new BindingSource();

        public DrawingsDTO drawingsDTO;
        public TechProcess001DTO techProcess001DTO;

        private ObjectBase Item
        {
            get { return techProcessBS.Current as ObjectBase; }
            set
            {
                techProcessBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public TechProcess001EditFm(Utils.Operation operation, TechProcess001DTO model, DrawingsDTO drawingsDTO)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();

            this.drawingsDTO = drawingsDTO;
            techProcessBS.DataSource = Item = model;


            this.techProcess001DTO = techProcess001DTO;


            //techProcess001DTO.TechProcessFullName = drawingsDTO.Number + "_TP" + techProcess001DTO.TechProcessName.ToString();





            drawingNumberEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessNumber001Edit.DataBindings.Add("EditValue", techProcessBS, "TechProcessName", true, DataSourceUpdateMode.OnPropertyChanged);
            revisionEdit.DataBindings.Add("EditValue", techProcessBS, "RevisionId", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessFullName.DataBindings.Add("EditValue", techProcessBS, "techProcessFullName", true, DataSourceUpdateMode.OnPropertyChanged);


            drawingBS.DataSource = drawingService.GetAllDrawing();
            drawingEdit.Properties.DataSource = drawingBS;
            drawingEdit.Properties.ValueMember = "Id";
            drawingEdit.Properties.DisplayMember = "Number";
            drawingEdit.Properties.NullText = "";

            //techProcessNumber001Edit.Text = techProcess001DTO.TechProcessFullName;

            revisionBS.DataSource = drawingService.GetRevisions();
            revisionEdit.Properties.DataSource = revisionBS;
            revisionEdit.Properties.ValueMember = "Id";
            revisionEdit.Properties.DisplayMember = "Symbol";
            revisionEdit.Properties.NullText = "";

            if (operation == Utils.Operation.Add)
            {
                ((TechProcess001DTO)Item).TechProcessName = drawingService.GetLastTechProcess001();
            }
            else
            {

            }



        }

        private bool SaveTechProces()
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


            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();
            string techProcessName = techProcessNumber001Edit.Text;

            if (drawingService.CheckTechProcess001(techProcessName))
            {
                MessageBox.Show("Техпроцесс с таким номером уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {

                ((TechProcess001DTO)Item).TechProcessPath = @"C:\TechProcess\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                ((TechProcess001DTO)Item).Id = drawingService.TechProcess001Create(((TechProcess001DTO)Item));

                drawingsDTO.TechProcess001Name = ((TechProcess001DTO)Item).TechProcessName;
                drawingsDTO.TechProcess001Path = ((TechProcess001DTO)Item).TechProcessPath;

                if (((TechProcess001DTO)Item).Id > 0)
                    reportService.CreateTemplateTechProcess001(drawingsDTO);

                return true;



                //if (operation == Utils.Operation.Add)
                //{
                //    drawingService = Program.kernel.Get<IDrawingService>();

                //    ((DrawingDTO)Item).Id = drawingService.DrawingCreate((DrawingDTO)Item);

                //    var createList = drawingScanList.Select(s => new DrawingScanDTO()
                //    {
                //        Id = 0,
                //        DrawingId = ((DrawingDTO)Item).Id,
                //        FileName = s.FileName,
                //        Scan = s.Scan,
                //        Status = 1
                //    }).ToList();

                //    foreach (var item in createList)
                //    {
                //        drawingService.DrawingScanCreate(item);
                //    }

                //    return true;
                //}
                //else
                //{
                //    drawingService = Program.kernel.Get<IDrawingService>();
                //    drawingService.DrawingUpdate((DrawingDTO)Item);

                //    var createList = drawingScanList.Where(bdsm => bdsm.Id == 0).Select(s => new DrawingScanDTO()
                //    {

                //        DrawingId = ((DrawingDTO)Item).Id,
                //        FileName = s.FileName,
                //        Scan = s.Scan,
                //        Status = 1
                //    }).ToList();

                //    foreach (var item in createList)
                //    {
                //        drawingService.DrawingScanCreate(item);
                //    }

                //    return true;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("При сохранении техпроцесса возникла ошибка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить?", "подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveTechProces())
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

        public TechProcess001DTO Return()
        {
            return ((TechProcess001DTO)Item);
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void TechProcess001EditFm_Load(object sender, EventArgs e)
        {

        }

        private void drawingNumberEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumber + "_TP" + ((TechProcess001DTO)Item).TechProcessName + "/" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumber + "_TP" + ((TechProcess001DTO)Item).TechProcessName;
        }

        private void techProcessNumber001Edit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumber + "_TP" + ((TechProcess001DTO)Item).TechProcessName + "/" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumber + "_TP" + ((TechProcess001DTO)Item).TechProcessName;
        }

        private void revisionEdit_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void revisionEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumber + "_TP" + ((TechProcess001DTO)Item).TechProcessName + "/" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumber + "_TP" + ((TechProcess001DTO)Item).TechProcessName;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void revisionEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                //case 1: //Додати
                //    {
                //        using (MaterialEditFm materialEditFm = new MaterialEditFm(Utils.Operation.Add, new MaterialsDTO()))
                //        {
                //            if (materialEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //            {
                //                MaterialsDTO return_Id = materialEditFm.Return();
                //                materialsBS.DataSource = journalService.GetMaterials();
                //                materialEdit.EditValue = return_Id.Id;
                //            }
                //        }
                //        break;
                //    }
                //case 2://Редагувати
                //    {
                //        if (materialEdit.EditValue == DBNull.Value)
                //            return;

                //        using (MaterialEditFm materialEditFm = new MaterialEditFm(Utils.Operation.Update, (MaterialsDTO)materialEdit.GetSelectedDataRow()))
                //        {
                //            if (materialEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //            {
                //                MaterialsDTO return_Id = materialEditFm.Return();
                //                materialsBS.DataSource = journalService.GetMaterials();
                //                materialEdit.EditValue = return_Id.Id;
                //            }
                //        }
                //        break;
                //    }
                //case 3://Видалити
                //    {
                //        if (materialEdit.EditValue == DBNull.Value)
                //            return;

                //        if (MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //        {
                //            journalService.MaterialsDelete(((MaterialsDTO)materialEdit.GetSelectedDataRow()).Id);
                //            materialEdit.Properties.DataSource = journalService.GetDetails();
                //            materialEdit.EditValue = null;
                //            materialEdit.Properties.NullText = "Немає данних";
                //        }

                //        break;
                //    }
                case 1://Очистити
                    {
                        revisionEdit.EditValue = null;
                        revisionEdit.Properties.NullText = "";
                        break;
                    }
            }
        }

        private void drawingEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}