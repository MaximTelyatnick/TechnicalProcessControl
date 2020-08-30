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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();
            string techProcessName = techProcessNumber001Edit.Text;

            if (drawingService.CheckTechProcess001(techProcessName))
            {
                MessageBox.Show("Техпроцесс с таким номером уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ((TechProcess001DTO)Item).TechProcessPath = @"C:\TechProcess\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
            var createTechProcess = drawingService.TechProcess001Create(((TechProcess001DTO)Item));

            drawingsDTO.TechProcess001Name = ((TechProcess001DTO)Item).TechProcessName;
            drawingsDTO.TechProcess001Path = ((TechProcess001DTO)Item).TechProcessPath;

            if (createTechProcess > 0)
            {


                //DrawingsDTO drawingsDTO = drawingService.GetDrawingsByStructuraId((int)((TechProcess001DTO)Item).DrawingsId);
                reportService.CreateTemplateTechProcess001(drawingsDTO);
            }



            //techProcess001DTO.TechProcessFullName = drawingsDTO.Number + "_TP" + techProcess001DTO.TechProcessName.ToString();
            //techProcess001DTO.TechProcessPath = @"C:\TechProcess\TechProcess001\" + techProcess001DTO.TechProcessFullName + ".xls";
            //techProcess001DTO.DrawingId = drawingsDTO.Id;
            //techProcess001DTO.Status = 1;


            //var createTechProcess = drawingService.TechProcess001Create(techProcess001DTO);


            //if (((DrawingsDTO)drawingsBS.Current).TechProcess001Id == null)
            //{
            //    TechProcess001DTO techProcess001DTO = new TechProcess001DTO();
            //    techProcess001DTO.TechProcessName = drawingService.GetLastTechProcess001();
            //    techProcess001DTO.TechProcessPath = @"C:\TechProcess\" + techProcess001DTO.TechProcessName.ToString() + ".xls";

            //    var createTechProcess = drawingService.TechProcess001Create(techProcess001DTO);

            //    if (createTechProcess > 0)
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

        public TechProcess001DTO Return()
        {
            return techProcess001DTO;
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
    }
}