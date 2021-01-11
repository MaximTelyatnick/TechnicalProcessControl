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
using System.IO;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess002EditFm : DevExpress.XtraEditors.XtraForm
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
        public TechProcess002DTO techProcess002DTO;
        public TechProcess002DTO techProcess002OldDTO;
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


        public TechProcess002EditFm(UsersDTO usersDTO, Utils.Operation operation, TechProcess002DTO techProcess002DTO, DrawingsDTO drawingsDTO = null, TechProcess002DTO techProcess002OldDTO = null)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();
            techProcessService = Program.kernel.Get<ITechProcessService>();
            drawingDTO = drawingService.GetDrawingById((int)techProcess002DTO.DrawingId);

            this.techProcess002DTO = techProcess002DTO;
            this.techProcess002OldDTO = techProcess002OldDTO;
            this.operation = operation;
            this.drawingsDTO = drawingsDTO;
            this.usersDTO = usersDTO;

            techProcess002DTO.DrawingNumberWithRevision = drawingDTO.FullName;
            techProcess002DTO.DrawingNumber = drawingDTO.Number;


            techProcessBS.DataSource = Item = techProcess002DTO;




            drawingNumberEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingNumberWithRevision", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessNumber002Edit.DataBindings.Add("EditValue", techProcessBS, "TechProcessName", true, DataSourceUpdateMode.OnPropertyChanged);
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
                ((TechProcess002DTO)Item).TechProcessName = techProcessService.GetLastTechProcess002();
                ((TechProcess002DTO)Item).CreateDate = DateTime.Now;
                ((TechProcess002DTO)Item).UserId = usersDTO.Id;
                ((TechProcess002DTO)Item).OldTechProcess = false;
                drawingEdit.ReadOnly = true;
                useExistingWorkflowCheck.Checked = false;
                checkPanelControl.Enabled = false;
                //useExistingWorkflowCheck.EditValue= false;

            }
            else if (operation == Utils.Operation.Update)
            {
                useExistingWorkflowCheck.Enabled = false;
                drawingNumberEdit.ReadOnly = true;
                techProcessNumber002Edit.ReadOnly = true;
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
                techProcessNumber002Edit.ReadOnly = true;
                techProcessFullName.ReadOnly = true;
                revisionEdit.ReadOnly = true;
                drawingEdit.ReadOnly = true;

                ((TechProcess002DTO)Item).OldTechProcess = false;
                ((TechProcess002DTO)Item).ParentId = null;
                ((TechProcess002DTO)Item).CreateDate = DateTime.Now;
                ((TechProcess002DTO)Item).UserId = usersDTO.Id;
                ((TechProcess002DTO)Item).TypeId = 1;
                //((TechProcess001DTO)Item).Active = true;

                if (((TechProcess002DTO)Item).RevisionId != null)
                    ((TechProcess002DTO)Item).RevisionId++;
                else
                    ((TechProcess002DTO)Item).RevisionId = 1;

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

                if (techProcessService.CheckTechProcess002(((TechProcess002DTO)Item).TechProcessName))
                {
                    MessageBox.Show("Техпроцесс с таким именем уже существует!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (!Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess002\"))
                {
                    MessageBox.Show("Директория техпроцесса 002 не найдена! Директория была создана" + @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess002\", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Directory.CreateDirectory(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess002\");
                }

                string techProcessName = techProcessNumber002Edit.Text;

                if (!useExistingWorkflowCheck.Checked)
                {
                    try
                    {

                        ((TechProcess002DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess002\" + ((TechProcess002DTO)Item).TechProcessFullName + ".xls";
                        List<DrawingDTO> parentDrawings = drawingService.GetDrawingParentByDrawingChildId((int)((TechProcess002DTO)Item).DrawingId).ToList();
                        DrawingDTO drawingTechproces = drawingService.GetDrawingById((int)((TechProcess002DTO)Item).DrawingId);
                        //////string path = reportService.CreateTemplateTechProcess001(usersDTO, drawingsDTO, null, parentDrawings);

                        ((TechProcess002DTO)Item).Id = techProcessService.TechProcess002Create(((TechProcess002DTO)Item));
                        if (((TechProcess002DTO)Item).Id > 0)
                        {
                            string path = reportService.CreateTemplateTechProcess002Exp(usersDTO, drawingTechproces, parentDrawings, null, ((TechProcess002DTO)Item), null);
                            if (path != "")
                            {
                                using (TestFm testFm = new TestFm(path))
                                {
                                    if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    {
                                        string return_Id = testFm.Return();
                                        ((TechProcess002DTO)Item).TechProcessFullName = return_Id;
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
                            techProcessService.TechProcess002Delete(((TechProcess002DTO)Item).Id);
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
                        ((TechProcess002DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess002\" + ((TechProcess002DTO)Item).TechProcessFullName + ".xls";
                        ((TechProcess002DTO)Item).TypeId = 5;
                        string path = reportService.ResaveFileTechProcess002(((TechProcess002DTO)Item), existingWorkflowPathEdit.Text);
                        if (path != "")
                        {
                            ((TechProcess002DTO)Item).Id = techProcessService.TechProcess002Create(((TechProcess002DTO)Item));

                            if (((TechProcess002DTO)Item).Id > 0)
                            {
                                reportService.OpenExcelFile(((TechProcess002DTO)Item).TechProcessPath);
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
                    techProcessService.TechProcess002Update(((TechProcess002DTO)Item));
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
                    ((TechProcess002DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess002\" + ((TechProcess002DTO)Item).TechProcessFullName + ".xls"; ;
                    List<DrawingDTO> parentDrawings = drawingService.GetDrawingParentByDrawingChildId((int)((TechProcess002DTO)Item).DrawingId).ToList();
                    DrawingDTO drawingTechproces = drawingService.GetDrawingById((int)((TechProcess002DTO)Item).DrawingId);


                    ((TechProcess002DTO)Item).Id = techProcessService.TechProcess002Create(((TechProcess002DTO)Item));

                    if (((TechProcess002DTO)Item).Id > 0)
                    {
                        techProcess002OldDTO.ParentId = ((TechProcess002DTO)Item).Id;
                        techProcess002OldDTO.TypeId = 2;
                        techProcessService.TechProcess002Update(techProcess002OldDTO);

                        List<TechProcess002DTO> techProcess002Revision = techProcessService.GetAllTechProcess002Revision(((TechProcess002DTO)Item).Id).ToList();

                        string path = reportService.CreateTemplateTechProcess002Exp(usersDTO, drawingTechproces, parentDrawings, techProcess002Revision, ((TechProcess002DTO)Item), techProcess002OldDTO);

                        if (path != "")
                        {
                            using (TestFm testFm = new TestFm(path))
                            {
                                if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                {
                                    string return_Id = testFm.Return();
                                    ((TechProcess002DTO)Item).TechProcessFullName = return_Id;
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

        private void drawingNumberEdit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess002DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess002DTO)Item).TechProcessName + "_" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess002DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess002DTO)Item).TechProcessName;
        }

        private void techProcessNumber002Edit_TextChanged(object sender, EventArgs e)
        {
            if (revisionEdit.Text != "")
                techProcessFullName.EditValue = ((TechProcess002DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess002DTO)Item).TechProcessName + "_" + revisionEdit.Text;
            else
                techProcessFullName.EditValue = ((TechProcess002DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess002DTO)Item).TechProcessName;
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
    }
}