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
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL;
using TechnicalProcessControl.BLL.Infrastructure;
using Ninject;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess003EditFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;

        private BindingSource drawingsBS = new BindingSource();
        private BindingSource drawingBS = new BindingSource();
        private BindingSource revisionBS = new BindingSource();
        private BindingSource techProcessBS = new BindingSource();

        public DrawingsDTO drawingsDTO;
        public TechProcess003DTO techProcess002DTO;

        private ObjectBase Item
        {
            get { return techProcessBS.Current as ObjectBase; }
            set
            {
                techProcessBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public TechProcess003EditFm(Utils.Operation operation, TechProcess002DTO model, DrawingsDTO drawingsDTO)
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

        private bool SaveTechProces()
        {
            this.Item.EndEdit();

            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();

            string techProcessName = techProcessNumberEdit.Text;
            if (drawingService.CheckTechProcess003(techProcessName))
            {
                MessageBox.Show("Техпроцесс с таким номером уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {

                ((TechProcess003DTO)Item).TechProcessPath = @"C:\TechProcess\" + ((TechProcess003DTO)Item).TechProcessFullName + ".xls";
                ((TechProcess003DTO)Item).Id = drawingService.TechProcess003Create(((TechProcess003DTO)Item));

                drawingsDTO.TechProcess003Name = ((TechProcess003DTO)Item).TechProcessName;
                drawingsDTO.TechProcess003Path = ((TechProcess003DTO)Item).TechProcessPath;

                if (((TechProcess003DTO)Item).Id > 0)
                    reportService.CreateTemplateTechProcess003(drawingsDTO);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("При сохранении техпроцесса возникла ошибка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}