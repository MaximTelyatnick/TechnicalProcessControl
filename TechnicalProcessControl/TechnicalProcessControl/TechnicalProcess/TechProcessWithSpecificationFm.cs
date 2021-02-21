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
using TechnicalProcessControl.BLL;
using TechnicalProcessControl.BLL.Interfaces;
using DevExpress.Spreadsheet;
using static TechnicalProcessControl.Utils;
using Ninject;
using DevExpress.XtraSplashScreen;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcessWithSpecificationFm : DevExpress.XtraEditors.XtraForm
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

        private DrawingDTO techProces003Drawing;
        private TechProcess003DTO techProcess003;
        private TechProcess003DTO techProcess003Old;
        private UsersDTO usersDTO;
        private List<DrawingsDTO> techProcess003DrawingsChild;
        private List<TechProcess003DTO> techProcess003Revision;


        private IReportService reportService;
        private ITechProcessService techProcessService;

        private Utils.Operation operation;

        public int pageNumber = 0;

        public IWorkbook workbook, workbookOld;

        public Worksheet worksheet, worksheetOld;
        public Range copyRange, copyRangeOld;

        int lastOldSpecRow = 0;
        int lastOldSimpleRow = 0;


        public string parentDrawings = "";

        /*
         * Тип работы с файлом
         * Параметры пользователя
         * Информация о чертеже
         * Структуры которые входят в сборку
         * Чертежи в которые входит чертёж
         * Чертежи которые входят в сборку
         * Ревизии техпроцесса
         * Старый техпроцесс
         * */
        public TechProcessWithSpecificationFm(TechProcesFileMode techProcessFileMode, UsersDTO usersDTO, DrawingDTO techProces003Drawing, List<DrawingDTO> drawingParent, List<DrawingsDTO> techProcess003DrawingsChild, List<TechProcess003DTO> techProcess003Revision, TechProcess003DTO techProcess003, TechProcess003DTO techProcess003Old = null)
        {
            InitializeComponent();

            this.techProces003Drawing = techProces003Drawing;
            this.techProcess003DrawingsChild = techProcess003DrawingsChild;
            this.usersDTO = usersDTO;
            this.techProcess003 = techProcess003;
            this.techProcess003Old = techProcess003Old;
            this.techProcess003Revision = techProcess003Revision;

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
                    //workbook.LoadDocument(Properties.Resources.template003New, DocumentFormat.Xls);
                    workbook.LoadDocument(GeneratedReportsDir + @"\template003New.xls", DocumentFormat.Xls);
                    worksheet = workbook.Worksheets[0];

                    if (drawingParent != null)
                        parentDrawings = String.Join(", ", drawingParent.Select(bdsm => bdsm.Number).ToArray());

                    techProcessNumber = reportService.TechProcesNameToStr(techProcess003.TechProcessName);

                    PrintHeader();
                    PrintSpecification();
                    PrintFormTittle();
                    PrintSimpleSheet();


                    workbook.EndUpdate();
                    break;
                case TechProcesFileMode.UpdateTechProcess:

                    workbook.BeginUpdate();
                    workbookOld.BeginUpdate();
                    workbook.LoadDocument(GeneratedReportsDir + @"\template003New.xls", DocumentFormat.Xls);
                    workbookOld.LoadDocument(techProcess003Old.TechProcessPath, DocumentFormat.Xls);

                    worksheetOld = workbookOld.Worksheets[0];
                    worksheet = workbook.Worksheets[0];

                    if (drawingParent != null)
                        parentDrawings = String.Join(", ", drawingParent.Select(bdsm => bdsm.Number).ToArray());

                    techProcessNumber = reportService.TechProcesNameToStr(techProcess003.TechProcessName);

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

        //прописываем ревизии на титульном листе
        private void PrintHeaderRevision()
        {
            if (techProcess003Revision.Count() == 1)
            {
                worksheet.Range["AW2:BV2"].Font.Bold = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Italic = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Size = 8;
                worksheet.Cells["AW" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AW" + 2].Value = techProcess003Revision[0].RivisionName;
                worksheet.Cells["BN" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BN" + 2].Value = usersDTO.Name;
                worksheet.Cells["BE" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BE" + 2].Value = techProcess003Revision[0].RevisionDocumentName;
                worksheet.Cells["BV" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BV" + 2].Font.Size = 6;
                worksheet.Cells["BV" + 2].Value = techProcess003Revision[0].CreateDate.Value.ToShortDateString();
            }
            else if (techProcess003Revision.Count() == 2)
            {
                worksheet.Range["AW2:BV2"].Font.Bold = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Italic = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Size = 8;
                worksheet.Cells["AW" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AW" + 2].Value = techProcess003Revision[0].RivisionName;
                worksheet.Cells["BN" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BN" + 2].Value = usersDTO.Name;
                worksheet.Cells["BE" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BE" + 2].Value = techProcess003Revision[0].RevisionDocumentName;
                worksheet.Cells["BV" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BV" + 2].Font.Size = 6;
                worksheet.Cells["BV" + 2].Value = techProcess003Revision[0].CreateDate.Value.ToShortDateString();

                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Bold = false;
                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Italic = false;
                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Size = 8;
                worksheet.Cells["CB" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CB" + 1].Value = techProcess003Revision[1].RivisionName;
                worksheet.Cells["CS" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CS" + 1].Value = usersDTO.Name;
                worksheet.Cells["CJ" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CJ" + 1].Value = techProcess003Revision[1].RevisionDocumentName;
                worksheet.Cells["DA" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["DA" + 1].Font.Size = 6;
                worksheet.Cells["DA" + 1].Value = techProcess003Revision[1].CreateDate.Value.ToShortDateString();
            }
            else if (techProcess003Revision.Count() > 2)
            {
                worksheet.Range["AW2:BV2"].Font.Bold = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Italic = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Size = 8;
                worksheet.Cells["AW" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AW" + 2].Value = techProcess003Revision[0].RivisionName;
                worksheet.Cells["BN" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BN" + 2].Value = usersDTO.Name;
                worksheet.Cells["BE" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BE" + 2].Value = techProcess003Revision[0].RevisionDocumentName;
                worksheet.Cells["BV" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BV" + 2].Font.Size = 6;
                worksheet.Cells["BV" + 2].Value = techProcess003Revision[0].CreateDate.Value.ToShortDateString();

                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Bold = false;
                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Italic = false;
                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Size = 8;
                worksheet.Cells["CB" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CB" + 1].Value = techProcess003Revision[1].RivisionName;
                worksheet.Cells["CS" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CS" + 1].Value = usersDTO.Name;
                worksheet.Cells["CJ" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CJ" + 1].Value = techProcess003Revision[1].RevisionDocumentName;
                worksheet.Cells["DA" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["DA" + 1].Font.Size = 6;
                worksheet.Cells["DA" + 1].Value = techProcess003Revision[1].CreateDate.Value.ToShortDateString();

                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Bold = false;
                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Italic = false;
                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Size = 8;
                worksheet.Cells["CB" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CB" + 2].Value = techProcess003Revision[2].RivisionName;
                worksheet.Cells["CS" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CS" + 2].Value = usersDTO.Name;
                worksheet.Cells["CJ" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CJ" + 2].Value = techProcess003Revision[2].RevisionDocumentName;
                worksheet.Cells["DA" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["DA" + 2].Font.Size = 6;
                worksheet.Cells["DA" + 2].Value = techProcess003Revision[2].CreateDate.Value.ToShortDateString();
            }
        }

        private void PrintSpecificationEasyRevision()
        {
            if (techProcess003Revision.Count() == 1)
            {
                worksheet.Range["AT"+36+":"+"BS"+36].Font.Bold = false;
                worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Italic = false;
                worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Size = 8;
                worksheet.Cells["AT" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AT" + 36].Value = techProcess003Revision[0].RivisionName;
                worksheet.Cells["BK" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BK" + 36].Value = usersDTO.Name;
                worksheet.Cells["BB" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BB" + 36].Value = techProcess003Revision[0].RevisionDocumentName;
                worksheet.Cells["BS" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BS" + 36].Font.Size = 6;
                worksheet.Cells["BS" + 36].Value = techProcess003Revision[0].CreateDate.Value.ToShortDateString();
            }
            else if (techProcess003Revision.Count() == 2)
            {
                worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Bold = false;
                worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Italic = false;
                worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Size = 8;
                worksheet.Cells["AT" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AT" + 36].Value = techProcess003Revision[0].RivisionName;
                worksheet.Cells["BK" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BK" + 36].Value = usersDTO.Name;
                worksheet.Cells["BB" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BB" + 36].Value = techProcess003Revision[0].RevisionDocumentName;
                worksheet.Cells["BS" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BS" + 36].Font.Size = 6;
                worksheet.Cells["BS" + 36].Value = techProcess003Revision[0].CreateDate.Value.ToShortDateString();

                worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Bold = false;
                worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Italic = false;
                worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Size = 8;
                worksheet.Cells["BY" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BY" + 34].Value = techProcess003Revision[1].RivisionName;
                worksheet.Cells["CP" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CP" + 34].Value = usersDTO.Name;
                worksheet.Cells["CG" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CG" + 34].Value = techProcess003Revision[1].RevisionDocumentName;
                worksheet.Cells["CX" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CX" + 34].Font.Size = 6;
                worksheet.Cells["CX" + 34].Value = techProcess003Revision[1].CreateDate.Value.ToShortDateString();
            }
            else if (techProcess003Revision.Count() == 3)
            {
                worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Bold = false;
                worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Italic = false;
                worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Size = 8;
                worksheet.Cells["AT" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AT" + 36].Value = techProcess003Revision[0].RivisionName;
                worksheet.Cells["BK" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BK" + 36].Value = usersDTO.Name;
                worksheet.Cells["BB" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BB" + 36].Value = techProcess003Revision[0].RevisionDocumentName;
                worksheet.Cells["BS" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BS" + 36].Font.Size = 6;
                worksheet.Cells["BS" + 36].Value = techProcess003Revision[0].CreateDate.Value.ToShortDateString();

                worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Bold = false;
                worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Italic = false;
                worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Size = 8;
                worksheet.Cells["BY" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BY" + 34].Value = techProcess003Revision[1].RivisionName;
                worksheet.Cells["CP" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CP" + 34].Value = usersDTO.Name;
                worksheet.Cells["CG" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CG" + 34].Value = techProcess003Revision[1].RevisionDocumentName;
                worksheet.Cells["CX" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CX" + 34].Font.Size = 6;
                worksheet.Cells["CX" + 34].Value = techProcess003Revision[1].CreateDate.Value.ToShortDateString();

                worksheet.Range["BY" + 35 + ":" + "CX" + 35].Font.Bold = false;
                worksheet.Range["BY" + 35 + ":" + "CX" + 35].Font.Italic = false;
                worksheet.Range["BY" + 35 + ":" + "CX" + 35].Font.Size = 8;
                worksheet.Cells["BY" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BY" + 35].Value = techProcess003Revision[2].RivisionName;
                worksheet.Cells["CP" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CP" + 35].Value = usersDTO.Name;
                worksheet.Cells["CG" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CG" + 35].Value = techProcess003Revision[2].RevisionDocumentName;
                worksheet.Cells["CX" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CX" + 35].Font.Size = 6;
                worksheet.Cells["CX" + 35].Value = techProcess003Revision[2].CreateDate.Value.ToShortDateString();

                worksheet.Range["BY" + 36 + ":" + "CX" + 36].Font.Bold = false;
                worksheet.Range["BY" + 36 + ":" + "CX" + 36].Font.Italic = false;
                worksheet.Range["BY" + 36 + ":" + "CX" + 36].Font.Size = 8;
                worksheet.Cells["BY" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BY" + 36].Value = techProcess003Revision[2].RivisionName;
                worksheet.Cells["CP" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CP" + 36].Value = usersDTO.Name;
                worksheet.Cells["CG" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CG" + 36].Value = techProcess003Revision[2].RevisionDocumentName;
                worksheet.Cells["CX" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CX" + 36].Font.Size = 6;
                worksheet.Cells["CX" + 36].Value = techProcess003Revision[2].CreateDate.Value.ToShortDateString();
            }
        }


        //создаём титульную странницу
        private void PrintHeader()
        {
            worksheet.Cells["CO6"].Value = techProcessNumber;
            worksheet.Cells["BB6"].Value = techProces003Drawing.Number;
            worksheet.Cells["AQ9"].Value = techProces003Drawing.DetailName;
            worksheet.Cells["AJ24"].Value = techProces003Drawing.DetailName;
            worksheet.Cells["BX27"].Value = "Created by " + usersDTO.Name + " " + techProcess003.CreateDate.Value.ToShortDateString();

            if (techProcess003Revision != null)
                PrintHeaderRevision();

            ++pageNumber;
        }

        //создаём странницы спецыфикации
        private void PrintSpecification()
        {
            int specCounter = 48; //строка с которой начинается перечесление спецификации

            worksheet.Cells["CL40"].Value = techProcessNumber;
            worksheet.Cells["AV40"].Value = techProces003Drawing.Number;
            worksheet.Cells["AN43"].Value = techProces003Drawing.DetailName;
            worksheet.Cells["J40"].Value = usersDTO.Name;
            worksheet.Cells["AB40"].Value = techProcess003.CreateDate.Value.ToShortDateString();
            worksheet.Cells["A38"].Value = parentDrawings;
            worksheet.Cells["CV38"].Value = (defaultSpecSheet + 1);

            // сортируем по последнему номеру элемента структуры (если там не цыфра - выводим сообщение что не можем отфильтровать)
            try
            {
                techProcess003DrawingsChild = techProcess003DrawingsChild.OrderBy(bdsm => Convert.ToInt32(bdsm.CurrentLevelMenu.Split('.').Last())).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("не получилось выполнить сортировку, в номере структры присутствуют буквы");
            }
            
            //Если состоит не больше чем из 15, то 1 лист спецификации
            if (techProcess003DrawingsChild.Count() < 15)
            {
                ++pageNumber;
                foreach (var item in techProcess003DrawingsChild)
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
                int rowCounter = 0;//счетчик переполнения текущего листа спецыфикации
                ++pageNumber;

                foreach (var item in techProcess003DrawingsChild)
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

                    if (rowCounter == 14)//на одном листе не больше 14 чертежей
                    {
                        rowCounter = 0;
                        specCounter += 18;//смещение при переходе не следующую странницу
                        AddSpecSheet(); //добавляем еще один лист
                    }
                }
            }

        }

        //создаём пояснительную строку 
        private void PrintFormTittle()
        {
            ++pageNumber;
            worksheet.Cells["CM" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcessNumber;
            worksheet.Cells["AZ" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces003Drawing.Number;
            worksheet.Cells["X" + (79 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces003Drawing.DetailWeight;
            worksheet.Cells["AO" + (75 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces003Drawing.DetailName;
            worksheet.Cells["K" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
            worksheet.Cells["AC" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess003.CreateDate.Value.ToShortDateString();
            worksheet.Cells["B" + (70 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = parentDrawings;
            worksheet.Cells["DA" + (70 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = (defaultSpecSheet + 2);
            


        }

        //по умолчанию в шаблоне 3 простые строки
        private void PrintSimpleSheet()
        {
            for (int i = 0; i < defaultSimpleSheett; i++)
            {
                ++pageNumber;
                worksheet.Cells["CY"+(102+ (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].Value = pageNumber;
                worksheet.Cells["CM"+(104+(31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].Value = techProcessNumber;
                worksheet.Cells["BQ"+(104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].Value = techProces003Drawing.Number;
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
                worksheet.Cells["W" + (lastSpecificationRowRow + i)].Value ="";
                worksheet.Cells["AA" + (lastSpecificationRowRow + i)].Value = "";
                worksheet.Cells["BD" + (lastSpecificationRowRow + i)].Value = "";
                worksheet.Cells["CH" + (lastSpecificationRowRow + i)].Value = "";
                worksheet.Cells["CL" + (lastSpecificationRowRow + i)].Value = "";
                worksheet.Cells["CQ" + (lastSpecificationRowRow + i)].Value = "";
            }

            worksheet.Cells["CL"+(40+(31*( defaultSpecSheet-1)) + (defaultSpecSheet - 1))].Value = techProcessNumber;
            worksheet.Cells["AV"+(40 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces003Drawing.Number;
            worksheet.Cells["AN"+(43 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces003Drawing.DetailName;
            worksheet.Cells["J"+(40 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
            worksheet.Cells["AB"+(40 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess003.CreateDate.Value.ToShortDateString();
            worksheet.Cells["A"+(38 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = parentDrawings;
            worksheet.Cells["CV"+(38 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = (defaultSpecSheet + 1);

            
            
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
                if (i > 2)
                    AddFormSpecificationInfo();
                //worksheet.Range["A" + (97 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (127 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].UnMerge();
                //worksheet.Range["A" + (317 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (347 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].GetMergedRanges();
                workbook.Worksheets[0].Range["A" + (97 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))+":DF"+ (127 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].CopyFrom(copyRangeFromOldFile[i], PasteSpecial.Values | PasteSpecial.NumberFormats);
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
                copySheetrange.Add(worksheetOld.Range["A" + ((lastOldSpecRow + 34) + (31 * i)) + ":" + "DF" + ((lastOldSpecRow + 34+31) + (31 * i)-1)]);
            }

            return copySheetrange;
        }


        private void AddFormSpecificationInfo()
        {
            workbook.BeginUpdate();
            ++pageNumber;
            ++defaultSimpleSheett;

            worksheet = workbook.Worksheets[0];
            copyRange = worksheet["A"+(159 + ((31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)))+":DF"+ (189+((31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)))];
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


            worksheet.Cells["CY" + (102 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett-1)))].Value = (defaultSpecSheet + 2) + defaultSimpleSheett;
            //worksheet.Cells["CY" + (102 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))].Value = (defaultSpecSheet + 2) + realSimpleSheet + 1;
            worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett-1)))].Value = techProcessNumber;
            worksheet.Cells["BQ" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett-1)))].Value = techProces003Drawing.Number;
            //++realSimpleSheet;

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
                        lastBomPosition =  bomPosition.Last();
                        break;
                    }
                }
            }
            workbook.EndUpdate();
            return lastBomPosition;
        }

        //обновляем счетчик общего количества странниц в шаблоне
        public void UpdatePageCounter()
        {
            workbook.BeginUpdate();
            worksheet.Cells["CS5"].Value = pageNumber;
            workbook.EndUpdate();
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






        private void deleteSimpleSheetBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (defaultSimpleSheett < 4)
            {
                MessageBox.Show("У файла отсутствуют добавленные листы");
                return;
            }

            worksheet.Cells["CY" + (102 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = "";
            worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = "";
            worksheet.Cells["BQ" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = "";


            splashScreenManager.ShowWaitForm();
            ButtonEnabled(false);
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            --pageNumber;
            --defaultSimpleSheett;


            int lastEmptyRow = GetLastEmptyRow(workbook);
            int firstDeleteRow = lastEmptyRow - 31;
            worksheet.Rows.Remove(firstDeleteRow, 31);
            workbook.EndUpdate();
            ButtonEnabled(true);
            splashScreenManager.CloseWaitForm();
        }

        private void addSpecSheetBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddSpecSheet();
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
            //++defaultSimpleSheett;
        }

        private void saveTemplateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                workbook.SaveDocument(techProcess003.TechProcessPath, DocumentFormat.Xls);
                DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception)
            {
                if (MessageBox.Show("При сохранении файла возникла ошибка.Файл с таким именем уже существует. Удалить существующий файл? ", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    techProcessService.FileDelete(techProcess003.TechProcessPath);


                }
                else
                {
                    MessageBox.Show("Сохранение техпроцесса невозможно.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }





        public TechProcess003DTO Return()
        {
            return techProcess003;
        }


    }
}