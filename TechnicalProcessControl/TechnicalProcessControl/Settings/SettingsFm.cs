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
using SpreadsheetGear;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.Settings;
using System.Globalization;

namespace TechnicalProcessControl
{
    public partial class SettingsFm : DevExpress.XtraEditors.XtraForm
    {
        string pathToXlsImoprtFile;
        List<DrawingsDTO> parseDrawingsList = new List<DrawingsDTO>();

        public SettingsFm()
        {
            InitializeComponent();
        }

        private void importFromExcelBtn_Click(object sender, EventArgs e)
        {
            parseDrawingsList = StartParseStructura(existingWorkflowFileEdit.Text);

            using (StructuraImportFm structuImportFm = new StructuraImportFm(parseDrawingsList))
            {
                if (structuImportFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //splashScreenManager.ShowWaitForm();

                    //DialogResult = DialogResult.OK;
                    //this.usersDTO = loginFm.Return();
                    //CheckUser();
                    //CloseAllMdiForm();

                    //splashScreenManager.CloseWaitForm();
                }
            }

        }

        public List<DrawingsDTO> StartParseStructura(string pathToXlsImoprtFile)
        {
            List<DrawingsDTO> importDrawingsList = new List<DrawingsDTO>();
            var Workbook = Factory.GetWorkbook(@pathToXlsImoprtFile);
            var Worksheet = Workbook.Worksheets[0];
            var Сells = Worksheet.Cells;
            int lastLevel = 0, currentLevel = 0, j = 10;
            int lastFirstLevelParent = 0, lastSecondLevelParent = 0, lastThreeLevelParent = 0,
                lastFourthLevelParent = 0, lastFivesLevelParent = 0, lastSixLevelParent = 0, lastSevenLevelParent = 0;

            #region Excel Document to list of ExcelModels

            for (int i = 9; i < 4000; i++)
            {
                decimal quantity = 0.00m;
                lastLevel = currentLevel;

                if (Convert.ToString(Сells["C" + i].Value) == "")
                    continue;
                currentLevel = CellLevelAnalizator(Convert.ToString(Сells["C" + i].Value));

                //decimal value;
                //bool isValid = decimal.TryParse((string)Сells["I" + i].Value, out value);
                //if (!isValid)
                //    value = 0.00m;

                //if(Сells["I" + i].Value.ToString().Contains())

                //if (Сells["I" + i].Value == "" || Сells["I" + i].Value == null || Сells["I" + i].Value == "")
                //    quantity = 0.00m;
                //else
                //    quantity = Convert.ToDecimal(Сells["I" + i].Value);

                switch (currentLevel)
                {
                    case 0:
                        {
                            lastFirstLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                 ParentId = null,
                                 CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                  //Quantity = Сells["I" + i].Value !=""? Convert.ToDecimal(Сells["I" + i].Value): 0.00m,
                                  //QuantityR = Decimal.Parse(Сells["G" + i].Value),
                                  //QuantityL = Decimal.Parse(Сells["H" + i].Value),
                                   DetailName = Convert.ToString(Сells["F" + i].Value),
                                    Number = Convert.ToString(Сells["D" + i].Value),
                                     TypeName = Convert.ToString(Сells["A" + i].Value)!=""? Convert.ToString(Сells["A" + i].Value): Convert.ToString(Сells["B" + i].Value),
                                      MaterialName = Convert.ToString(Сells["L" + i].Value),
                                       TH = Convert.ToString(Сells["M" + i].Value),
                                       W = Convert.ToString(Сells["N" + i].Value),
                                       W2 = Convert.ToString(Сells["O" + i].Value),
                                       L = Convert.ToString(Сells["P" + i].Value)
                            });
                            ++j;
                        }
                        break;
                    case 1:
                        {
                            lastSecondLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                ParentId = lastFirstLevelParent,
                                //Quantity = Сells["I" + i].Value != "" ? Convert.ToDecimal(Сells["I" + i].Value) : 0.00m,
                                //QuantityR = Convert.ToDecimal(Сells["G" + i].Value),
                                //QuantityL = Convert.ToDecimal(Сells["H" + i].Value),
                                DetailName = Convert.ToString(Сells["F" + i].Value),
                                Number = Convert.ToString(Сells["D" + i].Value),
                                TypeName = Convert.ToString(Сells["A" + i].Value) != "" ? Convert.ToString(Сells["A" + i].Value) : Convert.ToString(Сells["B" + i].Value),
                                MaterialName = Convert.ToString(Сells["L" + i].Value),
                                TH = Convert.ToString(Сells["M" + i].Value),
                                W = Convert.ToString(Сells["N" + i].Value),
                                W2 = Convert.ToString(Сells["O" + i].Value),
                                L = Convert.ToString(Сells["P" + i].Value)


                            });
                            ++j;
                        }
                        break;
                    case 2:
                        {
                            lastThreeLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastSecondLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                //Quantity = Сells["I" + i].Value != "" ? Convert.ToDecimal(Сells["I" + i].Value) : 0.00m,
                                //QuantityR = Convert.ToDecimal(Сells["G" + i].Value),
                                //QuantityL = Convert.ToDecimal(Сells["H" + i].Value),
                                DetailName = Convert.ToString(Сells["F" + i].Value),
                                Number = Convert.ToString(Сells["D" + i].Value),
                                TypeName = Convert.ToString(Сells["A" + i].Value) != "" ? Convert.ToString(Сells["A" + i].Value) : Convert.ToString(Сells["B" + i].Value),
                                MaterialName = Convert.ToString(Сells["L" + i].Value),
                                TH = Convert.ToString(Сells["M" + i].Value),
                                W = Convert.ToString(Сells["N" + i].Value),
                                W2 = Convert.ToString(Сells["O" + i].Value),
                                L = Convert.ToString(Сells["P" + i].Value)

                            });
                            ++j;
                        }
                        break;

                    case 3:
                        {
                            lastFourthLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastThreeLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                //Quantity = Сells["I" + i].Value != "" ? Convert.ToDecimal(Сells["I" + i].Value) : 0.00m,
                                //QuantityR = Convert.ToDecimal(Сells["G" + i].Value),
                                //QuantityL = Convert.ToDecimal(Сells["H" + i].Value),
                                DetailName = Convert.ToString(Сells["F" + i].Value),
                                Number = Convert.ToString(Сells["D" + i].Value),
                                TypeName = Convert.ToString(Сells["A" + i].Value) != "" ? Convert.ToString(Сells["A" + i].Value) : Convert.ToString(Сells["B" + i].Value),
                                MaterialName = Convert.ToString(Сells["L" + i].Value),
                                TH = Convert.ToString(Сells["M" + i].Value),
                                W = Convert.ToString(Сells["N" + i].Value),
                                W2 = Convert.ToString(Сells["O" + i].Value),
                                L = Convert.ToString(Сells["P" + i].Value)

                            });
                            ++j;
                        }
                        break;

                    case 4:
                        {
                            lastFivesLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastFourthLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                //Quantity = Сells["I" + i].Value != "" ? Convert.ToDecimal(Сells["I" + i].Value) : 0.00m,
                                //QuantityR = Convert.ToDecimal(Сells["G" + i].Value),
                                //QuantityL = Convert.ToDecimal(Сells["H" + i].Value),
                                DetailName = Convert.ToString(Сells["F" + i].Value),
                                Number = Convert.ToString(Сells["D" + i].Value),
                                TypeName = Convert.ToString(Сells["A" + i].Value) != "" ? Convert.ToString(Сells["A" + i].Value) : Convert.ToString(Сells["B" + i].Value),
                                MaterialName = Convert.ToString(Сells["L" + i].Value),
                                TH = Convert.ToString(Сells["M" + i].Value),
                                W = Convert.ToString(Сells["N" + i].Value),
                                W2 = Convert.ToString(Сells["O" + i].Value),
                                L = Convert.ToString(Сells["P" + i].Value)

                            });
                            ++j;
                        }
                        break;

                    case 5:
                        {
                            lastSixLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastFivesLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                //Quantity = Сells["I" + i].Value != "" ? Convert.ToDecimal(Сells["I" + i].Value) : 0.00m,
                                //QuantityR = Convert.ToDecimal(Сells["G" + i].Value),
                                //QuantityL = Convert.ToDecimal(Сells["H" + i].Value),
                                DetailName = Convert.ToString(Сells["F" + i].Value),
                                Number = Convert.ToString(Сells["D" + i].Value),
                                TypeName = Convert.ToString(Сells["A" + i].Value) != "" ? Convert.ToString(Сells["A" + i].Value) : Convert.ToString(Сells["B" + i].Value),
                                MaterialName = Convert.ToString(Сells["L" + i].Value),
                                TH = Convert.ToString(Сells["M" + i].Value),
                                W = Convert.ToString(Сells["N" + i].Value),
                                W2 = Convert.ToString(Сells["O" + i].Value),
                                L = Convert.ToString(Сells["P" + i].Value)

                            });
                            ++j;
                        }
                        break;
                    case 6:
                        {
                            lastSevenLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastSixLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                //Quantity = Сells["I" + i].Value != "" ? Convert.ToDecimal(Сells["I" + i].Value) : 0.00m,
                                //QuantityR = Convert.ToDecimal(Сells["G" + i].Value),
                                //QuantityL = Convert.ToDecimal(Сells["H" + i].Value),
                                DetailName = Convert.ToString(Сells["F" + i].Value),
                                Number = Convert.ToString(Сells["D" + i].Value),
                                TypeName = Convert.ToString(Сells["A" + i].Value) != "" ? Convert.ToString(Сells["A" + i].Value) : Convert.ToString(Сells["B" + i].Value),
                                MaterialName = Convert.ToString(Сells["L" + i].Value),
                                TH = Convert.ToString(Сells["M" + i].Value),
                                W = Convert.ToString(Сells["N" + i].Value),
                                W2 = Convert.ToString(Сells["O" + i].Value),
                                L = Convert.ToString(Сells["P" + i].Value)

                            });
                            ++j;
                        }
                        break;

                    default:
                        {

                        }
                        break;
                }
            }

            #endregion

            return importDrawingsList;
        }

        public short CellLevelAnalizator(string currentCell)
        {
            short zeroCounter = 0;
            foreach (var item in currentCell)
            {
                if (item == '.')
                    ++zeroCounter;
            }

            if (currentCell.Contains('-'))
                --zeroCounter;
            return zeroCounter;


        }

        private void addExistingWorkflowBtn_Click(object sender, EventArgs e)
        {

            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                existingWorkflowFileEdit.Text = ofd.FileName;
                //fileName = ofd.SafeFileName;
            }

            //FileBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            //folderBrowserDlg.ShowNewFolderButton = true;
            //DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            //if (dlgResult.Equals(DialogResult.OK))
            //{
            //    existingWorkflowFileEdit.Text = folderBrowserDlg.SelectedPath;
            //    Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;

            //}
        }

        private void showPasswordEdit_CheckedChanged(object sender, EventArgs e)
        {
            passEdit.Properties.UseSystemPasswordChar = !showPasswordEdit.Checked;
        }
    }
}