﻿using System;
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
    public partial class TechProcessTempXls002Fm : DevExpress.XtraEditors.XtraForm
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

        private DrawingDTO techProces002Drawing;
        private TechProcess002DTO techProcess002;
        private TechProcess002DTO techProcess002Old;
        private UsersDTO usersDTO;
        private List<DrawingsDTO> techProcess001DrawingsChild;
        private List<TechProcess002DTO> techProcess002Revision;
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

        public TechProcessTempXls002Fm(TechProcesFileMode techProcessFileMode, UsersDTO usersDTO, DrawingDTO techProces002Drawing, List<DrawingDTO> drawingParent, List<TechProcess002DTO> techProcess002Revision, TechProcess002DTO techProcess002, TechProcess002DTO techProcess002Old = null)
        {
            InitializeComponent();

            this.techProces002Drawing = techProces002Drawing;
            //this.techProcess002DrawingsChild = techProcess002DrawingsChild;
            this.usersDTO = usersDTO;
            this.techProcess002 = techProcess002;
            this.techProcess002Revision = techProcess002Revision;
            this.techProcess002Old = techProcess002Old;

            reportService = Program.kernel.Get<IReportService>();
            techProcessService = Program.kernel.Get<ITechProcessService>();
            splashScreenManager = new SplashScreenManager(this, typeof(WaitFm), true, true);
            workbook = spreadsheetControl.Document;
            workbookOld = spreadsheetControlOld.Document;

            switch (techProcessFileMode)
            {
                case TechProcesFileMode.AddTechProcess:

                    workbook.BeginUpdate();
                    workbook.LoadDocument(GeneratedReportsDir + @"\template001New.xls", DocumentFormat.Xls);
                    worksheet = workbook.Worksheets[0];

                    if (drawingParent != null)
                        parentDrawings = String.Join(", ", drawingParent.Select(bdsm => bdsm.Number).ToArray());

                    techProcessNumber = reportService.TechProcesNameToStr(techProcess002.TechProcessName);

                    PrintHeader();
                    PrintSecondSheet();
                    int numberSheet = GetNumberDocumentPages(workbook);
                    PrintInfoSheet((numberSheet - 2));

                    workbook.EndUpdate();
                    break;
                case TechProcesFileMode.UpdateTechProcess:

                    workbook.BeginUpdate();
                    workbookOld.BeginUpdate();
                    workbook.LoadDocument(GeneratedReportsDir + @"\template001New.xls", DocumentFormat.Xls);
                    workbookOld.LoadDocument(techProcess002Old.TechProcessPath, DocumentFormat.Xls);

                    worksheetOld = workbookOld.Worksheets[0];
                    worksheet = workbook.Worksheets[0];

                    if (drawingParent != null)
                        parentDrawings = String.Join(", ", drawingParent.Select(bdsm => bdsm.Number).ToArray());

                    techProcessNumber = reportService.TechProcesNameToStr(techProcess002.TechProcessName);

                    PrintHeader();
                    CopySecondSheet();
                    CopyInfoSheet();

                    UpdatePageCounter();

                    workbookOld.EndUpdate();
                    workbook.EndUpdate();
                    break;
                case TechProcesFileMode.TemplateTechProcess:
                    break;
                default:
                    break;
            }
        }

        private void PrintHeader()
        {
            worksheet.Cells["AG" + 24].Value = "Machining";
            worksheet.Cells["AG" + 24].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center; ;
            worksheet.Cells["BY" + 28].Value = "Created by " + usersDTO.Name + " " + techProcess002.CreateDate.Value.ToShortDateString();
            worksheet.Cells["D" + 30].Value = "Date of issue ";
            worksheet.Cells["DA" + 6].Value = "1";
            worksheet.Cells["AQ" + 10].Value = techProces002Drawing.DetailName;
            worksheet.Cells["AQ" + 10].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center; ;
            worksheet.Cells["BB" + 7].Value = techProces002Drawing.Number;
            worksheet.Cells["BB" + 7].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Cells["CO" + 07].Value = reportService.TechProcesNameToStr(techProcess002.TechProcessName);
            worksheet.Cells["CO" + 07].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Cells["CO7"].Value = techProcessNumber;
            worksheet.Cells["BB6"].Value = techProces002Drawing.Number;
            worksheet.Cells["AQ9"].Value = techProces002Drawing.DetailName;
            worksheet.Cells["AG23"].Value = techProces002Drawing.DetailName;

            if (techProcess002Revision != null)
                PrintHeaderRevision();
        }

        private void PrintSecondSheet()
        {
            worksheet.Cells["J" + 41].Value = usersDTO.Name;
            worksheet.Cells["AF" + 41].Value = techProcess002.CreateDate.Value.ToShortDateString();
            worksheet.Cells["AL" + 44].Value = techProces002Drawing.DetailName;
            worksheet.Cells["AL" + 44].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Cells["F" + 46].Value = techProces002Drawing.MaterialName;
            worksheet.Cells["F" + 46].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
            worksheet.Cells["A" + 39].Value = parentDrawings;
            worksheet.Cells["A" + 39].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Cells["W" + 48].Value = techProcess002.Weight;
            worksheet.Cells["W" + 48].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            string paramaterBlank = "";
            if (techProcess002.TH != "" && techProcess002.TH != null)
                paramaterBlank += techProcess002.TH.ToString() + "х";
            if (techProcess002.W != "" && techProcess002.W != null)
                paramaterBlank += techProcess002.W.ToString() + "x";
            if (techProcess002.W2 != "" && techProcess002.W2 != null)
                paramaterBlank += techProcess002.W2.ToString() + "x";
            if (techProcess002.L != "" && techProcess002.L != null)
                paramaterBlank += techProcess002.L.ToString();
            worksheet.Cells["BI" + 48].Value = paramaterBlank;
            worksheet.Cells["BI" + 48].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Cells["BB" + 41].Value = techProces002Drawing.Number;
            worksheet.Cells["BB" + 41].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Cells["CO" + 41].Value = reportService.TechProcesNameToStr(techProcess002.TechProcessName);
            worksheet.Cells["CO" + 41].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Cells["DC" + 39].Value = "2";
            PrintRevisionSecondheet();
        }

        private void PrintInfoSheet(int sheetNumber)
        {
            for (int i = 0; i < sheetNumber; i++)
            {
                worksheet.Cells["BS" + (74 + (30 * (i)))].Value = techProces002Drawing.Number;
                worksheet.Cells["BS" + (74 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CO" + (74 + (30 * (i)))].Value = reportService.TechProcesNameToStr(techProcess002.TechProcessName);
                worksheet.Cells["CO" + (74 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["DA" + (72 + (30 * (i)))].Value = i + 3;
            }
        }

        private void CopySecondSheet()
        {
            Range copySecondSheetRange = worksheetOld["A" + (34) + ":" + "DG" + (66)];

            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            workbook.Worksheets[0].Range["A" + (34) + ":" + "DG" + (66)].CopyFrom(copySecondSheetRange);
            PrintRevisionSecondheet();
            workbook.EndUpdate();
        }

        private void CopyInfoSheet()
        {
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            List<Range> copyRangeFromOldFile = GetSimpleSheetInfoRange();
            defaultSimpleSheett = copyRangeFromOldFile.Count;

            for (int i = 0; i < copyRangeFromOldFile.Count; i++)
            {
                if (i > 1)
                    AddInfoSheet();
                workbook.Worksheets[0].Range["A" + ((67) + (30 * i)) + ":DG" + ((96) + (29 * i))].CopyFrom(copyRangeFromOldFile[i]);
            }

            PrintRevisionInfoSheets(defaultSimpleSheett);
            //PrintSpecificationInfoRevisionAdded(copyRangeFromOldFile.Count);
            workbook.EndUpdate();
        }

        private List<Range> GetSimpleSheetInfoRange()
        {
            List<Range> copySheetrange = new List<Range>();

            int lastOldSpecRow = 67;
            int lastOldSimpleRow = GetLastEmptyRow(workbookOld);
            Range allInfoFromWorksheet = worksheetOld["A" + (lastOldSpecRow) + ":" + "DG" + (lastOldSimpleRow)];

            int allRow = allInfoFromWorksheet.RowCount;
            int allPages = (allRow / 30);

            for (int i = 0; i < allPages; i++)
            {
                copySheetrange.Add(worksheetOld.Range["A" + ((lastOldSpecRow) + (30 * i)) + ":" + "DG" + ((lastOldSpecRow + 29) + (30 * i))]);
            }
            return copySheetrange;
        }

        #region Delete and add sheet

        private void AddPageInfo()
        {
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            copyRange = worksheet["A" + (67) + ":DG" + (96)];
            int lastRow = GetLastEmptyRow(workbook);
            ++lastRow;
            worksheet.AddPrintRange(worksheet.Range["A" + (lastRow) + ":DG" + (lastRow + 29)]);
            worksheet.Range["A" + (lastRow) + ":DG" + (lastRow + 29)].CopyFrom(copyRange);
            worksheet.Cells["A" + (lastRow)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 1)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 2)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 3)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 4)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 5)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 6)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 7)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 8)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 9)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 10)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 11)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 12)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 13)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 29)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 14)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 15)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 16)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 17)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 18)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 19)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 20)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 21)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 22)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 23)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 24)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 25)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 26)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 27)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 28)].RowHeight = 97.7;
            worksheet.Cells["DA" + (lastRow + 5)].Value = GetNumberDocumentPages(workbook);
            workbook.EndUpdate();
        }

        private void AddInfoSheet()
        {
            workbook.BeginUpdate();
            ++pageNumber;

            worksheet = workbook.Worksheets[0];
            copyRange = worksheet["A97:DG126"];
            int lastRow = GetLastEmptyRow(workbook);
            ++lastRow;
            worksheet.AddPrintRange(worksheet.Range["A" + (lastRow) + ":DG" + (lastRow + 29)]);
            worksheet.Range["A" + (lastRow) + ":DG" + (lastRow + 29)].CopyFrom(copyRange);
            worksheet.Cells["A" + (lastRow)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 1)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 2)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 3)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 4)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 5)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 6)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 7)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 8)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 9)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 10)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 11)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 12)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 13)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 29)].RowHeight = 60.28;
            worksheet.Cells["A" + (lastRow + 14)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 15)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 16)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 17)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 18)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 19)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 20)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 21)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 22)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 23)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 24)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 25)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 26)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 27)].RowHeight = 97.7;
            worksheet.Cells["A" + (lastRow + 28)].RowHeight = 97.7;
            worksheet.Cells["DA" + (lastRow + 5)].Value = pageNumber;
            workbook.EndUpdate();
        }


        private void DeletePageInfo()
        {
            if (GetNumberDocumentPages(workbook) < 4)
            {
                MessageBox.Show("Файл содержит минимальное количество листов");
                return;
            }

            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            int lastEmptyRow = GetLastEmptyRow(workbook);
            int firstDeleteRow = lastEmptyRow - 30;
            worksheet.Rows.Remove(firstDeleteRow, 30);
            workbook.EndUpdate();
            UpdatePageCounter();
        }

        #endregion

        #region Print revision

        //прописываем ревизии на титульном листе
        private void PrintHeaderRevision()
        {
            if (techProcess002Revision.Count() == 1)
            {
                worksheet.Range["AW3:BV3"].Font.Bold = false;
                worksheet.Range["AW" + 3 + ":" + "BV" + 3].Font.Italic = false;
                worksheet.Range["AW" + 3 + ":" + "BV" + 3].Font.Size = 8;
                worksheet.Cells["AW" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AW" + 3].Value = techProcess002Revision[0].RivisionName;
                worksheet.Cells["BN" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BN" + 3].Value = usersDTO.Name;
                worksheet.Cells["BE" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BE" + 3].Value = techProcess002Revision[0].RevisionDocumentName;
                worksheet.Cells["BV" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BV" + 3].Font.Size = 6;
                worksheet.Cells["BV" + 3].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
            }
            else if (techProcess002Revision.Count() == 2)
            {
                worksheet.Range["AW3:BV3"].Font.Bold = false;
                worksheet.Range["AW" + 3 + ":" + "BV" + 3].Font.Italic = false;
                worksheet.Range["AW" + 3 + ":" + "BV" + 3].Font.Size = 8;
                worksheet.Cells["AW" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AW" + 3].Value = techProcess002Revision[0].RivisionName;
                worksheet.Cells["BN" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BN" + 3].Value = usersDTO.Name;
                worksheet.Cells["BE" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BE" + 3].Value = techProcess002Revision[0].RevisionDocumentName;
                worksheet.Cells["BV" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BV" + 3].Font.Size = 6;
                worksheet.Cells["BV" + 3].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Bold = false;
                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Italic = false;
                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Size = 8;
                worksheet.Cells["CB" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CB" + 2].Value = techProcess002Revision[1].RivisionName;
                worksheet.Cells["CS" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CS" + 2].Value = usersDTO.Name;
                worksheet.Cells["CJ" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CJ" + 2].Value = techProcess002Revision[1].RevisionDocumentName;
                worksheet.Cells["DA" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["DA" + 2].Font.Size = 6;
                worksheet.Cells["DA" + 2].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();
            }
            else if (techProcess002Revision.Count() > 2)
            {
                worksheet.Range["AW3:BV3"].Font.Bold = false;
                worksheet.Range["AW" + 3 + ":" + "BV" + 3].Font.Italic = false;
                worksheet.Range["AW" + 3 + ":" + "BV" + 3].Font.Size = 8;
                worksheet.Cells["AW" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["AW" + 3].Value = techProcess002Revision[0].RivisionName;
                worksheet.Cells["BN" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BN" + 3].Value = usersDTO.Name;
                worksheet.Cells["BE" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["BE" + 3].Value = techProcess002Revision[0].RevisionDocumentName;
                worksheet.Cells["BV" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["BV" + 3].Font.Size = 6;
                worksheet.Cells["BV" + 3].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Bold = false;
                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Italic = false;
                worksheet.Range["CB" + 2 + ":" + "DA" + 2].Font.Size = 8;
                worksheet.Cells["CB" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CB" + 2].Value = techProcess002Revision[1].RivisionName;
                worksheet.Cells["CS" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CS" + 2].Value = usersDTO.Name;
                worksheet.Cells["CJ" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CJ" + 2].Value = techProcess002Revision[1].RevisionDocumentName;
                worksheet.Cells["DA" + 2].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["DA" + 2].Font.Size = 6;
                worksheet.Cells["DA" + 2].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();
                worksheet.Range["CB" + 3 + ":" + "DA" + 3].Font.Bold = false;
                worksheet.Range["CB" + 3 + ":" + "DA" + 3].Font.Italic = false;
                worksheet.Range["CB" + 3 + ":" + "DA" + 3].Font.Size = 8;
                worksheet.Cells["CB" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CB" + 3].Value = techProcess002Revision[2].RivisionName;
                worksheet.Cells["CS" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["CS" + 3].Value = usersDTO.Name;
                worksheet.Cells["CJ" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                worksheet.Cells["CJ" + 3].Value = techProcess002Revision[2].RevisionDocumentName;
                worksheet.Cells["DA" + 3].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                worksheet.Cells["DA" + 3].Font.Size = 6;
                worksheet.Cells["DA" + 3].Value = techProcess002Revision[2].CreateDate.Value.ToShortDateString();
            }
        }

        //прописываем ревизии на втором листе
        private void PrintRevisionSecondheet()
        {
            if (techProcess002Revision != null)
            {
                if (techProcess002Revision.Count() == 1)
                {
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Bold = false;
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Italic = false;
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Size = 8;
                    worksheet.Cells["AW" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AW" + 37].Value = techProcess002Revision[0].RivisionName;
                    worksheet.Cells["BN" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BN" + 37].Value = usersDTO.Name;
                    worksheet.Cells["BE" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BE" + 37].Value = techProcess002Revision[0].RevisionDocumentName;
                    worksheet.Cells["BV" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BV" + 37].Font.Size = 6;
                    worksheet.Cells["BV" + 37].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                }
                else if (techProcess002Revision.Count() == 2)
                {
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Bold = false;
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Italic = false;
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Size = 8;
                    worksheet.Cells["AW" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AW" + 37].Value = techProcess002Revision[0].RivisionName;
                    worksheet.Cells["BN" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BN" + 37].Value = usersDTO.Name;
                    worksheet.Cells["BE" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BE" + 37].Value = techProcess002Revision[0].RevisionDocumentName;
                    worksheet.Cells["BV" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BV" + 37].Font.Size = 6;
                    worksheet.Cells["BV" + 37].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                    worksheet.Range["CB" + 35 + ":" + "CX" + 35].Font.Bold = false;
                    worksheet.Range["CB" + 35 + ":" + "CX" + 35].Font.Italic = false;
                    worksheet.Range["CB" + 35 + ":" + "CX" + 35].Font.Size = 8;
                    worksheet.Cells["CB" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CB" + 35].Value = techProcess002Revision[1].RivisionName;
                    worksheet.Cells["CS" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CS" + 35].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 35].Value = techProcess002Revision[1].RevisionDocumentName;
                    worksheet.Cells["DA" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["DA" + 35].Font.Size = 6;
                    worksheet.Cells["DA" + 35].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();
                }
                else if (techProcess002Revision.Count() == 3)
                {
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Bold = false;
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Italic = false;
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Size = 8;
                    worksheet.Cells["AW" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AW" + 37].Value = techProcess002Revision[0].RivisionName;
                    worksheet.Cells["BN" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BN" + 37].Value = usersDTO.Name;
                    worksheet.Cells["BE" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BE" + 37].Value = techProcess002Revision[0].RevisionDocumentName;
                    worksheet.Cells["BV" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BV" + 37].Font.Size = 6;
                    worksheet.Cells["BV" + 37].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                    worksheet.Range["CB" + 35 + ":" + "CX" + 35].Font.Bold = false;
                    worksheet.Range["CB" + 35 + ":" + "CX" + 35].Font.Italic = false;
                    worksheet.Range["CB" + 35 + ":" + "CX" + 35].Font.Size = 8;
                    worksheet.Cells["CB" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CB" + 35].Value = techProcess002Revision[1].RivisionName;
                    worksheet.Cells["CS" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CS" + 35].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 35].Value = techProcess002Revision[1].RevisionDocumentName;
                    worksheet.Cells["DA" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["DA" + 35].Font.Size = 6;
                    worksheet.Cells["DA" + 35].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();
                    worksheet.Range["CB" + 36 + ":" + "CX" + 36].Font.Bold = false;
                    worksheet.Range["CB" + 36 + ":" + "CX" + 36].Font.Italic = false;
                    worksheet.Range["CB" + 36 + ":" + "CX" + 36].Font.Size = 8;
                    worksheet.Cells["CB" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CB" + 36].Value = techProcess002Revision[2].RivisionName;
                    worksheet.Cells["CS" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CS" + 36].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 36].Value = techProcess002Revision[2].RevisionDocumentName;
                    worksheet.Cells["DA" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["DA" + 36].Font.Size = 6;
                    worksheet.Cells["DA" + 36].Value = techProcess002Revision[2].CreateDate.Value.ToShortDateString();
                }
                else if (techProcess002Revision.Count() > 3)
                {
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Bold = false;
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Italic = false;
                    worksheet.Range["AW" + 37 + ":" + "BV" + 37].Font.Size = 8;
                    worksheet.Cells["AW" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["AW" + 37].Value = techProcess002Revision[0].RivisionName;
                    worksheet.Cells["BN" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BN" + 37].Value = usersDTO.Name;
                    worksheet.Cells["BE" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["BE" + 37].Value = techProcess002Revision[0].RevisionDocumentName;
                    worksheet.Cells["BV" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["BV" + 37].Font.Size = 6;
                    worksheet.Cells["BV" + 37].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                    worksheet.Range["CB" + 35 + ":" + "CX" + 35].Font.Bold = false;
                    worksheet.Range["CB" + 35 + ":" + "CX" + 35].Font.Italic = false;
                    worksheet.Range["CB" + 35 + ":" + "CX" + 35].Font.Size = 8;
                    worksheet.Cells["CB" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CB" + 35].Value = techProcess002Revision[1].RivisionName;
                    worksheet.Cells["CS" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CS" + 35].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 35].Value = techProcess002Revision[1].RevisionDocumentName;
                    worksheet.Cells["DA" + 35].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["DA" + 35].Font.Size = 6;
                    worksheet.Cells["DA" + 35].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();
                    worksheet.Range["CB" + 36 + ":" + "CX" + 36].Font.Bold = false;
                    worksheet.Range["CB" + 36 + ":" + "CX" + 36].Font.Italic = false;
                    worksheet.Range["CB" + 36 + ":" + "CX" + 36].Font.Size = 8;
                    worksheet.Cells["CB" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CB" + 36].Value = techProcess002Revision[2].RivisionName;
                    worksheet.Cells["CS" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CS" + 36].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 36].Value = techProcess002Revision[2].RevisionDocumentName;
                    worksheet.Cells["DA" + 36].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["DA" + 36].Font.Size = 6;
                    worksheet.Cells["DA" + 36].Value = techProcess002Revision[2].CreateDate.Value.ToShortDateString();
                    worksheet.Range["CB" + 37 + ":" + "CX" + 37].Font.Bold = false;
                    worksheet.Range["CB" + 37 + ":" + "CX" + 37].Font.Italic = false;
                    worksheet.Range["CB" + 37 + ":" + "CX" + 37].Font.Size = 8;
                    worksheet.Cells["CB" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CB" + 37].Value = techProcess002Revision[3].RivisionName;
                    worksheet.Cells["CS" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["CS" + 37].Value = usersDTO.Name;
                    worksheet.Cells["CG" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                    worksheet.Cells["CG" + 37].Value = techProcess002Revision[3].RevisionDocumentName;
                    worksheet.Cells["DA" + 37].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    worksheet.Cells["DA" + 37].Font.Size = 6;
                    worksheet.Cells["DA" + 37].Value = techProcess002Revision[3].CreateDate.Value.ToShortDateString();
                }
            }
        }

        private void saveTemplateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                workbook.SaveDocument(techProcess002.TechProcessPath, DocumentFormat.Xls);
                DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception)
            {
                if (MessageBox.Show("При сохранении файла возникла ошибка.Файл с таким именем уже существует. Удалить существующий файл? ", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    techProcessService.FileDelete(techProcess002.TechProcessPath);


                }
                else
                {
                    MessageBox.Show("Сохранение техпроцесса невозможно.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void PrintRevisionInfoSheets(int pageNumber)
        {
            if (techProcess002Revision != null)
            {
                for (int i = 0; i < pageNumber; i++)
                {
                    if (techProcess002Revision.Count() == 1)
                    {
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Bold = false;
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Italic = false;
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Size = 8;
                        worksheet.Cells["AW" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["AW" + (70 + (30 * (i)))].Value = techProcess002Revision[0].RivisionName;
                        worksheet.Cells["BN" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["BN" + (70 + (30 * (i)))].Value = usersDTO.Name;
                        worksheet.Cells["BE" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["BE" + (70 + (30 * (i)))].Value = techProcess002Revision[0].RevisionDocumentName;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Font.Size = 6;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                    }
                    else if (techProcess002Revision.Count() == 2)
                    {
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Bold = false;
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Italic = false;
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Size = 8;
                        worksheet.Cells["AW" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["AW" + (70 + (30 * (i)))].Value = techProcess002Revision[0].RivisionName;
                        worksheet.Cells["BN" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["BN" + (70 + (30 * (i)))].Value = usersDTO.Name;
                        worksheet.Cells["BE" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["BE" + (70 + (30 * (i)))].Value = techProcess002Revision[0].RevisionDocumentName;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Font.Size = 6;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                        worksheet.Range["CB" + (68 + (30 * (i))) + ":" + "CX" + (68 + (30 * (i)))].Font.Bold = false;
                        worksheet.Range["CB" + (68 + (30 * (i))) + ":" + "CX" + (68 + (30 * (i)))].Font.Italic = false;
                        worksheet.Range["CB" + (68 + (30 * (i))) + ":" + "CX" + (68 + (30 * (i)))].Font.Size = 8;
                        worksheet.Cells["CB" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CB" + (68 + (30 * (i)))].Value = techProcess002Revision[1].RivisionName;
                        worksheet.Cells["CS" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["CS" + (68 + (30 * (i)))].Value = usersDTO.Name;
                        worksheet.Cells["CG" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CG" + (68 + (30 * (i)))].Value = techProcess002Revision[1].RevisionDocumentName;
                        worksheet.Cells["DA" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["DA" + (68 + (30 * (i)))].Font.Size = 6;
                        worksheet.Cells["DA" + (68 + (30 * (i)))].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();
                    }
                    else if (techProcess002Revision.Count() == 3)
                    {
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Bold = false;
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Italic = false;
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Size = 8;
                        worksheet.Cells["AW" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["AW" + (70 + (30 * (i)))].Value = techProcess002Revision[0].RivisionName;
                        worksheet.Cells["BN" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["BN" + (70 + (30 * (i)))].Value = usersDTO.Name;
                        worksheet.Cells["BE" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["BE" + (70 + (30 * (i)))].Value = techProcess002Revision[0].RevisionDocumentName;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Font.Size = 6;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                        worksheet.Range["CB" + (68 + (30 * (i))) + ":" + "CX" + (68 + (30 * (i)))].Font.Bold = false;
                        worksheet.Range["CB" + (68 + (30 * (i))) + ":" + "CX" + (68 + (30 * (i)))].Font.Italic = false;
                        worksheet.Range["CB" + (68 + (30 * (i))) + ":" + "CX" + (68 + (30 * (i)))].Font.Size = 8;
                        worksheet.Cells["CB" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CB" + (68 + (30 * (i)))].Value = techProcess002Revision[1].RivisionName;
                        worksheet.Cells["CS" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["CS" + (68 + (30 * (i)))].Value = usersDTO.Name;
                        worksheet.Cells["CG" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CG" + (68 + (30 * (i)))].Value = techProcess002Revision[1].RevisionDocumentName;
                        worksheet.Cells["DA" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["DA" + (68 + (30 * (i)))].Font.Size = 6;
                        worksheet.Cells["DA" + (68 + (30 * (i)))].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();
                        worksheet.Range["CB" + (69 + (30 * (i))) + ":" + "CX" + (69 + (30 * (i)))].Font.Bold = false;
                        worksheet.Range["CB" + (69 + (30 * (i))) + ":" + "CX" + (69 + (30 * (i)))].Font.Italic = false;
                        worksheet.Range["CB" + (69 + (30 * (i))) + ":" + "CX" + (69 + (30 * (i)))].Font.Size = 8;
                        worksheet.Cells["CB" + (69 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CB" + (69 + (30 * (i)))].Value = techProcess002Revision[2].RivisionName;
                        worksheet.Cells["CS" + (69 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["CS" + (69 + (30 * (i)))].Value = usersDTO.Name;
                        worksheet.Cells["CG" + (69 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CG" + (69 + (30 * (i)))].Value = techProcess002Revision[2].RevisionDocumentName;
                        worksheet.Cells["DA" + (69 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["DA" + (69 + (30 * (i)))].Font.Size = 6;
                        worksheet.Cells["DA" + (69 + (30 * (i)))].Value = techProcess002Revision[2].CreateDate.Value.ToShortDateString();
                    }
                    else if (techProcess002Revision.Count() > 3)
                    {
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Bold = false;
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Italic = false;
                        worksheet.Range["AW" + (70 + (30 * (i))) + ":" + "BV" + (70 + (30 * (i)))].Font.Size = 8;
                        worksheet.Cells["AW" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["AW" + (70 + (30 * (i)))].Value = techProcess002Revision[0].RivisionName;
                        worksheet.Cells["BN" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["BN" + (70 + (30 * (i)))].Value = usersDTO.Name;
                        worksheet.Cells["BE" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["BE" + (70 + (30 * (i)))].Value = techProcess002Revision[0].RevisionDocumentName;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Font.Size = 6;
                        worksheet.Cells["BV" + (70 + (30 * (i)))].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                        worksheet.Range["CB" + (68 + (30 * (i))) + ":" + "CX" + (68 + (30 * (i)))].Font.Bold = false;
                        worksheet.Range["CB" + (68 + (30 * (i))) + ":" + "CX" + (68 + (30 * (i)))].Font.Italic = false;
                        worksheet.Range["CB" + (68 + (30 * (i))) + ":" + "CX" + (68 + (30 * (i)))].Font.Size = 8;
                        worksheet.Cells["CB" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CB" + (68 + (30 * (i)))].Value = techProcess002Revision[1].RivisionName;
                        worksheet.Cells["CS" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["CS" + (68 + (30 * (i)))].Value = usersDTO.Name;
                        worksheet.Cells["CG" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CG" + (68 + (30 * (i)))].Value = techProcess002Revision[1].RevisionDocumentName;
                        worksheet.Cells["DA" + (68 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["DA" + (68 + (30 * (i)))].Font.Size = 6;
                        worksheet.Cells["DA" + (68 + (30 * (i)))].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();
                        worksheet.Range["CB" + (69 + (30 * (i))) + ":" + "CX" + (69 + (30 * (i)))].Font.Bold = false;
                        worksheet.Range["CB" + (69 + (30 * (i))) + ":" + "CX" + (69 + (30 * (i)))].Font.Italic = false;
                        worksheet.Range["CB" + (69 + (30 * (i))) + ":" + "CX" + (69 + (30 * (i)))].Font.Size = 8;
                        worksheet.Cells["CB" + (69 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CB" + (69 + (30 * (i)))].Value = techProcess002Revision[2].RivisionName;
                        worksheet.Cells["CS" + (69 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["CS" + (69 + (30 * (i)))].Value = usersDTO.Name;
                        worksheet.Cells["CG" + (69 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CG" + (69 + (30 * (i)))].Value = techProcess002Revision[2].RevisionDocumentName;
                        worksheet.Cells["DA" + (69 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["DA" + (69 + (30 * (i)))].Font.Size = 6;
                        worksheet.Cells["DA" + (69 + (30 * (i)))].Value = techProcess002Revision[2].CreateDate.Value.ToShortDateString();
                        worksheet.Range["CB" + (70 + (30 * (i))) + ":" + "CX" + (70 + (30 * (i)))].Font.Bold = false;
                        worksheet.Range["CB" + (70 + (30 * (i))) + ":" + "CX" + (70 + (30 * (i)))].Font.Italic = false;
                        worksheet.Range["CB" + (70 + (30 * (i))) + ":" + "CX" + (70 + (30 * (i)))].Font.Size = 8;
                        worksheet.Cells["CB" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CB" + (70 + (30 * (i)))].Value = techProcess002Revision[3].RivisionName;
                        worksheet.Cells["CS" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["CS" + (70 + (30 * (i)))].Value = usersDTO.Name;
                        worksheet.Cells["CG" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                        worksheet.Cells["CG" + (70 + (30 * (i)))].Value = techProcess002Revision[3].RevisionDocumentName;
                        worksheet.Cells["DA" + (70 + (30 * (i)))].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        worksheet.Cells["DA" + (70 + (30 * (i)))].Font.Size = 6;
                        worksheet.Cells["DA" + (70 + (30 * (i)))].Value = techProcess002Revision[3].CreateDate.Value.ToShortDateString();
                    }
                    worksheet.Cells["DA" + (72 + (30 * (i)))].Value = i + 3;
                }
            }
        }

        #endregion

        public int GetNumberDocumentPages(IWorkbook workbook)
        {
            var worksheet = workbook.Worksheets[0];
            int currentLastRow = GetLastEmptyRow(workbook);
            return (int)Math.Ceiling(((double)currentLastRow / 34));
        }

        

        public int GetLastEmptyRow(IWorkbook workbook)
        {
            int currentLastRow = 97;
            var worksheet = workbook.Worksheets[0];

            while (currentLastRow > 0)
            {
                if (worksheet.Cells["A" + (currentLastRow)].Value.IsEmpty)
                {
                    if (worksheet.Cells["A" + (currentLastRow + 1)].Value.IsEmpty &&
                        worksheet.Cells["A" + (currentLastRow + 2)].Value.IsEmpty &&
                        worksheet.Cells["A" + (currentLastRow + 3)].Value.IsEmpty &&
                        worksheet.Cells["A" + (currentLastRow + 4)].Value.IsEmpty &&
                        worksheet.Cells["A" + (currentLastRow + 5)].Value.IsEmpty &&
                        worksheet.Cells["A" + (currentLastRow + 6)].Value.IsEmpty)
                    {
                        return currentLastRow;
                    }
                    else
                        currentLastRow++;
                }
                else
                    currentLastRow++;
            }
            return 0;
        }

        public void UpdatePageCounter()
        {
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            worksheet.Cells["CS6"].Value = GetNumberDocumentPages(workbook);
            workbook.EndUpdate();
        }

        public TechProcess002DTO Return()
        {
            return techProcess002;
        }

        private void addSimpleSheetBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddPageInfo();
            UpdatePageCounter();
        }

        private void deleteSimpleSheetBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeletePageInfo();
        }
    }
}