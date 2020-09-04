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
using TechnicalProcessControl.BLL.Infrastructure;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess002EditFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;

        private BindingSource drawingsBS = new BindingSource();
        private BindingSource drawingBS = new BindingSource();
        private BindingSource revisionBS = new BindingSource();
        private BindingSource techProcessBS = new BindingSource();

        public DrawingsDTO drawingsDTO;
        public TechProcess002DTO techProcess002DTO;

        private ObjectBase Item
        {
            get { return techProcessBS.Current as ObjectBase; }
            set
            {
                techProcessBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public TechProcess002EditFm(Utils.Operation operation, TechProcess002DTO model, DrawingsDTO drawingsDTO)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();

            this.drawingsDTO = drawingsDTO;
            techProcessBS.DataSource = Item = model;

            this.techProcess002DTO = techProcess002DTO;

            drawingNumberEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessNumberEdit.DataBindings.Add("EditValue", techProcessBS, "TechProcessName", true, DataSourceUpdateMode.OnPropertyChanged);
            revisionEdit.DataBindings.Add("EditValue", techProcessBS, "RevisionId", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessFullName.DataBindings.Add("EditValue", techProcessBS, "techProcessFullName", true, DataSourceUpdateMode.OnPropertyChanged);

            drawingBS.DataSource = drawingService.GetAllDrawing();
            drawingEdit.Properties.DataSource = drawingBS;
            drawingEdit.Properties.ValueMember = "Id";
            drawingEdit.Properties.DisplayMember = "Number";
            drawingEdit.Properties.NullText = "";

            revisionBS.DataSource = drawingService.GetRevisions();
            revisionEdit.Properties.DataSource = revisionBS;
            revisionEdit.Properties.ValueMember = "Id";
            revisionEdit.Properties.DisplayMember = "Symbol";
            revisionEdit.Properties.NullText = "";

            if (operation == Utils.Operation.Add)
            {
                ((TechProcess002DTO)Item).TechProcessName = drawingService.GetLastTechProcess001();
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
            string techProcessName = techProcessNumberEdit.Text;

            if (drawingService.CheckTechProcess002(techProcessName))
            {
                MessageBox.Show("Техпроцесс с таким номером уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {

                ((TechProcess002DTO)Item).TechProcessPath = @"C:\TechProcess\" + ((TechProcess002DTO)Item).TechProcessFullName + ".xls";
                ((TechProcess002DTO)Item).Id = drawingService.TechProcess002Create(((TechProcess002DTO)Item));

                drawingsDTO.TechProcess002Name = ((TechProcess002DTO)Item).TechProcessName;
                drawingsDTO.TechProcess002Path = ((TechProcess002DTO)Item).TechProcessPath;

                if (((TechProcess002DTO)Item).Id > 0)
                    reportService.CreateTemplateTechProcess002(drawingsDTO);

                return true;

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

        public TechProcess002DTO Return()
        {
            return ((TechProcess002DTO)Item);
        }

        private void drawingEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess002DTO)Item).DrawingNumber + "_TP" + ((TechProcess002DTO)Item).TechProcessName + "/" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess002DTO)Item).DrawingNumber + "_TP" + ((TechProcess002DTO)Item).TechProcessName;
        }

        private void techProcessNumberEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess002DTO)Item).DrawingNumber + "_TP" + ((TechProcess002DTO)Item).TechProcessName + "/" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess002DTO)Item).DrawingNumber + "_TP" + ((TechProcess002DTO)Item).TechProcessName;
        }

        private void revisionEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess002DTO)Item).DrawingNumber + "_TP" + ((TechProcess002DTO)Item).TechProcessName + "/" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess002DTO)Item).DrawingNumber + "_TP" + ((TechProcess002DTO)Item).TechProcessName;
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