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
        private List<TechProcess004DTO> techProcess004Revision;


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
        public TechProcessWithSpecification004Fm(TechProcesFileMode techProcessFileMode, UsersDTO usersDTO, DrawingDTO techProces004Drawing, List<DrawingDTO> drawingParent, List<DrawingsDTO> techProcess004DrawingsChild, List<TechProcess004DTO> techProcess004Revision, TechProcess004DTO techProcess004, TechProcess004DTO techProcess004Old = null)
        {
            InitializeComponent();

            this.techProces004Drawing = techProces004Drawing;
            this.techProcess004DrawingsChild = techProcess004DrawingsChild;
            this.usersDTO = usersDTO;
            this.techProcess004 = techProcess004;
            this.techProcess004Old = techProcess004Old;
            this.techProcess004Revision = techProcess004Revision;

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


                    workbookOld.EndUpdate();
                    workbook.EndUpdate();
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
            if (techProcess004Revision.Count() == 1)
            {
                worksheet.Range["AW2:BV2"].Font.Bold = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Italic = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Size = 8;
                worksheet.Cells["AW" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AW" + 2].Value = techProcess004Revision[0].RivisionName;
                worksheet.Cells["BN" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BN" + 2].Value = usersDTO.Name;
                worksheet.Cells["BE" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BE" + 2].Value = techProcess004Revision[0].RevisionDocumentName;
                worksheet.Cells["BV" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BV" + 2].Font.Size = 6;
                worksheet.Cells["BV" + 2].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();
            }
            else if (techProcess004Revision.Count() == 2)
            {
                worksheet.Range["AW2:BV2"].Font.Bold = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Italic = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Size = 8;
                worksheet.Cells["AW" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AW" + 2].Value = techProcess004Revision[0].RivisionName;
                worksheet.Cells["BN" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BN" + 2].Value = usersDTO.Name;
                worksheet.Cells["BE" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BE" + 2].Value = techProcess004Revision[0].RevisionDocumentName;
                worksheet.Cells["BV" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BV" + 2].Font.Size = 6;
                worksheet.Cells["BV" + 2].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Bold = false;
                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Italic = false;
                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Size = 8;
                worksheet.Cells["CB" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CB" + 1].Value = techProcess004Revision[1].RivisionName;
                worksheet.Cells["CS" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CS" + 1].Value = usersDTO.Name;
                worksheet.Cells["CJ" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CJ" + 1].Value = techProcess004Revision[1].RevisionDocumentName;
                worksheet.Cells["DA" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["DA" + 1].Font.Size = 6;
                worksheet.Cells["DA" + 1].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();
            }
            else if (techProcess004Revision.Count() > 2)
            {
                worksheet.Range["AW2:BV2"].Font.Bold = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Italic = false;
                worksheet.Range["AW" + 2 + ":" + "BV" + 2].Font.Size = 8;
                worksheet.Cells["AW" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AW" + 2].Value = techProcess004Revision[0].RivisionName;
                worksheet.Cells["BN" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BN" + 2].Value = usersDTO.Name;
                worksheet.Cells["BE" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BE" + 2].Value = techProcess004Revision[0].RevisionDocumentName;
                worksheet.Cells["BV" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BV" + 2].Font.Size = 6;
                worksheet.Cells["BV" + 2].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Bold = false;
                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Italic = false;
                worksheet.Range["CB" + 1 + ":" + "DA" + 1].Font.Size = 8;
                worksheet.Cells["CB" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CB" + 1].Value = techProcess004Revision[1].RivisionName;
                worksheet.Cells["CS" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CS" + 1].Value = usersDTO.Name;
                worksheet.Cells["CJ" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CJ" + 1].Value = techProcess004Revision[1].RevisionDocumentName;
                worksheet.Cells["DA" + 1].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["DA" + 1].Font.Size = 6;
                worksheet.Cells["DA" + 1].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();

                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Bold = false;
                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Italic = false;
                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Size = 8;
                worksheet.Cells["CB" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CB" + 2].Value = techProcess004Revision[2].RivisionName;
                worksheet.Cells["CS" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CS" + 2].Value = usersDTO.Name;
                worksheet.Cells["CJ" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CJ" + 2].Value = techProcess004Revision[2].RevisionDocumentName;
                worksheet.Cells["DA" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["DA" + 2].Font.Size = 6;
                worksheet.Cells["DA" + 2].Value = techProcess004Revision[2].CreateDate.Value.ToShortDateString();
            }
        }

        //прописываем ревизии на листе спецификации
        private void PrintSpecificationEasyRevision()
        {
            if (techProcess004Revision != null)
            {
                if (techProcess004Revision.Count() == 1)
                {
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Bold = false;
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Italic = false;
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Size = 8;
                    worksheet.Cells["AT" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AT" + 36].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BK" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BK" + 36].Value = usersDTO.Name;
                    worksheet.Cells["BB" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BB" + 36].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BS" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BS" + 36].Font.Size = 6;
                    worksheet.Cells["BS" + 36].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();
                }
                else if (techProcess004Revision.Count() == 2)
                {
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Bold = false;
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Italic = false;
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Size = 8;
                    worksheet.Cells["AT" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AT" + 36].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BK" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BK" + 36].Value = usersDTO.Name;
                    worksheet.Cells["BB" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BB" + 36].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BS" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BS" + 36].Font.Size = 6;
                    worksheet.Cells["BS" + 36].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Bold = false;
                    worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Italic = false;
                    worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Size = 8;
                    worksheet.Cells["BY" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BY" + 34].Value = techProcess004Revision[1].RivisionName;
                    worksheet.Cells["CP" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CP" + 34].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 34].Value = techProcess004Revision[1].RevisionDocumentName;
                    worksheet.Cells["CX" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CX" + 34].Font.Size = 6;
                    worksheet.Cells["CX" + 34].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();
                }
                else if (techProcess004Revision.Count() == 3)
                {
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Bold = false;
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Italic = false;
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Size = 8;
                    worksheet.Cells["AT" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AT" + 36].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BK" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BK" + 36].Value = usersDTO.Name;
                    worksheet.Cells["BB" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BB" + 36].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BS" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BS" + 36].Font.Size = 6;
                    worksheet.Cells["BS" + 36].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Bold = false;
                    worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Italic = false;
                    worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Size = 8;
                    worksheet.Cells["BY" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BY" + 34].Value = techProcess004Revision[1].RivisionName;
                    worksheet.Cells["CP" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CP" + 34].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 34].Value = techProcess004Revision[1].RevisionDocumentName;
                    worksheet.Cells["CX" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CX" + 34].Font.Size = 6;
                    worksheet.Cells["CX" + 34].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BY" + 35 + ":" + "CX" + 35].Font.Bold = false;
                    worksheet.Range["BY" + 35 + ":" + "CX" + 35].Font.Italic = false;
                    worksheet.Range["BY" + 35 + ":" + "CX" + 35].Font.Size = 8;
                    worksheet.Cells["BY" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BY" + 35].Value = techProcess004Revision[2].RivisionName;
                    worksheet.Cells["CP" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CP" + 35].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 35].Value = techProcess004Revision[2].RevisionDocumentName;
                    worksheet.Cells["CX" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CX" + 35].Font.Size = 6;
                    worksheet.Cells["CX" + 35].Value = techProcess004Revision[2].CreateDate.Value.ToShortDateString();

                }
                else if (techProcess004Revision.Count() > 3)
                {
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Bold = false;
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Italic = false;
                    worksheet.Range["AT" + 36 + ":" + "BS" + 36].Font.Size = 8;
                    worksheet.Cells["AT" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AT" + 36].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BK" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BK" + 36].Value = usersDTO.Name;
                    worksheet.Cells["BB" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BB" + 36].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BS" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BS" + 36].Font.Size = 6;
                    worksheet.Cells["BS" + 36].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Bold = false;
                    worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Italic = false;
                    worksheet.Range["BY" + 34 + ":" + "CX" + 34].Font.Size = 8;
                    worksheet.Cells["BY" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BY" + 34].Value = techProcess004Revision[1].RivisionName;
                    worksheet.Cells["CP" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CP" + 34].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 34].Value = techProcess004Revision[1].RevisionDocumentName;
                    worksheet.Cells["CX" + 34].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CX" + 34].Font.Size = 6;
                    worksheet.Cells["CX" + 34].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BY" + 35 + ":" + "CX" + 35].Font.Bold = false;
                    worksheet.Range["BY" + 35 + ":" + "CX" + 35].Font.Italic = false;
                    worksheet.Range["BY" + 35 + ":" + "CX" + 35].Font.Size = 8;
                    worksheet.Cells["BY" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BY" + 35].Value = techProcess004Revision[2].RivisionName;
                    worksheet.Cells["CP" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CP" + 35].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 35].Value = techProcess004Revision[2].RevisionDocumentName;
                    worksheet.Cells["CX" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CX" + 35].Font.Size = 6;
                    worksheet.Cells["CX" + 35].Value = techProcess004Revision[2].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BY" + 36 + ":" + "CX" + 36].Font.Bold = false;
                    worksheet.Range["BY" + 36 + ":" + "CX" + 36].Font.Italic = false;
                    worksheet.Range["BY" + 36 + ":" + "CX" + 36].Font.Size = 8;
                    worksheet.Cells["BY" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BY" + 36].Value = techProcess004Revision[3].RivisionName;
                    worksheet.Cells["CP" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CP" + 36].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 36].Value = techProcess004Revision[3].RevisionDocumentName;
                    worksheet.Cells["CX" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CX" + 36].Font.Size = 6;
                    worksheet.Cells["CX" + 36].Value = techProcess004Revision[3].CreateDate.Value.ToShortDateString();
                }
            }
        }

        //прописываем ревизии на титулке листа описания
        private void PrintSpecificationInfoRevision()
        {

            if (techProcess004Revision != null)
            {
                if (techProcess004Revision.Count() == 1)
                {
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Bold = false;
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Italic = false;
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 8;
                    worksheet.Cells["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BL" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BL" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                    worksheet.Cells["BC" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BC" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 6;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                }
                else if (techProcess004Revision.Count() == 2)
                {
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Bold = false;
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Italic = false;
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 8;
                    worksheet.Cells["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BL" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BL" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                    worksheet.Cells["BC" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BC" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 6;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Bold = false;
                    worksheet.Range["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Italic = false;
                    worksheet.Range["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 8;
                    worksheet.Cells["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[1].RivisionName;
                    worksheet.Cells["CQ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[1].RevisionDocumentName;
                    worksheet.Cells["CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 6;
                    worksheet.Cells["CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();

                }
                else if (techProcess004Revision.Count() == 3)
                {
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Bold = false;
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Italic = false;
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 8;
                    worksheet.Cells["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BL" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BL" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                    worksheet.Cells["BC" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BC" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 6;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Bold = false;
                    worksheet.Range["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Italic = false;
                    worksheet.Range["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 8;
                    worksheet.Cells["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[1].RivisionName;
                    worksheet.Cells["CQ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[1].RevisionDocumentName;
                    worksheet.Cells["CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 6;
                    worksheet.Cells["CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Bold = false;
                    worksheet.Range["BZ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Italic = false;
                    worksheet.Range["BZ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 8;
                    worksheet.Cells["BZ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[2].RivisionName;
                    worksheet.Cells["CQ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[2].RevisionDocumentName;
                    worksheet.Cells["CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 6;
                    worksheet.Cells["CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[2].CreateDate.Value.ToShortDateString();

                }
                else if (techProcess004Revision.Count() > 3)
                {
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Bold = false;
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Italic = false;
                    worksheet.Range["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 8;
                    worksheet.Cells["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AU" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BL" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BL" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                    worksheet.Cells["BC" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BC" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 6;
                    worksheet.Cells["BT" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Bold = false;
                    worksheet.Range["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Italic = false;
                    worksheet.Range["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 8;
                    worksheet.Cells["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[1].RivisionName;
                    worksheet.Cells["CQ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[1].RevisionDocumentName;
                    worksheet.Cells["CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 6;
                    worksheet.Cells["CY" + (66 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Bold = false;
                    worksheet.Range["BZ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Italic = false;
                    worksheet.Range["BZ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 8;
                    worksheet.Cells["BZ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[2].RivisionName;
                    worksheet.Cells["CQ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[2].RevisionDocumentName;
                    worksheet.Cells["CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 6;
                    worksheet.Cells["CY" + (67 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[2].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Bold = false;
                    worksheet.Range["BZ" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Italic = false;
                    worksheet.Range["BZ" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1)) + ":" + "CY" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 8;
                    worksheet.Cells["BZ" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[3].RivisionName;
                    worksheet.Cells["CQ" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[3].RevisionDocumentName;
                    worksheet.Cells["CY" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Font.Size = 6;
                    worksheet.Cells["CY" + (68 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004Revision[3].CreateDate.Value.ToShortDateString();
                }
            }
        }

        private void PrintSpecificationInfoRevisionAdded(int sheetNumber)
        {
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            for (int simpleSheet = 0; simpleSheet < sheetNumber; simpleSheet++)
            {
                //worksheet.Range["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "DD" + (106 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Bold = true;
                //worksheet.Range["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "DD" + (106 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 19;
                //worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Bold = true;
                //worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.FontStyle = SpreadsheetFontStyle.Bold;
                //worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = "dsdsd";
                //worksheet.Range["BQ" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "DD" + (106 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Bold = true;
                //worksheet.Range["BQ" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "DD" + (106 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 11;
                //worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Bold = true;
                //worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 11;


                if (techProcess004Revision.Count() == 1)
                {
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Bold = false;
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Italic = false;
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 8;
                    worksheet.Cells["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BL" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BL" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = usersDTO.Name;
                    worksheet.Cells["BC" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BC" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 6;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                }
                else if (techProcess004Revision.Count() == 2)
                {
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Bold = false;
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Italic = false;
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 8;
                    worksheet.Cells["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BL" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BL" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = usersDTO.Name;
                    worksheet.Cells["BC" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BC" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 6;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Bold = false;
                    worksheet.Range["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Italic = false;
                    worksheet.Range["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 8;
                    worksheet.Cells["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[1].RivisionName;
                    worksheet.Cells["CQ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[1].RevisionDocumentName;
                    worksheet.Cells["CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 6;
                    worksheet.Cells["CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();

                }
                else if (techProcess004Revision.Count() == 3)
                {
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Bold = false;
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Italic = false;
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 8;
                    worksheet.Cells["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BL" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BL" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = usersDTO.Name;
                    worksheet.Cells["BC" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BC" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 6;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Bold = false;
                    worksheet.Range["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Italic = false;
                    worksheet.Range["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 8;
                    worksheet.Cells["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[1].RivisionName;
                    worksheet.Cells["CQ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[1].RevisionDocumentName;
                    worksheet.Cells["CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 6;
                    worksheet.Cells["CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Bold = false;
                    worksheet.Range["BZ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Italic = false;
                    worksheet.Range["BZ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1))) + ":" + "CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 8;
                    worksheet.Cells["BZ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[2].RivisionName;
                    worksheet.Cells["CQ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[2].RevisionDocumentName;
                    worksheet.Cells["CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 6;
                    worksheet.Cells["CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Value = techProcess004Revision[2].CreateDate.Value.ToShortDateString();

                }
                else if (techProcess004Revision.Count() > 3)
                {
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Bold = false;
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Italic = false;
                    worksheet.Range["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 8;
                    worksheet.Cells["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AU" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[0].RivisionName;
                    worksheet.Cells["BL" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BL" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = usersDTO.Name;
                    worksheet.Cells["BC" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BC" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[0].RevisionDocumentName;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 6;
                    worksheet.Cells["BT" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[0].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Bold = false;
                    worksheet.Range["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Italic = false;
                    worksheet.Range["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 8;
                    worksheet.Cells["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[1].RivisionName;
                    worksheet.Cells["CQ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[1].RevisionDocumentName;
                    worksheet.Cells["CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 6;
                    worksheet.Cells["CY" + (98 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[1].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Bold = false;
                    worksheet.Range["BZ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Italic = false;
                    worksheet.Range["BZ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 8;
                    worksheet.Cells["BZ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[2].RivisionName;
                    worksheet.Cells["CQ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[2].RevisionDocumentName;
                    worksheet.Cells["CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 6;
                    worksheet.Cells["CY" + (99 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[2].CreateDate.Value.ToShortDateString();

                    worksheet.Range["BZ" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Bold = false;
                    worksheet.Range["BZ" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Italic = false;
                    worksheet.Range["BZ" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet)) + ":" + "CY" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 8;
                    worksheet.Cells["BZ" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BZ" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[3].RivisionName;
                    worksheet.Cells["CQ" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CQ" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = usersDTO.Name;
                    worksheet.Cells["CH" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CH" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[3].RevisionDocumentName;
                    worksheet.Cells["CY" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CY" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Font.Size = 6;
                    worksheet.Cells["CY" + (100 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * simpleSheet))].Value = techProcess004Revision[3].CreateDate.Value.ToShortDateString();
                }
            }
            workbook.EndUpdate();
        }

        //создаём титульную странницу
        private void PrintHeader()
        {
            worksheet.Cells["CO6"].Value = techProcessNumber;
            worksheet.Cells["BB6"].Value = techProces004Drawing.Number;
            worksheet.Cells["AQ9"].Value = techProces004Drawing.DetailName;
            worksheet.Cells["AJ24"].Value = techProces004Drawing.DetailName;
            worksheet.Cells["BX27"].Value = "Created by " + usersDTO.Name + " " + techProcess004.CreateDate.Value.ToShortDateString();

            if (techProcess004Revision != null)
                PrintHeaderRevision();

            ++pageNumber;
        }

        //создаём странницы спецыфикации
        private void PrintSpecification()
        {
            int specCounter = 48; //строка с которой начинается перечесление спецификации

            worksheet.Cells["CL40"].Value = techProcessNumber;
            worksheet.Cells["AV40"].Value = techProces004Drawing.Number;
            worksheet.Cells["AN43"].Value = techProces004Drawing.DetailName;
            worksheet.Cells["J40"].Value = usersDTO.Name;
            worksheet.Cells["AB40"].Value = techProcess004.CreateDate.Value.ToShortDateString();
            worksheet.Cells["A38"].Value = parentDrawings;
            worksheet.Cells["CV38"].Value = (defaultSpecSheet + 1);

            // сортируем по последнему номеру элемента структуры (если там не цыфра - выводим сообщение что не можем отфильтровать)
            try
            {
                techProcess004DrawingsChild = techProcess004DrawingsChild.OrderBy(bdsm => Convert.ToInt32(bdsm.CurrentLevelMenu.Split('.').Last())).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("не получилось выполнить сортировку, в номере структры присутствуют буквы");
            }

            //Если состоит не больше чем из 15, то 1 лист спецификации
            if (techProcess004DrawingsChild.Count() < 15)
            {
                ++pageNumber;
                PrintSpecificationEasyRevision();
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
                int rowCounter = 0;//счетчик переполнения текущего листа спецыфикации
                ++pageNumber;
                PrintSpecificationEasyRevision();

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
            worksheet.Cells["AZ" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces004Drawing.Number;
            worksheet.Cells["X" + (79 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces004Drawing.DetailWeight;
            worksheet.Cells["AO" + (75 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProces004Drawing.DetailName;
            worksheet.Cells["K" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = usersDTO.Name;
            worksheet.Cells["AC" + (72 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = techProcess004.CreateDate.Value.ToShortDateString();
            worksheet.Cells["B" + (70 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = parentDrawings;
            worksheet.Cells["DA" + (70 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1))].Value = (defaultSpecSheet + 2);
            PrintSpecificationInfoRevision();
        }

        //по умолчанию в шаблоне 3 простые строки
        private void PrintSimpleSheet()
        {
            for (int i = 0; i < defaultSimpleSheett; i++)
            {
                ++pageNumber;
                worksheet.Cells["CY" + (102 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].Value = pageNumber;
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
            defaultSimpleSheett = copyRangeFromOldFile.Count;

            for (int i = 0; i < copyRangeFromOldFile.Count; i++)
            {

                if (i > 2)
                    AddFormSpecificationInfo();
                // //worksheet.Range["A" + (97 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (127 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].UnMerge();
                // //worksheet.Range["A" + (317 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (347 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].GetMergedRanges();
                workbook.Worksheets[0].Range["A" + (97 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (127 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].CopyFrom(copyRangeFromOldFile[i]);

                //++pageNumber;
                //worksheet.Cells["CY" + (102 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].Value = pageNumber;
                //worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].Font.FontStyle = SpreadsheetFontStyle.Bold;
                //worksheet.Cells["BQ" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].Font.FontStyle = SpreadsheetFontStyle.Bold;
                // //workbook.Worksheets[0].Range["A" + (317 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (347 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].CopyFrom(workbookOld.Worksheets[0].Range["A" + ((lastOldSpecRow + 34) + (31 * i)) + ":" + "DF" + ((lastOldSpecRow + 34 + 31) + (31 * i) - 1)]);
                // //workbook.Range["A" + (317 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i)) + ":DF" + (347 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * i))].CopyFrom(workbookOld.Worksheets[0].(copyRangeFromOldFile[i]));
                // PrintSpecificationInfoRevisionAdded(i);

            }

            PrintSpecificationInfoRevisionAdded(copyRangeFromOldFile.Count);

            //PrintSpecificationInfoRevisionAdded(copyRangeFromOldFile.Count);

            workbook.EndUpdate();

            //*****************PrintSpecificationInfoRevisionAdded(copyRangeFromOldFile.Count);

            //int row = copyRangeFromOldFile.RowCount;
            //int copyPage = row / 31;

            //worksheet.Range["B" + (110 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))+":"+ "CW" + (125 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * realSimpleSheet))].CopyFrom(copyRange.Worksheet["B14:CW29"]);

            //for(int i=0; i<copyPage;++i)
            // {




            //}



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
            worksheet.Range["A" + (lastRow) + ":DF" + (lastRow + 30)].CopyFrom(copyRange, PasteSpecial.All);

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


            //////worksheet.Cells["CY" + (102 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett-1)))].Value = (defaultSpecSheet + 2) + defaultSimpleSheett;
            //////worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett-1)))].Value = techProcessNumber;
            //////worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Bold = true;
            //////worksheet.Cells["CM" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett - 1)))].Font.Size = 11;
            //////worksheet.Cells["BQ" + (104 + (31 * (defaultSpecSheet - 1)) + (defaultSpecSheet - 1) + (31 * (defaultSimpleSheett-1)))].Value = techProces003Drawing.Number;
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
                        lastBomPosition = bomPosition.Last();
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

            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            --pageNumber;
            --defaultSpecSheet;

            int lastSpecificationRowRow = GetLastSpecificationRow(workbook);
            int firstDeleteRow = lastSpecificationRowRow - 31;
            worksheet.Rows.Remove(firstDeleteRow, 32);
            workbook.EndUpdate();
        }

        private void addSimpleSheetBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddFormSpecificationInfo();
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



            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            --pageNumber;
            --defaultSimpleSheett;


            int lastEmptyRow = GetLastEmptyRow(workbook);
            int firstDeleteRow = lastEmptyRow - 31;
            worksheet.Rows.Remove(firstDeleteRow, 31);
            workbook.EndUpdate();
        }

        public TechProcess004DTO Return()
        {
            return techProcess004;
        }

    }
}