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

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcessWithSpecificationFm : DevExpress.XtraEditors.XtraForm
    {
        string techProcessNumber;
        int defaultLastRow = 189;
        int defaultSpecificationLastRow = 64;
        private string GeneratedReportsDir = Utils.HomePath + @"\Templates\";


        private IReportService reportService;

        private Utils.Operation operation;

        public int pageNumber;

        public IWorkbook workbook;
        public Worksheet worksheet;
        public Range copyRange;


        public TechProcessWithSpecificationFm(TechProcesFileMode techProcessFileMode, UsersDTO usersDTO, DrawingDTO techProces003Drawing, List<DrawingDTO> techProcess003DrawingsParent, List<TechProcess003DTO> techProcess003Revision, TechProcess003DTO techProcess003, TechProcess003DTO techProcess003Old = null)
        {
            InitializeComponent();

            reportService = Program.kernel.Get<IReportService>();

            workbook = spreadsheetControl.Document;
            
            workbook.BeginUpdate();
            workbook.LoadDocument(GeneratedReportsDir + @"\template003New.xls", DocumentFormat.Xls);
            worksheet = workbook.Worksheets[0];
            //Factory.GetWorkbook(GeneratedReportsDir + @"\template001.xls");
            switch (techProcessFileMode)
            {
                case TechProcesFileMode.AddTechProcess:
                    techProcessNumber = reportService.TechProcesNameToStr(techProcess003.TechProcessName);
                    worksheet.Cells["CO6"].Value = techProcessNumber;
                    worksheet.Cells["BB6"].Value = techProces003Drawing.Number;
                    worksheet.Cells["AQ9"].Value = techProces003Drawing.DetailName;
                    worksheet.Cells["BX27"].Value = "Created by " + usersDTO.Name + " " + techProcess003.CreateDate.Value.ToShortDateString();

                    //worksheet.Cells["CS6"].Value = pageNumber;





                    break;
                case TechProcesFileMode.UpdateTechProcess:
                    break;
                case TechProcesFileMode.TemplateTechProcess:
                    break;
                default:
                    break;
            }

           




            





            workbook.EndUpdate();



            
        }

        private void addSpecSheetBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            workbook.BeginUpdate();
            ++pageNumber;

            worksheet = workbook.Worksheets[0];
            copyRange = worksheet["A33:DF64"];
            int lastSpecificationRowRow = GetLastSpecificationRow();
            //++lastRow;
            //worksheet.InsertCells(copyRange);
            worksheet.Rows.Insert(lastSpecificationRowRow, 31);
            worksheet.AddPrintRange(worksheet.Range["A" + (lastSpecificationRowRow) + ":DG" + (lastSpecificationRowRow + 31)]);
            worksheet.Range["A" + (lastSpecificationRowRow) + ":DG" + (lastSpecificationRowRow + 31)].CopyFrom(copyRange);

            //worksheet.Cells["A" + (lastRow)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 1)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 2)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 3)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 4)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 5)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 6)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 7)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 8)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 9)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 10)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 11)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 12)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 13)].RowHeight = 97.7;

            //worksheet.Cells["A" + (lastRow + 29)].RowHeight = 60.28;
            //worksheet.Cells["A" + (lastRow + 14)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 15)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 16)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 17)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 18)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 19)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 20)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 21)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 22)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 23)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 24)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 25)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 26)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 27)].RowHeight = 97.7;
            //worksheet.Cells["A" + (lastRow + 28)].RowHeight = 97.7;
            ////worksheet.Cells["A" + (lastRow + 29)].RowHeight = 97.7;
            ////worksheet.Cells["A" + (lastRow + 30)].RowHeight = 97.7;
            //worksheet.Cells["DA" + (lastRow + 5)].Value = pageNumber;
            UpdatePageCounter();
            workbook.EndUpdate();
        }

        public int GetLastSpecificationRow()
        {
            List<int> bomPosition = new List<int>();
            int currentSpecLatRow = defaultSpecificationLastRow;
            int lastBomPosition = 0;
            workbook.BeginUpdate();
            worksheet = workbook.Worksheets[0];
            while (currentSpecLatRow > 0)
            {
                if (worksheet.Cells["A" + (currentSpecLatRow)].Value == "BOM")
                {
                    bomPosition.Add(currentSpecLatRow);
                    lastBomPosition = 0;
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

        public void UpdatePageCounter()
        {
            //workbook.BeginUpdate();
            worksheet.Cells["CS5"].Value = pageNumber;
            //workbook.EndUpdate();
        }
    }
}