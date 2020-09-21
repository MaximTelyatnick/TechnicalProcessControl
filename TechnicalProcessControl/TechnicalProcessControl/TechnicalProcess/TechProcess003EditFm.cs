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
using DevExpress.Spreadsheet;

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
        public TechProcess003DTO techProcess003DTO;
        public TechProcess003DTO techProcess003OldDTO;
        public Utils.Operation operation;

        private ObjectBase Item
        {
            get { return techProcessBS.Current as ObjectBase; }
            set
            {
                techProcessBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public TechProcess003EditFm(Utils.Operation operation, TechProcess003DTO model, DrawingsDTO drawingsDTO, TechProcess003DTO techProcess003OldDTO = null)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();

            this.drawingsDTO = drawingsDTO;
            techProcessBS.DataSource = Item = model;

            this.techProcess003DTO = techProcess003DTO;
            this.techProcess003OldDTO = techProcess003OldDTO;
            this.operation = operation;

            drawingNumberEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingNumberWithRevision", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessNumberEdit.DataBindings.Add("EditValue", techProcessBS, "TechProcessName", true, DataSourceUpdateMode.OnPropertyChanged);
            revisionEdit.DataBindings.Add("EditValue", techProcessBS, "RevisionId", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessFullName.DataBindings.Add("EditValue", techProcessBS, "techProcessFullName", true, DataSourceUpdateMode.OnPropertyChanged);
            createDateEdit.DataBindings.Add("EditValue", techProcessBS, "CreateDate", true, DataSourceUpdateMode.OnPropertyChanged);


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
                ((TechProcess003DTO)Item).TechProcessName = drawingService.GetLastTechProcess003();
            }
            else if(operation == Utils.Operation.Update)
            {

            }
            else if(operation == Utils.Operation.Custom)
            {
                Item.BeginEdit();

                ((TechProcess003DTO)Item).ParentId = null;
                ((TechProcess003DTO)Item).CreateDate = DateTime.Now;

                if (((TechProcess003DTO)Item).RevisionId != null)
                    ((TechProcess003DTO)Item).RevisionId++;
                else
                    ((TechProcess003DTO)Item).RevisionId = 1;

                Item.EndEdit();
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

            if (operation == Utils.Operation.Add)
            {

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

                    List<DrawingsDTO> drawingsList = drawingService.GetChildDrawings(drawingsDTO).ToList();

                    if (((TechProcess003DTO)Item).Id > 0)
                    {
                        string path = reportService.CreateTemplateTechProcess003(drawingsDTO, drawingsList);
                        if (path != "")
                        {
                            using (TestFm testFm = new TestFm(path))
                            {
                                if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                {
                                    string return_Id = testFm.Return();
                                    ((TechProcess003DTO)Item).TechProcessFullName = return_Id;



                                }
                            }
                        }
                    }

                    //if (((TechProcess003DTO)Item).Id > 0)
                    //    reportService.CreateTemplateTechProcess003(drawingsDTO, drawingsList);

                    return true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При сохранении техпроцесса возникла ошибка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (operation == Utils.Operation.Custom)
            {
                try
                {

                    ((TechProcess003DTO)Item).TechProcessPath = @"C:\TechProcess\" + ((TechProcess003DTO)Item).TechProcessFullName + ".xls";
                    ((TechProcess003DTO)Item).Id = drawingService.TechProcess003Create(((TechProcess003DTO)Item));

                    drawingsDTO.TechProcess003Name = ((TechProcess003DTO)Item).TechProcessName;
                    drawingsDTO.TechProcess003Path = ((TechProcess003DTO)Item).TechProcessPath;

                    List<DrawingsDTO> drawingsList = drawingService.GetChildDrawings(drawingsDTO).ToList();

                    if (((TechProcess003DTO)Item).Id > 0)
                    {
                        techProcess003OldDTO.ParentId = ((TechProcess003DTO)Item).Id;
                        drawingService.TechProcess003Update(techProcess003OldDTO);

                        string path = reportService.CreateTemplateTechProcess003(drawingsDTO, drawingsList, techProcess003OldDTO);
                        if (path != "")
                        {
                            using (TestFm testFm = new TestFm(path))
                            {
                                if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                {
                                    string return_Id = testFm.Return();
                                    ((TechProcess003DTO)Item).TechProcessFullName = return_Id;
                                }
                            }
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При сохранении техпроцесса возникла ошибка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            return false;
        }
        

        


        public TechProcess003DTO Return()
        {
            return ((TechProcess003DTO)Item);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void techProcessNumberEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess003DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess003DTO)Item).TechProcessName + "_" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess003DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess003DTO)Item).TechProcessName;
        }

        private void revisionEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess003DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess003DTO)Item).TechProcessName + "_" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess003DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess003DTO)Item).TechProcessName;
        }
    }
}