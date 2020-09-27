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


        public TechProcess001EditFm(UsersDTO usersDTO, Utils.Operation operation, TechProcess001DTO techProcess001DTO, DrawingsDTO drawingsDTO, TechProcess001DTO techProcess001OldDTO = null)
        {
            InitializeComponent();

            drawingService = Program.kernel.Get<IDrawingService>();

            this.operation = operation;
            this.drawingsDTO = drawingsDTO;
            this.usersDTO = usersDTO;
            techProcessBS.DataSource = Item = techProcess001DTO;

            this.techProcess001DTO = techProcess001DTO;
            this.techProcess001OldDTO = techProcess001OldDTO;

            drawingNumberEdit.DataBindings.Add("EditValue", techProcessBS, "DrawingNumberWithRevision", true, DataSourceUpdateMode.OnPropertyChanged);
            techProcessNumber001Edit.DataBindings.Add("EditValue", techProcessBS, "TechProcessName", true, DataSourceUpdateMode.OnPropertyChanged);
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
                ((TechProcess001DTO)Item).TechProcessName = drawingService.GetLastTechProcess001();
                ((TechProcess001DTO)Item).CreateDate = DateTime.Now;
            }
            else if(operation == Utils.Operation.Update)
            {

            }
            else if (operation == Utils.Operation.Custom)
            {
                Item.BeginEdit();

                ((TechProcess001DTO)Item).ParentId = null;
                ((TechProcess001DTO)Item).CreateDate = DateTime.Now;

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

            if (operation == Utils.Operation.Add)
            {

                string techProcessName = techProcessNumber001Edit.Text;

                if (drawingService.CheckTechProcess001(techProcessName))
                {
                    MessageBox.Show("Техпроцесс с таким номером уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                try
                {

                    ((TechProcess001DTO)Item).TechProcessPath = @"C:\TechProcess\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                    

                    drawingsDTO.TechProcess001Name = ((TechProcess001DTO)Item).TechProcessName;
                    drawingsDTO.TechProcess001Path = ((TechProcess001DTO)Item).TechProcessPath;

                    string path = reportService.CreateTemplateTechProcess001(usersDTO, drawingsDTO);
                    if(path!= "")
                    {
                        ((TechProcess001DTO)Item).Id = drawingService.TechProcess001Create(((TechProcess001DTO)Item));
                        if(((TechProcess001DTO)Item).Id>0)
                        {
                            reportService.OpenExcelFile(((TechProcess001DTO)Item).TechProcessPath);
                        }
                    }
                    else
                    {
                        throw new System.ArgumentException("Не получилось создать файл или сохранить в бд", "Ошибка");
                    }

                    //if (((TechProcess001DTO)Item).Id > 0)
                    //{
                    //    string path = reportService.CreateTemplateTechProcess001(usersDTO,drawingsDTO);
                    //    if (path != "")
                    //    {
                    //        //using (TestFm testFm = new TestFm(path))
                    //        //{
                    //        //    if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    //        //    {
                    //        //        string return_Id = testFm.Return();
                    //        //        ((TechProcess001DTO)Item).TechProcessFullName = return_Id;
                    //        //    }
                    //        //}
                    //    }
                    //}

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
                    ((TechProcess001DTO)Item).TechProcessPath = @"C:\TechProcess\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                    //((TechProcess001DTO)Item).Id = drawingService.TechProcess001Create(((TechProcess001DTO)Item));

                    drawingsDTO.TechProcess001Name = ((TechProcess001DTO)Item).TechProcessName;
                    drawingsDTO.TechProcess001Path = ((TechProcess001DTO)Item).TechProcessPath;

                    //if (((TechProcess001DTO)Item).Id > 0)
                    
                        //techProcess001OldDTO.ParentId = ((TechProcess001DTO)Item).Id;
                        //drawingService.TechProcess001Update(techProcess001OldDTO);

                    string path = reportService.CreateTemplateTechProcess001(usersDTO,drawingsDTO, techProcess001OldDTO);
                    if (path != "")
                    {
                        ((TechProcess001DTO)Item).Id = drawingService.TechProcess001Create(((TechProcess001DTO)Item));
                        if (((TechProcess001DTO)Item).Id > 0)
                        {
                            reportService.OpenExcelFile(((TechProcess001DTO)Item).TechProcessPath);
                            techProcess001OldDTO.ParentId = ((TechProcess001DTO)Item).Id;
                            drawingService.TechProcess001Update(techProcess001OldDTO);
                        }
                        //using (TestFm testFm = new TestFm(path))
                        //{
                        //    if (testFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        string return_Id = testFm.Return();
                        //        ((TechProcess001DTO)Item).TechProcessFullName = return_Id;



                        //    }
                        //}
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


            }
            if (filePath.Length > 0)
            {
                

            }
            else
                return;


        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }
    }
}