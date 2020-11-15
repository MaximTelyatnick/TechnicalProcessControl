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

namespace TechnicalProcessControl
{
    public partial class settingsFm : DevExpress.XtraEditors.XtraForm
    {
        string pathToXlsImoprtFile;
        

        public settingsFm()
        {
            InitializeComponent();
        }

        private void importFromExcelBtn_Click(object sender, EventArgs e)
        {

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

                lastLevel = currentLevel;

                currentLevel = CellLevelAnalizator(Convert.ToString(Сells["C" + i].Value));

                switch (currentLevel)
                {
                    case 0:
                        {
                            lastFirstLevelParent = j;
                            modelDkpp.Add(new ExcelDkppDTO()
                            {
                                Id = j,
                                Code = Convert.ToString(Сells["A" + i].Value),
                                Level = currentLevel,
                                ParentId = null,
                                Name = Convert.ToString(Сells["B" + i].Value),
                                NameUKTV = Convert.ToString(Сells["C" + i].Value)

                            });
                            ++j;
                        }
                        break;
                    case 1:
                        {
                            lastSecondLevelParent = j;
                            modelDkpp.Add(new ExcelDkppDTO()
                            {
                                Id = j,
                                Code = Convert.ToString(Сells["A" + i].Value),
                                Level = currentLevel,
                                ParentId = lastFirstLevelParent,
                                Name = Convert.ToString(Сells["B" + i].Value),
                                NameUKTV = Convert.ToString(Сells["C" + i].Value)

                            });
                            ++j;
                        }
                        break;
                    case 2:
                        {
                            lastThreeLevelParent = j;
                            modelDkpp.Add(new ExcelDkppDTO()
                            {
                                Id = j,
                                Code = Convert.ToString(Сells["A" + i].Value),
                                Level = currentLevel,
                                ParentId = lastSecondLevelParent,
                                Name = Convert.ToString(Сells["B" + i].Value),
                                NameUKTV = Convert.ToString(Сells["C" + i].Value)

                            });
                            ++j;
                        }
                        break;

                    case 3:
                        {
                            lastFourthLevelParent = j;
                            modelDkpp.Add(new ExcelDkppDTO()
                            {
                                Id = j,
                                Code = Convert.ToString(Сells["A" + i].Value),
                                Level = currentLevel,
                                ParentId = lastThreeLevelParent,
                                Name = Convert.ToString(Сells["B" + i].Value),
                                NameUKTV = Convert.ToString(Сells["C" + i].Value)

                            });
                            ++j;
                        }
                        break;

                    case 4:
                        {
                            lastFivesLevelParent = j;
                            modelDkpp.Add(new ExcelDkppDTO()
                            {
                                Id = j,
                                Code = Convert.ToString(Сells["A" + i].Value),
                                Level = currentLevel,
                                ParentId = lastFourthLevelParent,
                                Name = Convert.ToString(Сells["B" + i].Value),
                                NameUKTV = Convert.ToString(Сells["C" + i].Value)

                            });
                            ++j;
                        }
                        break;

                    case 5:
                        {
                            lastSixLevelParent = j;
                            modelDkpp.Add(new ExcelDkppDTO()
                            {
                                Id = j,
                                Code = Convert.ToString(Сells["A" + i].Value),
                                Level = currentLevel,
                                ParentId = lastFivesLevelParent,
                                Name = Convert.ToString(Сells["B" + i].Value),
                                NameUKTV = Convert.ToString(Сells["C" + i].Value)

                            });
                            ++j;
                        }
                        break;
                    case 6:
                        {
                            lastSevenLevelParent = j;
                            modelDkpp.Add(new ExcelDkppDTO()
                            {
                                Id = j,
                                Code = Convert.ToString(Сells["A" + i].Value),
                                Level = currentLevel,
                                ParentId = lastSixLevelParent,
                                Name = Convert.ToString(Сells["B" + i].Value),
                                NameUKTV = Convert.ToString(Сells["C" + i].Value)

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
        }

        public short CellLevelAnalizator(string currentCell)
        {




        }
    }
}