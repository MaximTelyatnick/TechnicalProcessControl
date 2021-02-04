using AutoMapper;
using SpreadsheetGear;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class ReportService : IReportService
    {
        private string GeneratedReportsDir = Utils.HomePath + @"\Templates\";
        private string DbExelDir = @"C:\TechProcess\";

        private IUnitOfWork Database { get; set; }

        private IRepository<Drawings> drawings;
        private IRepository<Drawings> drawingsChild;
        private IRepository<Drawing> drawing;
        private IRepository<Drawing> drawingChild;
        private IRepository<Details> details;
        private IRepository<DrawingScan> drawingScan;
        private IRepository<Materials> materials;
        private IRepository<Revisions> revisions;



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
            drawingsChild = Database.GetRepository<Drawings>();
            drawing = Database.GetRepository<Drawing>();
            drawingChild = Database.GetRepository<Drawing>();
            drawingScan = Database.GetRepository<DrawingScan>();
            details = Database.GetRepository<Details>();
            type = Database.GetRepository<DAL.Models.Type>();
            materials = Database.GetRepository<Materials>();
            techProcess001 = Database.GetRepository<TechProcess001>();
            techProcess002 = Database.GetRepository<TechProcess002>();
            techProcess003 = Database.GetRepository<TechProcess003>();
            techProcess004 = Database.GetRepository<TechProcess004>();
            techProcess005 = Database.GetRepository<TechProcess005>();
            revisions = Database.GetRepository<Revisions>();
            

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Drawings, DrawingsDTO>();
                cfg.CreateMap<DrawingsDTO, Drawings>();
                cfg.CreateMap<Materials, MaterialsDTO>();
                cfg.CreateMap<Revisions, RevisionsDTO>();
                cfg.CreateMap<RevisionsDTO, Revisions>();
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

        public IEnumerable<DrawingDTO> GetDrawingParentByDrawingChildId(int drawingId)
        {
            var result = (from drw in drawings.GetAll()
                          join dr in drawing.GetAll() on drw.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join drwch in drawingsChild.GetAll() on drw.Id equals drwch.ParentId into drwchh
                          from drwch in drwchh.DefaultIfEmpty()
                          join drch in drawingChild.GetAll() on drwch.DrawingId equals drch.Id into drchh
                          from drch in drchh.DefaultIfEmpty()
                          join tp in type.GetAll() on dr.TypeId equals tp.Id into tpp
                          from tp in tpp.DefaultIfEmpty()
                          join det in details.GetAll() on dr.DetailId equals det.Id into dett
                          from det in dett.DefaultIfEmpty()
                          join mat in materials.GetAll() on dr.MaterialId equals mat.Id into matt
                          from mat in matt.DefaultIfEmpty()
                          join rev in revisions.GetAll() on dr.RevisionId equals rev.Id into revv
                          from rev in revv.DefaultIfEmpty()
                          where drch.Id == drawingId && dr.Id != null

                          select new DrawingDTO
                          {
                              Id = dr.Id == null ? -1 : dr.Id,
                              Number = dr.Number,
                              CreateDate = dr.CreateDate,
                              DetailId = dr.DetailId,
                              DetailName = det.DetailName,
                              MaterialId = dr.MaterialId,
                              Note = dr.Note,
                              RevisionId = dr.RevisionId,
                              RevisionName = rev.Symbol,
                              TypeId = dr.TypeId,
                              TypeName = tp.TypeName,
                              FullName = rev.Symbol == null ? dr.Number : (dr.Number + "_" + rev.Symbol),
                              L = dr.L,
                              TH = dr.TH,
                              W = dr.W,
                              W2 = dr.W2,
                              MaterialName = mat.MaterialName,
                              DetailWeight = dr.DetailWeight,
                          }
                          ).ToList();



            return result.GroupBy(x => x.Id).Select(y => y.First()).ToList();
        }


        public int GetLastEmptyRow(IWorkbook workbook)
        {
            int currentLastRow = 128;
            var worksheet = workbook.Worksheets[0];

            //worksheet = workbook.Worksheets[0];
            while (currentLastRow > 0)
            {
                if (worksheet.Cells["A" + (currentLastRow)].Value == null)
                {
                    if (worksheet.Cells["A" + (currentLastRow + 1)].Value == null &&
                        worksheet.Cells["A" + (currentLastRow + 2)].Value == null &&
                        worksheet.Cells["A" + (currentLastRow + 3)].Value == null &&
                        worksheet.Cells["A" + (currentLastRow + 4)].Value == null &&
                        worksheet.Cells["A" + (currentLastRow + 5)].Value == null &&
                        worksheet.Cells["A" + (currentLastRow + 6)].Value == null)
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

        public int GetNumberDocumentPages(IWorkbook workbook)
        {
            var worksheet = workbook.Worksheets[0];
            int currentLastRow = GetLastEmptyRow(workbook);
            return (int)Math.Ceiling(((double)currentLastRow / 34));
        }



        /*
         * 1 - структура
         * 2 - необязательный, его передаем только тогда, когда вместо шаблона нужно использовать готовый техпроцесс 
         * 
         * */
        public string CreateTemplateTechProcess001(UsersDTO usersDTO,DrawingsDTO drawingsDTO, TechProcess001DTO techProcess001OldDTO = null,List<DrawingDTO> listParentDrawings = null )
        {
            try
            {
                if(techProcess001OldDTO == null)
                    Factory.GetWorkbook(GeneratedReportsDir + @"\template001.xls");
                else
                    Factory.GetWorkbook(techProcess001OldDTO.TechProcessPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("не найдено шаблон документа!\n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            IWorkbook workbook = null;

            if (techProcess001OldDTO == null)
                workbook = Factory.GetWorkbook(GeneratedReportsDir + @"\template001.xls");
            else
                workbook = Factory.GetWorkbook(techProcess001OldDTO.TechProcessPath);

            var Worksheet = workbook.Worksheets[0];
            var Сells = Worksheet.Cells;
            IRange cells = Worksheet.Cells;

            string parentDrawings="";

            int pages = GetNumberDocumentPages(workbook);

            //получаем все чертежи-родители 
            if (listParentDrawings!=null)
                parentDrawings = String.Join(", ", listParentDrawings.Select(bdsm => bdsm.Number).ToArray());

            cells["BY" + 28].Value = "Created by "+ usersDTO.Name;
            cells["J" + 41].Value = usersDTO.Name;
            cells["D" + 30].Value = "Date of issue "; 


            Сells["AQ" + 10].Value = drawingsDTO.DetailName;
            Сells["AQ" + 10].HorizontalAlignment = HAlign.Center;
            Сells["AL" + 44].Value = drawingsDTO.DetailName;
            Сells["AL" + 44].HorizontalAlignment = HAlign.Center;

            Сells["F" + 46].Value = drawingsDTO.MaterialName;
            Сells["F" + 46].HorizontalAlignment = HAlign.Left;

            Сells["A" + 39].Value = parentDrawings;
            Сells["A" + 39].HorizontalAlignment = HAlign.Center;
            Сells["W" + 48].Value = drawingsDTO.DetailWeight;
            Сells["W" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BI" + 48].Value = drawingsDTO.TH.ToString() + "х" + drawingsDTO.W.ToString() + "х" + drawingsDTO.L.ToString();
            Сells["BI" + 48].HorizontalAlignment = HAlign.Center;
            Сells["CD" + 48].Value = drawingsDTO.Quantity;
            Сells["CD" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 7].Value = drawingsDTO.Number;
            Сells["BB" + 7].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 41].Value = drawingsDTO.Number;
            Сells["BB" + 41].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 75].Value = drawingsDTO.Number;
            Сells["BS" + 75].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 106].Value = drawingsDTO.Number;
            Сells["BS" + 106].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 07].Value = TechProcesNameToStr(drawingsDTO.TechProcess001Name);
            Сells["CO" + 07].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 41].Value = TechProcesNameToStr(drawingsDTO.TechProcess001Name);
            Сells["CO" + 41].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 75].Value = TechProcesNameToStr(drawingsDTO.TechProcess001Name);
            Сells["CO" + 75].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 106].Value = TechProcesNameToStr(drawingsDTO.TechProcess001Name);
            Сells["CO" + 106].HorizontalAlignment = HAlign.Center;

            //+31




            try
            {
                workbook.SaveAs(drawingsDTO.TechProcess001Path, FileFormat.XLS97);

            }

            catch (System.IO.IOException)
            {
                MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            return drawingsDTO.TechProcess001Path;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="usersDTO"> Обьект с информацией о пользователе </param>
        /// <param name="techProces001Drawing"> Обьект с информацией о чертеже</param>
        /// <param name="techProcess001DrawingParent"> Список обьектов типа  чертёж(все чертежи - родители)</param>
        /// <param name="techProcess001Revision">Список обьектов типа Техпроцесс 001 (все техпроцессы - ревизии)</param>
        /// <param name="techProcess001">Обьект типа техпроцесс 001, текущий техпроцесс</param>
        /// <param name="techProcess001Old"> </param>
        /// <returns>Путь к файлу</returns>
        public string CreateTemplateTechProcess001Exp(UsersDTO usersDTO,DrawingDTO techProces001Drawing,List<DrawingDTO> techProcess001DrawingParent, List<TechProcess001DTO> techProcess001Revision, TechProcess001DTO techProcess001, TechProcess001DTO techProcess001Old = null)
        {
            try
            {
                if (techProcess001Old == null)
                    Factory.GetWorkbook(GeneratedReportsDir + @"\template001.xls");
                else
                    Factory.GetWorkbook(techProcess001Old.TechProcessPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не найден шаблон документа!\n" + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            IWorkbook workbook = null;

            if (techProcess001Old == null)
                workbook = Factory.GetWorkbook(GeneratedReportsDir + @"\template001New.xls");
            else
                workbook = Factory.GetWorkbook(techProcess001Old.TechProcessPath);

            var Worksheet = workbook.Worksheets[0];
            var Сells = Worksheet.Cells;
            IRange cells = Worksheet.Cells;

            int pagesStock = 4;
            int pagesOpenDocument = GetNumberDocumentPages(workbook);
            string parentDrawings = "";
            //получаем чертеж на который создаём техпроцесс
            //var drawingDTO = drawingService.GetDrawingById((int)techProcess001DTO.DrawingId);
            //получаем все чертежи-родители 
            //var listParentDrawings = GetDrawingParentByDrawingChildId((int)techProcess001DTO.DrawingId);
            if (techProcess001DrawingParent != null)
                parentDrawings = String.Join(", ", techProcess001DrawingParent.Select(bdsm => bdsm.Number).ToArray());
            Сells["AG" + 24].Value = "Metal forming and cutting";
            Сells["AG" + 24].HorizontalAlignment = HAlign.Center;
            cells["BY" + 28].Value = "Created by " + usersDTO.Name + " " + techProcess001.CreateDate.Value.ToShortDateString();
            //cells["J" + 41].Value = techProcess001.UserName;
            cells["J" + 41].Value = usersDTO.Name;
            cells["AF" + 41].Value = techProcess001.CreateDate.Value.ToShortDateString();
            cells["D" + 30].Value = "Date of issue ";


            Сells["AQ" + 10].Value = techProces001Drawing.DetailName;
            Сells["AQ" + 10].HorizontalAlignment = HAlign.Center;
            Сells["AL" + 44].Value = techProces001Drawing.DetailName;
            Сells["AL" + 44].HorizontalAlignment = HAlign.Center;

            if (techProcess001Revision != null)
            {
                for (int i = 0; i < techProcess001Revision.Count(); i++)
                {
                    if(i==0)
                    {
                        Сells["AW" + 3 + ":" + "BV" + 3].Font.Bold = false;
                        Сells["AW" + 3 + ":" + "BV" + 3].Font.Italic = false;
                        Сells["AW" + 3 + ":" + "BV" + 3].Font.Size = 8;
                        Сells["AW" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 3].Value = techProcess001Revision[0].RivisionName;
                        Сells["BN" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 3].Value = usersDTO.Name;
                        Сells["BE" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 3].Value = techProcess001Revision[0].RevisionDocumentName;
                        Сells["BV" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 3].Font.Size = 6;
                        Сells["BV" + 3].Value = techProcess001Revision[0].CreateDate.Value.ToShortDateString();

                        Сells["AW" + 37 + ":" + "BV" + 37].Font.Bold = false;
                        Сells["AW" + 37 + ":" + "BV" + 37].Font.Italic = false;
                        Сells["AW" + 37 + ":" + "BV" + 37].Font.Size = 8;
                        Сells["AW" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 37].Value = techProcess001Revision[0].RivisionName;
                        Сells["BN" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 37].Value = usersDTO.Name;
                        Сells["BE" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 37].Value = techProcess001Revision[0].RevisionDocumentName;
                        Сells["BV" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 37].Font.Size = 6;
                        Сells["BV" + 37].Value = techProcess001Revision[0].CreateDate.Value.ToShortDateString();

                        Сells["AW" + 70 + ":" + "BV" + 70].Font.Bold = false;
                        Сells["AW" + 70 + ":" + "BV" + 70].Font.Italic = false;
                        Сells["AW" + 70 + ":" + "BV" + 70].Font.Size = 8;
                        Сells["AW" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 70].Value = techProcess001Revision[0].RivisionName;
                        Сells["BN" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 70].Value = usersDTO.Name;
                        Сells["BE" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 70].Value = techProcess001Revision[0].RevisionDocumentName;
                        Сells["BV" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 70].Font.Size = 6;
                        Сells["BV" + 70].Value = techProcess001Revision[0].CreateDate.Value.ToShortDateString();

                        Сells["AW" + 100 + ":" + "BV" + 100].Font.Bold = false;
                        Сells["AW" + 100 + ":" + "BV" + 100].Font.Italic = false;
                        Сells["AW" + 100 + ":" + "BV" + 100].Font.Size = 8;
                        Сells["AW" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 100].Value = techProcess001Revision[0].RivisionName;
                        Сells["BN" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 100].Value = usersDTO.Name;
                        Сells["BE" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 100].Value = techProcess001Revision[0].RevisionDocumentName;
                        Сells["BV" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 100].Font.Size = 6;
                        Сells["BV" + 100].Value = techProcess001Revision[0].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 1)
                    {
                        Сells["CB" + 2 + ":" + "DA" + 2].Font.Bold = false;
                        Сells["CB" + 2 + ":" + "DA" + 2].Font.Italic = false;
                        Сells["CB" + 2 + ":" + "DA" + 2].Font.Size = 8;
                        Сells["CB" + 2].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 2].Value = techProcess001Revision[1].RivisionName;
                        Сells["CS" + 2].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 2].Value = usersDTO.Name;
                        Сells["CJ" + 2].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 2].Value = techProcess001Revision[1].RevisionDocumentName;
                        Сells["DA" + 2].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 2].Font.Size = 6;
                        Сells["DA" + 2].Value = techProcess001Revision[1].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 35 + ":" + "DA" + 35].Font.Bold = false;
                        Сells["CB" + 35 + ":" + "DA" + 35].Font.Italic = false;
                        Сells["CB" + 35 + ":" + "DA" + 35].Font.Size = 8;
                        Сells["CB" + 35].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 35].Value = techProcess001Revision[1].RivisionName;
                        Сells["CS" + 35].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 35].Value = usersDTO.Name;
                        Сells["CJ" + 35].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 35].Value = techProcess001Revision[1].RevisionDocumentName;
                        Сells["DA" + 35].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 35].Font.Size = 6;
                        Сells["DA" + 35].Value = techProcess001Revision[1].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 68 + ":" + "DA" + 68].Font.Bold = false;
                        Сells["CB" + 68 + ":" + "DA" + 68].Font.Italic = false;
                        Сells["CB" + 68 + ":" + "DA" + 68].Font.Size = 8;
                        Сells["CB" + 68].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 68].Value = techProcess001Revision[1].RivisionName;
                        Сells["CS" + 68].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 68].Value = usersDTO.Name;
                        Сells["CJ" + 68].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 68].Value = techProcess001Revision[1].RevisionDocumentName;
                        Сells["DA" + 68].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 68].Font.Size = 6;
                        Сells["DA" + 68].Value = techProcess001Revision[1].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 98 + ":" + "DA" + 98].Font.Bold = false;
                        Сells["CB" + 98 + ":" + "DA" + 98].Font.Italic = false;
                        Сells["CB" + 98 + ":" + "DA" + 98].Font.Size = 8;
                        Сells["CB" + 98].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 98].Value = techProcess001Revision[1].RivisionName;
                        Сells["CS" + 98].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 98].Value = usersDTO.Name;
                        Сells["CJ" + 98].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 98].Value = techProcess001Revision[1].RevisionDocumentName;
                        Сells["DA" + 98].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 98].Font.Size = 6;
                        Сells["DA" + 98].Value = techProcess001Revision[1].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 2)
                    {
                        Сells["CB" + 3 + ":" + "DA" + 3].Font.Bold = false;
                        Сells["CB" + 3 + ":" + "DA" + 3].Font.Italic = false;
                        Сells["CB" + 3 + ":" + "DA" + 3].Font.Size = 8;
                        Сells["CB" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 3].Value = techProcess001Revision[2].RivisionName;
                        Сells["CS" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 3].Value = usersDTO.Name;
                        Сells["CJ" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 3].Value = techProcess001Revision[2].RevisionDocumentName;
                        Сells["DA" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 3].Font.Size = 6;
                        Сells["DA" + 3].Value = techProcess001Revision[2].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 36 + ":" + "DA" + 36].Font.Bold = false;
                        Сells["CB" + 36 + ":" + "DA" + 36].Font.Italic = false;
                        Сells["CB" + 36 + ":" + "DA" + 36].Font.Size = 8;
                        Сells["CB" + 36].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 36].Value = techProcess001Revision[2].RivisionName;
                        Сells["CS" + 36].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 36].Value = usersDTO.Name;
                        Сells["CJ" + 36].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 36].Value = techProcess001Revision[2].RevisionDocumentName;
                        Сells["DA" + 36].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 36].Font.Size = 6;
                        Сells["DA" + 36].Value = techProcess001Revision[2].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 69 + ":" + "DA" + 69].Font.Bold = false;
                        Сells["CB" + 69 + ":" + "DA" + 69].Font.Italic = false;
                        Сells["CB" + 69 + ":" + "DA" + 69].Font.Size = 8;
                        Сells["CB" + 69].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 69].Value = techProcess001Revision[2].RivisionName;
                        Сells["CS" + 69].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 69].Value = usersDTO.Name;
                        Сells["CJ" + 69].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 69].Value = techProcess001Revision[2].RevisionDocumentName;
                        Сells["DA" + 69].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 69].Font.Size = 6;
                        Сells["DA" + 69].Value = techProcess001Revision[2].CreateDate.Value.ToShortDateString();

                        

                        Сells["CB" + 99 + ":" + "DA" + 99].Font.Bold = false;
                        Сells["CB" + 99 + ":" + "DA" + 99].Font.Italic = false;
                        Сells["CB" + 99 + ":" + "DA" + 99].Font.Size = 8;
                        Сells["CB" + 99].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 99].Value = techProcess001Revision[2].RivisionName;
                        Сells["CS" + 99].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 99].Value = usersDTO.Name;
                        Сells["CJ" + 99].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 99].Value = techProcess001Revision[2].RevisionDocumentName;
                        Сells["DA" + 99].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 99].Font.Size = 6;
                        Сells["DA" + 99].Value = techProcess001Revision[2].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 3)
                    {
                        Сells["CB" + 37 + ":" + "DA" + 37].Font.Bold = false;
                        Сells["CB" + 37 + ":" + "DA" + 37].Font.Italic = false;
                        Сells["CB" + 37 + ":" + "DA" + 37].Font.Size = 8;
                        Сells["CB" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 37].Value = techProcess001Revision[3].RivisionName;
                        Сells["CS" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 37].Value = usersDTO.Name;
                        Сells["CJ" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 37].Value = techProcess001Revision[3].RevisionDocumentName;
                        Сells["DA" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 37].Font.Size = 6;
                        Сells["DA" + 37].Value = techProcess001Revision[3].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 70 + ":" + "DA" + 70].Font.Bold = false;
                        Сells["CB" + 70 + ":" + "DA" + 70].Font.Italic = false;
                        Сells["CB" + 70 + ":" + "DA" + 70].Font.Size = 8;
                        Сells["CB" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 70].Value = techProcess001Revision[3].RivisionName;
                        Сells["CS" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 70].Value = usersDTO.Name;
                        Сells["CJ" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 70].Value = techProcess001Revision[3].RevisionDocumentName;
                        Сells["DA" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 70].Font.Size = 6;
                        Сells["DA" + 70].Value = techProcess001Revision[3].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 100 + ":" + "DA" + 100].Font.Bold = false;
                        Сells["CB" + 100 + ":" + "DA" + 100].Font.Italic = false;
                        Сells["CB" + 100 + ":" + "DA" + 100].Font.Size = 8;
                        Сells["CB" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 100].Value = techProcess001Revision[3].RivisionName;
                        Сells["CS" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 100].Value = usersDTO.Name;
                        Сells["CJ" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 100].Value = techProcess001Revision[3].RevisionDocumentName;
                        Сells["DA" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 100].Font.Size = 6;
                        Сells["DA" + 100].Value = techProcess001Revision[3].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 4)
                        break;
                }
            }


            Сells["F" + 46].Value = techProces001Drawing.MaterialName;
            Сells["F" + 46].HorizontalAlignment = HAlign.Left;

            Сells["A" + 39].Value = parentDrawings;
            Сells["A" + 39].HorizontalAlignment = HAlign.Center;
            Сells["W" + 48].Value = techProcess001.Weight;
            Сells["W" + 48].HorizontalAlignment = HAlign.Center;

            string paramaterBlank = "";

            if (techProcess001.TH != "" && techProcess001.TH != null)
                paramaterBlank += techProcess001.TH.ToString() + "х";
            if (techProcess001.W != "" && techProcess001.W != null)
                paramaterBlank += techProcess001.W.ToString() + "x";
            if (techProcess001.W2 != "" && techProcess001.W2 != null)
                paramaterBlank += techProcess001.W2.ToString() + "x";
            if (techProcess001.L != "" && techProcess001.L != null)
                paramaterBlank += techProcess001.L.ToString();

            Сells["BI" + 48].Value = paramaterBlank;
            Сells["BI" + 48].HorizontalAlignment = HAlign.Center;
            
            //Количество, нужно ли??????????????
            //Сells["CD" + 48].Value = drawingsDTO.Quantity;
            //Сells["CD" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 7].Value = techProces001Drawing.Number;
            Сells["BB" + 7].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 41].Value = techProces001Drawing.Number;
            Сells["BB" + 41].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 74].Value = techProces001Drawing.Number;
            Сells["BS" + 74].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 104].Value = techProces001Drawing.Number;
            Сells["BS" + 104].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 07].Value = TechProcesNameToStr(techProcess001.TechProcessName);
            Сells["CO" + 07].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 41].Value = TechProcesNameToStr(techProcess001.TechProcessName);
            Сells["CO" + 41].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 74].Value = TechProcesNameToStr(techProcess001.TechProcessName);
            Сells["CO" + 74].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 104].Value = TechProcesNameToStr(techProcess001.TechProcessName);
            Сells["CO" + 104].HorizontalAlignment = HAlign.Center;

            if (pagesOpenDocument > pagesStock)
            {
                for (int i = 1; i <= pagesOpenDocument - pagesStock; i++)
                {
                    Сells["CO" + (104 + (30 * i))].Value = TechProcesNameToStr(techProcess001.TechProcessName);
                    Сells["CO" + (104 + (30 * i))].HorizontalAlignment = HAlign.Center;
                    Сells["BS" + (104 + (30 * i))].Value = techProces001Drawing.Number;
                    Сells["BS" + (104 + (30 * i))].HorizontalAlignment = HAlign.Center;

                    if (techProcess001Revision != null)
                    {
                        for (int j = 0; j < techProcess001Revision.Count(); j++)
                        {
                            if (j == 0)
                            {
                                Сells["AW" + (100 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["AW" + (100 + (30 * i))].Value = techProcess001Revision[0].RivisionName;
                                Сells["BN" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["BN" + (100 + (30 * i))].Value = usersDTO.Name;
                                Сells["BV" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["BV" + (100 + (30 * i))].Font.Size = 6;
                                Сells["BV" + (100 + (30 * i))].Value = techProcess001Revision[0].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 1)
                            {
                                Сells["CB" + (98 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["CB" + (98 + (30 * i))].Value = techProcess001Revision[1].RivisionName;
                                Сells["CS" + (98 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["CS" + (98 + (30 * i))].Value = usersDTO.Name;
                                Сells["DA" + (98 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["DA" + (98 + (30 * i))].Font.Size = 6;
                                Сells["DA" + (98 + (30 * i))].Value = techProcess001Revision[1].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 2)
                            {

                                Сells["CB" + (99 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["CB" + (99 + (30 * i))].Value = techProcess001Revision[2].RivisionName;
                                Сells["CS" + (99 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["CS" + (99 + (30 * i))].Value = usersDTO.Name;
                                Сells["DA" + (99 + (30 * i))].Font.Size = 6;
                                Сells["DA" + (99 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["DA" + (99 + (30 * i))].Value = techProcess001Revision[2].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 3)
                            {

                                Сells["CB" + (100 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["CB" + (100 + (30 * i))].Value = techProcess001Revision[3].RivisionName;
                                Сells["CS" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["CS" + (100 + (30 * i))].Value = usersDTO.Name;
                                Сells["DA" + (100 + (30 * i))].Font.Size = 6;
                                Сells["DA" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["DA" + (100 + (30 * i))].Value = techProcess001Revision[3].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 4)
                                break;

                        }
                    }
                }
            }

            try
            {
               // workbook.Protect("gbhj98PK3", false, false);
                workbook.ProtectStructure = true;
                workbook.ProtectWindows = true;
                workbook.SaveAs(techProcess001.TechProcessPath, FileFormat.XLS97);
            }

            catch (System.IO.IOException)
            {
                MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            return techProcess001.TechProcessPath;
        }






        public string UpdateTemplateTechProcess001(DrawingsDTO drawingsDTO)
        {

            var Workbook = Factory.GetWorkbook(drawingsDTO.TechProcess001Path);
            var Worksheet = Workbook.Worksheets[0];
            var Сells = Worksheet.Cells;
            IRange cells = Worksheet.Cells;
            
            Сells["A" + 39].Value = drawingsDTO.ParentName;
            Сells["A" + 39].HorizontalAlignment = HAlign.Center;
            Сells["W" + 48].Value = drawingsDTO.DetailWeight;
            Сells["W" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BI" + 48].Value = drawingsDTO.TH.ToString() + "х" + drawingsDTO.W.ToString() + "х" + drawingsDTO.L.ToString();
            Сells["BI" + 48].HorizontalAlignment = HAlign.Center;
            Сells["CD" + 48].Value = drawingsDTO.Quantity;
            Сells["CD" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 7].Value = drawingsDTO.Number;
            Сells["BB" + 7].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 41].Value = drawingsDTO.Number;
            Сells["BB" + 41].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 75].Value = drawingsDTO.Number;
            Сells["BS" + 75].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 106].Value = drawingsDTO.Number;
            Сells["BS" + 106].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 07].Value = TechProcesNameToStr(drawingsDTO.TechProcess001Name);
            Сells["CO" + 07].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 41].Value = TechProcesNameToStr(drawingsDTO.TechProcess001Name);
            Сells["CO" + 41].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 75].Value = TechProcesNameToStr(drawingsDTO.TechProcess001Name);
            Сells["CO" + 75].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 106].Value = TechProcesNameToStr(drawingsDTO.TechProcess001Name);
            Сells["CO" + 106].HorizontalAlignment = HAlign.Center;
            //BB7, BB41 = Назв чертежа
            //BS75 = Назва чертежа (цыкл)
            //CO7,CO41 = Номер техпроцесса(цыкл +45)
            //W48 = вес
            //BI48 = размеры
            //A39 = размеры

            try
            {
                Workbook.Save();
            }

            catch (System.IO.IOException)
            {
                MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            return drawingsDTO.TechProcess001Path;
        }

        public string CreateTemplateTechProcess002(DrawingsDTO drawingsDTO)
        {
            try
            {
                Factory.GetWorkbook(GeneratedReportsDir + @"\template001.xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("не найдено шаблон документа!\n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            var Workbook = Factory.GetWorkbook(GeneratedReportsDir + @"\template001.xlsx");
            var Worksheet = Workbook.Worksheets[0];
            var Сells = Worksheet.Cells;
            IRange cells = Worksheet.Cells;
            Сells["A" + 39].Value = drawingsDTO.ParentName;
            Сells["A" + 39].HorizontalAlignment = HAlign.Center;
            Сells["W" + 48].Value = drawingsDTO.DetailWeight;
            Сells["W" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BI" + 48].Value = drawingsDTO.TH.ToString() + "х" + drawingsDTO.W.ToString() + "х" + drawingsDTO.L.ToString();
            Сells["BI" + 48].HorizontalAlignment = HAlign.Center;
            Сells["CD" + 48].Value = drawingsDTO.Quantity;
            Сells["CD" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 7].Value = drawingsDTO.Number;
            Сells["BB" + 7].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 41].Value = drawingsDTO.Number;
            Сells["BB" + 41].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 75].Value = drawingsDTO.Number;
            Сells["BS" + 75].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 106].Value = drawingsDTO.Number;
            Сells["BS" + 106].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 07].Value = TechProcesNameToStr(drawingsDTO.TechProcess002Name);
            Сells["CO" + 07].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 41].Value = TechProcesNameToStr(drawingsDTO.TechProcess002Name);
            Сells["CO" + 41].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 75].Value = TechProcesNameToStr(drawingsDTO.TechProcess002Name);
            Сells["CO" + 75].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 106].Value = TechProcesNameToStr(drawingsDTO.TechProcess002Name);
            Сells["CO" + 106].HorizontalAlignment = HAlign.Center;


            try
            {
                string fileName = String.Format("Зведена обігово-сальдова по рахунку 313 за період");
                //string fileName = String.Format("Зведена обігово-сальдова по рахунку 313 за період з {0} по {1}", startDate.ToShortDateString(), endDate.ToShortDateString());
                //Workbook.SaveAs(DbExelDir + techProcess001DTO.TechProcessName.ToString() + ".xls", FileFormat.Excel8);
                Workbook.SaveAs(drawingsDTO.TechProcess002Path, FileFormat.Excel8);
                Process process = new Process();
                process.StartInfo.Arguments = "\"" + drawingsDTO.TechProcess002Path + "\"";
                process.StartInfo.FileName = "Excel.exe";
                process.Start();

            }

            catch (System.IO.IOException) { MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (System.ComponentModel.Win32Exception) { MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            return drawingsDTO.TechProcess001Path;
        }






/// <summary>
///     
/// </summary>
/// <param name="usersDTO"></param>
/// <param name="techProces002Drawing"></param>
/// <param name="techProcess002DrawingParent"></param>
/// <param name="techProcess002Revision"></param>
/// <param name="techProcess002"></param>
/// <param name="techProcess002Old"></param>
/// <returns></returns>


    
        public string CreateTemplateTechProcess002Exp(UsersDTO usersDTO, DrawingDTO techProces002Drawing, List<DrawingDTO> techProcess002DrawingParent, List<TechProcess002DTO> techProcess002Revision, TechProcess002DTO techProcess002, TechProcess002DTO techProcess002Old = null)
        {
            try
            {
                if (techProcess002Old == null)
                    Factory.GetWorkbook(GeneratedReportsDir + @"\template001.xls");
                else
                    Factory.GetWorkbook(techProcess002Old.TechProcessPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не найден шаблон документа!\n" + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            IWorkbook workbook = null;

            if (techProcess002Old == null)
                workbook = Factory.GetWorkbook(GeneratedReportsDir + @"\template001New.xls");
            else
                workbook = Factory.GetWorkbook(techProcess002Old.TechProcessPath);

            var Worksheet = workbook.Worksheets[0];
            var Сells = Worksheet.Cells;
            IRange cells = Worksheet.Cells;

            int pagesStock = 4;
            int pagesOpenDocument = GetNumberDocumentPages(workbook);
            string parentDrawings = "";
            //получаем чертеж на который создаём техпроцесс
            //var drawingDTO = drawingService.GetDrawingById((int)techProcess001DTO.DrawingId);
            //получаем все чертежи-родители 
            //var listParentDrawings = GetDrawingParentByDrawingChildId((int)techProcess001DTO.DrawingId);
            if (techProcess002DrawingParent != null)
                parentDrawings = String.Join(", ", techProcess002DrawingParent.Select(bdsm => bdsm.Number).ToArray());

            Сells["AG" + 24].Value = "Machining";
            Сells["AG" + 24].HorizontalAlignment = HAlign.Center;
            

            cells["BY" + 28].Value = "Created by " + usersDTO.Name + " " + techProcess002.CreateDate.Value.ToShortDateString();
            //cells["J" + 41].Value = techProcess002.UserName;
            cells["J" + 41].Value = usersDTO.Name;
            cells["AF" + 41].Value = techProcess002.CreateDate.Value.ToShortDateString();
            cells["D" + 30].Value = "Date of issue ";


            Сells["AQ" + 10].Value = techProces002Drawing.DetailName;
            Сells["AQ" + 10].HorizontalAlignment = HAlign.Center;
            Сells["AL" + 44].Value = techProces002Drawing.DetailName;
            Сells["AL" + 44].HorizontalAlignment = HAlign.Center;

            if (techProcess002Revision != null)
            {
                for (int i = 0; i < techProcess002Revision.Count(); i++)
                {
                    if (i == 0)
                    {
                        Сells["AW" + 3 + ":" + "BV" + 3].Font.Bold = false;
                        Сells["AW" + 3 + ":" + "BV" + 3].Font.Italic = false;
                        Сells["AW" + 3 + ":" + "BV" + 3].Font.Size = 8;
                        Сells["AW" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 3].Value = techProcess002Revision[0].RivisionName;
                        Сells["BN" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 3].Value = usersDTO.Name;
                        Сells["BE" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 3].Value = techProcess002Revision[0].RevisionDocumentName;
                        Сells["BV" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 3].Font.Size = 6;
                        Сells["BV" + 3].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();

                        Сells["AW" + 37 + ":" + "BV" + 37].Font.Bold = false;
                        Сells["AW" + 37 + ":" + "BV" + 37].Font.Italic = false;
                        Сells["AW" + 37 + ":" + "BV" + 37].Font.Size = 8;
                        Сells["AW" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 37].Value = techProcess002Revision[0].RivisionName;
                        Сells["BN" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 37].Value = usersDTO.Name;
                        Сells["BE" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 37].Value = techProcess002Revision[0].RevisionDocumentName;
                        Сells["BV" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 37].Font.Size = 6;
                        Сells["BV" + 37].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();

                        Сells["AW" + 70 + ":" + "BV" + 70].Font.Bold = false;
                        Сells["AW" + 70 + ":" + "BV" + 70].Font.Italic = false;
                        Сells["AW" + 70 + ":" + "BV" + 70].Font.Size = 8;
                        Сells["AW" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 70].Value = techProcess002Revision[0].RivisionName;
                        Сells["BN" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 70].Value = usersDTO.Name;
                        Сells["BE" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 70].Value = techProcess002Revision[0].RevisionDocumentName;
                        Сells["BV" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 70].Font.Size = 6;
                        Сells["BV" + 70].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();

                        Сells["AW" + 100 + ":" + "BV" + 100].Font.Bold = false;
                        Сells["AW" + 100 + ":" + "BV" + 100].Font.Italic = false;
                        Сells["AW" + 100 + ":" + "BV" + 100].Font.Size = 8;
                        Сells["AW" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 100].Value = techProcess002Revision[0].RivisionName;
                        Сells["BN" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 100].Value = usersDTO.Name;
                        Сells["BE" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 100].Value = techProcess002Revision[0].RevisionDocumentName;
                        Сells["BV" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 100].Font.Size = 6;
                        Сells["BV" + 100].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 1)
                    {
                        Сells["CB" + 2 + ":" + "DA" + 2].Font.Bold = false;
                        Сells["CB" + 2 + ":" + "DA" + 2].Font.Italic = false;
                        Сells["CB" + 2 + ":" + "DA" + 2].Font.Size = 8;
                        Сells["CB" + 2].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 2].Value = techProcess002Revision[1].RivisionName;
                        Сells["CS" + 2].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 2].Value = usersDTO.Name;
                        Сells["CJ" + 2].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 2].Value = techProcess002Revision[1].RevisionDocumentName;
                        Сells["DA" + 2].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 2].Font.Size = 6;
                        Сells["DA" + 2].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 35 + ":" + "DA" + 35].Font.Bold = false;
                        Сells["CB" + 35 + ":" + "DA" + 35].Font.Italic = false;
                        Сells["CB" + 35 + ":" + "DA" + 35].Font.Size = 8;
                        Сells["CB" + 35].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 35].Value = techProcess002Revision[1].RivisionName;
                        Сells["CS" + 35].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 35].Value = usersDTO.Name;
                        Сells["CJ" + 35].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 35].Value = techProcess002Revision[1].RevisionDocumentName;
                        Сells["DA" + 35].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 35].Font.Size = 6;
                        Сells["DA" + 35].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 68 + ":" + "DA" + 68].Font.Bold = false;
                        Сells["CB" + 68 + ":" + "DA" + 68].Font.Italic = false;
                        Сells["CB" + 68 + ":" + "DA" + 68].Font.Size = 8;
                        Сells["CB" + 68].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 68].Value = techProcess002Revision[1].RivisionName;
                        Сells["CS" + 68].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 68].Value = usersDTO.Name;
                        Сells["CJ" + 68].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 68].Value = techProcess002Revision[1].RevisionDocumentName;
                        Сells["DA" + 68].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 68].Font.Size = 6;
                        Сells["DA" + 68].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 98 + ":" + "DA" + 98].Font.Bold = false;
                        Сells["CB" + 98 + ":" + "DA" + 98].Font.Italic = false;
                        Сells["CB" + 98 + ":" + "DA" + 98].Font.Size = 8;
                        Сells["CB" + 98].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 98].Value = techProcess002Revision[1].RivisionName;
                        Сells["CS" + 98].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 98].Value = usersDTO.Name;
                        Сells["CJ" + 98].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 98].Value = techProcess002Revision[1].RevisionDocumentName;
                        Сells["DA" + 98].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 98].Font.Size = 6;
                        Сells["DA" + 98].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 2)
                    {
                        Сells["CB" + 3 + ":" + "DA" + 3].Font.Bold = false;
                        Сells["CB" + 3 + ":" + "DA" + 3].Font.Italic = false;
                        Сells["CB" + 3 + ":" + "DA" + 3].Font.Size = 8;
                        Сells["CB" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 3].Value = techProcess002Revision[2].RivisionName;
                        Сells["CS" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 3].Value = usersDTO.Name;
                        Сells["CJ" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 3].Value = techProcess002Revision[2].RevisionDocumentName;
                        Сells["DA" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 3].Font.Size = 6;
                        Сells["DA" + 3].Value = techProcess002Revision[2].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 36 + ":" + "DA" + 36].Font.Bold = false;
                        Сells["CB" + 36 + ":" + "DA" + 36].Font.Italic = false;
                        Сells["CB" + 36 + ":" + "DA" + 36].Font.Size = 8;
                        Сells["CB" + 36].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 36].Value = techProcess002Revision[2].RivisionName;
                        Сells["CS" + 36].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 36].Value = usersDTO.Name;
                        Сells["CJ" + 36].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 36].Value = techProcess002Revision[2].RevisionDocumentName;
                        Сells["DA" + 36].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 36].Font.Size = 6;
                        Сells["DA" + 36].Value = techProcess002Revision[2].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 69 + ":" + "DA" + 69].Font.Bold = false;
                        Сells["CB" + 69 + ":" + "DA" + 69].Font.Italic = false;
                        Сells["CB" + 69 + ":" + "DA" + 69].Font.Size = 8;
                        Сells["CB" + 69].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 69].Value = techProcess002Revision[2].RivisionName;
                        Сells["CS" + 69].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 69].Value = usersDTO.Name;
                        Сells["CJ" + 69].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 69].Value = techProcess002Revision[2].RevisionDocumentName;
                        Сells["DA" + 69].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 69].Font.Size = 6;
                        Сells["DA" + 69].Value = techProcess002Revision[2].CreateDate.Value.ToShortDateString();



                        Сells["CB" + 99 + ":" + "DA" + 99].Font.Bold = false;
                        Сells["CB" + 99 + ":" + "DA" + 99].Font.Italic = false;
                        Сells["CB" + 99 + ":" + "DA" + 99].Font.Size = 8;
                        Сells["CB" + 99].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 99].Value = techProcess002Revision[2].RivisionName;
                        Сells["CS" + 99].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 99].Value = usersDTO.Name;
                        Сells["CJ" + 99].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 99].Value = techProcess002Revision[2].RevisionDocumentName;
                        Сells["DA" + 99].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 99].Font.Size = 6;
                        Сells["DA" + 99].Value = techProcess002Revision[2].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 3)
                    {
                        Сells["CB" + 37 + ":" + "DA" + 37].Font.Bold = false;
                        Сells["CB" + 37 + ":" + "DA" + 37].Font.Italic = false;
                        Сells["CB" + 37 + ":" + "DA" + 37].Font.Size = 8;
                        Сells["CB" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 37].Value = techProcess002Revision[3].RivisionName;
                        Сells["CS" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 37].Value = usersDTO.Name;
                        Сells["CJ" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 37].Value = techProcess002Revision[3].RevisionDocumentName;
                        Сells["DA" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 37].Font.Size = 6;
                        Сells["DA" + 37].Value = techProcess002Revision[3].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 70 + ":" + "DA" + 70].Font.Bold = false;
                        Сells["CB" + 70 + ":" + "DA" + 70].Font.Italic = false;
                        Сells["CB" + 70 + ":" + "DA" + 70].Font.Size = 8;
                        Сells["CB" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 70].Value = techProcess002Revision[3].RivisionName;
                        Сells["CS" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 70].Value = usersDTO.Name;
                        Сells["CJ" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 70].Value = techProcess002Revision[3].RevisionDocumentName;
                        Сells["DA" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 70].Font.Size = 6;
                        Сells["DA" + 70].Value = techProcess002Revision[3].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 100 + ":" + "DA" + 100].Font.Bold = false;
                        Сells["CB" + 100 + ":" + "DA" + 100].Font.Italic = false;
                        Сells["CB" + 100 + ":" + "DA" + 100].Font.Size = 8;
                        Сells["CB" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 100].Value = techProcess002Revision[3].RivisionName;
                        Сells["CS" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 100].Value = usersDTO.Name;
                        Сells["CJ" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 100].Value = techProcess002Revision[3].RevisionDocumentName;
                        Сells["DA" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 100].Font.Size = 6;
                        Сells["DA" + 100].Value = techProcess002Revision[3].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 4)
                        break;
                }
            }


            Сells["F" + 46].Value = techProces002Drawing.MaterialName;
            Сells["F" + 46].HorizontalAlignment = HAlign.Left;

            Сells["A" + 39].Value = parentDrawings;
            Сells["A" + 39].HorizontalAlignment = HAlign.Center;
            Сells["W" + 48].Value = techProcess002.Weight;
            Сells["W" + 48].HorizontalAlignment = HAlign.Center;

            string paramaterBlank = "";

            if (techProcess002.TH != "" && techProcess002.TH != null)
                paramaterBlank += techProcess002.TH.ToString() + "х";
            if (techProcess002.W != "" && techProcess002.W != null)
                paramaterBlank += techProcess002.W.ToString() + "x";
            if (techProcess002.W2 != "" && techProcess002.W2 != null)
                paramaterBlank += techProcess002.W2.ToString() + "x";
            if (techProcess002.L != "" && techProcess002.L != null)
                paramaterBlank += techProcess002.L.ToString();

            Сells["BI" + 48].Value = paramaterBlank;
            Сells["BI" + 48].HorizontalAlignment = HAlign.Center;

            //Количество, нужно ли??????????????
            //Сells["CD" + 48].Value = drawingsDTO.Quantity;
            //Сells["CD" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 7].Value = techProces002Drawing.Number;
            Сells["BB" + 7].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 41].Value = techProces002Drawing.Number;
            Сells["BB" + 41].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 74].Value = techProces002Drawing.Number;
            Сells["BS" + 74].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 104].Value = techProces002Drawing.Number;
            Сells["BS" + 104].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 07].Value = TechProcesNameToStr(techProcess002.TechProcessName);
            Сells["CO" + 07].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 41].Value = TechProcesNameToStr(techProcess002.TechProcessName);
            Сells["CO" + 41].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 74].Value = TechProcesNameToStr(techProcess002.TechProcessName);
            Сells["CO" + 74].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 104].Value = TechProcesNameToStr(techProcess002.TechProcessName);
            Сells["CO" + 104].HorizontalAlignment = HAlign.Center;

            if (pagesOpenDocument > pagesStock)
            {
                for (int i = 1; i <= pagesOpenDocument - pagesStock; i++)
                {
                    Сells["CO" + (104 + (30 * i))].Value = TechProcesNameToStr(techProcess002.TechProcessName);
                    Сells["CO" + (104 + (30 * i))].HorizontalAlignment = HAlign.Center;
                    Сells["BS" + (104 + (30 * i))].Value = techProces002Drawing.Number;
                    Сells["BS" + (104 + (30 * i))].HorizontalAlignment = HAlign.Center;

                    if (techProcess002Revision != null)
                    {
                        for (int j = 0; j < techProcess002Revision.Count(); j++)
                        {
                            if (j == 0)
                            {
                                Сells["AW" + (100 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["AW" + (100 + (30 * i))].Value = techProcess002Revision[0].RivisionName;
                                Сells["BN" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["BN" + (100 + (30 * i))].Value = usersDTO.Name;
                                Сells["BV" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["BV" + (100 + (30 * i))].Font.Size = 6;
                                Сells["BV" + (100 + (30 * i))].Value = techProcess002Revision[0].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 1)
                            {
                                Сells["CB" + (98 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["CB" + (98 + (30 * i))].Value = techProcess002Revision[1].RivisionName;
                                Сells["CS" + (98 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["CS" + (98 + (30 * i))].Value = usersDTO.Name;
                                Сells["DA" + (98 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["DA" + (98 + (30 * i))].Font.Size = 6;
                                Сells["DA" + (98 + (30 * i))].Value = techProcess002Revision[1].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 2)
                            {

                                Сells["CB" + (99 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["CB" + (99 + (30 * i))].Value = techProcess002Revision[2].RivisionName;
                                Сells["CS" + (99 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["CS" + (99 + (30 * i))].Value = usersDTO.Name;
                                Сells["DA" + (99 + (30 * i))].Font.Size = 6;
                                Сells["DA" + (99 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["DA" + (99 + (30 * i))].Value = techProcess002Revision[2].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 3)
                            {

                                Сells["CB" + (100 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["CB" + (100 + (30 * i))].Value = techProcess002Revision[3].RivisionName;
                                Сells["CS" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["CS" + (100 + (30 * i))].Value = usersDTO.Name;
                                Сells["DA" + (100 + (30 * i))].Font.Size = 6;
                                Сells["DA" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["DA" + (100 + (30 * i))].Value = techProcess002Revision[3].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 4)
                                break;

                        }
                    }
                }
            }

            try
            {
                workbook.SaveAs(techProcess002.TechProcessPath, FileFormat.XLS97);
            }

            catch (System.IO.IOException)
            {
                MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            return techProcess002.TechProcessPath;
        }

        public string UpdateTemplateTechProcess002(DrawingsDTO drawingsDTO)
        {

            var Workbook = Factory.GetWorkbook(drawingsDTO.TechProcess002Path);
            var Worksheet = Workbook.Worksheets[0];
            var Сells = Worksheet.Cells;
            IRange cells = Worksheet.Cells;
            Сells["A" + 39].Value = drawingsDTO.ParentName;
            Сells["A" + 39].HorizontalAlignment = HAlign.Center;
            Сells["W" + 48].Value = drawingsDTO.DetailWeight;
            Сells["W" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BI" + 48].Value = drawingsDTO.TH.ToString() + "х" + drawingsDTO.W.ToString() + "х" + drawingsDTO.L.ToString();
            Сells["BI" + 48].HorizontalAlignment = HAlign.Center;
            Сells["CD" + 48].Value = drawingsDTO.Quantity;
            Сells["CD" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 7].Value = drawingsDTO.Number;
            Сells["BB" + 7].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 41].Value = drawingsDTO.Number;
            Сells["BB" + 41].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 75].Value = drawingsDTO.Number;
            Сells["BS" + 75].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 106].Value = drawingsDTO.Number;
            Сells["BS" + 106].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 07].Value = TechProcesNameToStr(drawingsDTO.TechProcess002Name);
            Сells["CO" + 07].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 41].Value = TechProcesNameToStr(drawingsDTO.TechProcess002Name);
            Сells["CO" + 41].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 75].Value = TechProcesNameToStr(drawingsDTO.TechProcess002Name);
            Сells["CO" + 75].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 106].Value = TechProcesNameToStr(drawingsDTO.TechProcess002Name);
            Сells["CO" + 106].HorizontalAlignment = HAlign.Center;
            //BB7, BB41 = Назв чертежа
            //BS75 = Назва чертежа (цыкл)
            //CO7,CO41 = Номер техпроцесса(цыкл +45)
            //W48 = вес
            //BI48 = размеры
            //A39 = размеры

            try
            {
                //string fileName = String.Format("Зведена обігово-сальдова по рахунку 313 за період");
                //string fileName = String.Format("Зведена обігово-сальдова по рахунку 313 за період з {0} по {1}", startDate.ToShortDateString(), endDate.ToShortDateString());
                //Workbook.SaveAs(DbExelDir + techProcess001DTO.TechProcessName.ToString() + ".xls", FileFormat.Excel8);
                Workbook.Save();
                //Workbook.SaveAs(techProcess001DTO.TechProcessPath, FileFormat.Excel8);
                //Process process = new Process();
                //process.StartInfo.Arguments = "\"" + techProcess001DTO.TechProcessPath + "\"";
                //process.StartInfo.FileName = "Excel.exe";
                //process.Start();

            }

            catch (System.IO.IOException) { MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (System.ComponentModel.Win32Exception) { MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            return drawingsDTO.TechProcess001Path;
        }

        public string CreateTemplateTechProcess003(DrawingsDTO drawingsDTO, List<DrawingsDTO> drawingsListDTO, TechProcess003DTO techProcess003OldDTO = null)
        {
            try
            {
                if (techProcess003OldDTO == null)
                    Factory.GetWorkbook(GeneratedReportsDir + @"\template002.xls");
                else
                    Factory.GetWorkbook(techProcess003OldDTO.TechProcessPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не найдено шаблон документа!\n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            IWorkbook workbook = null;

            if (techProcess003OldDTO == null)
                workbook = Factory.GetWorkbook(GeneratedReportsDir + @"\template002.xls");
            else
                workbook = Factory.GetWorkbook(techProcess003OldDTO.TechProcessPath);

            //var Workbook = Factory.GetWorkbook(GeneratedReportsDir + @"\template002.xls");
            var Worksheet = workbook.Worksheets[0];
            var Сells = Worksheet.Cells;
            IRange cells = Worksheet.Cells;

            #region Header
            Сells["BX" + 27].Value = "Created by "; //создатель + дата


            Сells["BB" + 6].Value = drawingsDTO.Number;
            Сells["AV" + 40].Value = drawingsDTO.Number;

            Сells["CO" + 6].Value = TechProcesNameToStr(drawingsDTO.TechProcess003Name);
            Сells["CL" + 40].Value = TechProcesNameToStr(drawingsDTO.TechProcess003Name);

            Сells["AQ" + 9].Value = drawingsDTO.DetailName;
            Сells["AJ" + 24].Value = drawingsDTO.DetailName;
            Сells["AN" + 43].Value = drawingsDTO.DetailName;

            #endregion

            int startSheetRow = 34;
            int endSheetRow = 63;
            int moveRow = 30;
            int roundListSpecificationNumber = (int)Math.Ceiling((double)drawingsListDTO.Count() / 15.0);

            #region Specification lists
            if (techProcess003OldDTO == null)
            {
                #region Create specification list empty sheet

                for (int i = 1; i < roundListSpecificationNumber; i++)
                {
                    cells[startSheetRow + ":" + endSheetRow].Insert(InsertShiftDirection.Down);
                    cells[startSheetRow + ":" + endSheetRow].RowHeight = 21;
                    cells[startSheetRow + ":" + endSheetRow].HorizontalAlignment = HAlign.Left;
                    cells[startSheetRow + ":" + endSheetRow].Font.Bold = false;
                    cells["A" + (startSheetRow + moveRow) + ":" + "DF" + (endSheetRow + moveRow)].EntireMergeArea.Copy(cells["A" + startSheetRow + ":" + "DF" + endSheetRow], PasteType.All, PasteOperation.None, false, false);
                }
            }
            #endregion

            int specRow = 48;
            int mover = 1;
            int j = 0;

            for (int i = 0; i < drawingsListDTO.Count; i++)
            {
                Сells["W" + (specRow + j)].Value = i + 1;
                Сells["AA" + (specRow + j)].Value = drawingsListDTO[i].DetailName;
                Сells["BD" + (specRow + j)].Value = drawingsListDTO[i].Number;
                Сells["CH" + (specRow + j)].Value = "kg";
                Сells["CL" + (specRow + j)].Value = drawingsListDTO[i].DetailWeight;
                Сells["CQ" + (specRow + j)].Value = drawingsListDTO[i].Quantity;
                Сells["W" + (specRow + j) + ":" + "CQ" + (specRow + j)].HorizontalAlignment = HAlign.Left;
                Сells["W" + (specRow + j) + ":" + "CQ" + (specRow + j)].Font.Bold = false;
                ++j;

                if ((i % 14) == 0 && i != 0)
                {
                    specRow = 48 + (moveRow * mover);
                    ++mover;
                    j = 0;
                }
            }

            #endregion

            #region Footer

            Сells["J" + 40].Value = "Создатель";
            Сells["J" + 70].Value = "Создатель";
            Сells["J" + 71].Value = "Создатель";
            Сells["J" + 101].Value = "Создатель";

            Сells["AZ" + (71 + (30 * (roundListSpecificationNumber - 1)))].Value = drawingsDTO.Number;
            Сells["BQ" + (104 + (30 * (roundListSpecificationNumber - 1)))].Value = drawingsDTO.Number;
            Сells["BQ" + (135 + (30 * (roundListSpecificationNumber - 1)))].Value = drawingsDTO.Number;
            Сells["BQ" + (166 + (30 * (roundListSpecificationNumber - 1)))].Value = drawingsDTO.Number;


            Сells["CM" + (71 + (30 * (roundListSpecificationNumber - 1)))].Value = TechProcesNameToStr(drawingsDTO.TechProcess003Name);
            Сells["CM" + (104 + (30 * (roundListSpecificationNumber - 1)))].Value = TechProcesNameToStr(drawingsDTO.TechProcess003Name);
            Сells["CM" + (135 + (30 * (roundListSpecificationNumber - 1)))].Value = TechProcesNameToStr(drawingsDTO.TechProcess003Name);
            Сells["CM" + (166 + (30 * (roundListSpecificationNumber - 1)))].Value = TechProcesNameToStr(drawingsDTO.TechProcess003Name);

            Сells["AO" + (74 + (30 * (roundListSpecificationNumber - 1)))].Value = drawingsDTO.DetailName;
            Сells["X" + (78 + (30 * (roundListSpecificationNumber - 1)))].Value = drawingsDTO.DetailWeight;
            #endregion

            try
            {
                //string fileName = String.Format("Зведена обігово-сальдова по рахунку 313 за період з {0} по {1}", startDate.ToShortDateString(), endDate.ToShortDateString());
                //Workbook.SaveAs(DbExelDir + techProcess001DTO.TechProcessName.ToString() + ".xls", FileFormat.Excel8);
                workbook.SaveAs(drawingsDTO.TechProcess003Path, FileFormat.Excel8);
                //Process process = new Process();
                //process.StartInfo.Arguments = "\"" + drawingsDTO.TechProcess003Path + "\"";
                //process.StartInfo.FileName = "Excel.exe";
                //process.Start();

            }

            catch (System.IO.IOException) { MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (System.ComponentModel.Win32Exception) { MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            return drawingsDTO.TechProcess003Path;
        }

        public string CreateTemplateTechProcess003Exp(UsersDTO usersDTO, DrawingDTO techProces003Drawing, List<DrawingDTO> techProcess003DrawingParent, List<TechProcess003DTO> techProcess003Revision, TechProcess003DTO techProcess003, TechProcess003DTO techProcess003Old = null)
        {

            //Workbook workbook = new Workbook();
            //workbook.LoadDocument("Documents\\Document.xlsx", DocumentFormat.Xlsx);

            //try
            //{
            //    if (techProcess003Old == null)
            //        Factory.GetWorkbook(GeneratedReportsDir + @"\template003New.xls");
            //    else
            //        Factory.GetWorkbook(techProcess003Old.TechProcessPath);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Не найден шаблон документа!\n" + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return "";
            //}

            //IWorkbook workbook = null;



            //try
            //{
            //    workbook.SaveAs(techProcess003.TechProcessPath, FileFormat.XLS97);
            //}

            //catch (System.IO.IOException)
            //{
            //    MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return "";
            //}
            //catch (System.ComponentModel.Win32Exception)
            //{
            //    MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return "";
            //}

            //return techProcess003.TechProcessPath;
            return "";
        }

        public void OpenExcelFile(string fullPath)
        {
            Process process = new Process();
            process.StartInfo.Arguments = "\"" + fullPath + "\"";
            process.StartInfo.FileName = "Excel.exe";
            process.Start();
        }

        public string ResaveFileTechProcess001(TechProcess001DTO techProcess001, string fullPathExistingFile)
        {
            try
            {
                    Factory.GetWorkbook(fullPathExistingFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не найдено файл!\n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            IWorkbook workbook = Factory.GetWorkbook(fullPathExistingFile); ;
            try
            {
                workbook.SaveAs(techProcess001.TechProcessPath, FileFormat.XLS97);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            return techProcess001.TechProcessPath;
        }

        public string ResaveFileTechProcess002(TechProcess002DTO techProcess002, string fullPathExistingFile)
        {
            try
            {
                Factory.GetWorkbook(fullPathExistingFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не найдено файл!\n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            IWorkbook workbook = Factory.GetWorkbook(fullPathExistingFile); ;
            try
            {
                workbook.SaveAs(techProcess002.TechProcessPath, FileFormat.XLS97);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            return techProcess002.TechProcessPath;
        }

        public string ResaveFileTechProcess003(TechProcess003DTO techProcess003, string fullPathExistingFile)
        {
            try
            {
                Factory.GetWorkbook(fullPathExistingFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не найдено файл!\n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            IWorkbook workbook = Factory.GetWorkbook(fullPathExistingFile); ;
            try
            {
                workbook.SaveAs(techProcess003.TechProcessPath, FileFormat.XLS97);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            return techProcess003.TechProcessPath;
        }

        public string TechProcesNameToStr(long? techProcessName)
        {
            string techProcessNameStr = techProcessName.ToString();
            string dot = ".";
            techProcessNameStr = techProcessNameStr.Insert(2, dot);
            techProcessNameStr = techProcessNameStr.Insert(6, dot);


            return techProcessNameStr;
        }

        public string CreateTemplateTechProcess005Exp(UsersDTO usersDTO, DrawingDTO techProces005Drawing, List<DrawingDTO> techProcess005DrawingParent, List<TechProcess005DTO> techProcess005Revision, TechProcess005DTO techProcess005, TechProcess005DTO techProcess005Old = null)
        {
            try
            {
                if (techProcess005Old == null)
                    Factory.GetWorkbook(GeneratedReportsDir + @"\template001.xls");
                else
                    Factory.GetWorkbook(techProcess005Old.TechProcessPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не найден шаблон документа!\n" + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            IWorkbook workbook = null;

            if (techProcess005Old == null)
                workbook = Factory.GetWorkbook(GeneratedReportsDir + @"\template001New.xls");
            else
                workbook = Factory.GetWorkbook(techProcess005Old.TechProcessPath);

            var Worksheet = workbook.Worksheets[0];
            var Сells = Worksheet.Cells;
            IRange cells = Worksheet.Cells;

            int pagesStock = 4;
            int pagesOpenDocument = GetNumberDocumentPages(workbook);
            string parentDrawings = "";
            //получаем чертеж на который создаём техпроцесс
            //var drawingDTO = drawingService.GetDrawingById((int)techProcess001DTO.DrawingId);
            //получаем все чертежи-родители 
            //var listParentDrawings = GetDrawingParentByDrawingChildId((int)techProcess001DTO.DrawingId);
            if (techProcess005DrawingParent != null)
                parentDrawings = String.Join(", ", techProcess005DrawingParent.Select(bdsm => bdsm.Number).ToArray());

            Сells["AG" + 24].Value = "Machining";
            Сells["AG" + 24].HorizontalAlignment = HAlign.Center;


            cells["BY" + 28].Value = "Created by " + usersDTO.Name + " " + techProcess005.CreateDate.Value.ToShortDateString();
            //cells["J" + 41].Value = techProcess002.UserName;
            cells["J" + 41].Value = usersDTO.Name;
            cells["AF" + 41].Value = techProcess005.CreateDate.Value.ToShortDateString();
            cells["D" + 30].Value = "Date of issue ";


            Сells["AQ" + 10].Value = techProces005Drawing.DetailName;
            Сells["AQ" + 10].HorizontalAlignment = HAlign.Center;
            Сells["AL" + 44].Value = techProces005Drawing.DetailName;
            Сells["AL" + 44].HorizontalAlignment = HAlign.Center;

            if (techProcess005Revision != null)
            {
                for (int i = 0; i < techProcess005Revision.Count(); i++)
                {
                    if (i == 0)
                    {
                        Сells["AW" + 3 + ":" + "BV" + 3].Font.Bold = false;
                        Сells["AW" + 3 + ":" + "BV" + 3].Font.Italic = false;
                        Сells["AW" + 3 + ":" + "BV" + 3].Font.Size = 8;
                        Сells["AW" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 3].Value = techProcess005Revision[0].RivisionName;
                        Сells["BN" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 3].Value = usersDTO.Name;
                        Сells["BE" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 3].Value = techProcess005Revision[0].RevisionDocumentName;
                        Сells["BV" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 3].Font.Size = 6;
                        Сells["BV" + 3].Value = techProcess005Revision[0].CreateDate.Value.ToShortDateString();

                        Сells["AW" + 37 + ":" + "BV" + 37].Font.Bold = false;
                        Сells["AW" + 37 + ":" + "BV" + 37].Font.Italic = false;
                        Сells["AW" + 37 + ":" + "BV" + 37].Font.Size = 8;
                        Сells["AW" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 37].Value = techProcess005Revision[0].RivisionName;
                        Сells["BN" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 37].Value = usersDTO.Name;
                        Сells["BE" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 37].Value = techProcess005Revision[0].RevisionDocumentName;
                        Сells["BV" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 37].Font.Size = 6;
                        Сells["BV" + 37].Value = techProcess005Revision[0].CreateDate.Value.ToShortDateString();

                        Сells["AW" + 70 + ":" + "BV" + 70].Font.Bold = false;
                        Сells["AW" + 70 + ":" + "BV" + 70].Font.Italic = false;
                        Сells["AW" + 70 + ":" + "BV" + 70].Font.Size = 8;
                        Сells["AW" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 70].Value = techProcess005Revision[0].RivisionName;
                        Сells["BN" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 70].Value = usersDTO.Name;
                        Сells["BE" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 70].Value = techProcess005Revision[0].RevisionDocumentName;
                        Сells["BV" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 70].Font.Size = 6;
                        Сells["BV" + 70].Value = techProcess005Revision[0].CreateDate.Value.ToShortDateString();

                        Сells["AW" + 100 + ":" + "BV" + 100].Font.Bold = false;
                        Сells["AW" + 100 + ":" + "BV" + 100].Font.Italic = false;
                        Сells["AW" + 100 + ":" + "BV" + 100].Font.Size = 8;
                        Сells["AW" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["AW" + 100].Value = techProcess005Revision[0].RivisionName;
                        Сells["BN" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["BN" + 100].Value = usersDTO.Name;
                        Сells["BE" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["BE" + 100].Value = techProcess005Revision[0].RevisionDocumentName;
                        Сells["BV" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["BV" + 100].Font.Size = 6;
                        Сells["BV" + 100].Value = techProcess005Revision[0].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 1)
                    {
                        Сells["CB" + 2 + ":" + "DA" + 2].Font.Bold = false;
                        Сells["CB" + 2 + ":" + "DA" + 2].Font.Italic = false;
                        Сells["CB" + 2 + ":" + "DA" + 2].Font.Size = 8;
                        Сells["CB" + 2].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 2].Value = techProcess005Revision[1].RivisionName;
                        Сells["CS" + 2].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 2].Value = usersDTO.Name;
                        Сells["CJ" + 2].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 2].Value = techProcess005Revision[1].RevisionDocumentName;
                        Сells["DA" + 2].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 2].Font.Size = 6;
                        Сells["DA" + 2].Value = techProcess005Revision[1].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 35 + ":" + "DA" + 35].Font.Bold = false;
                        Сells["CB" + 35 + ":" + "DA" + 35].Font.Italic = false;
                        Сells["CB" + 35 + ":" + "DA" + 35].Font.Size = 8;
                        Сells["CB" + 35].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 35].Value = techProcess005Revision[1].RivisionName;
                        Сells["CS" + 35].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 35].Value = usersDTO.Name;
                        Сells["CJ" + 35].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 35].Value = techProcess005Revision[1].RevisionDocumentName;
                        Сells["DA" + 35].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 35].Font.Size = 6;
                        Сells["DA" + 35].Value = techProcess005Revision[1].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 68 + ":" + "DA" + 68].Font.Bold = false;
                        Сells["CB" + 68 + ":" + "DA" + 68].Font.Italic = false;
                        Сells["CB" + 68 + ":" + "DA" + 68].Font.Size = 8;
                        Сells["CB" + 68].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 68].Value = techProcess005Revision[1].RivisionName;
                        Сells["CS" + 68].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 68].Value = usersDTO.Name;
                        Сells["CJ" + 68].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 68].Value = techProcess005Revision[1].RevisionDocumentName;
                        Сells["DA" + 68].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 68].Font.Size = 6;
                        Сells["DA" + 68].Value = techProcess005Revision[1].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 98 + ":" + "DA" + 98].Font.Bold = false;
                        Сells["CB" + 98 + ":" + "DA" + 98].Font.Italic = false;
                        Сells["CB" + 98 + ":" + "DA" + 98].Font.Size = 8;
                        Сells["CB" + 98].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 98].Value = techProcess005Revision[1].RivisionName;
                        Сells["CS" + 98].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 98].Value = usersDTO.Name;
                        Сells["CJ" + 98].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 98].Value = techProcess005Revision[1].RevisionDocumentName;
                        Сells["DA" + 98].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 98].Font.Size = 6;
                        Сells["DA" + 98].Value = techProcess005Revision[1].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 2)
                    {
                        Сells["CB" + 3 + ":" + "DA" + 3].Font.Bold = false;
                        Сells["CB" + 3 + ":" + "DA" + 3].Font.Italic = false;
                        Сells["CB" + 3 + ":" + "DA" + 3].Font.Size = 8;
                        Сells["CB" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 3].Value = techProcess005Revision[2].RivisionName;
                        Сells["CS" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 3].Value = usersDTO.Name;
                        Сells["CJ" + 3].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 3].Value = techProcess005Revision[2].RevisionDocumentName;
                        Сells["DA" + 3].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 3].Font.Size = 6;
                        Сells["DA" + 3].Value = techProcess005Revision[2].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 36 + ":" + "DA" + 36].Font.Bold = false;
                        Сells["CB" + 36 + ":" + "DA" + 36].Font.Italic = false;
                        Сells["CB" + 36 + ":" + "DA" + 36].Font.Size = 8;
                        Сells["CB" + 36].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 36].Value = techProcess005Revision[2].RivisionName;
                        Сells["CS" + 36].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 36].Value = usersDTO.Name;
                        Сells["CJ" + 36].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 36].Value = techProcess005Revision[2].RevisionDocumentName;
                        Сells["DA" + 36].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 36].Font.Size = 6;
                        Сells["DA" + 36].Value = techProcess005Revision[2].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 69 + ":" + "DA" + 69].Font.Bold = false;
                        Сells["CB" + 69 + ":" + "DA" + 69].Font.Italic = false;
                        Сells["CB" + 69 + ":" + "DA" + 69].Font.Size = 8;
                        Сells["CB" + 69].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 69].Value = techProcess005Revision[2].RivisionName;
                        Сells["CS" + 69].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 69].Value = usersDTO.Name;
                        Сells["CJ" + 69].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 69].Value = techProcess005Revision[2].RevisionDocumentName;
                        Сells["DA" + 69].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 69].Font.Size = 6;
                        Сells["DA" + 69].Value = techProcess005Revision[2].CreateDate.Value.ToShortDateString();



                        Сells["CB" + 99 + ":" + "DA" + 99].Font.Bold = false;
                        Сells["CB" + 99 + ":" + "DA" + 99].Font.Italic = false;
                        Сells["CB" + 99 + ":" + "DA" + 99].Font.Size = 8;
                        Сells["CB" + 99].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 99].Value = techProcess005Revision[2].RivisionName;
                        Сells["CS" + 99].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 99].Value = usersDTO.Name;
                        Сells["CJ" + 99].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 99].Value = techProcess005Revision[2].RevisionDocumentName;
                        Сells["DA" + 99].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 99].Font.Size = 6;
                        Сells["DA" + 99].Value = techProcess005Revision[2].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 3)
                    {
                        Сells["CB" + 37 + ":" + "DA" + 37].Font.Bold = false;
                        Сells["CB" + 37 + ":" + "DA" + 37].Font.Italic = false;
                        Сells["CB" + 37 + ":" + "DA" + 37].Font.Size = 8;
                        Сells["CB" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 37].Value = techProcess005Revision[3].RivisionName;
                        Сells["CS" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 37].Value = usersDTO.Name;
                        Сells["CJ" + 37].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 37].Value = techProcess005Revision[3].RevisionDocumentName;
                        Сells["DA" + 37].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 37].Font.Size = 6;
                        Сells["DA" + 37].Value = techProcess005Revision[3].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 70 + ":" + "DA" + 70].Font.Bold = false;
                        Сells["CB" + 70 + ":" + "DA" + 70].Font.Italic = false;
                        Сells["CB" + 70 + ":" + "DA" + 70].Font.Size = 8;
                        Сells["CB" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 70].Value = techProcess005Revision[3].RivisionName;
                        Сells["CS" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 70].Value = usersDTO.Name;
                        Сells["CJ" + 70].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 70].Value = techProcess005Revision[3].RevisionDocumentName;
                        Сells["DA" + 70].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 70].Font.Size = 6;
                        Сells["DA" + 70].Value = techProcess005Revision[3].CreateDate.Value.ToShortDateString();

                        Сells["CB" + 100 + ":" + "DA" + 100].Font.Bold = false;
                        Сells["CB" + 100 + ":" + "DA" + 100].Font.Italic = false;
                        Сells["CB" + 100 + ":" + "DA" + 100].Font.Size = 8;
                        Сells["CB" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["CB" + 100].Value = techProcess005Revision[3].RivisionName;
                        Сells["CS" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["CS" + 100].Value = usersDTO.Name;
                        Сells["CJ" + 100].HorizontalAlignment = HAlign.Center;
                        Сells["CJ" + 100].Value = techProcess005Revision[3].RevisionDocumentName;
                        Сells["DA" + 100].HorizontalAlignment = HAlign.Left;
                        Сells["DA" + 100].Font.Size = 6;
                        Сells["DA" + 100].Value = techProcess005Revision[3].CreateDate.Value.ToShortDateString();
                        continue;
                    }
                    if (i == 4)
                        break;
                }
            }


            Сells["F" + 46].Value = techProces005Drawing.MaterialName;
            Сells["F" + 46].HorizontalAlignment = HAlign.Left;

            Сells["A" + 39].Value = parentDrawings;
            Сells["A" + 39].HorizontalAlignment = HAlign.Center;
            Сells["W" + 48].Value = techProcess005.Weight;
            Сells["W" + 48].HorizontalAlignment = HAlign.Center;

            string paramaterBlank = "";

            if (techProcess005.TH != "" && techProcess005.TH != null)
                paramaterBlank += techProcess005.TH.ToString() + "х";
            if (techProcess005.W != "" && techProcess005.W != null)
                paramaterBlank += techProcess005.W.ToString() + "x";
            if (techProcess005.W2 != "" && techProcess005.W2 != null)
                paramaterBlank += techProcess005.W2.ToString() + "x";
            if (techProcess005.L != "" && techProcess005.L != null)
                paramaterBlank += techProcess005.L.ToString();

            Сells["BI" + 48].Value = paramaterBlank;
            Сells["BI" + 48].HorizontalAlignment = HAlign.Center;

            //Количество, нужно ли??????????????
            //Сells["CD" + 48].Value = drawingsDTO.Quantity;
            //Сells["CD" + 48].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 7].Value = techProces005Drawing.Number;
            Сells["BB" + 7].HorizontalAlignment = HAlign.Center;
            Сells["BB" + 41].Value = techProces005Drawing.Number;
            Сells["BB" + 41].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 74].Value = techProces005Drawing.Number;
            Сells["BS" + 74].HorizontalAlignment = HAlign.Center;
            Сells["BS" + 104].Value = techProces005Drawing.Number;
            Сells["BS" + 104].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 07].Value = TechProcesNameToStr(techProcess005.TechProcessName);
            Сells["CO" + 07].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 41].Value = TechProcesNameToStr(techProcess005.TechProcessName);
            Сells["CO" + 41].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 74].Value = TechProcesNameToStr(techProcess005.TechProcessName);
            Сells["CO" + 74].HorizontalAlignment = HAlign.Center;
            Сells["CO" + 104].Value = TechProcesNameToStr(techProcess005.TechProcessName);
            Сells["CO" + 104].HorizontalAlignment = HAlign.Center;

            if (pagesOpenDocument > pagesStock)
            {
                for (int i = 1; i <= pagesOpenDocument - pagesStock; i++)
                {
                    Сells["CO" + (104 + (30 * i))].Value = TechProcesNameToStr(techProcess005.TechProcessName);
                    Сells["CO" + (104 + (30 * i))].HorizontalAlignment = HAlign.Center;
                    Сells["BS" + (104 + (30 * i))].Value = techProces005Drawing.Number;
                    Сells["BS" + (104 + (30 * i))].HorizontalAlignment = HAlign.Center;

                    if (techProcess005Revision != null)
                    {
                        for (int j = 0; j < techProcess005Revision.Count(); j++)
                        {
                            if (j == 0)
                            {
                                Сells["AW" + (100 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["AW" + (100 + (30 * i))].Value = techProcess005Revision[0].RivisionName;
                                Сells["BN" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["BN" + (100 + (30 * i))].Value = usersDTO.Name;
                                Сells["BV" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["BV" + (100 + (30 * i))].Font.Size = 6;
                                Сells["BV" + (100 + (30 * i))].Value = techProcess005Revision[0].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 1)
                            {
                                Сells["CB" + (98 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["CB" + (98 + (30 * i))].Value = techProcess005Revision[1].RivisionName;
                                Сells["CS" + (98 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["CS" + (98 + (30 * i))].Value = usersDTO.Name;
                                Сells["DA" + (98 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["DA" + (98 + (30 * i))].Font.Size = 6;
                                Сells["DA" + (98 + (30 * i))].Value = techProcess005Revision[1].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 2)
                            {

                                Сells["CB" + (99 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["CB" + (99 + (30 * i))].Value = techProcess005Revision[2].RivisionName;
                                Сells["CS" + (99 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["CS" + (99 + (30 * i))].Value = usersDTO.Name;
                                Сells["DA" + (99 + (30 * i))].Font.Size = 6;
                                Сells["DA" + (99 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["DA" + (99 + (30 * i))].Value = techProcess005Revision[2].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 3)
                            {

                                Сells["CB" + (100 + (30 * i))].HorizontalAlignment = HAlign.Center;
                                Сells["CB" + (100 + (30 * i))].Value = techProcess005Revision[3].RivisionName;
                                Сells["CS" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["CS" + (100 + (30 * i))].Value = usersDTO.Name;
                                Сells["DA" + (100 + (30 * i))].Font.Size = 6;
                                Сells["DA" + (100 + (30 * i))].HorizontalAlignment = HAlign.Left;
                                Сells["DA" + (100 + (30 * i))].Value = techProcess005Revision[3].CreateDate.Value.ToShortDateString();
                                continue;
                            }
                            if (j == 4)
                                break;

                        }
                    }
                }
            }

            try
            {
                workbook.SaveAs(techProcess005.TechProcessPath, FileFormat.XLS97);
            }

            catch (System.IO.IOException)
            {
                MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            return techProcess005.TechProcessPath;


        }

        public IEnumerable<DrawingsDTO> GetChildDrawings(DrawingsDTO drawingsDTO)
        {
            var result = (from drw in drawings.GetAll()
                          join dr in drawing.GetAll() on drw.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join det in details.GetAll() on dr.DetailId equals det.Id into dett
                          from det in dett.DefaultIfEmpty()
                          join mat in materials.GetAll() on dr.MaterialId equals mat.Id into matt
                          from mat in matt.DefaultIfEmpty()
                          where drw.ParentId == drawingsDTO.Id

                          select new DrawingsDTO
                          {
                              Id = drw.Id,
                              Number = dr.Number,
                               DrawingId = dr.Id,
                              DetailName = det.DetailName,
                              MaterialName = mat.MaterialName,
                              Quantity = drw.Quantity,
                              QuantityL = drw.QuantityL,
                              QuantityR = drw.QuantityR,
                              DetailWeight = dr.DetailWeight,
                          }
                          ).ToList();

            return result;
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
