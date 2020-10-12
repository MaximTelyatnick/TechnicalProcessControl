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
        public UsersDTO usersDTO;

        public DrawingsDTO drawingsDTO;
        public TechProcess001DTO techProcess001DTO;
        public TechProcess001DTO techProcess001OldDTO;
        public DrawingDTO drawingDTO;
        public Utils.Operation operation;

        public string filePath = "";
        public string fileName = "";

        private ObjectBase Item
        {
            get { return techProcessBS.Current as ObjectBase; }
            set
            {
                techProcessBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public TechProcess001EditFm(UsersDTO usersDTO, Utils.Operation operation, TechProcess001DTO techProcess001DTO, DrawingsDTO drawingsDTO = null, TechProcess001DTO techProcess001OldDTO = null)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();
            drawingDTO = drawingService.GetDrawingById((int)techProcess001DTO.DrawingId);

            this.techProcess001DTO = techProcess001DTO;
            this.techProcess001OldDTO = techProcess001OldDTO;
            this.operation = operation;
            this.drawingsDTO = drawingsDTO;
            this.usersDTO = usersDTO;

            techProcess001DTO.DrawingNumberWithRevision = drawingDTO.FullName;
            techProcess001DTO.DrawingNumber = drawingDTO.Number;


            techProcessBS.DataSource = Item = techProcess001DTO;

            
            

            drawingNumberEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingNumberWithRevision", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessNumber001Edit.DataBindings.Add("EditValue", techProcessBS, "TechProcessName", true, DataSourceUpdateMode.OnPropertyChanged);
            revisionEdit.DataBindings.Add("EditValue", techProcessBS, "RevisionId", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessFullName.DataBindings.Add("EditValue", techProcessBS, "techProcessFullName", true, DataSourceUpdateMode.OnPropertyChanged);
            createDateEdit.DataBindings.Add("EditValue", techProcessBS, "CreateDate", true, DataSourceUpdateMode.OnPropertyChanged);
            useExistingWorkflowCheck.DataBindings.Add("Checked", techProcessBS, "OldTechProcess", true, DataSourceUpdateMode.OnPropertyChanged);
            thEdit.DataBindings.Add("EditValue", techProcessBS, "TH", true, DataSourceUpdateMode.OnPropertyChanged);
            wEdit.DataBindings.Add("EditValue", techProcessBS, "W", true, DataSourceUpdateMode.OnPropertyChanged);
            w2Edit.DataBindings.Add("EditValue", techProcessBS, "W2", true, DataSourceUpdateMode.OnPropertyChanged);
            lEdit.DataBindings.Add("EditValue", techProcessBS, "L", true, DataSourceUpdateMode.OnPropertyChanged);
            weightEdit.DataBindings.Add("EditValue", techProcessBS, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);


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
                ((TechProcess001DTO)Item).TechProcessName = drawingService.GetLastTechProcess001();
                ((TechProcess001DTO)Item).CreateDate = DateTime.Now;
                ((TechProcess001DTO)Item).UserId = usersDTO.Id;
                ((TechProcess001DTO)Item).OldTechProcess = false;
                drawingEdit.ReadOnly = true;

            }
            else if(operation == Utils.Operation.Update)
            {
                useExistingWorkflowCheck.Enabled = false;
                drawingNumberEdit.ReadOnly = true;
                techProcessNumber001Edit.ReadOnly = true;
                techProcessFullName.ReadOnly = true;
                revisionEdit.ReadOnly = true;
                drawingEdit.ReadOnly = true;
                createDateEdit.ReadOnly = true;
                thEdit.ReadOnly = true;
                wEdit.ReadOnly = true;
                w2Edit.ReadOnly = true;
                lEdit.ReadOnly = true;
            }
            else if (operation == Utils.Operation.Custom)
            {
                Item.BeginEdit();

                useExistingWorkflowCheck.Enabled = false;
                drawingNumberEdit.ReadOnly = true;
                techProcessNumber001Edit.ReadOnly = true;
                techProcessFullName.ReadOnly = true;
                revisionEdit.ReadOnly = true;
                drawingEdit.ReadOnly = true;

                ((TechProcess001DTO)Item).OldTechProcess = false;
                ((TechProcess001DTO)Item).ParentId = null;
                ((TechProcess001DTO)Item).CreateDate = DateTime.Now;
                ((TechProcess001DTO)Item).UserId = usersDTO.Id;

                if (((TechProcess001DTO)Item).RevisionId != null)
                    ((TechProcess001DTO)Item).RevisionId++;
                else
                    ((TechProcess001DTO)Item).RevisionId = 1;

                Item.EndEdit();
            }



        }

        private bool SaveTechProces()
        {
            this.Item.EndEdit();

            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();

            if (operation == Utils.Operation.Add)
            {

                if (drawingService.CheckTechProcess001(((TechProcess001DTO)Item).TechProcessName))
                {
                    MessageBox.Show("Техпроцесс с таким именем уже существует!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                string techProcessName = techProcessNumber001Edit.Text;

                if (!useExistingWorkflowCheck.Checked)
                {
                    try
                    {

                        ((TechProcess001DTO)Item).TechProcessPath = @"C:\TechProcess\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                        List<DrawingDTO> parentDrawings = drawingService.GetDrawingParentByDrawingChildId((int)((TechProcess001DTO)Item).DrawingId).ToList();
                        DrawingDTO drawingTechproces = drawingService.GetDrawingById((int)((TechProcess001DTO)Item).DrawingId);
                        //////string path = reportService.CreateTemplateTechProcess001(usersDTO, drawingsDTO, null, parentDrawings);

                        ((TechProcess001DTO)Item).Id = drawingService.TechProcess001Create(((TechProcess001DTO)Item));
                        if (((TechProcess001DTO)Item).Id > 0)
                        {
                            string path = reportService.CreateTemplateTechProcess001Exp(usersDTO, drawingTechproces, parentDrawings,null, ((TechProcess001DTO)Item), null);
                            if (path != "")
                            {
                                using (TestFm testFm = new TestFm(path))
                                {
                                    if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    {
                                        string return_Id = testFm.Return();
                                        ((TechProcess001DTO)Item).TechProcessFullName = return_Id;
                                    }
                                }
                            }
                            else
                            {
                                throw new System.ArgumentException("Не получилось создать файл или сохранить в бд", "Ошибка");
                            }

                        }                                       
                        return true;
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            drawingService.TechProcess001Delete(((TechProcess001DTO)Item).Id);
                            MessageBox.Show("При сохранении техпроцесса возникла ошибка. Выполнен откат изменений. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("При сохранении техпроцесса возникла ошибка. Не удалось выполнить откат изменений. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        
                    }
                }
                else
                {
                    try
                    {
                        ((TechProcess001DTO)Item).TechProcessPath = @"C:\TechProcess\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";

                        string path = reportService.ResaveFileTechProcess001(((TechProcess001DTO)Item), existingWorkflowPathEdit.Text);
                        if (path != "")
                        {
                            ((TechProcess001DTO)Item).Id = drawingService.TechProcess001Create(((TechProcess001DTO)Item));
                            if (((TechProcess001DTO)Item).Id > 0)
                            {
                                reportService.OpenExcelFile(((TechProcess001DTO)Item).TechProcessPath);
                            }
                        }
                        else
                        {
                            throw new System.ArgumentException("Не получилось создать файл или сохранить в бд", "Ошибка");
                        }

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("При сохранении техпроцесса возникла ошибка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else if (operation == Utils.Operation.Update)
            {
                try
                {
                    drawingService.TechProcess001Update(((TechProcess001DTO)Item));
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При обновлении техпроцесса возникла ошибка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                

            }
            else if (operation == Utils.Operation.Custom)
            {
                try
                {
                    ((TechProcess001DTO)Item).TechProcessPath = @"C:\TechProcess\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                    List<DrawingDTO> parentDrawings = drawingService.GetDrawingParentByDrawingChildId((int)((TechProcess001DTO)Item).DrawingId).ToList();
                    DrawingDTO drawingTechproces = drawingService.GetDrawingById((int)((TechProcess001DTO)Item).DrawingId);
                    

                    ((TechProcess001DTO)Item).Id = drawingService.TechProcess001Create(((TechProcess001DTO)Item));

                    if (((TechProcess001DTO)Item).Id > 0)
                    {
                        techProcess001OldDTO.ParentId = ((TechProcess001DTO)Item).Id;
                        drawingService.TechProcess001Update(techProcess001OldDTO);

                        List<TechProcess001DTO> techProcess001Revision = drawingService.GetAllTechProcess001Revision(((TechProcess001DTO)Item).Id).ToList();

                        string path = reportService.CreateTemplateTechProcess001Exp(usersDTO, drawingTechproces, parentDrawings, techProcess001Revision, ((TechProcess001DTO)Item), techProcess001OldDTO);

                        if (path != "")
                        {
                            using (TestFm testFm = new TestFm(path))
                            {
                                if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                {
                                    string return_Id = testFm.Return();
                                    ((TechProcess001DTO)Item).TechProcessFullName = return_Id;
                                }
                            }
                        }
                        else
                        {
                            throw new System.ArgumentException("Не получилось создать файл или сохранить в бд", "Ошибка");
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

        private void drawingNumberEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess001DTO)Item).TechProcessName + "_" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess001DTO)Item).TechProcessName;
        }

        private void techProcessNumber001Edit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess001DTO)Item).TechProcessName + "_" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess001DTO)Item).TechProcessName;
        }

        private void revisionEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess001DTO)Item).TechProcessName + "_" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess001DTO)Item).TechProcessName;
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

        private void addExistingWorkflowBtn_Click(object sender, EventArgs e)
        {
            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
                existingWorkflowPathEdit.Text = filePath;
                existingWorkflowFileEdit.Text = fileName;
            }
            else
                return;


        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void useExistingWorkflowCheck_EditValueChanged(object sender, EventArgs e)
        {
            if(useExistingWorkflowCheck.Checked)
                checkPanelControl.Enabled = true;
            else
                checkPanelControl.Enabled = false;
        }

        private void TechProcess001EditFm_Load(object sender, EventArgs e)
        {
            if (useExistingWorkflowCheck.Checked)
                checkPanelControl.Enabled = true;
            else
                checkPanelControl.Enabled = false;
        }


    }
}