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
using DevExpress.XtraSplashScreen;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Interfaces;
using DevExpress.Spreadsheet;
using static TechnicalProcessControl.Utils;
using Ninject;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcessWithSpecification004Fm : DevExpress.XtraEditors.XtraForm
    {
        private SplashScreenManager splashScreenManager;
        string techProcessNumber;
        int defaultLastRow = 189;
        int defaultSpecificationLastRow = 63;
        int defaultSpecSheet = 1;
        int defaultSimpleSheett = 3;

        int realSimpleSheet = 0;
        int realSpecSheet = 0;

        private string GeneratedReportsDir = Utils.HomePath + @"\Templates\";

        private DrawingDTO techProces004Drawing;
        private TechProcess004DTO techProcess004;
        private TechProcess004DTO techProcess004Old;
        private UsersDTO usersDTO;
        private List<DrawingsDTO> techProcess004DrawingsChild;


        private IReportService reportService;
        private ITechProcessService techProcessService;

        private Utils.Operation operation;

        public int pageNumber;

        public IWorkbook workbook, workbookOld;

        public Worksheet worksheet, worksheetOld;
        public Range copyRange, copyRangeOld;

        int lastOldSpecRow = 0;
        int lastOldSimpleRow = 0;

        public string parentDrawings = "";


        public TechProcessWithSpecification004Fm(TechProcesFileMode techProcessFileMode, UsersDTO usersDTO, DrawingDTO techProces004Drawing, List<DrawingDTO> drawingParent, List<DrawingsDTO> techProcess004DrawingsChild, List<TechProcess004DTO> techProcess004Revision, TechProcess004DTO techProcess004, TechProcess004DTO techProcess004Old = null)
        {
            InitializeComponent();

            this.techProces004Drawing = techProces004Drawing;
            this.techProcess004DrawingsChild = techProcess004DrawingsChild;
            this.usersDTO = usersDTO;
            this.techProcess004 = techProcess004;
            this.techProcess004Old = techProcess004Old;

            reportService = Program.kernel.Get<IReportService>();
            techProcessService = Program.kernel.Get<ITechProcessService>();
            splashScreenManager = new SplashScreenManager(this, typeof(WaitFm), true, true);
            workbook = spreadsheetControl.Document;
            workbookOld = spreadsheetControlOld.Document;

            //Factory.GetWorkbook(GeneratedReportsDir + @"\template001.xls");
            switch (techProcessFileMode)
            {
                case TechProcesFileMode.AddTechProcess:

                    workbook.BeginUpdate();
                    workbook.LoadDocument(GeneratedReportsDir + @"\template004New.xls", DocumentFormat.Xls);
                    worksheet = workbook.Worksheets[0];

                    if (drawingParent != null)
                        parentDrawings = String.Join(", ", drawingParent.Select(bdsm => bdsm.Number).ToArray());

                    techProcessNumber = reportService.TechProcesNameToStr(techProcess004.TechProcessName);

                    PrintHeader();
                    PrintSpecification();
                    PrintFormTittle();
                    PrintSimpleSheet();


                    workbook.EndUpdate();
                    break;
                case TechProcesFileMode.UpdateTechProcess:

                    workbook.BeginUpdate();
                    workbookOld.BeginUpdate();
                    workbook.LoadDocument(GeneratedReportsDir + @"\template004New.xls", DocumentFormat.Xls);
                    workbookOld.LoadDocument(techProcess004Old.TechProcessPath, DocumentFormat.Xls);

                    worksheetOld = workbookOld.Worksheets[0];
                    worksheet = workbook.Worksheets[0];

                    if (drawingParent != null)
                        parentDrawings = String.Join(", ", drawingParent.Select(bdsm => bdsm.Number).ToArray());

                    techProcessNumber = reportService.TechProcesNameToStr(techProcess004.TechProcessName);

                    PrintHeader();
                    PrintSpecification();
                    PrintFormTittle();
                    PrintSimpleSheetFromRevision();



                    workbook.EndUpdate();

                    //посчитать сколько каких листов
                    break;
                case TechProcesFileMode.TemplateTechProcess:
                    break;
                default:
                    break;
            }
        }

        private void PrintHeader()
        {
            worksheet.Cells["CO6"].Value = techProcessNumber;
            worksheet.Cells["BB6"].Value = techProces004Drawing.Number;
            worksheet.Cells["AQ9"].Value = techProces004Drawing.DetailName;
            worksheet.Cells["AJ24"].Value = techProces004Drawing.DetailName;
            worksheet.Cells["BX27"].Value = "Created by " + usersDTO.Name + " " + techProcess004.CreateDate.Value.ToShortDateString();

        }

        private void PrintSpecification()
        {
            if (techProcess004DrawingsChild.Count() < 15)
            {
                worksheet.Cells["CL40"].Value = techProcessNumber;
                worksheet.Cells["AV40"].Value = techProces004Drawing.Number;
                worksheet.Cells["AN43"].Value = techProces004Drawing.DetailName;
                worksheet.Cells["J40"].Value = usersDTO.Name;
                worksheet.Cells["AB40"].Value = techProcess004.CreateDate.Value.ToShortDateString();
                worksheet.Cells["A38"].Value = parentDrawings;
                worksheet.Cells["CV38"].Value = (defaultSpecSheet + 1);

                int specCounter = 48;

                foreach (var item in techProcess004DrawingsChild)
                {
                    string[] subs = item.CurrentLevelMenu.Split('.');

                    worksheet.Cells["W" + (specCounter)].Value = subs.LastOrDefault();
                    worksheet.Cells["AA" + (specCounter)].Value = item.DetailName;
                    worksheet.Cells["BD" + (specCounter)].Value = item.Number;
                    worksheet.Cells["CH" + (specCounter)].Value = "";
                    worksheet.Cells["CL" + (specCounter)].Value = item.DetailWeight;
                    worksheet.Cells["CQ" + (specCounter)].Value = item.Quantity + item.QuantityL + item.QuantityR;
                    ++specCounter;

                }
            }
            else
            {
                worksheet.Cells["CL40"].Value = techProcessNumber;
                worksheet.Cells["AV40"].Value = techProces004Drawing.Number;
                worksheet.Cells["AN43"].Value = techProces004Drawing.DetailName;
                worksheet.Cells["J40"].Value = usersDTO.Name;
                worksheet.Cells["AB40"].Value = techProcess004.CreateDate.Value.ToShortDateString();
                worksheet.Cells["A38"].Value = parentDrawings;
                worksheet.Cells["CV38"].Value = (defaultSpecSheet + 1);

                int specCounter = 48;
                int rowCounter = 0;

                foreach (var item in techProcess004DrawingsChild)
                {

                    string[] subs = item.CurrentLevelMenu.Split('.');

                    worksheet.Cells["W" + (specCounter)].Value = subs.LastOrDefault();
                    worksheet.Cells["AA" + (specCounter)].Value = item.DetailName;
                    worksheet.Cells["BD" + (specCounter)].Value = item.Number;
                    worksheet.Cells["CH" + (specCounter)].Value = "";
                    worksheet.Cells["CL" + (specCounter)].Value = item.DetailWeight;
                    worksheet.Cells["CQ" + (specCounter)].Value = item.Quantity + item.QuantityL + item.QuantityR;
                    ++specCounter;
                    ++rowCounter;

                    if (rowCounter == 14)
                    {
                        rowCounter = 0;
                        specCounter += 18;
                        AddSpecSheet();
                    }
                }
            }

        }

        private void PrintFormTittle()
        {
            if (techProcess004DrawingsChild.Count() < 15)
            {
                worksheet.Cells["CM72"].Value = techProcessNumber;
                worksheet.Cells["AZ72"].Value = techProces004Drawing.Number;
                worksheet.Cells["X79"].Value = techProces004Drawing.DetailWeight;
                worksheet.Cells["AO75"].Value = techProces004Drawing.DetailName;
                worksheet.Cells["K72"].Value = usersDTO.Name;
                worksheet.Cells["AC72"].Value = techProcess004.CreateDate.Value.ToShortDateString();
                worksheet.Cells["B70"].Value = parentDrawings;
                worksheet.Cells["DA70"].Value = (defaultSpecSheet + 2);

            }
            else
            {
                worksheet.Cells["CM" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcessNumber;
                worksheet.Cells["AZ" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces004Drawing.Number;
                worksheet.Cells["X" + (79 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces004Drawing.DetailWeight;
                worksheet.Cells["AO" + (75 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces004Drawing.DetailName;
                worksheet.Cells["K" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                worksheet.Cells["AC" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004.CreateDate.Value.ToShortDateString();
                worksheet.Cells["B" + (70 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = parentDrawings;
                worksheet.Cells["DA" + (70 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = (defaultSpecSheet + 2);
            }

        }

        private void PrintSimpleSheet()
        {
            for (int i = 0; i < defaultSimpleSheett; i++)
            {

                ++realSimpleSheet;
                worksheet.Cells["CY" + (102 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].Value = (defaultSpecSheet + 2) + realSimpleSheet;
                worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].Value = techProcessNumber;
                worksheet.Cells["BQ" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].Value = techProces004Drawing.Number;
            }



            //second page

            //

        }

        private void AddSpecSheet()
        {
            workbook.BeginUpdate();
            ++pageNumber;
            ++defaultSpecSheet;

            worksheet = workbook.Worksheets[0];
            copyRange = worksheet["A33:DF64"];
            int lastSpecificationRowRow = GetLastSpecificationRow(workbook);
            lastSpecificationRowRow++;
            //lastSpecificationRowRow++;
            //++lastRow;
            //worksheet.InsertCells(copyRange);
            worksheet.Rows.Insert(lastSpecificationRowRow, 32);
            worksheet.AddPrintRange(worksheet.Range["A" + (lastSpecificationRowRow + 1) + ":DF" + (lastSpecificationRowRow + 32)]);
            worksheet.Range["A" + (lastSpecificationRowRow + 1) + ":DF" + (lastSpecificationRowRow + 32)].CopyFrom(copyRange);

            worksheet.Cells["A" + (lastSpecificationRowRow)].RowHeight = 100.5;
            //worksheet.Cells["A" + (lastSpecificationRowRow)].RowHeight = 90.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 1)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 2)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 3)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 4)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 5)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 6)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 7)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 8)].RowHeight = 65.6;
            worksheet.Cells["A" + (lastSpecificationRowRow + 9)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 10)].RowHeight = 65.6;
            worksheet.Cells["A" + (lastSpecificationRowRow + 11)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 12)].RowHeight = 65.6;
            worksheet.Cells["A" + (lastSpecificationRowRow + 13)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 14)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 15)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 16)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 17)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 18)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 19)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 20)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 21)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 22)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 23)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 24)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 25)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 26)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 27)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 28)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 29)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 30)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastSpecificationRowRow + 31)].RowHeight = 87.5;

            for (int i = 16; i < 30; i++)
            {
                worksheet.Cells["W" + (lastSpecificationRowRow + i)].Value = "";
                worksheet.Cells["AA" + (lastSpecificationRowRow + i)].Value = "";
                worksheet.Cells["BD" + (lastSpecificationRowRow + i)].Value = "";
                worksheet.Cells["CH" + (lastSpecificationRowRow + i)].Value = "";
                worksheet.Cells["CL" + (lastSpecificationRowRow + i)].Value = "";
                worksheet.Cells["CQ" + (lastSpecificationRowRow + i)].Value = "";
            }

            worksheet.Cells["CL" + (40 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcessNumber;
            worksheet.Cells["AV" + (40 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces004Drawing.Number;
            worksheet.Cells["AN" + (43 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces004Drawing.DetailName;
            worksheet.Cells["J" + (40 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
            worksheet.Cells["AB" + (40 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004.CreateDate.Value.ToShortDateString();
            worksheet.Cells["A" + (38 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = parentDrawings;
            worksheet.Cells["CV" + (38 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = (defaultSpecSheet + 1);



            //worksheet.Cells["CV38"].Value = (defaultSpecSheet + 1);

            UpdatePageCounter();
            workbook.EndUpdate();
        }

        private void PrintSimpleSheetFromRevision()
        {
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            List<Range> copyRangeFromOldFile = GetSimpleSheetInfoRange();

            //copyRangeFromOldFile.R
            for (int i = 0; i < copyRangeFromOldFile.Count; i++)
            {
                //worksheet.Range["A" + (97 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (127 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].UnMerge();
                //worksheet.Range["A" + (317 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (347 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].GetMergedRanges();
                workbook.Worksheets[0].Range["A" + (97 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (127 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].CopyFrom(copyRangeFromOldFile[i], PasteSpecial.Values | PasteSpecial.NumberFormats);
                //workbook.Worksheets[0].Range["A" + (317 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (347 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].CopyFrom(workbookOld.Worksheets[0].Range["A" + ((lastOldSpecRow + 34) + (31 * i)) + ":" + "DF" + ((lastOldSpecRow + 34 + 31) + (31 * i) - 1)]);
                //workbook.Range["A" + (317 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (347 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].CopyFrom(workbookOld.Worksheets[0].(copyRangeFromOldFile[i]));
            }



            //int row = copyRangeFromOldFile.RowCount;
            //int copyPage = row / 31;

            //worksheet.Range["B" + (110 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))+":"+ "CW" + (125 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))].CopyFrom(copyRange.Worksheet["B14:CW29"]);

            //for(int i=0; i<copyPage;++i)
            // {




            //}


            workbook.EndUpdate();
        }


        private List<Range> GetSimpleSheetInfoRange()
        {


            List<Range> copySheetrange = new List<Range>();

            int lastOldSpecRow = GetLastSpecificationRow(workbookOld);
            int lastOldSimpleRow = GetLastEmptyRow(workbookOld);
            Range allInfoFromWorksheet = worksheetOld["A" + (lastOldSpecRow + 34) + ":" + "DF" + (lastOldSimpleRow)];

            int allRow = allInfoFromWorksheet.RowCount;
            int allPages = (allRow / 31);

            for (int i = 0; i < allPages; i++)
            {
                copySheetrange.Add(worksheetOld.Range["A" + ((lastOldSpecRow + 34) + (31 * i)) + ":" + "DF" + ((lastOldSpecRow + 34 + 31) + (31 * i) - 1)]);
            }

            return copySheetrange;
        }


        private void AddFormSpecificationInfo()
        {
            workbook.BeginUpdate();
            ++pageNumber;
            ++defaultSimpleSheett;

            worksheet = workbook.Worksheets[0];
            copyRange = worksheet["A" + (159 + ((31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))) + ":DF" + (189 + ((31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)))];
            int lastRow = GetLastEmptyRow(workbook);
            ++lastRow;
            worksheet.AddPrintRange(worksheet.Range["A" + (lastRow) + ":DF" + (lastRow + 30)]);
            worksheet.Range["A" + (lastRow) + ":DF" + (lastRow + 30)].CopyFrom(copyRange);

            worksheet.Cells["A" + (lastRow - 1)].RowHeight = 209.3;

            worksheet.Cells["A" + (lastRow)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastRow + 1)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastRow + 2)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastRow + 3)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastRow + 4)].RowHeight = 65.6;
            worksheet.Cells["A" + (lastRow + 5)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastRow + 6)].RowHeight = 65.6;
            worksheet.Cells["A" + (lastRow + 7)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastRow + 8)].RowHeight = 65.6;
            worksheet.Cells["A" + (lastRow + 9)].RowHeight = 65.6;
            worksheet.Cells["A" + (lastRow + 10)].RowHeight = 62.5;
            worksheet.Cells["A" + (lastRow + 11)].RowHeight = 65.6;
            worksheet.Cells["A" + (lastRow + 12)].RowHeight = 65.6;
            worksheet.Cells["A" + (lastRow + 13)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 14)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 15)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 16)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 17)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 18)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 19)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 20)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 21)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 22)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 23)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 24)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 25)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 26)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 27)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 28)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 29)].RowHeight = 87.5;
            worksheet.Cells["A" + (lastRow + 30)].RowHeight = 65.6;

            worksheet.Cells["CY" + (102 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))].Value = (defaultSpecSheet + 2) + realSimpleSheet + 1;
            worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))].Value = techProcessNumber;
            worksheet.Cells["BQ" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))].Value = techProces004Drawing.Number;
            ++realSimpleSheet;

            //worksheet.Cells["DA" + (lastRow + 5)].Value = pageNumber;
            //UpdatePageCounter();
            workbook.EndUpdate();
        }
        public int GetLastSpecificationRow(IWorkbook workbook)
        {
            List<int> bomPosition = new List<int>();
            int currentSpecLatRow = defaultSpecificationLastRow;
            int lastBomPosition = 0;
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            while (currentSpecLatRow > 0)
            {
                string DDD = worksheet.Cells["A" + (currentSpecLatRow)].Value.TextValue;
                if (DDD == null)
                    DDD = "";

                if (DDD.Contains("BOM"))
                {
                    bomPosition.Add(currentSpecLatRow);
                    lastBomPosition = 0;
                    currentSpecLatRow++;
                }
                else
                {
                    currentSpecLatRow++;
                    lastBomPosition++;

                    if (lastBomPosition > 35 && bomPosition.Count() == 0)
                    {
                        lastBomPosition = defaultSpecificationLastRow;
                        break;
                    }
                    else if (lastBomPosition > 35 && bomPosition.Count() > 0)
                    {
                        lastBomPosition = bomPosition.Last();
                        break;
                    }
                }
            }
            workbook.EndUpdate();
            return lastBomPosition;
        }

        public void UpdatePageCounter()
        {
            //workbook.BeginUpdate();
            worksheet.Cells["CS5"].Value = pageNumber;
            //workbook.EndUpdate();
        }

        private void addSpecSheetBtn_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddSpecSheet();
        }

        private void saveTemplateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                workbook.SaveDocument(techProcess004.TechProcessPath, DocumentFormat.Xls);
                DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception)
            {
                if (MessageBox.Show("При сохранении файла возникла ошибка.Файл с таким именем уже существует. Удалить существующий файл? ", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    techProcessService.FileDelete(techProcess004.TechProcessPath);


                }
                else
                {
                    MessageBox.Show("Сохранение техпроцесса невозможно.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void deleteSpecSheetBtn_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (defaultSpecSheet < 2)
            {
                MessageBox.Show("Файл содержит только один лист спецификации");
                return;
            }

            splashScreenManager.ShowWaitForm();
            ButtonEnabled(false);
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            --pageNumber;
            --defaultSpecSheet;



            int lastSpecificationRowRow = GetLastSpecificationRow(workbook);
            int firstDeleteRow = lastSpecificationRowRow - 31;
            worksheet.Rows.Remove(firstDeleteRow, 32);
            workbook.EndUpdate();
            ButtonEnabled(true);
            splashScreenManager.CloseWaitForm();
        }

        private void addSimpleSheetBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddFormSpecificationInfo();
        }

        private void deleteSimpleSheetBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (defaultSimpleSheett < 3)
            {
                MessageBox.Show("У файла отсутствуют добавленные листы");
                return;
            }

            worksheet.Cells["CY" + (102 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))].Value = "";
            worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))].Value = "";
            worksheet.Cells["BQ" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))].Value = "";


            splashScreenManager.ShowWaitForm();
            ButtonEnabled(false);
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            --pageNumber;
            --defaultSimpleSheett;
            --realSimpleSheet;


            int lastEmptyRow = GetLastEmptyRow(workbook);
            int firstDeleteRow = lastEmptyRow - 31;
            worksheet.Rows.Remove(firstDeleteRow, 31);
            workbook.EndUpdate();
            ButtonEnabled(true);
            splashScreenManager.CloseWaitForm();
        }

        public void ButtonEnabled(bool flag)
        {
            addSimpleSheetBtn.Enabled = flag;
            addSpecSheetBtn.Enabled = flag;
            deleteSimpleSheetBtn.Enabled = flag;
            deleteSpecSheetBtn.Enabled = flag;
        }

        public int GetLastEmptyRow(IWorkbook workbook)
        {
            int currentLastRow = defaultLastRow;
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            while (currentLastRow > 0)
            {
                if (worksheet.Cells["B" + (currentLastRow)].Value.IsEmpty)
                {
                    if (worksheet.Cells["B" + (currentLastRow + 1)].Value.IsEmpty &&
                        worksheet.Cells["B" + (currentLastRow + 2)].Value.IsEmpty &&
                        worksheet.Cells["B" + (currentLastRow + 3)].Value.IsEmpty &&
                        worksheet.Cells["B" + (currentLastRow + 4)].Value.IsEmpty &&
                        worksheet.Cells["B" + (currentLastRow + 5)].Value.IsEmpty &&
                        worksheet.Cells["B" + (currentLastRow + 6)].Value.IsEmpty &&
                        worksheet.Cells["B" + (currentLastRow + 7)].Value.IsEmpty &&
                        worksheet.Cells["B" + (currentLastRow + 8)].Value.IsEmpty)
                    {
                        workbook.EndUpdate();
                        return (currentLastRow);
                    }
                    else
                        currentLastRow++;
                }
                else
                    currentLastRow++;
            }
            workbook.EndUpdate();
            return 0;
        }

        public TechProcess004DTO Return()
        {
            return techProcess004;
        }

    }
}