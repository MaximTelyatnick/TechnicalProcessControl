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

namespace TechnicalProcessControl.Drawings
{
    public partial class DrawingReplaceFm : DevExpress.XtraEditors.XtraForm
    {
        private IDrawingService drawingService;

        private BindingSource drawingsBS = new BindingSource();
        private BindingSource drawingBS = new BindingSource();

        private List<DrawingDTO> drawingList = new List<DrawingDTO>();

        public DrawingReplaceFm(DrawingsDTO drawingsDTO)
        {
            InitializeComponent();
            drawingService = Program.kernel.Get<IDrawingService>();


            drawingsBS.DataSource = drawingsDTO;

            //currentLevelMenuEdit.DataBindings.Add("EditValue", drawingsBS, "CurrentLevelMenu", true, DataSourceUpdateMode.OnPropertyChanged);

            drawingList = drawingService.GetAllDrawingActual().ToList();

            numberEdit.DataBindings.Add("EditValue", drawingsBS, "DrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingBS.DataSource = drawingList;
            numberEdit.Properties.DataSource = drawingBS;
            numberEdit.Properties.ValueMember = "Id";
            numberEdit.Properties.DisplayMember = "FullName";
            numberEdit.Properties.NullText = "Не указан чертёж";

            //numberReplaceEdit.DataBindings.Add("EditValue", drawingsBS, "DrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingBS.DataSource = drawingList;
            numberReplaceEdit.Properties.DataSource = drawingBS;
            numberReplaceEdit.Properties.ValueMember = "Id";
            numberReplaceEdit.Properties.DisplayMember = "FullName";
            numberReplaceEdit.Properties.NullText = null;

            numberReplaceEdit.EditValue = null;

            ControlValidation();

        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;

        }

        private void numberReplaceEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (SaveReplaceDrawing())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка при замене чертежа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private bool SaveReplaceDrawing()
        {
            drawingService = Program.kernel.Get<IDrawingService>();

            ((DrawingsDTO)drawingsBS.Current).DrawingId = (int)numberReplaceEdit.EditValue;
            ((DrawingsDTO)drawingsBS.Current).ReplaceDrawingId = (int)numberEdit.EditValue;
            drawingBS.EndEdit();

            var drawingsUpdateList = drawingService.ReplaceDrawingIdInStructura((int)numberEdit.EditValue, (int)numberReplaceEdit.EditValue);

            if (drawingsUpdateList!= null)
            {

                 string updateStructuraNumber = String.Join(", ", drawingsUpdateList.Select(bdsm => bdsm.CurrentLevelMenu).ToArray());

                if (MessageBox.Show("Чертёж был заменен в следующих структарах: "+ updateStructuraNumber, "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var techProcess001OldDTO = drawingService.GetTechProcess001ByDrawingId((int)numberReplaceEdit.EditValue);
                    var techProcess002OldDTO = drawingService.GetTechProcess002ByDrawingId((int)numberReplaceEdit.EditValue);
                    var techProcess003OldDTO = drawingService.GetTechProcess003ByDrawingId((int)numberReplaceEdit.EditValue);
                    var techProcess004OldDTO = drawingService.GetTechProcess004ByDrawingId((int)numberReplaceEdit.EditValue);
                    var techProcess005OldDTO = drawingService.GetTechProcess005ByDrawingId((int)numberReplaceEdit.EditValue);

                    #region Create revision for techprocess 001

                    if (techProcess001OldDTO != null)
                    {
                        if (MessageBox.Show("Выполнена замена чертежа " + numberEdit.Text + " на " + numberReplaceEdit.Text +
                               "\nЧертёж: " + numberEdit.Text + " содержит техпроцесс: " + techProcess001OldDTO.TechProcessFullName +
                               "\nСоздать ревизию техпроццесса " + techProcess001OldDTO.TechProcessFullName + " ?"
                                , "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // techProcess001OldDTO.DrawingId = ((DrawingDTO)Item).Id;


                        }
                        else
                        {
                            MessageBox.Show("Ревизия техпроцесса не была создана", "Создание ревизии техпроцесса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    #endregion

                    #region Create revision for techprocess 002

                    if (techProcess002OldDTO != null)
                    {
                        if (MessageBox.Show("Выполнена замена чертежа " + numberEdit.Text + " на " + numberReplaceEdit.Text +
                               "\nЧертёж: " + numberEdit.Text + " содержит техпроцесс: " + techProcess002OldDTO.TechProcessFullName +
                               "\nСоздать ревизию техпроццесса " + techProcess002OldDTO.TechProcessFullName + " ?"
                                , "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // techProcess001OldDTO.DrawingId = ((DrawingDTO)Item).Id;


                        }
                        else
                        {
                            MessageBox.Show("Ревизия техпроцесса не была создана", "Создание ревизии техпроцесса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    #endregion

                    #region Create revision for techprocess 003

                    if (techProcess003OldDTO != null)
                    {
                        if (MessageBox.Show("Выполнена замена чертежа " + numberEdit.Text + " на " + numberReplaceEdit.Text +
                               "\nЧертёж: " + numberEdit.Text + " содержит техпроцесс: " + techProcess003OldDTO.TechProcessFullName +
                               "\nСоздать ревизию техпроццесса " + techProcess003OldDTO.TechProcessFullName + " ?"
                                , "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // techProcess001OldDTO.DrawingId = ((DrawingDTO)Item).Id;


                        }
                        else
                        {
                            MessageBox.Show("Ревизия техпроцесса не была создана", "Создание ревизии техпроцесса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    #endregion

                    #region Create revision for techprocess 004

                    if (techProcess004OldDTO != null)
                    {
                        if (MessageBox.Show("Выполнена замена чертежа " + numberEdit.Text + " на " + numberReplaceEdit.Text +
                               "\nЧертёж: " + numberEdit.Text + " содержит техпроцесс: " + techProcess004OldDTO.TechProcessFullName +
                               "\nСоздать ревизию техпроццесса " + techProcess004OldDTO.TechProcessFullName + " ?"
                                , "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // techProcess001OldDTO.DrawingId = ((DrawingDTO)Item).Id;


                        }
                        else
                        {
                            MessageBox.Show("Ревизия техпроцесса не была создана", "Создание ревизии техпроцесса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    #endregion

                    #region Create revision for techprocess 005

                    if (techProcess005OldDTO != null)
                    {
                        if (MessageBox.Show("Выполнена замена чертежа " + numberEdit.Text + " на " + numberReplaceEdit.Text +
                               "\nЧертёж: " + numberEdit.Text + " содержит техпроцесс: " + techProcess005OldDTO.TechProcessFullName +
                               "\nСоздать ревизию техпроццесса " + techProcess005OldDTO.TechProcessFullName + " ?"
                                , "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // techProcess001OldDTO.DrawingId = ((DrawingDTO)Item).Id;


                        }
                        else
                        {
                            MessageBox.Show("Ревизия техпроцесса не была создана", "Создание ревизии техпроцесса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    #endregion

                    return true;

                }
                else
                {
                    var drawingsUpdateReverseList = drawingService.ReplaceDrawingIdInStructura((int)numberReplaceEdit.EditValue,(int)numberEdit.EditValue);
                    string updateStructuraReverseNumber = String.Join(", ", drawingsUpdateList.Select(bdsm => bdsm.CurrentLevelMenu).ToArray());
                    MessageBox.Show("Произведен откат изменений: " + updateStructuraReverseNumber, "Подтверждение", MessageBoxButtons.OK);
                    return true;
                }  
            }
            else
            {
                return false;
            }
        }
    }
}