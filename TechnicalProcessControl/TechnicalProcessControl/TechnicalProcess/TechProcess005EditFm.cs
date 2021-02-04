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
using TechnicalProcessControl.BLL.Infrastructure;
using Ninject;
using System.IO;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess005EditFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;
        public static ITechProcessService techProcessService;

        private BindingSource drawingsBS = new BindingSource();
        private BindingSource drawingBS = new BindingSource();
        private BindingSource revisionBS = new BindingSource();
        private BindingSource techProcessBS = new BindingSource();
        public UsersDTO usersDTO;

        public DrawingsDTO drawingsDTO;
        public TechProcess005DTO techProcess005DTO;
        public TechProcess005DTO techProcess005OldDTO;
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


        public TechProcess005EditFm(UsersDTO usersDTO, Utils.Operation operation, TechProcess005DTO techProcess005DTO, DrawingsDTO drawingsDTO = null, TechProcess005DTO techProcess005OldDTO = null)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();
            techProcessService = Program.kernel.Get<ITechProcessService>();

            drawingDTO = drawingService.GetDrawingById((int)techProcess005DTO.DrawingId);

            this.techProcess005DTO = techProcess005DTO;
            this.techProcess005OldDTO = techProcess005OldDTO;
            this.operation = operation;
            this.drawingsDTO = drawingsDTO;
            this.usersDTO = usersDTO;

            techProcess005DTO.DrawingNumberWithRevision = drawingDTO.FullName;
            techProcess005DTO.DrawingNumber = drawingDTO.Number;


            techProcessBS.DataSource = Item = techProcess005DTO;

            drawingNumberEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingNumberWithRevision", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessNumberEdit.DataBindings.Add("EditValue", techProcessBS, "TechProcessName", true, DataSourceUpdateMode.OnPropertyChanged);
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
            revisionDocumentEdit.DataBindings.Add("EditValue", techProcessBS, "RevisionDocumentName", true, DataSourceUpdateMode.OnPropertyChanged);

            welding20SteelEdit.DataBindings.Add("EditValue", techProcessBS, "Welding20Steel", true, DataSourceUpdateMode.OnPropertyChanged);
            welding10Edit.DataBindings.Add("EditValue", techProcessBS, "Welding10", true, DataSourceUpdateMode.OnPropertyChanged);
            welding12Edit.DataBindings.Add("EditValue", techProcessBS, "Welding12", true, DataSourceUpdateMode.OnPropertyChanged);
            welding16Edit.DataBindings.Add("EditValue", techProcessBS, "Welding16", true, DataSourceUpdateMode.OnPropertyChanged);
            welding20Edit.DataBindings.Add("EditValue", techProcessBS, "Welding20", true, DataSourceUpdateMode.OnPropertyChanged);
            gasArCO2Edit.DataBindings.Add("EditValue", techProcessBS, "GasArCO2", true, DataSourceUpdateMode.OnPropertyChanged);
            gasCO3Edit.DataBindings.Add("EditValue", techProcessBS, "GasCO3", true, DataSourceUpdateMode.OnPropertyChanged);
            gasArEdit.DataBindings.Add("EditValue", techProcessBS, "GasAr", true, DataSourceUpdateMode.OnPropertyChanged);
            weldingElektrodEdit.DataBindings.Add("EditValue", techProcessBS, "WeldingElektrod", true, DataSourceUpdateMode.OnPropertyChanged);
            gasO2Edit.DataBindings.Add("EditValue", techProcessBS, "GasO2", true, DataSourceUpdateMode.OnPropertyChanged);
            gasNatureEdit.DataBindings.Add("EditValue", techProcessBS, "GasNature", true, DataSourceUpdateMode.OnPropertyChanged);
            gasN2Edit.DataBindings.Add("EditValue", techProcessBS, "GasN2", true, DataSourceUpdateMode.OnPropertyChanged);
            hardKapci881Edit.DataBindings.Add("EditValue", techProcessBS, "HardKapci881", true, DataSourceUpdateMode.OnPropertyChanged);
            hardKapciHs6055Edit.DataBindings.Add("EditValue", techProcessBS, "HardKapciHs6055", true, DataSourceUpdateMode.OnPropertyChanged);
            hardKapci126Edit.DataBindings.Add("EditValue", techProcessBS, "HardKapci126", true, DataSourceUpdateMode.OnPropertyChanged);
            hardKapciPEPuttyEdit.DataBindings.Add("EditValue", techProcessBS, "HardKapciPEPutty", true, DataSourceUpdateMode.OnPropertyChanged);
            hardKapci2KMS651Edit.DataBindings.Add("EditValue", techProcessBS, "HardKapci2KMS651", true, DataSourceUpdateMode.OnPropertyChanged);
            dilKapci881Edit.DataBindings.Add("EditValue", techProcessBS, "DilKapci881", true, DataSourceUpdateMode.OnPropertyChanged);
            dilKapci2KEdit.DataBindings.Add("EditValue", techProcessBS, "DilKapci2K", true, DataSourceUpdateMode.OnPropertyChanged);
            dilKapci880Edit.DataBindings.Add("EditValue", techProcessBS, "DilKapci880", true, DataSourceUpdateMode.OnPropertyChanged);
            primerKapci125Edit.DataBindings.Add("EditValue", techProcessBS, "PrimerKapci125", true, DataSourceUpdateMode.OnPropertyChanged);
            primerKapci633Edit.DataBindings.Add("EditValue", techProcessBS, "PrimerKapci633", true, DataSourceUpdateMode.OnPropertyChanged);
            enamelKapci641Edit.DataBindings.Add("EditValue", techProcessBS, "EnamelKapci641", true, DataSourceUpdateMode.OnPropertyChanged);
            enamelKapci670Edit.DataBindings.Add("EditValue", techProcessBS, "EnamelKapci670", true, DataSourceUpdateMode.OnPropertyChanged);
            enamelKapci6030Edit.DataBindings.Add("EditValue", techProcessBS, "EnamelKapci6030", true, DataSourceUpdateMode.OnPropertyChanged);
            universalSikaflex527Edit.DataBindings.Add("EditValue", techProcessBS, "UniversalSikaflex527", true, DataSourceUpdateMode.OnPropertyChanged);
            puttyKapci350Edit.DataBindings.Add("EditValue", techProcessBS, "PuttyKapci350", true, DataSourceUpdateMode.OnPropertyChanged);
            laborIntencity001Edit.DataBindings.Add("EditValue", techProcessBS, "LaborIntensity001", true, DataSourceUpdateMode.OnPropertyChanged);
            laborIntencity002Edit.DataBindings.Add("EditValue", techProcessBS, "LaborIntensity002", true, DataSourceUpdateMode.OnPropertyChanged);
            laborIntencity003Edit.DataBindings.Add("EditValue", techProcessBS, "LaborIntensity003", true, DataSourceUpdateMode.OnPropertyChanged);
            laborIntencity004Edit.DataBindings.Add("EditValue", techProcessBS, "LaborIntensity004", true, DataSourceUpdateMode.OnPropertyChanged);
            laborIntencity005Edit.DataBindings.Add("EditValue", techProcessBS, "LaborIntensity005", true, DataSourceUpdateMode.OnPropertyChanged);



            #region TechProcess Materials


            #endregion


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
                ((TechProcess005DTO)Item).TechProcessName = techProcessService.GetLastTechProcess005();
                ((TechProcess005DTO)Item).CreateDate = DateTime.Now;
                ((TechProcess005DTO)Item).UserId = usersDTO.Id;
                ((TechProcess005DTO)Item).OldTechProcess = false;
                drawingEdit.ReadOnly = true;
                useExistingWorkflowCheck.Checked = false;
                checkPanelControl.Enabled = false;
                //useExistingWorkflowCheck.EditValue= false;

            }
            else if (operation == Utils.Operation.Update)
            {
                useExistingWorkflowCheck.Enabled = false;
                drawingNumberEdit.ReadOnly = true;
                techProcessNumberEdit.ReadOnly = true;
                techProcessFullName.ReadOnly = true;
                revisionEdit.ReadOnly = true;
                drawingEdit.ReadOnly = true;
                createDateEdit.ReadOnly = true;
                thEdit.ReadOnly = true;
                wEdit.ReadOnly = true;
                w2Edit.ReadOnly = true;
                lEdit.ReadOnly = true;
                weightEdit.ReadOnly = true;
                revisionDocumentEdit.ReadOnly = true;
                checkPanelControl.Enabled = false;
            }
            else if (operation == Utils.Operation.Custom)
            {
                Item.BeginEdit();

                useExistingWorkflowCheck.Enabled = false;
                drawingNumberEdit.ReadOnly = true;
                techProcessNumberEdit.ReadOnly = true;
                techProcessFullName.ReadOnly = true;
                revisionEdit.ReadOnly = true;
                drawingEdit.ReadOnly = true;

                ((TechProcess005DTO)Item).OldTechProcess = false;
                ((TechProcess005DTO)Item).ParentId = null;
                ((TechProcess005DTO)Item).CreateDate = DateTime.Now;
                ((TechProcess005DTO)Item).UserId = usersDTO.Id;
                ((TechProcess005DTO)Item).TypeId = 1;
                //((TechProcess001DTO)Item).Active = true;

                if (((TechProcess005DTO)Item).RevisionId != null)
                    ((TechProcess005DTO)Item).RevisionId++;
                else
                    ((TechProcess005DTO)Item).RevisionId = 1;

                Item.EndEdit();
            }
        }

        private void drawingNumberEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess005DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess005DTO)Item).TechProcessName + "_" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess005DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess005DTO)Item).TechProcessName;
        }

        private void techProcessNumberEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess005DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess005DTO)Item).TechProcessName + "_" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess005DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess005DTO)Item).TechProcessName;
        }

        private void revisionEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess005DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess005DTO)Item).TechProcessName + "_" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess005DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess005DTO)Item).TechProcessName;
        }

        private void useExistingWorkflowCheck_CheckedChanged(object sender, EventArgs e)
        {
            
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

        public TechProcess005DTO Return()
        {
            return ((TechProcess005DTO)Item);
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

        private bool SaveTechProces()
        {
            this.Item.EndEdit();

            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();
            techProcessService = Program.kernel.Get<ITechProcessService>();




            if (operation == Utils.Operation.Add)
            {

                if (techProcessService.CheckTechProcess005(((TechProcess005DTO)Item).TechProcessName))
                {
                    MessageBox.Show("Техпроцесс с таким именем уже существует!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (!Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess005\"))
                {
                    MessageBox.Show("Директория техпроцесса 005 не найдена! Директория была создана" + @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess005\", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Directory.CreateDirectory(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess005\");
                }



                string techProcessName = techProcessNumberEdit.Text;

                if (!useExistingWorkflowCheck.Checked)
                {
                    try
                    {

                        ((TechProcess005DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess005\" + ((TechProcess005DTO)Item).TechProcessFullName + ".xls";
                        List<DrawingDTO> parentDrawings = drawingService.GetDrawingParentByDrawingChildId((int)((TechProcess005DTO)Item).DrawingId).ToList();
                        DrawingDTO drawingTechproces = drawingService.GetDrawingById((int)((TechProcess005DTO)Item).DrawingId);
                        //////string path = reportService.CreateTemplateTechProcess001(usersDTO, drawingsDTO, null, parentDrawings);

                        ((TechProcess005DTO)Item).Id = techProcessService.TechProcess005Create(((TechProcess005DTO)Item));
                        if (((TechProcess005DTO)Item).Id > 0)
                        {
                            string path = reportService.CreateTemplateTechProcess005Exp(usersDTO, drawingTechproces, parentDrawings, null, ((TechProcess005DTO)Item), null);
                            if (path != "")
                            {
                                using (TestFm testFm = new TestFm(path))
                                {
                                    if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    {
                                        string return_Id = testFm.Return();
                                        ((TechProcess005DTO)Item).TechProcessFullName = return_Id;
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
                            techProcessService.TechProcess005Delete(((TechProcess005DTO)Item).Id);
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
                        ((TechProcess005DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess005\" + ((TechProcess005DTO)Item).TechProcessFullName + ".xls";
                        ((TechProcess005DTO)Item).TypeId = 5;
                        //string path = reportService.ResaveFileTechProcess001(((TechProcess001DTO)Item), existingWorkflowPathEdit.Text);
                        string path = techProcessService.ResaveFileTechProcess(((TechProcess005DTO)Item).TechProcessPath, existingWorkflowPathEdit.Text);
                        if (path != "")
                        {
                            ((TechProcess005DTO)Item).Id = techProcessService.TechProcess005Create(((TechProcess005DTO)Item));

                            if (((TechProcess005DTO)Item).Id > 0)
                            {
                                reportService.OpenExcelFile(((TechProcess005DTO)Item).TechProcessPath);
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
                    techProcessService.TechProcess005Update(((TechProcess005DTO)Item));
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
                    ((TechProcess005DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess005\" + ((TechProcess005DTO)Item).TechProcessFullName + ".xls";
                    List<DrawingDTO> parentDrawings = drawingService.GetDrawingParentByDrawingChildId((int)((TechProcess005DTO)Item).DrawingId).ToList();
                    DrawingDTO drawingTechproces = drawingService.GetDrawingById((int)((TechProcess005DTO)Item).DrawingId);


                    ((TechProcess005DTO)Item).Id = techProcessService.TechProcess005Create(((TechProcess005DTO)Item));

                    if (((TechProcess005DTO)Item).Id > 0)
                    {
                        techProcess005OldDTO.ParentId = ((TechProcess005DTO)Item).Id;
                        techProcess005OldDTO.TypeId = 2;
                        techProcessService.TechProcess005Update(techProcess005OldDTO);

                        List<TechProcess005DTO> techProcess005Revision = techProcessService.GetAllTechProcess005Revision(((TechProcess005DTO)Item).Id).ToList();

                        string path = reportService.CreateTemplateTechProcess005Exp(usersDTO, drawingTechproces, parentDrawings, techProcess005Revision, ((TechProcess005DTO)Item), techProcess005OldDTO);

                        if (path != "")
                        {
                            using (TestFm testFm = new TestFm(path))
                            {
                                if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                {
                                    string return_Id = testFm.Return();
                                    ((TechProcess005DTO)Item).TechProcessFullName = return_Id;
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

        private void useExistingWorkflowCheck_EditValueChanged(object sender, EventArgs e)
        {
            if (useExistingWorkflowCheck.Checked && operation != Utils.Operation.Update)
            {
                checkPanelControl.Enabled = true;
            }
            else
            {
                checkPanelControl.Enabled = false;
            }
        }
    }
}