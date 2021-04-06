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
using System.IO;
using TechnicalProcessControl.TechnicalProcess;

namespace TechnicalProcessControl
{
    public partial class TechProcess001EditFm : DevExpress.XtraEditors.XtraForm
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
            techProcessService = Program.kernel.Get<ITechProcessService>();

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
                ((TechProcess001DTO)Item).TechProcessName = techProcessService.GetLastTechProcess001();
                ((TechProcess001DTO)Item).CreateDate = DateTime.Now;
                ((TechProcess001DTO)Item).UserId = usersDTO.Id;
                ((TechProcess001DTO)Item).OldTechProcess = false;
                drawingEdit.ReadOnly = true;
                useExistingWorkflowCheck.Checked = false;
                checkPanelControl.Enabled = false;
                //useExistingWorkflowCheck.EditValue= false;

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
                weightEdit.ReadOnly = true;
                revisionDocumentEdit.ReadOnly = true;
                checkPanelControl.Enabled = false;
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
                ((TechProcess001DTO)Item).TypeId = 1;
                //((TechProcess001DTO)Item).Active = true;

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
            techProcessService = Program.kernel.Get<ITechProcessService>();

            if (operation == Utils.Operation.Add)
            {

                if (techProcessService.CheckTechProcess001(((TechProcess001DTO)Item).TechProcessName))
                {
                    MessageBox.Show("Техпроцесс с таким именем уже существует!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (!Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\"))
                {
                    MessageBox.Show("Директория техпроцесса 001 не найдена! Директория была создана"+ @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Directory.CreateDirectory(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\");
                }
            
                    

                string techProcessName = techProcessNumber001Edit.Text;

                if (!useExistingWorkflowCheck.Checked)
                {
                   
                    try
                    {
 

                        ((TechProcess001DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString()+@"\TechProcess001\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                        List<DrawingDTO> parentDrawings = drawingService.GetDrawingParentByDrawingChildId((int)((TechProcess001DTO)Item).DrawingId).ToList();
                        DrawingDTO drawingTechproces = drawingService.GetDrawingById((int)((TechProcess001DTO)Item).DrawingId);
                        List<DrawingsDTO> structuraChilds = drawingService.GetDrawingsParentByDrawingChildId(drawingsDTO.Id).ToList();
                        //////string path = reportService.CreateTemplateTechProcess001(usersDTO, drawingsDTO, null, parentDrawings);

                        using (TechProcessTempXls001Fm techProcess001Fm = new TechProcessTempXls001Fm(Utils.TechProcesFileMode.AddTechProcess,
                            usersDTO, drawingTechproces, parentDrawings, null, ((TechProcess001DTO)Item), null))
                        {
                            if (techProcess001Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                string returnModel = techProcess001Fm.Return().TechProcessPath;
                                //((TechProcess003DTO)Item).TechProcessFullName = returnModel;
                                ((TechProcess001DTO)Item).Id = techProcessService.TechProcess001Create(((TechProcess001DTO)Item));
                            }

                        }                                     
                        return true;
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            techProcessService.TechProcess001Delete(((TechProcess001DTO)Item).Id);
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
                        ((TechProcess001DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                        ((TechProcess001DTO)Item).TypeId = 5;
                        //string path = reportService.ResaveFileTechProcess001(((TechProcess001DTO)Item), existingWorkflowPathEdit.Text);
                        string path = techProcessService.ResaveFileTechProcess(((TechProcess001DTO)Item).TechProcessPath, existingWorkflowPathEdit.Text);
                        if (path != "")
                        {
                            ((TechProcess001DTO)Item).Id = techProcessService.TechProcess001Create(((TechProcess001DTO)Item));
                            
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
                    techProcessService.TechProcess001Update(((TechProcess001DTO)Item));
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
                    ((TechProcess001DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                    List<DrawingDTO> parentDrawings = drawingService.GetDrawingParentByDrawingChildId((int)((TechProcess001DTO)Item).DrawingId).ToList();
                    List<TechProcess001DTO> techProcess003RevisionOld = techProcessService.GetAllTechProcess001Revision(techProcess001OldDTO.Id).ToList();

                    List<TechProcess001DTO> techProcess001Revision = techProcessService.GetAllTechProcess001RevisionWithActualTechprocess(techProcess001OldDTO.Id).ToList();
                    ((TechProcess001DTO)Item).RivisionName = revisionEdit.Text;
                    techProcess001Revision.Insert(0, (TechProcess001DTO)Item);

                    DrawingDTO drawingTechproces = drawingService.GetDrawingById((int)((TechProcess001DTO)Item).DrawingId);
                    List<DrawingsDTO> structuraChilds = drawingService.GetDrawingsParentByDrawingChildId(drawingsDTO.Id).ToList();

                    using (TechProcessTempXls001Fm techProcessTempXls001Fm = new TechProcessTempXls001Fm(Utils.TechProcesFileMode.UpdateTechProcess,
                            usersDTO, drawingTechproces, parentDrawings, techProcess001Revision, ((TechProcess001DTO)Item), techProcess001OldDTO))
                    {
                        if (techProcessTempXls001Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            string returnModel = techProcessTempXls001Fm.Return().TechProcessPath;
                            //((TechProcess003DTO)Item).TechProcessFullName = returnModel;
                            ((TechProcess001DTO)Item).Id = techProcessService.TechProcess001Create(((TechProcess001DTO)Item));

                            if (((TechProcess001DTO)Item).Id > 0)
                            {
                                techProcess001OldDTO.ParentId = ((TechProcess001DTO)Item).Id;
                                techProcess001OldDTO.TypeId = 2;
                                techProcessService.TechProcess001Update(techProcess001OldDTO);
                            }
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
            if (useExistingWorkflowCheck.Checked && operation!= Utils.Operation.Update)
            {
                checkPanelControl.Enabled = true;
            }
            else
            {
                checkPanelControl.Enabled = false;
            }
        }

        private void TechProcess001EditFm_Load(object sender, EventArgs e)
        {
            //if (useExistingWorkflowCheck.Checked)
            //    checkPanelControl.Enabled = true;
            //else
            //    checkPanelControl.Enabled = false;
        }


    }
}