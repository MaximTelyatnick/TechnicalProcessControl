using AutoMapper;
using SpreadsheetGear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalProcessControl.BLL.Infrastructure;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.DAL.Interfaces;
using TechnicalProcessControl.DAL.Models;

namespace TechnicalProcessControl.BLL.Services
{
    public class ReportService: IReportService
    {
        private string GeneratedReportsDir = Utils.HomePath + @"\Temp\";


        private IUnitOfWork Database { get; set; }

        private IRepository<Drawings> drawings;
        private IRepository<DrawingScan> drawingScan;
        private IRepository<Details> details;
        private IRepository<DAL.Models.Type> type;
        private IRepository<TechProcess001> techProcess001;
        private IRepository<TechProcess002> techProcess002;
        private IRepository<TechProcess003> techProcess003;
        private IRepository<TechProcess004> techProcess004;
        private IRepository<TechProcess005> techProcess005;

        private IMapper mapper;

        public ReportService(IUnitOfWork uow)
        {
            Database = uow;

            drawings = Database.GetRepository<Drawings>();
            drawingScan = Database.GetRepository<DrawingScan>();
            details = Database.GetRepository<Details>();
            type = Database.GetRepository<DAL.Models.Type>();
            techProcess001 = Database.GetRepository<TechProcess001>();
            techProcess002 = Database.GetRepository<TechProcess002>();
            techProcess003 = Database.GetRepository<TechProcess003>();
            techProcess004 = Database.GetRepository<TechProcess004>();
            techProcess005 = Database.GetRepository<TechProcess005>();


            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Drawings, DrawingsDTO>();
                cfg.CreateMap<DrawingsDTO, Drawings>();
                cfg.CreateMap<DrawingScan, DrawingScanDTO>();
                cfg.CreateMap<DrawingScanDTO, DrawingScan>();
                cfg.CreateMap<Details, DetailsDTO>();
                cfg.CreateMap<DetailsDTO, Details>();
                cfg.CreateMap<DAL.Models.Type, TypeDTO>();
                cfg.CreateMap<TypeDTO, DAL.Models.Type>();
                cfg.CreateMap<Details, DetailsDTO>();
                cfg.CreateMap<DetailsDTO, Details>();
                cfg.CreateMap<TechProcess001, TechProcess001DTO>();
                cfg.CreateMap<TechProcess001DTO, TechProcess001>();
                cfg.CreateMap<TechProcess002, TechProcess002DTO>();
                cfg.CreateMap<TechProcess002DTO, TechProcess002>();
                cfg.CreateMap<TechProcess003, TechProcess003DTO>();
                cfg.CreateMap<TechProcess003DTO, TechProcess003>();
                cfg.CreateMap<TechProcess004, TechProcess004DTO>();
                cfg.CreateMap<TechProcess004DTO, TechProcess004>();
                cfg.CreateMap<TechProcess005, TechProcess005DTO>();
                cfg.CreateMap<TechProcess005DTO, TechProcess005>();

            });

            mapper = config.CreateMapper();
        }

        //public bool CreateTemplateTechProcess001(DrawingsDTO source)
        //{
        //    try
        //    {
        //        Factory.GetWorkbook(GeneratedReportsDir + @"\Templates\BankPaymentTrialBalanceAll313Template.xls");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Не знайдено шаблон документа!\n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }


        //    var Workbook = Factory.GetWorkbook(GeneratedReportsDir + @"\Templates\BankPaymentTrialBalanceAll313Template.xls");
        //    var Worksheet = Workbook.Worksheets[0];
        //    var Сells = Worksheet.Cells;

        //    IRange cells = Worksheet.Cells;

        //    string statementDate = RuDateAndMoneyConverter.DateToTextShort(endDate);

        //    Сells["A" + 6].Value = "за " + statementDate + " року";
        //    Сells["A" + 6].HorizontalAlignment = HAlign.Center;

        //    int startWith = 9;
        //    int k = startWith;
        //    int counterRow = 1;
        //    decimal prevSaldo = 0;
        //    decimal endSaldo = 0;


        //    int currentBankAccountId = dataSource[0].Bank_Account_Id;

        //    for (int i = 0; i < dataSource.Count; i++)
        //    {
        //        Сells["D" + startWith + ":" + "L" + startWith].NumberFormat = "### ### ##0.00";

        //        if ((dataSource[i].Bank_Account_Id != currentBankAccountId))
        //        {
        //            Сells["A" + startWith].Value = counterRow;
        //            Сells["B" + startWith].Value = dataSource[i - 1].AccountNum;
        //            Сells["C" + startWith].Value = dataSource[i - 1].AccountNumDescription;

        //            cells["H" + startWith].Formula = "=SUM(" + "F" + startWith + ":" + "G" + startWith + ")";
        //            cells["K" + startWith].Formula = "=SUM(" + "I" + startWith + ":" + "J" + startWith + ")";

        //            if (prevSaldo >= 0)
        //            {
        //                Сells["D" + startWith].Value = Math.Abs(prevSaldo);
        //                Сells["E" + startWith].Value = 0;
        //            }
        //            else
        //            {
        //                Сells["D" + startWith].Value = 0;
        //                Сells["E" + startWith].Value = Math.Abs(prevSaldo);
        //            }

        //            if (endSaldo >= 0)
        //            {
        //                Сells["L" + startWith].Value = Math.Abs(endSaldo);
        //                Сells["M" + startWith].Value = 0;
        //            }
        //            else
        //            {
        //                Сells["L" + startWith].Value = 0;
        //                Сells["M" + startWith].Value = Math.Abs(endSaldo);
        //            }

        //            prevSaldo = 0;
        //            endSaldo = 0;

        //            ++startWith;
        //            ++counterRow;

        //            Сells["" + startWith + ":" + startWith].Insert();
        //            currentBankAccountId = dataSource[i].Bank_Account_Id;

        //        }

        //        switch (dataSource[i].PurposeAccountNum)
        //        {
        //            case "311/2":
        //                Сells["G" + startWith].Value = dataSource[i].DebitFromPeriod;
        //                Сells["H" + startWith].Value = dataSource[i].DebitFromPeriod;
        //                Сells["J" + startWith].Value = Math.Abs(dataSource[i].CreditFromPeriod);

        //                prevSaldo += dataSource[i].DebitPrewPeriod;
        //                prevSaldo -= dataSource[i].CreditPrewPeriod;

        //                endSaldo += dataSource[i].DebitEndPeriod;
        //                endSaldo -= dataSource[i].CreditEndPeriod;


        //                break;
        //            case "372":
        //            case "373":
        //                Сells["F" + startWith].Value = Math.Abs(dataSource[i].DebitFromPeriod);
        //                Сells["I" + startWith].Value = Math.Abs(dataSource[i].CreditFromPeriod);

        //                prevSaldo += dataSource[i].DebitPrewPeriod;
        //                prevSaldo -= dataSource[i].CreditPrewPeriod;

        //                endSaldo += dataSource[i].DebitEndPeriod;
        //                endSaldo -= dataSource[i].CreditEndPeriod;

        //                break;
        //            default:
        //                break;
        //        }

        //        if (i == dataSource.Count - 1)
        //        {
        //            Сells["A" + startWith].Value = counterRow;
        //            Сells["B" + startWith].Value = dataSource[i].AccountNum;
        //            Сells["C" + startWith].Value = dataSource[i].AccountNumDescription;

        //            cells["H" + startWith].Formula = "=SUM(" + "F" + startWith + ":" + "G" + startWith + ")";
        //            cells["K" + startWith].Formula = "=SUM(" + "I" + startWith + ":" + "J" + startWith + ")";

        //            if (prevSaldo >= 0)
        //            {
        //                Сells["D" + startWith].Value = Math.Abs(prevSaldo);
        //                Сells["E" + startWith].Value = 0;
        //            }
        //            else
        //            {
        //                Сells["D" + startWith].Value = 0;
        //                Сells["E" + startWith].Value = Math.Abs(prevSaldo);
        //            }

        //            if (endSaldo >= 0)
        //            {
        //                Сells["L" + startWith].Value = Math.Abs(endSaldo);
        //                Сells["M" + startWith].Value = 0;
        //            }
        //            else
        //            {
        //                Сells["L" + startWith].Value = 0;
        //                Сells["M" + startWith].Value = Math.Abs(endSaldo);
        //            }
        //        }
        //    }

        //    startWith += 7;

        //    counterRow = counterRow + 8;

        //    int lastStr = startWith + 6;
        //    int lastStrAllSum = startWith + 9;
        //    int lastStrAllSumEndPeriod = startWith + 10;
        //    ////sum prevdebit everybody of working of employees
        //    cells["D" + lastStr].Formula = "=SUM(" + vsS[3] + 9 + ":" + vsS[3] + counterRow + ")";
        //    Сells["D" + lastStr].HorizontalAlignment = HAlign.Center;
        //    Сells["D" + lastStr].NumberFormat = "### ### ##0.00";

        //    //sum prevcredit everybody of working of employees
        //    cells["E" + lastStr].Formula = "=SUM(" + vsS[4] + 9 + ":" + vsS[4] + counterRow + ")";
        //    Сells["E" + lastStr].HorizontalAlignment = HAlign.Center;
        //    Сells["E" + lastStr].NumberFormat = "### ### ##0.00";

        //    //sum of credit account number 372
        //    cells["F" + lastStr].Formula = "=SUM(" + vsS[5] + 9 + ":" + vsS[5] + counterRow + ")";
        //    Сells["F" + lastStr].HorizontalAlignment = HAlign.Center;
        //    Сells["F" + lastStr].NumberFormat = "### ### ##0.00";

        //    ////sum of credit account number 311/2
        //    cells["G" + lastStr].Formula = "=SUM(" + vsS[6] + 9 + ":" + vsS[6] + counterRow + ")";
        //    Сells["G" + lastStr].HorizontalAlignment = HAlign.Center;
        //    Сells["G" + lastStr].NumberFormat = "### ### ##0.00";

        //    ////sum of credit account number 311/2 all debit's
        //    cells["H" + lastStr].Formula = "=SUM(" + vsS[7] + 9 + ":" + vsS[7] + counterRow + ")";
        //    Сells["H" + lastStr].HorizontalAlignment = HAlign.Center;
        //    Сells["H" + lastStr].NumberFormat = "### ### ##0.00";

        //    ////sum of debit account number 372
        //    cells["I" + lastStr].Formula = "=SUM(" + vsS[8] + 9 + ":" + vsS[8] + counterRow + ")";
        //    Сells["I" + lastStr].HorizontalAlignment = HAlign.Center;
        //    Сells["I" + lastStr].NumberFormat = "### ### ##0.00";

        //    ////sum of debit account number 311/2
        //    cells["J" + lastStr].Formula = "=SUM(" + vsS[9] + 9 + ":" + vsS[9] + counterRow + ")";
        //    Сells["J" + lastStr].HorizontalAlignment = HAlign.Center;
        //    Сells["J" + lastStr].NumberFormat = "### ### ##0.00";

        //    ////sum of debit account number 311/2 and debit account number 372
        //    cells["K" + lastStr].Formula = "=SUM(" + vsS[10] + 9 + ":" + vsS[10] + counterRow + ")";
        //    Сells["K" + lastStr].HorizontalAlignment = HAlign.Center;
        //    Сells["K" + lastStr].NumberFormat = "### ### ##0.00";

        //    ////sum debit everybody of working of employees end period
        //    cells["L" + lastStr].Formula = "=SUM(" + vsS[11] + 9 + ":" + vsS[11] + counterRow + ")";
        //    Сells["L" + lastStr].HorizontalAlignment = HAlign.Center;
        //    Сells["L" + lastStr].NumberFormat = "### ### ##0.00";

        //    ///sum credit everybody of working of employees end period
        //    cells["M" + lastStr].Formula = "=SUM(" + vsS[12] + 9 + ":" + vsS[12] + counterRow + ")";
        //    Сells["M" + lastStr].HorizontalAlignment = HAlign.Center;
        //    Сells["M" + lastStr].NumberFormat = "### ### ##0.00";


        //    ///sum all debit from start period
        //    cells["D" + lastStrAllSum].Formula = "=SUM(" + vsS[3] + 9 + ":" + vsS[3] + counterRow + ")";
        //    Сells["D" + lastStrAllSum].HorizontalAlignment = HAlign.Center;
        //    Сells["D" + lastStrAllSum].NumberFormat = "### ### ##0.00";
        //    Сells["D" + lastStrAllSum].Font.Bold = true;

        //    //sum all debit end period
        //    cells["D" + lastStrAllSumEndPeriod].Formula = "=SUM(" + vsS[11] + 9 + ":" + vsS[11] + counterRow + ")";
        //    Сells["D" + lastStrAllSumEndPeriod].HorizontalAlignment = HAlign.Center;
        //    Сells["D" + lastStrAllSumEndPeriod].NumberFormat = "### ### ##0.00";
        //    Сells["D" + lastStrAllSumEndPeriod].Font.Bold = true;

        //    ///sum all credit from start period
        //    cells["E" + lastStrAllSum].Formula = "=SUM(" + vsS[4] + 9 + ":" + vsS[4] + counterRow + ")";
        //    Сells["E" + lastStrAllSum].HorizontalAlignment = HAlign.Center;
        //    Сells["E" + lastStrAllSum].NumberFormat = "### ### ##0.00";
        //    Сells["E" + lastStrAllSum].Font.Bold = true;

        //    //sum all credit end period
        //    cells["E" + lastStrAllSumEndPeriod].Formula = "=SUM(" + vsS[12] + 9 + ":" + vsS[12] + counterRow + ")";
        //    Сells["E" + lastStrAllSumEndPeriod].HorizontalAlignment = HAlign.Center;
        //    Сells["E" + lastStrAllSumEndPeriod].NumberFormat = "### ### ##0.00";
        //    Сells["E" + lastStrAllSumEndPeriod].Font.Bold = true;

        //    //try
        //    //{
        //    //    string documentAddresName = GeneratedReportsDir +
        //    //                                String.Format("Зведена оборотносальдова відомість до рахунку 313 за період з {0} по {1}", startDate.ToShortDateString(), endDate.ToShortDateString()) + ".xls";
        //    //    workbook.SaveAs(documentAddresName, FileFormat.Excel8);

        //    //    Process process = new Process();
        //    //    process.StartInfo.Arguments = "\"" + documentAddresName + "\"";
        //    //    process.StartInfo.FileName = "Excel.exe";
        //    //    process.Start();

        //    //}
        //    //catch (System.IO.IOException) { MessageBox.Show("Документ вже відкритий!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        //    //catch (System.ComponentModel.Win32Exception) { MessageBox.Show("Не знайдено програму Microsoft Excel!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        //    //string name = string.Format("Зведена оборотносальдова відомість до рахунку 313 за період з {0} по {1}", startDate.ToShortDateString(), endDate.ToShortDateString());


        //    try
        //    {

        //        string fileName = String.Format("Зведена обігово-сальдова по рахунку 313 за період з {0} по {1}", startDate.ToShortDateString(), endDate.ToShortDateString());
        //        Workbook.SaveAs(GeneratedReportsDir + fileName + ".xls", FileFormat.Excel8);
        //        Process process = new Process();
        //        process.StartInfo.Arguments = "\"" + GeneratedReportsDir + fileName + ".xls" + "\"";
        //        process.StartInfo.FileName = "Excel.exe";
        //        process.Start();

        //    }

        //    catch (System.IO.IOException) { MessageBox.Show("Документ вже відкрито!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        //    catch (System.ComponentModel.Win32Exception) { MessageBox.Show("Не знайдено пакет програм Microsoft Excel!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }


        //    //try
        //    //{
        //    //    Workbook.SaveAs(GeneratedReportsDir + name + ".xls", FileFormat.Excel8);

        //    //    Process process = new Process();
        //    //    process.StartInfo.Arguments = "\"" + GeneratedReportsDir + name + ".xls" + "\"";
        //    //    process.StartInfo.FileName = "Excel.exe";
        //    //    process.Start();
        //    //}

        //    //catch (System.IO.IOException) { MessageBox.Show("Документ вже відкритий!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        //    //catch (System.ComponentModel.Win32Exception) { MessageBox.Show("Не знайдено програму Microsoft Excel!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); }






        //    return true;

        //    //   return true;
        //}


    }
}
