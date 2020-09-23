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
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Spreadsheet;
using System.IO;

namespace TechnicalProcessControl
{
    public partial class TestFm : DevExpress.XtraEditors.XtraForm
    {
        private IDrawingService drawingService;
        private IJournalService journalService;

        private Utils.Operation operation;

        private IWorkbook workbook;

        private BindingSource operationBS = new BindingSource();
        private BindingSource operationNumberBS = new BindingSource();
        private BindingSource operationPaintMaterialBS = new BindingSource();

        //Обработка закрытия по крестику
        public bool ClosedByXButtonOrAltF4 { get; private set; }
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;

        public TestFm(string pathToFile)
        {
            InitializeComponent();
            this.pathToFile = pathToFile;

            splashScreenManager.ShowWaitForm();


            LoadData();
            splashScreenManager.CloseWaitForm();



        }

        //protected override void WndProc(ref Message msg)
        //{
        //    if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
        //        ClosedByXButtonOrAltF4 = true;
        //    base.WndProc(ref msg);
        //}
        //protected override void OnShown(EventArgs e)
        //{
        //    ClosedByXButtonOrAltF4 = false;
        //}
        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    if (ClosedByXButtonOrAltF4)
        //    {
        //        if (MessageBox.Show("Сохранить изменения?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            workbook.SaveDocument(pathToFile);
        //            DialogResult = DialogResult.OK;
        //            this.Close();
        //        }
        //        else
        //        {
        //            DialogResult = DialogResult.Cancel;
        //            this.Close();
        //        }
        //    }
        //    //else
        //    //    MessageBox.Show("Closed by calling Close()");
        //}

        private string pathToFile;

        

        void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            journalService = Program.kernel.Get<IJournalService>();

            operationBS.DataSource = journalService.GetOperationName();
            operatioRepositoryEdit.DataSource = operationBS;
            operatioRepositoryEdit.ValueMember = "Id";
            operatioRepositoryEdit.DisplayMember = "NameRus";
            operatioRepositoryEdit.NullText = "";

            operationNumberBS.DataSource = journalService.GetOperationNumber();
            operationNumberRepositoryEdit.DataSource = operationNumberBS;
            operationNumberRepositoryEdit.ValueMember = "Id";
            operationNumberRepositoryEdit.DisplayMember = "OperationNumber";
            operationNumberRepositoryEdit.NullText = "";

            operationPaintMaterialBS.DataSource = journalService.GetOperationPaintMaterial();
            operationPaintRepositoryEdit.DataSource = operationPaintMaterialBS;
            operationPaintRepositoryEdit.ValueMember = "Id";
            operationPaintRepositoryEdit.DisplayMember = "NameEng";
            operationPaintRepositoryEdit.NullText = "";

            workbook = spreadsheetControl.Document;
            workbook.BeginUpdate();
            if(pathToFile == null)
            {
                MessageBox.Show("Файл не найден");
            }
            workbook.LoadDocument(pathToFile, DocumentFormat.Xls);


            
            workbook.EndUpdate();

        }

        private void repositoryItemLookUpEditMaterial_DoubleClick(object sender, EventArgs e)
        {
            //spreadsheetControl.SelectedCell.Value = ((MaterialsDTO)materialsBS.Current).MaterialName;
        }

        private void materialEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //var bdsm = repositoryItemLookUpEditMaterial.GetDataSourceRowByKeyValue((int)materialEdit.EditValue);

            //if(bdsm!=null)
            //spreadsheetControl.SelectedCell.Value = ((MaterialsDTO)(repositoryItemLookUpEditMaterial.GetDataSourceRowByKeyValue((int)materialEdit.EditValue))).MaterialName;
        }

        private void repositoryItemLookUpEditMaterial_Enter(object sender, EventArgs e)
        {
            //if(materialEdit.EditValue!=null)
            //spreadsheetControl.SelectedCell.Value = ((MaterialsDTO)(repositoryItemLookUpEditMaterial.GetDataSourceRowByKeyValue((int)materialEdit.EditValue))).MaterialName;
        }

        private void saveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            workbook.SaveDocument(pathToFile, DocumentFormat.Xls);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TestFm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Сохранить изменения?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    workbook.SaveDocument(pathToFile);
                    DialogResult = DialogResult.OK;
                    //this.Close();
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                    //this.Close();
                }
            }
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                if (MessageBox.Show("Сохранить изменения?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    workbook.SaveDocument(pathToFile);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void addOperationBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (operationEdit.EditValue != null)
            {
                workbook.BeginUpdate();

                Clipboard.SetText(((OperationNameDTO)(operatioRepositoryEdit.GetRowByKeyValue(operationEdit.EditValue))).NameRus);

                spreadsheetControl.SelectedCell.Value = Clipboard.GetText();
                workbook.EndUpdate();
            }
        }

        public string Return()
        {
            return pathToFile;
        } 
    }
}