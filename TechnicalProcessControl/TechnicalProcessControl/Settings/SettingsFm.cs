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
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using DevExpress.XtraSplashScreen;
using TechnicalProcessControl.BLL;

namespace TechnicalProcessControl
{
    public partial class SettingsFm : DevExpress.XtraEditors.XtraForm
    {
        string pathToXlsImoprtFile;

        UsersDTO usersDTO = new UsersDTO();

        private SplashScreenManager splashScreenManager;
        public IUserService userService;
        public IDrawingService drawingService;
        public ITechProcessService techProcessService;
        public BindingSource usersBS = new BindingSource();


        List<DrawingsDTO> parseDrawingsList = new List<DrawingsDTO>();
        List<DrawingScanDTO> parseDrawingScanList = new List<DrawingScanDTO>();
        List<TechProcessDTO> parseTechProcessList = new List<TechProcessDTO>();

        public SettingsFm(UsersDTO usersDTO)
        {
            InitializeComponent();

            splashScreenManager = new SplashScreenManager(this, typeof(WaitFm), true, true);
            this.usersDTO = usersDTO;

            userDirectoryPathEdit.Text = Properties.Settings.Default.UserDirectoryPath;
            backupFileStorageEdit.Text = Properties.Settings.Default.TechProcessDirectoryPath;

            LoadUsers();
            //LoadHistory();


            UserAcces();
        }

        private void LoadUsers()
        {
            userService = Program.kernel.Get<IUserService>();
            usersBS.DataSource = userService.GetAllUsersWithRole();
            userGrid.DataSource = usersBS;
        }

        private void UserAcces()
        {
            switch (usersDTO.RoleId)
            {
                case 1:



                    break;
                case 2:

                    //технолог

                    break;
                case 3:

                    break;
                //конструктор
                case 4:
                    //usersTab.PageEnabled = false;
                    //databaseTab.PageEnabled = false;
                    //recoveryTab.PageEnabled = false;
                    //importTab.PageEnabled = false;
                    //exportTab.PageEnabled = false;
                    //гость

                    break;
                default:
                    break;
            }
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
                lastEightLevelParent = 0, lastNineLevelParent = 0, lastTenLevelParent = 0, lastElevenLevelParent = 0,
                lastTwelweLevelParent = 0, lastThirtenLevelParent = 0, lastFourteenLevelParent = 0,
                lastFifteenLevelParent = 0, lastSixteenLevelParent = 0, lastSeventeenLevelParent = 0,
                lastEighteenLevelParent = 0, lastNineteenLevelParent = 0, lastTwentynLevelParent = 0;

            #region Excel Document to list of ExcelModels

            for (int i = 8; i < 8000; i++)
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

        public void LoadTechProcess()
        {

            parseTechProcessList.Clear();

            if (!techProcessPathEdit.Text.Equals(String.Empty) && System.IO.Directory.Exists(techProcessPathEdit.Text))
            {
                if (System.IO.Directory.GetFiles(techProcessPathEdit.Text).Length > 0)
                {

                    List<string> files = Directory.GetFiles(techProcessPathEdit.Text, "*.*", SearchOption.AllDirectories)
                        .Where(file => new string[] { ".xls", ".xlsx", ".xlsm" }
                        .Contains(Path.GetExtension(file)))
                        .ToList();
                    int i = 0;
                    foreach (string file in files)
                    {
                        TechProcessDTO techProcessDTO = new TechProcessDTO();

                        techProcessDTO.TechProcessFileName = Path.GetFileName(file);
                        techProcessDTO.TechProcessPath = file;
                        //drawingScanDTO.Scan = System.IO.File.ReadAllBytes(@file);

                        parseTechProcessList.Add(techProcessDTO);

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

        private void addPathToTechProcessBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.ShowNewFolderButton = true;
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                techProcessPathEdit.Text = folderBrowserDlg.SelectedPath;
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }

        private void importTechProcessBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перед импортом техпроцессов будут удалены все существующие техпроцессы?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                techProcessService = Program.kernel.Get<ITechProcessService>();

                var techProcess001 = techProcessService.GetAllTechProcess001Simple();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем техпроцессы 001");

                foreach (var item in techProcess001)
                    techProcessService.TechProcess001Delete(item.Id);

                splashScreenManager.CloseWaitForm();

                var techProcess002 = techProcessService.GetAllTechProcess002Simple();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем техпроцессы 002");

                foreach (var item in techProcess002)
                    techProcessService.TechProcess002Delete(item.Id);

                splashScreenManager.CloseWaitForm();

                var techProcess003 = techProcessService.GetAllTechProcess003Simple();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем техпроцессы 003");

                foreach (var item in techProcess003)
                    techProcessService.TechProcess003Delete(item.Id);

                splashScreenManager.CloseWaitForm();

                var techProcess004 = techProcessService.GetAllTechProcess004Simple();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем техпроцессы 004");

                foreach (var item in techProcess004)
                    techProcessService.TechProcess004Delete(item.Id);

                splashScreenManager.CloseWaitForm();

                var techProcess005 = techProcessService.GetAllTechProcess005Simple();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем техпроцессы 005");

                foreach (var item in techProcess005)
                    techProcessService.TechProcess005Delete(item.Id);

                splashScreenManager.CloseWaitForm();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем хранилище техпроцессов которые не прошли импорт");

                if (Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\Trash"))
                {
                    Directory.Delete(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\Trash", true);
                }

                splashScreenManager.CloseWaitForm();

                MessageBox.Show("Все техпроцессы удалены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Начать импорт техпроцессов?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (techProcessPathEdit.Text != "")
                    {
                        LoadTechProcess();

                        drawingService = Program.kernel.Get<IDrawingService>();
                        techProcessService = Program.kernel.Get<ITechProcessService>();

                        if (parseTechProcessList.Count > 0)
                        {
                            splashScreenManager.ShowWaitForm();
                            splashScreenManager.SetWaitFormDescription("Импортируем техпроцессы");

                            foreach (var item in parseTechProcessList)
                            {
                                ParseTechProcessToTechProcess(item);

                            }

                            splashScreenManager.CloseWaitForm();


                            //using (DrawingScanImportFm drawingScanImportFm = new DrawingScanImportFm(parseDrawingScanList))
                            //{
                            //    if (drawingScanImportFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            //    {

                            //    }
                            //}
                        }
                    }
                    else
                    {
                        MessageBox.Show("Перед началом импорта необходимо указать файл", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {

                }
            }
            else
            {

            }
        }

        public void NonUsedTechProcessFile(string pathToFile, string fileName)
        {
            if (!Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\Trash"))
            {
                Directory.CreateDirectory(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\Trash");
            }

            techProcessService.ResaveFileTechProcess(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\Trash\" + fileName, pathToFile);
        }

        private bool ParseTechProcessToTechProcess(TechProcessDTO techProcess)
        {
            string drawingName;
            try
            {
                drawingName = techProcess.TechProcessFileName.Substring(0, techProcess.TechProcessFileName.IndexOf("_TP"));
            }
            catch (Exception ex)
            {
                NonUsedTechProcessFile(techProcess.TechProcessPath, techProcess.TechProcessFileName);
                return false;
            }


            //drawingName = drawingName.Replace(@"_A", "/A");
            //drawingName = drawingName.Replace(@"_B", "/B");
            //drawingName = drawingName.Replace(@"_C", "/C");
            //drawingName = drawingName.Replace(@"_D", "/D");
            //drawingName = drawingName.Replace(@"_E", "/E");
            //drawingName = drawingName.Replace(@"_F", "/F");
            //drawingName = drawingName.Replace(@"_G", "/G");
            //drawingName = drawingName.Replace(@"_H", "/H");
            //drawingName = drawingName.Replace(@"_I", "/I");
            //drawingName = drawingName.Replace(@"_J", "/J");
            //drawingName = drawingName.Replace(@"_K", "/K");
            //drawingName = drawingName.Replace(@"_L", "/L");
            //drawingName = drawingName.Replace(@"_M", "/M");
            //drawingName = drawingName.Replace(@"_N", "/N");
            //drawingName = drawingName.Replace(@"_O", "/O");
            drawingName = drawingName.Replace(@"_", "");
            drawingName = drawingName.Replace(@"/", "");
            drawingName = drawingName.Replace(@".", "");
            drawingName = drawingName.Replace(@"-", "");

            DrawingDTO drawingDTO = drawingService.GetDrawingByName(drawingName);
            if (drawingDTO == null)
            {
                NonUsedTechProcessFile(techProcess.TechProcessPath, techProcess.TechProcessFileName);
                return false;
            }


            string techProcessNumber = techProcess.TechProcessFileName.Substring(techProcess.TechProcessFileName.IndexOf(@"_TP") + 3);
            techProcessNumber = Path.GetFileNameWithoutExtension(techProcessNumber);
            //string techProcessNumberParse = techProcessNumber;

            techProcessNumber = techProcessNumber.Replace(@"_", "");
            techProcessNumber = techProcessNumber.Replace(@"-", "");


            //techProcessNumber = techProcessNumber.Substring(0,(techProcess.TechProcessFileName.IndexOf(@"."))-1);

            string techProcessType = techProcessNumber.Substring(2, 3);

            switch (techProcessType)
            {
                case "001":

                    if (techProcessService.CheckTechProcess001Drawing(drawingDTO.Id))
                        break;

                    TechProcess001DTO createTechProcess001 = new TechProcess001DTO();
                    createTechProcess001.TechProcessName = Int64.Parse(techProcessNumber);
                    createTechProcess001.DrawingId = drawingDTO.Id;
                    createTechProcess001.DrawingNumberWithRevision = drawingName;
                    createTechProcess001.TechProcessFullName = createTechProcess001.DrawingNumberWithRevision + "_TP" + createTechProcess001.TechProcessName;
                    createTechProcess001.TypeId = 5;
                    createTechProcess001.TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\" + createTechProcess001.TechProcessFullName + ".xls";
                    createTechProcess001.CreateDate = DateTime.Now;
                    createTechProcess001.OldTechProcess = true;

                    if (!Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001"))
                    {
                        Directory.CreateDirectory(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001");
                    }
                    //createTechProcess001.

                    //((TechProcess001DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                    //((TechProcess001DTO)Item).TypeId = 5;
                    string path = techProcessService.ResaveFileTechProcess(createTechProcess001.TechProcessPath, techProcess.TechProcessPath);

                    if (path != "")
                    {
                        try
                        {
                            createTechProcess001.Id = techProcessService.TechProcess001Create(createTechProcess001);
                        }
                        catch
                        {
                            techProcessService.FileDelete(path);
                        }


                    }
                    else
                    {



                        //throw new System.ArgumentException("Не получилось создать файл или сохранить в бд", "Ошибка");
                    }


                    //techProcessFullName.EditValue = ((TechProcess001DTO)Item).DrawingNumberWithRevision + "_TP" + ((TechProcess001DTO)Item).TechProcessName;


                    break;
                case "002":
                    if (techProcessService.CheckTechProcess002Drawing(drawingDTO.Id))
                        break;

                    TechProcess002DTO createTechProcess002 = new TechProcess002DTO();
                    createTechProcess002.TechProcessName = Int64.Parse(techProcessNumber);
                    createTechProcess002.DrawingId = drawingDTO.Id;
                    createTechProcess002.DrawingNumberWithRevision = drawingName;
                    createTechProcess002.TechProcessFullName = createTechProcess002.DrawingNumberWithRevision + "_TP" + createTechProcess002.TechProcessName;
                    createTechProcess002.TypeId = 5;
                    createTechProcess002.TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess002\" + createTechProcess002.TechProcessFullName + ".xls";
                    createTechProcess002.CreateDate = DateTime.Now;
                    createTechProcess002.OldTechProcess = true;

                    if (!Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess002"))
                    {
                        Directory.CreateDirectory(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess002");
                    }

                    //createTechProcess001.

                    //((TechProcess001DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                    //((TechProcess001DTO)Item).TypeId = 5;
                    string path002 = techProcessService.ResaveFileTechProcess(createTechProcess002.TechProcessPath, techProcess.TechProcessPath);

                    if (path002 != "")
                    {
                        try
                        {
                            createTechProcess002.Id = techProcessService.TechProcess002Create(createTechProcess002);
                        }
                        catch
                        {
                            techProcessService.FileDelete(path002);
                        }


                    }
                    else
                    {



                        //throw new System.ArgumentException("Не получилось создать файл или сохранить в бд", "Ошибка");
                    }
                    break;
                case "003":
                    if (techProcessService.CheckTechProcess003Drawing(drawingDTO.Id))
                        break;

                    TechProcess003DTO createTechProcess003 = new TechProcess003DTO();
                    createTechProcess003.TechProcessName = Int64.Parse(techProcessNumber);
                    createTechProcess003.DrawingId = drawingDTO.Id;
                    createTechProcess003.DrawingNumberWithRevision = drawingName;
                    createTechProcess003.TechProcessFullName = createTechProcess003.DrawingNumberWithRevision + "_TP" + createTechProcess003.TechProcessName;
                    createTechProcess003.TypeId = 5;
                    createTechProcess003.TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess003\" + createTechProcess003.TechProcessFullName + ".xls";
                    createTechProcess003.CreateDate = DateTime.Now;
                    createTechProcess003.OldTechProcess = true;

                    if (!Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess003"))
                    {
                        Directory.CreateDirectory(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess003");
                    }
                    //createTechProcess001.

                    //((TechProcess001DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                    //((TechProcess001DTO)Item).TypeId = 5;
                    string path003 = techProcessService.ResaveFileTechProcess(createTechProcess003.TechProcessPath, techProcess.TechProcessPath);

                    if (path003 != "")
                    {
                        try
                        {
                            createTechProcess003.Id = techProcessService.TechProcess003Create(createTechProcess003);
                        }
                        catch
                        {
                            techProcessService.FileDelete(path003);
                        }


                    }
                    else
                    {



                        //throw new System.ArgumentException("Не получилось создать файл или сохранить в бд", "Ошибка");
                    }
                    break;
                case "004":
                    if (techProcessService.CheckTechProcess004Drawing(drawingDTO.Id))
                        break;

                    TechProcess004DTO createTechProcess004 = new TechProcess004DTO();
                    createTechProcess004.TechProcessName = Int64.Parse(techProcessNumber);
                    createTechProcess004.DrawingId = drawingDTO.Id;
                    createTechProcess004.DrawingNumberWithRevision = drawingName;
                    createTechProcess004.TechProcessFullName = createTechProcess004.DrawingNumberWithRevision + "_TP" + createTechProcess004.TechProcessName;
                    createTechProcess004.TypeId = 5;
                    createTechProcess004.TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess004\" + createTechProcess004.TechProcessFullName + ".xls";
                    createTechProcess004.CreateDate = DateTime.Now;
                    createTechProcess004.OldTechProcess = true;

                    if (!Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess004"))
                    {
                        Directory.CreateDirectory(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess004");
                    }
                    //createTechProcess001.

                    //((TechProcess001DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                    //((TechProcess001DTO)Item).TypeId = 5;
                    string path004 = techProcessService.ResaveFileTechProcess(createTechProcess004.TechProcessPath, techProcess.TechProcessPath);

                    if (path004 != "")
                    {
                        try
                        {
                            createTechProcess004.Id = techProcessService.TechProcess004Create(createTechProcess004);
                        }
                        catch
                        {
                            techProcessService.FileDelete(path004);
                        }


                    }
                    else
                    {



                        //throw new System.ArgumentException("Не получилось создать файл или сохранить в бд", "Ошибка");
                    }
                    break;
                case "005":
                    if (techProcessService.CheckTechProcess005Drawing(drawingDTO.Id))
                        break;

                    TechProcess005DTO createTechProcess005 = new TechProcess005DTO();
                    createTechProcess005.TechProcessName = Int64.Parse(techProcessNumber);
                    createTechProcess005.DrawingId = drawingDTO.Id;
                    createTechProcess005.DrawingNumberWithRevision = drawingName;
                    createTechProcess005.TechProcessFullName = createTechProcess005.DrawingNumberWithRevision + "_TP" + createTechProcess005.TechProcessName;
                    createTechProcess005.TypeId = 5;
                    createTechProcess005.TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess005\" + createTechProcess005.TechProcessFullName + ".xls";
                    createTechProcess005.CreateDate = DateTime.Now;
                    createTechProcess005.OldTechProcess = true;

                    if (!Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess005"))
                    {
                        Directory.CreateDirectory(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess005");
                    }
                    //createTechProcess001.

                    //((TechProcess001DTO)Item).TechProcessPath = @Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\TechProcess001\" + ((TechProcess001DTO)Item).TechProcessFullName + ".xls";
                    //((TechProcess001DTO)Item).TypeId = 5;
                    string path005 = techProcessService.ResaveFileTechProcess(createTechProcess005.TechProcessPath, techProcess.TechProcessPath);

                    if (path005 != "")
                    {
                        try
                        {
                            createTechProcess005.Id = techProcessService.TechProcess005Create(createTechProcess005);
                        }
                        catch
                        {
                            techProcessService.FileDelete(path005);
                        }


                    }
                    else
                    {



                        //throw new System.ArgumentException("Не получилось создать файл или сохранить в бд", "Ошибка");
                    }
                    break;
                default:
                    //Console.WriteLine("Default case");
                    break;
            }


            return true;
        }


        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void setPathTechProcessFileStorageBtn_Click(object sender, EventArgs e)
        {

            //Если есть файлы в папке, спрашиваем нужно ли менять
            if (Utils.DirectoryContainFiles(Properties.Settings.Default.TechProcessDirectoryPath))
                if (MessageBox.Show("Директория содержит техпроцессы, изменить директорию хранилища техпроцессов?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;


            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.ShowNewFolderButton = true;
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                backupFileStorageEdit.Text = folderBrowserDlg.SelectedPath;
                Properties.Settings.Default.TechProcessDirectoryPath = backupFileStorageEdit.Text;
                Properties.Settings.Default.Save();
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }

        private void updateDrawingNumberParseBtn_Click(object sender, EventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            var allDrawing = drawingService.GetAllDrawing();

            splashScreenManager.ShowWaitForm();
            splashScreenManager.SetWaitFormDescription("Обновляем данные чертежей");

            foreach (var item in allDrawing)
                drawingService.DrawingParseUpdate(item);

            splashScreenManager.CloseWaitForm();
        }

        private void allTechProcessDeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Будут удалены все существующие техпроцессы?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                techProcessService = Program.kernel.Get<ITechProcessService>();

                var techProcess001 = techProcessService.GetAllTechProcess001Simple();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем техпроцессы 001");

                foreach (var item in techProcess001)
                    techProcessService.TechProcess001Delete(item.Id);

                splashScreenManager.CloseWaitForm();

                var techProcess002 = techProcessService.GetAllTechProcess002Simple();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем техпроцессы 002");

                foreach (var item in techProcess002)
                    techProcessService.TechProcess002Delete(item.Id);

                splashScreenManager.CloseWaitForm();

                var techProcess003 = techProcessService.GetAllTechProcess003Simple();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем техпроцессы 003");

                foreach (var item in techProcess003)
                    techProcessService.TechProcess003Delete(item.Id);

                splashScreenManager.CloseWaitForm();

                var techProcess004 = techProcessService.GetAllTechProcess004Simple();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем техпроцессы 004");

                foreach (var item in techProcess004)
                    techProcessService.TechProcess004Delete(item.Id);

                splashScreenManager.CloseWaitForm();

                var techProcess005 = techProcessService.GetAllTechProcess005Simple();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем техпроцессы 005");

                foreach (var item in techProcess005)
                    techProcessService.TechProcess005Delete(item.Id);

                splashScreenManager.CloseWaitForm();

                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormDescription("Удаляем хранилище техпроцессов которые не прошли импорт");

                if (Directory.Exists(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\Trash"))
                {
                    Directory.Delete(@Properties.Settings.Default.TechProcessDirectoryPath.ToString() + @"\Trash", true);
                }

                splashScreenManager.CloseWaitForm();

                MessageBox.Show("Все техпроцессы удалены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}