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
using System.IO;

namespace TechnicalProcessControl
{
    public partial class SettingsFm : DevExpress.XtraEditors.XtraForm
    {
        string pathToXlsImoprtFile;
        List<DrawingsDTO> parseDrawingsList = new List<DrawingsDTO>();
        List<DrawingScanDTO> parseDrawingScanList = new List<DrawingScanDTO>();

        public SettingsFm()
        {
            InitializeComponent();

            userDirectoryPathEdit.Text = Properties.Settings.Default.UserDirectoryPath;
        }

        private void importFromExcelBtn_Click(object sender, EventArgs e)
        {
            if (existingWorkflowFileEdit.Text != "")
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
            else
            {
                MessageBox.Show("Перед началом импорта необходимо указать файл", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public decimal ParseDecimalValue(object cell)
        {
            decimal value = 0;
            if (cell != null)
                decimal.TryParse(cell.ToString(), out value);

            return value;
        }
        

        public List<DrawingsDTO> StartParseStructura(string pathToXlsImoprtFile)
        {
            List<DrawingsDTO> importDrawingsList = new List<DrawingsDTO>();
            var Workbook = Factory.GetWorkbook(@pathToXlsImoprtFile);
            var Worksheet = Workbook.Worksheets[0];
            var Сells = Worksheet.Cells;
            int lastLevel = 0, currentLevel = 0, j = 10;
            int lastFirstLevelParent = 0, lastSecondLevelParent = 0, lastThreeLevelParent = 0,
                lastFourthLevelParent = 0, lastFivesLevelParent = 0, lastSixLevelParent = 0, lastSevenLevelParent = 0,
                lastEightLevelParent = 0, lastNineLevelParent=0, lastTenLevelParent=0, lastElevenLevelParent = 0,
                lastTwelweLevelParent = 0, lastThirtenLevelParent=0, lastFourteenLevelParent = 0,
                lastFifteenLevelParent = 0, lastSixteenLevelParent = 0, lastSeventeenLevelParent=0,
                lastEighteenLevelParent = 0, lastNineteenLevelParent = 0, lastTwentynLevelParent = 0;

            #region Excel Document to list of ExcelModels

            for (int i = 9; i < 8000; i++)
            {
                decimal quantity = 0.00m;
                lastLevel = currentLevel;

                if (Convert.ToString(Сells["C" + i].Value) == "")
                    continue;
                currentLevel = CellLevelAnalizator(Convert.ToString(Сells["C" + i].Value));

                

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
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 7:
                        {
                            lastEightLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastSevenLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 8:
                        {
                            lastNineLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastEightLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 9:
                        {
                            lastTenLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastNineLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 10:
                        {
                            lastElevenLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastTenLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 11:
                        {
                            lastTwelweLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastElevenLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 12:
                        {
                            lastThirtenLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastTwelweLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 13:
                        {
                            lastFourteenLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastThirtenLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 14:
                        {
                            lastFifteenLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastFourteenLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 15:
                        {
                            lastSixteenLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastFifteenLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 16:
                        {
                            lastSeventeenLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastSixteenLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 17:
                        {
                            lastEighteenLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastSeventeenLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 18:
                        {
                            lastNineteenLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastEighteenLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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
                    case 19:
                        {
                            lastTwentynLevelParent = j;
                            importDrawingsList.Add(new DrawingsDTO()
                            {
                                Id = j,
                                ParentId = lastNineteenLevelParent,
                                CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                                Quantity = ParseDecimalValue(Сells["I" + i].Value),
                                QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                                QuantityL = ParseDecimalValue(Сells["H" + i].Value),
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

        }

        private void showPasswordEdit_CheckedChanged(object sender, EventArgs e)
        {
            passEdit.Properties.UseSystemPasswordChar = !showPasswordEdit.Checked;
        }

        private void addPathToDrawingScanBtn_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.ShowNewFolderButton = true;
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                drawingScanDirectoryEdit.Text = folderBrowserDlg.SelectedPath;
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }

        }

        private void importDrawingScanBtn_Click(object sender, EventArgs e)
        {
            if (drawingScanDirectoryEdit.Text != "")
            {
                LoadDrawingScan();

                if (parseDrawingScanList.Count > 0)
                {
                    using (DrawingScanImportFm drawingScanImportFm = new DrawingScanImportFm(parseDrawingScanList))
                    {
                        if (drawingScanImportFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Перед началом импорта необходимо указать файл", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadDrawingScan()
        {

            parseDrawingScanList.Clear();

            if (!drawingScanDirectoryEdit.Text.Equals(String.Empty) && System.IO.Directory.Exists(drawingScanDirectoryEdit.Text))
            {
                if (System.IO.Directory.GetFiles(drawingScanDirectoryEdit.Text).Length > 0)
                {

                    List<string> files = Directory.GetFiles(drawingScanDirectoryEdit.Text, "*.*", SearchOption.AllDirectories)
                        .Where(file => new string[] { ".tif" }
                        .Contains(Path.GetExtension(file)))
                        .ToList();
                    int i = 0;
                    foreach (string file in files)
                    {
                        DrawingScanDTO drawingScanDTO = new DrawingScanDTO();

                        drawingScanDTO.FileName = Path.GetFileName(file);
                        drawingScanDTO.FileNamePath = file;
                        //drawingScanDTO.Scan = System.IO.File.ReadAllBytes(@file);

                        parseDrawingScanList.Add(drawingScanDTO);

                    }
                }
            }
        }

        private void setUserDirectoryPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.ShowNewFolderButton = true;
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                userDirectoryPathEdit.Text = folderBrowserDlg.SelectedPath;
                Properties.Settings.Default.UserDirectoryPath = userDirectoryPathEdit.Text;
                Properties.Settings.Default.Save();
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }
    }
}