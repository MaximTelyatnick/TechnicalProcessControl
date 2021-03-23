using AutoMapper;
using SpreadsheetGear;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.DAL.Interfaces;
using TechnicalProcessControl.DAL.Models;

namespace TechnicalProcessControl.BLL.Services
{
    public class TechProcessService : ITechProcessService
    {

        private IUnitOfWork Database { get; set; }

        private IRepository<Colors> colorsMenu;
        private IRepository<Colors> colorsDrawing;
        private IRepository<Colors> colorsDetail;
        private IRepository<Drawings> drawings;
        private IRepository<Drawings> drawingsChild;
        private IRepository<Drawings> parentDrawings;
        private IRepository<DrawingScan> drawingScan;
        private IRepository<Details> details;
        private IRepository<Materials> materials;
        private IRepository<DAL.Models.Type> type;
        private IRepository<TechProcess001> techProcess001;
        private IRepository<TechProcess002> techProcess002;
        private IRepository<TechProcess003> techProcess003;
        private IRepository<TechProcess004> techProcess004;
        private IRepository<TechProcess005> techProcess005;
        private IRepository<Drawing> drawing;
        private IRepository<Drawing> drawingCopy;
        private IRepository<Drawing> drawingTech;
        private IRepository<Drawing> drawingChild;
        private IRepository<Drawing> replacementDrawing;
        private IRepository<Drawing> firstUseDrawing;
        private IRepository<Revisions> revisions;
        private IRepository<Revisions> revisionsTechProcess001;
        private IRepository<Revisions> revisionsTechProcess002;
        private IRepository<Revisions> revisionsTechProcess003;
        private IRepository<Revisions> revisionsTechProcess004;
        private IRepository<Revisions> revisionsTechProcess005;
        private IRepository<Users> users;

        private IRepository<DrawingsInfo> drawingsInfo;
        private IRepository<Test> test;

        private IMapper mapper;

        public TechProcessService(IUnitOfWork uow)
        {
            Database = uow;

            colorsMenu = Database.GetRepository<Colors>();
            colorsDrawing = Database.GetRepository<Colors>();
            colorsDetail = Database.GetRepository<Colors>();
            drawings = Database.GetRepository<Drawings>();
            drawingsChild = Database.GetRepository<Drawings>();
            parentDrawings = Database.GetRepository<Drawings>();
            drawingScan = Database.GetRepository<DrawingScan>();
            details = Database.GetRepository<Details>();
            materials = Database.GetRepository<Materials>();
            type = Database.GetRepository<DAL.Models.Type>();
            techProcess001 = Database.GetRepository<TechProcess001>();
            techProcess002 = Database.GetRepository<TechProcess002>();
            techProcess003 = Database.GetRepository<TechProcess003>();
            techProcess004 = Database.GetRepository<TechProcess004>();
            techProcess005 = Database.GetRepository<TechProcess005>();
            drawing = Database.GetRepository<Drawing>();
            drawingCopy = Database.GetRepository<Drawing>();
            drawingTech = Database.GetRepository<Drawing>();
            drawingChild = Database.GetRepository<Drawing>();
            replacementDrawing = Database.GetRepository<Drawing>();
            firstUseDrawing = Database.GetRepository<Drawing>();
            revisions = Database.GetRepository<Revisions>();
            revisionsTechProcess001 = Database.GetRepository<Revisions>();
            revisionsTechProcess002 = Database.GetRepository<Revisions>();
            revisionsTechProcess003 = Database.GetRepository<Revisions>();
            revisionsTechProcess004 = Database.GetRepository<Revisions>();
            revisionsTechProcess005 = Database.GetRepository<Revisions>();
            users = Database.GetRepository<Users>();

            drawingsInfo = Database.GetRepository<DrawingsInfo>();
            test = Database.GetRepository<Test>();



            var config = new MapperConfiguration(cfg =>
            {
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
                cfg.CreateMap<Materials, MaterialsDTO>();
                cfg.CreateMap<MaterialsDTO, Materials>();
                cfg.CreateMap<Drawing, DrawingDTO>();
                cfg.CreateMap<DrawingDTO, Drawing>();
                cfg.CreateMap<Revisions, RevisionsDTO>();
                cfg.CreateMap<RevisionsDTO, Revisions>();
                cfg.CreateMap<Users, UsersDTO>();
                cfg.CreateMap<UsersDTO, Users>();

                cfg.CreateMap<DrawingsInfo, DrawingsInfoDTO>();
                cfg.CreateMap<DrawingsInfoDTO, DrawingsInfo>();
            });

            mapper = config.CreateMapper();
        }

        public bool FileDelete(string URI)
        {
            if (File.Exists(URI))
            {
                try
                {
                    File.Delete(URI);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #region TechProcess001 method's

        //получить все техпроцессы 001 по айди техпроцесса с краткой информацией ok
        public IEnumerable<TechProcess001DTO> GetAllTechProcess001Simple()
        {
            return mapper.Map<IEnumerable<TechProcess001>, List<TechProcess001DTO>>(techProcess001.GetAll());
        }

        //получить техпроцесс 001 по айди техпроцесса с подробной информацией   ok
        public TechProcess001DTO GetTechProcess001ByIdFull(int techProcess001Id)
        {
            var result = (from tcp in techProcess001.GetAll()
                          join rt in revisionsTechProcess001.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.Id == techProcess001Id
                          select new TechProcess001DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              UserId = tcp.UserId,
                              UserName = usr.Name
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }

        //получить техпроцесс 001 по айди техпроцесса с краткой информацией   ok
        public TechProcess001DTO GetTechProcess001Simple(int techProcess001Id)
        {
            return mapper.Map<TechProcess001, TechProcess001DTO>(techProcess001.GetAll().FirstOrDefault(srt => srt.Id == techProcess001Id));
        }

        //получить ревизию техпроцесса 001 по айди техпроцесса с краткой информацией ok
        public TechProcess001DTO GetTechProcess001RevisionByIdSimple(int techProcess001Id)
        {
            return mapper.Map<TechProcess001, TechProcess001DTO>(techProcess001.GetAll().FirstOrDefault(srt => srt.ParentId == techProcess001Id));
        }

        //получить ревизию техпроцесса 001 по айди техпроцесса с подробной информацией ok
        public TechProcess001DTO GetTechProcess001RevisionByIdFull(int techProcess001Id)
        {
            var result = (from tcp in techProcess001.GetAll()
                          join rt in revisionsTechProcess001.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.ParentId == techProcess001Id
                          select new TechProcess001DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              UserId = tcp.UserId,
                              UserName = usr.Name
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }



        //получить актуальный техпроцесс 001 по айди чертежа  с подробной информацией (материалы и трудоёмкость)
        public TechProcess001DTO GetTechProcess001ByDrawingId(int drawingId)
        {
            var result = (from tcp in techProcess001.GetAll()
                          join rt in revisionsTechProcess001.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.DrawingId == drawingId && tcp.ParentId == null
                          select new TechProcess001DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              CopyDrawingId = tcp.CopyDrawingId,
                              DilKapci2K = tcp.DilKapci2K,
                              DilKapci880 = tcp.DilKapci880,
                              DilKapci881 = tcp.DilKapci881,
                              EnamelKapci6030 = tcp.EnamelKapci6030,
                              EnamelKapci641 = tcp.EnamelKapci641,
                              EnamelKapci670 = tcp.EnamelKapci670,
                              GasAr = tcp.GasAr,
                              GasArCO2 = tcp.GasArCO2,
                              GasCO3 = tcp.GasCO3,
                              GasN2 = tcp.GasN2,
                              GasNature = tcp.GasNature,
                              GasO2 = tcp.GasO2,
                              HardKapci126 = tcp.HardKapci126,
                              HardKapci2KMS651 = tcp.HardKapci2KMS651,
                              HardKapci881 = tcp.HardKapci881,
                              HardKapciHs6055 = tcp.HardKapciHs6055,
                              HardKapciPEPutty = tcp.HardKapciPEPutty,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              PrimerKapci125 = tcp.PrimerKapci125,
                              PrimerKapci633 = tcp.PrimerKapci633,
                              PuttyKapci350 = tcp.PuttyKapci350,
                              UniversalSikaflex527 = tcp.UniversalSikaflex527,
                              Welding10 = tcp.Welding10,
                              Welding12 = tcp.Welding12,
                              Welding16 = tcp.Welding16,
                              Welding20 = tcp.Welding20,
                              Welding20Steel = tcp.Welding20Steel,
                              WeldingElektrod = tcp.WeldingElektrod
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }

        //получить все техпроцессы 001 и их ревизии с подробной информацией (без материалов и трудоёмкости)
        public IEnumerable<TechProcess001DTO> GetAllTechProcess001()
        {
            var result = (from tcp in techProcess001.GetAll()
                          join rt in revisionsTechProcess001.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join drCopy in drawingCopy.GetAll() on tcp.CopyDrawingId equals drCopy.Id into drCopyy
                          from drCopy in drCopyy.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.TechProcessName != 100010000
                          select new TechProcess001DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = tcp.DrawingId != null ? dr.Number : drCopy.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              CopyDrawingId = drCopy.Id
                          }
                          ).ToList();

            return result;
        }

        //получить только актуальные техпроцессы 001 без ревизий с подробной информацией
        public IEnumerable<TechProcess001DTO> GetAllTechProcessActual001()
        {
            var result = (from tcp in techProcess001.GetAll()
                          join rt in revisionsTechProcess001.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.ParentId == null
                          select new TechProcess001DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              OldTechProcess = tcp.OldTechProcess,
                              TypeId = tcp.TypeId,
                              RevisionDocumentName = tcp.RevisionDocumentName
                          }
                          ).ToList();

            return result;
        }

        //проверить наличие техпроцесса 001 по его номеру ok
        public bool CheckTechProcess001(long techProcesName)
        {
            return techProcess001.GetAll().Any(chk => chk.TechProcessName == techProcesName);
        }

        //получить номер техпроцесса 001 которого еще не существует в базе (максимальный + 1) ok
        public long GetLastTechProcess001()
        {
            long maxValue = techProcess001.GetAll().Where(srt => srt.TechProcessName < 200000000).Select(bdsm => bdsm.TechProcessName).Max();
            ++maxValue;
            return maxValue;
        }


        // получить ревизии техпроцесса 001 по Id родителя ok
        public IEnumerable<TechProcess001DTO> GetAllTechProcess001Revision(int techProcessId)
        {
            List<TechProcess001DTO> allRevisiontechProcess001 = new List<TechProcess001DTO>();

            var techProcess001 = GetTechProcess001RevisionByIdFull(techProcessId);
            if (techProcess001 == null)
            {
                return allRevisiontechProcess001;
            }
            else
            {
                allRevisiontechProcess001.Add(techProcess001);
                allRevisiontechProcess001 = TechProcess001Revision(techProcess001, allRevisiontechProcess001);
                return allRevisiontechProcess001;
            }
        }

        public List<TechProcess001DTO> TechProcess001Revision(TechProcess001DTO techProcess001, List<TechProcess001DTO> alltechProcessRevision)
        {
            var techProcessRevision001 = GetTechProcess001RevisionByIdFull(((TechProcess001DTO)techProcess001).Id);
            if (techProcessRevision001 == null)
            {
                return alltechProcessRevision;
            }
            else
            {
                alltechProcessRevision.Add(techProcessRevision001);
                alltechProcessRevision = TechProcess001Revision(techProcessRevision001, alltechProcessRevision);
                return alltechProcessRevision;
            }
        }



        // получить  ревизии техпроцесса 001 + актуальный по Id 
        public IEnumerable<TechProcess001DTO> GetAllTechProcess001RevisionWithActualTechprocess(int techProcessId)
        {
            List<TechProcess001DTO> allRevisiontechProcess001 = new List<TechProcess001DTO>();
            var techProcess001Actial = GetTechProcess001Simple(techProcessId);
            allRevisiontechProcess001.Add(techProcess001Actial);

            var techProcess001 = GetTechProcess001RevisionByIdFull(techProcessId);
            if (techProcess001 == null)
            {
                return allRevisiontechProcess001;
            }
            else
            {
                allRevisiontechProcess001.Add(techProcess001);
                allRevisiontechProcess001 = TechProcess001Revision(techProcess001, allRevisiontechProcess001);
                return allRevisiontechProcess001;
            }
        }

        //проверяем есть ли техпроцессы первого типа подвязанные к айди чертежа ок
        public bool CheckTechProcess001Drawing(int drawingId)
        {
            return techProcess001.GetAll().Any(chk => chk.DrawingId == drawingId);
        }

        #endregion

        #region TechProcess002 method's

        //получить все техпроцессы 002 по айди техпроцесса с краткой информацией ok
        public IEnumerable<TechProcess002DTO> GetAllTechProcess002Simple()
        {
            return mapper.Map<IEnumerable<TechProcess002>, List<TechProcess002DTO>>(techProcess002.GetAll());
        }

        //получить техпроцесс 002 по айди техпроцесса с подробной информацией   ok
        public TechProcess002DTO GetTechProcess002ByIdFull(int techProcess002Id)
        {
            var result = (from tcp in techProcess002.GetAll()
                          join rt in revisionsTechProcess002.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.Id == techProcess002Id
                          select new TechProcess002DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              UserId = tcp.UserId,
                              UserName = usr.Name
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }

        //получить техпроцесс 002 по айди техпроцесса с краткой информацией   ok
        public TechProcess002DTO GetTechProcess002Simple(int techProcess002Id)
        {
            return mapper.Map<TechProcess002, TechProcess002DTO>(techProcess002.GetAll().FirstOrDefault(srt => srt.Id == techProcess002Id));
        }

        //получить ревизию техпроцесса 002 по айди техпроцесса с краткой информацией ok
        public TechProcess002DTO GetTechProcess002RevisionByIdSimple(int techProcess002Id)
        {
            return mapper.Map<TechProcess002, TechProcess002DTO>(techProcess002.GetAll().FirstOrDefault(srt => srt.ParentId == techProcess002Id));
        }

        //получить ревизию техпроцесса 002 по айди техпроцесса с подробной информацией ok
        public TechProcess002DTO GetTechProcess002RevisionByIdFull(int techProcess002Id)
        {
            var result = (from tcp in techProcess002.GetAll()
                          join rt in revisionsTechProcess002.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.ParentId == techProcess002Id
                          select new TechProcess002DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              UserId = tcp.UserId,
                              UserName = usr.Name
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }



        //получить актуальный техпроцесс 002 по айди чертежа  с подробной информацией (материалы и трудоёмкость)
        public TechProcess002DTO GetTechProcess002ByDrawingId(int drawingId)
        {
            var result = (from tcp in techProcess002.GetAll()
                          join rt in revisionsTechProcess002.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.DrawingId == drawingId && tcp.ParentId == null
                          select new TechProcess002DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              CopyDrawingId = tcp.CopyDrawingId,
                              DilKapci2K = tcp.DilKapci2K,
                              DilKapci880 = tcp.DilKapci880,
                              DilKapci881 = tcp.DilKapci881,
                              EnamelKapci6030 = tcp.EnamelKapci6030,
                              EnamelKapci641 = tcp.EnamelKapci641,
                              EnamelKapci670 = tcp.EnamelKapci670,
                              GasAr = tcp.GasAr,
                              GasArCO2 = tcp.GasArCO2,
                              GasCO3 = tcp.GasCO3,
                              GasN2 = tcp.GasN2,
                              GasNature = tcp.GasNature,
                              GasO2 = tcp.GasO2,
                              HardKapci126 = tcp.HardKapci126,
                              HardKapci2KMS651 = tcp.HardKapci2KMS651,
                              HardKapci881 = tcp.HardKapci881,
                              HardKapciHs6055 = tcp.HardKapciHs6055,
                              HardKapciPEPutty = tcp.HardKapciPEPutty,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              PrimerKapci125 = tcp.PrimerKapci125,
                              PrimerKapci633 = tcp.PrimerKapci633,
                              PuttyKapci350 = tcp.PuttyKapci350,
                              UniversalSikaflex527 = tcp.UniversalSikaflex527,
                              Welding10 = tcp.Welding10,
                              Welding12 = tcp.Welding12,
                              Welding16 = tcp.Welding16,
                              Welding20 = tcp.Welding20,
                              Welding20Steel = tcp.Welding20Steel,
                              WeldingElektrod = tcp.WeldingElektrod
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }

        //получить все техпроцессы 001 и их ревизии с подробной информацией (без материалов и трудоёмкости)
        public IEnumerable<TechProcess002DTO> GetAllTechProcess002()
        {
            var result = (from tcp in techProcess002.GetAll()
                          join rt in revisionsTechProcess002.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join drCopy in drawingCopy.GetAll() on tcp.CopyDrawingId equals drCopy.Id into drCopyy
                          from drCopy in drCopyy.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.TechProcessName != 100020000
                          select new TechProcess002DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = tcp.DrawingId != null ? dr.Number : drCopy.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              CopyDrawingId = drCopy.Id
                          }
                          ).ToList();

            return result;
        }

        //получить только актуальные техпроцессы 002 без ревизий с подробной информацией
        public IEnumerable<TechProcess002DTO> GetAllTechProcessActual002()
        {
            var result = (from tcp in techProcess002.GetAll()
                          join rt in revisionsTechProcess002.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.ParentId == null
                          select new TechProcess002DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              OldTechProcess = tcp.OldTechProcess,
                              TypeId = tcp.TypeId,
                              RevisionDocumentName = tcp.RevisionDocumentName
                          }
                          ).ToList();

            return result;
        }

        //проверить наличие техпроцесса 002 по его номеру ok
        public bool CheckTechProcess002(long techProcesName)
        {
            return techProcess002.GetAll().Any(chk => chk.TechProcessName == techProcesName);
        }

        //получить номер техпроцесса 002 которого еще не существует в базе (максимальный + 1) ok
        public long GetLastTechProcess002()
        {
            long maxValue = techProcess002.GetAll().Where(srt => srt.TechProcessName < 300000000).Select(bdsm => bdsm.TechProcessName).Max();
            ++maxValue;
            return maxValue;
        }


        // получить ревизии техпроцесса 002 по Id родителя ok
        public IEnumerable<TechProcess002DTO> GetAllTechProcess002Revision(int techProcessId)
        {
            List<TechProcess002DTO> allRevisiontechProcess002 = new List<TechProcess002DTO>();

            var techProcess002 = GetTechProcess002RevisionByIdFull(techProcessId);
            if (techProcess002 == null)
            {
                return allRevisiontechProcess002;
            }
            else
            {
                allRevisiontechProcess002.Add(techProcess002);
                allRevisiontechProcess002 = TechProcess002Revision(techProcess002, allRevisiontechProcess002);
                return allRevisiontechProcess002;
            }
        }

        public List<TechProcess002DTO> TechProcess002Revision(TechProcess002DTO techProcess002, List<TechProcess002DTO> alltechProcessRevision)
        {
            var techProcessRevision002 = GetTechProcess002RevisionByIdFull(((TechProcess002DTO)techProcess002).Id);
            if (techProcessRevision002 == null)
            {
                return alltechProcessRevision;
            }
            else
            {
                alltechProcessRevision.Add(techProcessRevision002);
                alltechProcessRevision = TechProcess002Revision(techProcessRevision002, alltechProcessRevision);
                return alltechProcessRevision;
            }
        }



        // получить  ревизии техпроцесса 002 + актуальный по Id 
        public IEnumerable<TechProcess002DTO> GetAllTechProcess002RevisionWithActualTechprocess(int techProcessId)
        {
            List<TechProcess002DTO> allRevisiontechProcess002 = new List<TechProcess002DTO>();
            var techProcess002Actial = GetTechProcess002Simple(techProcessId);
            allRevisiontechProcess002.Add(techProcess002Actial);

            var techProcess002 = GetTechProcess002RevisionByIdFull(techProcessId);
            if (techProcess002 == null)
            {
                return allRevisiontechProcess002;
            }
            else
            {
                allRevisiontechProcess002.Add(techProcess002);
                allRevisiontechProcess002 = TechProcess002Revision(techProcess002, allRevisiontechProcess002);
                return allRevisiontechProcess002;
            }
        }

        //проверяем есть ли техпроцессы второго типа подвязанные к айди чертежа ок
        public bool CheckTechProcess002Drawing(int drawingId)
        {
            return techProcess002.GetAll().Any(chk => chk.DrawingId == drawingId);
        }

        #endregion

        #region TechProcess003 method's

        //получить актуальный техпроцесс 003 по айди чертежа  с подробной информацией (материалы и трудоёмкость)
        public TechProcess003DTO GetTechProcess003ByDrawingId(int drawingId)
        {
            var result = (from tcp in techProcess003.GetAll()
                          join rt in revisionsTechProcess003.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.DrawingId == drawingId && tcp.ParentId == null
                          select new TechProcess003DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              CopyDrawingId = tcp.CopyDrawingId,
                              DilKapci2K = tcp.DilKapci2K,
                              DilKapci880 = tcp.DilKapci880,
                              DilKapci881 = tcp.DilKapci881,
                              EnamelKapci6030 = tcp.EnamelKapci6030,
                              EnamelKapci641 = tcp.EnamelKapci641,
                              EnamelKapci670 = tcp.EnamelKapci670,
                              GasAr = tcp.GasAr,
                              GasArCO2 = tcp.GasArCO2,
                              GasCO3 = tcp.GasCO3,
                              GasN2 = tcp.GasN2,
                              GasNature = tcp.GasNature,
                              GasO2 = tcp.GasO2,
                              HardKapci126 = tcp.HardKapci126,
                              HardKapci2KMS651 = tcp.HardKapci2KMS651,
                              HardKapci881 = tcp.HardKapci881,
                              HardKapciHs6055 = tcp.HardKapciHs6055,
                              HardKapciPEPutty = tcp.HardKapciPEPutty,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              PrimerKapci125 = tcp.PrimerKapci125,
                              PrimerKapci633 = tcp.PrimerKapci633,
                              PuttyKapci350 = tcp.PuttyKapci350,
                              UniversalSikaflex527 = tcp.UniversalSikaflex527,
                              Welding10 = tcp.Welding10,
                              Welding12 = tcp.Welding12,
                              Welding16 = tcp.Welding16,
                              Welding20 = tcp.Welding20,
                              Welding20Steel = tcp.Welding20Steel,
                              WeldingElektrod = tcp.WeldingElektrod
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }

        //получить техпроцесс 003 по айди техпроцесса с краткой информацией и именем ревизии   ok
        public TechProcess003DTO GetTechProcess003SimpleWithRevisionName(int techProcess003Id)
        {
            var result = (from tcp in techProcess003.GetAll()
                          join rd in revisions.GetAll() on tcp.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          where (tcp.Id == techProcess003Id)
                          select new TechProcess003DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              RivisionName = rd.Symbol,
                              OldTechProcess = tcp.OldTechProcess,
                              TypeId = tcp.TypeId,
                              RevisionDocumentName = tcp.RevisionDocumentName
                          }
                          ).FirstOrDefault();

            return result;
        }

        //получить техпроцесс 003 по айди техпроцесса с краткой информацией   ok
        public TechProcess003DTO GetTechProcess003Simple(int techProcess003Id)
        {
            return mapper.Map<TechProcess003, TechProcess003DTO>(techProcess003.GetAll().FirstOrDefault(srt => srt.Id == techProcess003Id));
        }

        // получить  ревизии техпроцесса 003 + актуальный по Id 
        public IEnumerable<TechProcess003DTO> GetAllTechProcess003RevisionWithActualTechprocess(int techProcessId)
        {
            List<TechProcess003DTO> allRevisiontechProcess003 = new List<TechProcess003DTO>();
            var techProcess003Actial = GetTechProcess003SimpleWithRevisionName(techProcessId);
            allRevisiontechProcess003.Add(techProcess003Actial);

            var techProcess003 = GetTechProcess003RevisionByIdFull(techProcessId);
            if (techProcess003 == null)
            {
                return allRevisiontechProcess003;
            }
            else
            {
                allRevisiontechProcess003.Add(techProcess003);
                allRevisiontechProcess003 = TechProcess003Revision(techProcess003, allRevisiontechProcess003);
                return allRevisiontechProcess003;
            }
        }

        // получить ревизии техпроцесса 003 по Id родителя ok
        public IEnumerable<TechProcess003DTO> GetAllTechProcess003Revision(int techProcessId)
        {
            List<TechProcess003DTO> allRevisiontechProcess003 = new List<TechProcess003DTO>();

            var techProcess003 = GetTechProcess003RevisionByIdFull(techProcessId);
            if (techProcess003 == null)
            {
                return allRevisiontechProcess003;
            }
            else
            {
                allRevisiontechProcess003.Add(techProcess003);
                allRevisiontechProcess003 = TechProcess003Revision(techProcess003, allRevisiontechProcess003);
                return allRevisiontechProcess003;
            }
        }

        public List<TechProcess003DTO> TechProcess003Revision(TechProcess003DTO techProcess003, List<TechProcess003DTO> alltechProcessRevision)
        {
            var techProcessRevision003 = GetTechProcess003RevisionByIdFull(((TechProcess003DTO)techProcess003).Id);
            if (techProcessRevision003 == null)
            {
                return alltechProcessRevision;
            }
            else
            {
                alltechProcessRevision.Add(techProcessRevision003);
                alltechProcessRevision = TechProcess003Revision(techProcessRevision003, alltechProcessRevision);
                return alltechProcessRevision;
            }
        }

        //получить ревизию техпроцесса 003 по айди техпроцесса с подробной информацией ok
        public TechProcess003DTO GetTechProcess003RevisionByIdFull(int techProcess003Id)
        {
            var result = (from tcp in techProcess003.GetAll()
                          join rt in revisionsTechProcess003.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.ParentId == techProcess003Id
                          select new TechProcess003DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              UserId = tcp.UserId,
                              UserName = usr.Name
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }


        //проверить наличие техпроцесса 003 по его номеру ok
        public bool CheckTechProcess003(long techProcesName)
        {
            return techProcess003.GetAll().Any(chk => chk.TechProcessName == techProcesName);
        }

        //получить все техпроцессы 003 по айди техпроцесса с краткой информацией ok
        public IEnumerable<TechProcess003DTO> GetAllTechProcess003Simple()
        {
            return mapper.Map<IEnumerable<TechProcess003>, List<TechProcess003DTO>>(techProcess003.GetAll());
        }

        //проверяем есть ли техпроцессы третьего типа подвязанные к айди чертежа ок
        public bool CheckTechProcess003Drawing(int drawingId)
        {
            return techProcess003.GetAll().Any(chk => chk.DrawingId == drawingId);
        }

        //получить все техпроцессы 003 и их ревизии с подробной информацией (без материалов и трудоёмкости)
        public IEnumerable<TechProcess003DTO> GetAllTechProcess003()
        {
            var result = (from tcp in techProcess003.GetAll()
                          join rt in revisionsTechProcess003.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join drCopy in drawingCopy.GetAll() on tcp.CopyDrawingId equals drCopy.Id into drCopyy
                          from drCopy in drCopyy.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.TechProcessName != 100030000
                          select new TechProcess003DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = tcp.DrawingId != null ? dr.Number : drCopy.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              CopyDrawingId = drCopy.Id
                          }
                          ).ToList();

            return result;
        }

        //получить номер техпроцесса 003 которого еще не существует в базе (максимальный + 1) ok
        public long GetLastTechProcess003()
        {
            long maxValue = techProcess003.GetAll().Where(srt => srt.TechProcessName < 400000000).Select(bdsm => bdsm.TechProcessName).Max();
            ++maxValue;
            return maxValue;
        }


        #endregion

        #region TechProcess004 method's

        public List<TechProcess004DTO> TechProcess004Revision(TechProcess004DTO techProcess004, List<TechProcess004DTO> alltechProcessRevision)
        {
            var techProcessRevision004 = GetTechProcess004RevisionByIdFull(((TechProcess004DTO)techProcess004).Id);
            if (techProcessRevision004 == null)
            {
                return alltechProcessRevision;
            }
            else
            {
                alltechProcessRevision.Add(techProcessRevision004);
                alltechProcessRevision = TechProcess004Revision(techProcessRevision004, alltechProcessRevision);
                return alltechProcessRevision;
            }
        }

        //получить техпроцесс 003 по айди техпроцесса с краткой информацией и именем ревизии   ok
        public TechProcess004DTO GetTechProcess004SimpleWithRevisionName(int techProcess004Id)
        {
            var result = (from tcp in techProcess004.GetAll()
                          join rd in revisions.GetAll() on tcp.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          where (tcp.Id == techProcess004Id)
                          select new TechProcess004DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              RivisionName = rd.Symbol,
                              OldTechProcess = tcp.OldTechProcess,
                              TypeId = tcp.TypeId,
                              RevisionDocumentName = tcp.RevisionDocumentName
                          }
                          ).FirstOrDefault();

            return result;
        }

        //получить техпроцесс 004 по айди техпроцесса с краткой информацией   ok
        public TechProcess004DTO GetTechProcess004Simple(int techProcess004Id)
        {
            return mapper.Map<TechProcess004, TechProcess004DTO>(techProcess004.GetAll().FirstOrDefault(srt => srt.Id == techProcess004Id));
        }

        // получить  ревизии техпроцесса 004 + актуальный по Id 
        public IEnumerable<TechProcess004DTO> GetAllTechProcess004RevisionWithActualTechprocess(int techProcessId)
        {
            List<TechProcess004DTO> allRevisiontechProcess004 = new List<TechProcess004DTO>();
            var techProcess004Actial = GetTechProcess004SimpleWithRevisionName(techProcessId);
            allRevisiontechProcess004.Add(techProcess004Actial);

            var techProcess004 = GetTechProcess004RevisionByIdFull(techProcessId);
            if (techProcess004 == null)
            {
                return allRevisiontechProcess004;
            }
            else
            {
                allRevisiontechProcess004.Add(techProcess004);
                allRevisiontechProcess004 = TechProcess004Revision(techProcess004, allRevisiontechProcess004);
                return allRevisiontechProcess004;
            }
        }

        //получить актуальный техпроцесс 004 по айди чертежа  с подробной информацией (материалы и трудоёмкость)
        public TechProcess004DTO GetTechProcess004ByDrawingId(int drawingId)
        {
            var result = (from tcp in techProcess004.GetAll()
                          join rt in revisionsTechProcess004.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.DrawingId == drawingId && tcp.ParentId == null
                          select new TechProcess004DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              CopyDrawingId = tcp.CopyDrawingId,
                              DilKapci2K = tcp.DilKapci2K,
                              DilKapci880 = tcp.DilKapci880,
                              DilKapci881 = tcp.DilKapci881,
                              EnamelKapci6030 = tcp.EnamelKapci6030,
                              EnamelKapci641 = tcp.EnamelKapci641,
                              EnamelKapci670 = tcp.EnamelKapci670,
                              GasAr = tcp.GasAr,
                              GasArCO2 = tcp.GasArCO2,
                              GasCO3 = tcp.GasCO3,
                              GasN2 = tcp.GasN2,
                              GasNature = tcp.GasNature,
                              GasO2 = tcp.GasO2,
                              HardKapci126 = tcp.HardKapci126,
                              HardKapci2KMS651 = tcp.HardKapci2KMS651,
                              HardKapci881 = tcp.HardKapci881,
                              HardKapciHs6055 = tcp.HardKapciHs6055,
                              HardKapciPEPutty = tcp.HardKapciPEPutty,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              PrimerKapci125 = tcp.PrimerKapci125,
                              PrimerKapci633 = tcp.PrimerKapci633,
                              PuttyKapci350 = tcp.PuttyKapci350,
                              UniversalSikaflex527 = tcp.UniversalSikaflex527,
                              Welding10 = tcp.Welding10,
                              Welding12 = tcp.Welding12,
                              Welding16 = tcp.Welding16,
                              Welding20 = tcp.Welding20,
                              Welding20Steel = tcp.Welding20Steel,
                              WeldingElektrod = tcp.WeldingElektrod
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }

        //получить ревизию техпроцесса 004 по айди техпроцесса с подробной информацией ok
        public TechProcess004DTO GetTechProcess004RevisionByIdFull(int techProcess004Id)
        {
            var result = (from tcp in techProcess004.GetAll()
                          join rt in revisionsTechProcess004.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.ParentId == techProcess004Id
                          select new TechProcess004DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              UserId = tcp.UserId,
                              UserName = usr.Name
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }

        //получить номер техпроцесса 004 которого еще не существует в базе (максимальный + 1) ok
        public long GetLastTechProcess004()
        {
            long maxValue = techProcess004.GetAll().Where(srt => srt.TechProcessName < 500000000).Select(bdsm => bdsm.TechProcessName).Max();
            ++maxValue;
            return maxValue;
        }

        //проверить наличие техпроцесса 004 по его номеру ok
        public bool CheckTechProcess004(long techProcesName)
        {
            return techProcess004.GetAll().Any(chk => chk.TechProcessName == techProcesName);
        }

        //получить все техпроцессы 004 по айди техпроцесса с краткой информацией ok
        public IEnumerable<TechProcess004DTO> GetAllTechProcess004Simple()
        {
            return mapper.Map<IEnumerable<TechProcess004>, List<TechProcess004DTO>>(techProcess004.GetAll());
        }

        //проверяем есть ли техпроцессы четвертого типа подвязанные к айди чертежа ок
        public bool CheckTechProcess004Drawing(int drawingId)
        {
            return techProcess004.GetAll().Any(chk => chk.DrawingId == drawingId);
        }

        //получить все техпроцессы 004 и их ревизии с подробной информацией (без материалов и трудоёмкости)
        public IEnumerable<TechProcess004DTO> GetAllTechProcess004()
        {
            var result = (from tcp in techProcess004.GetAll()
                          join rt in revisionsTechProcess004.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join drCopy in drawingCopy.GetAll() on tcp.CopyDrawingId equals drCopy.Id into drCopyy
                          from drCopy in drCopyy.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.TechProcessName != 100040000
                          select new TechProcess004DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = tcp.DrawingId != null ? dr.Number : drCopy.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              CopyDrawingId = drCopy.Id
                          }
                          ).ToList();

            return result;
        }

        #endregion

        #region TechProcess005 method's

        //получить актуальный техпроцесс 005 по айди чертежа  с подробной информацией (материалы и трудоёмкость)
        public TechProcess005DTO GetTechProcess005ByDrawingId(int drawingId)
        {
            var result = (from tcp in techProcess005.GetAll()
                          join rt in revisionsTechProcess005.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.DrawingId == drawingId && tcp.ParentId == null
                          select new TechProcess005DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              CopyDrawingId = tcp.CopyDrawingId,
                              DilKapci2K = tcp.DilKapci2K,
                              DilKapci880 = tcp.DilKapci880,
                              DilKapci881 = tcp.DilKapci881,
                              EnamelKapci6030 = tcp.EnamelKapci6030,
                              EnamelKapci641 = tcp.EnamelKapci641,
                              EnamelKapci670 = tcp.EnamelKapci670,
                              GasAr = tcp.GasAr,
                              GasArCO2 = tcp.GasArCO2,
                              GasCO3 = tcp.GasCO3,
                              GasN2 = tcp.GasN2,
                              GasNature = tcp.GasNature,
                              GasO2 = tcp.GasO2,
                              HardKapci126 = tcp.HardKapci126,
                              HardKapci2KMS651 = tcp.HardKapci2KMS651,
                              HardKapci881 = tcp.HardKapci881,
                              HardKapciHs6055 = tcp.HardKapciHs6055,
                              HardKapciPEPutty = tcp.HardKapciPEPutty,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              PrimerKapci125 = tcp.PrimerKapci125,
                              PrimerKapci633 = tcp.PrimerKapci633,
                              PuttyKapci350 = tcp.PuttyKapci350,
                              UniversalSikaflex527 = tcp.UniversalSikaflex527,
                              Welding10 = tcp.Welding10,
                              Welding12 = tcp.Welding12,
                              Welding16 = tcp.Welding16,
                              Welding20 = tcp.Welding20,
                              Welding20Steel = tcp.Welding20Steel,
                              WeldingElektrod = tcp.WeldingElektrod
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }

        //получить номер техпроцесса 005 которого еще не существует в базе (максимальный + 1) ok
        public long GetLastTechProcess005()
        {
            long maxValue = techProcess005.GetAll().Where(srt => srt.TechProcessName < 600000000).Select(bdsm => bdsm.TechProcessName).Max();
            ++maxValue;
            return maxValue;
        }

        //проверить наличие техпроцесса 005 по его номеру ok
        public bool CheckTechProcess005(long techProcesName)
        {
            return techProcess005.GetAll().Any(chk => chk.TechProcessName == techProcesName);
        }

        //получить все техпроцессы 005 по айди техпроцесса с краткой информацией ok
        public IEnumerable<TechProcess005DTO> GetAllTechProcess005Simple()
        {
            return mapper.Map<IEnumerable<TechProcess005>, List<TechProcess005DTO>>(techProcess005.GetAll());
        }

        //проверяем есть ли техпроцессы пятого типа подвязанные к айди чертежа ок
        public bool CheckTechProcess005Drawing(int drawingId)
        {
            return techProcess005.GetAll().Any(chk => chk.DrawingId == drawingId);
        }

        //получить все техпроцессы 005 и их ревизии с подробной информацией (без материалов и трудоёмкости)
        public IEnumerable<TechProcess005DTO> GetAllTechProcess005()
        {
            var result = (from tcp in techProcess005.GetAll()
                          join rt in revisionsTechProcess005.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join drCopy in drawingCopy.GetAll() on tcp.CopyDrawingId equals drCopy.Id into drCopyy
                          from drCopy in drCopyy.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.TechProcessName != 100050000
                          select new TechProcess005DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = tcp.DrawingId != null ? dr.Number : drCopy.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              CopyDrawingId = drCopy.Id
                          }
                          ).ToList();

            return result;
        }

        // получить ревизии техпроцесса 005 по Id родителя ok
        public IEnumerable<TechProcess005DTO> GetAllTechProcess005Revision(int techProcessId)
        {
            List<TechProcess005DTO> allRevisiontechProcess005 = new List<TechProcess005DTO>();

            var techProcess005 = GetTechProcess005RevisionByIdFull(techProcessId);
            if (techProcess005 == null)
            {
                return allRevisiontechProcess005;
            }
            else
            {
                allRevisiontechProcess005.Add(techProcess005);
                allRevisiontechProcess005 = TechProcess005Revision(techProcess005, allRevisiontechProcess005);
                return allRevisiontechProcess005;
            }
        }

        public List<TechProcess005DTO> TechProcess005Revision(TechProcess005DTO techProcess005, List<TechProcess005DTO> alltechProcessRevision)
        {
            var techProcessRevision005 = GetTechProcess005RevisionByIdFull(((TechProcess002DTO)techProcess002).Id);
            if (techProcessRevision005 == null)
            {
                return alltechProcessRevision;
            }
            else
            {
                alltechProcessRevision.Add(techProcessRevision005);
                alltechProcessRevision = TechProcess005Revision(techProcessRevision005, alltechProcessRevision);
                return alltechProcessRevision;
            }
        }

        //получить ревизию техпроцесса 005 по айди техпроцесса с подробной информацией ok
        public TechProcess005DTO GetTechProcess005RevisionByIdFull(int techProcess005Id)
        {
            var result = (from tcp in techProcess005.GetAll()
                          join rt in revisionsTechProcess005.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          join usr in users.GetAll() on tcp.UserId equals usr.Id into usrr
                          from usr in usrr.DefaultIfEmpty()
                          where tcp.ParentId == techProcess005Id
                          select new TechProcess005DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              TH = tcp.TH,
                              W = tcp.W,
                              W2 = tcp.W2,
                              L = tcp.L,
                              Weight = tcp.Weight,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol,
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName,
                              UserId = tcp.UserId,
                              UserName = usr.Name
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }


        #endregion


        public string ResaveFileTechProcess(string techProcesspath, string fullPathExistingFile)
        {
            try
            {
                Factory.GetWorkbook(fullPathExistingFile);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Не найдено файл!\n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            IWorkbook workbook = Factory.GetWorkbook(fullPathExistingFile); ;
            try
            {
                workbook.SaveAs(techProcesspath, FileFormat.XLS97);
            }
            catch (System.IO.IOException)
            {
                //MessageBox.Show("Документ уже открыто!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            catch (System.ComponentModel.Win32Exception)
            {
               // MessageBox.Show("На рабочей станции отсутсутствует пакет программ Microsoft Oficce!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            return techProcesspath;
        }


        




        #region TechProcess001 CRUD method's

        public int TechProcess001Create(TechProcess001DTO techProcess001DTO)
        {
            var createTechProcess001 = techProcess001.Create(mapper.Map<TechProcess001>(techProcess001DTO));
            return (int)createTechProcess001.Id;
        }

        public void TechProcess001Update(TechProcess001DTO techProcess001DTO)
        {
            var techProcess001Update = techProcess001.GetAll().SingleOrDefault(c => c.Id == techProcess001DTO.Id);
            techProcess001.Update((mapper.Map<TechProcess001DTO, TechProcess001>(techProcess001DTO, techProcess001Update)));
        }

        public bool TechProcess001Delete(int id)
        {
            try
            {
                var techProcessDelete = techProcess001.GetAll().FirstOrDefault(c => c.Id == id);
                if (((TechProcess001)techProcessDelete).TechProcessName == 100010000)
                    return true;
                techProcess001.Delete(techProcess001.GetAll().FirstOrDefault(c => c.Id == id));
                if (!FileDelete(techProcessDelete.TechProcessPath))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region TechProcess002 CRUD method's

        public int TechProcess002Create(TechProcess002DTO techProcess002DTO)
        {
            var createTechProcess002 = techProcess002.Create(mapper.Map<TechProcess002>(techProcess002DTO));
            return (int)createTechProcess002.Id;
        }

        public void TechProcess002Update(TechProcess002DTO techProcess002DTO)
        {
            var techProcess002Update = techProcess002.GetAll().SingleOrDefault(c => c.Id == techProcess002DTO.Id);
            techProcess002.Update((mapper.Map<TechProcess002DTO, TechProcess002>(techProcess002DTO, techProcess002Update)));
        }

        public bool TechProcess002Delete(int id)
        {
            try
            {
                var techProcessDelete = techProcess002.GetAll().FirstOrDefault(c => c.Id == id);
                if (((TechProcess002)techProcessDelete).TechProcessName == 100020000)
                    return true;
                techProcess002.Delete(techProcess002.GetAll().FirstOrDefault(c => c.Id == id));
                if (!FileDelete(techProcessDelete.TechProcessPath))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region TechProcess003 CRUD method's

        public int TechProcess003Create(TechProcess003DTO techProcess003DTO)
        {
            var createTechProcess003 = techProcess003.Create(mapper.Map<TechProcess003>(techProcess003DTO));
            return (int)createTechProcess003.Id;
        }

        public void TechProcess003Update(TechProcess003DTO techProcess003DTO)
        {
            var techProcess003Update = techProcess003.GetAll().SingleOrDefault(c => c.Id == techProcess003DTO.Id);
            techProcess003.Update((mapper.Map<TechProcess003DTO, TechProcess003>(techProcess003DTO, techProcess003Update)));
        }

        public bool TechProcess003Delete(int id)
        {
            try
            {
                var techProcessDelete = techProcess003.GetAll().FirstOrDefault(c => c.Id == id);
                if (((TechProcess003)techProcessDelete).TechProcessName == 100030000)
                    return true;
                techProcess003.Delete(techProcess003.GetAll().FirstOrDefault(c => c.Id == id));
                if (!FileDelete(techProcessDelete.TechProcessPath))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region TechProcess004 CRUD method's

        public int TechProcess004Create(TechProcess004DTO techProcess004DTO)
        {
            var createTechProcess004 = techProcess004.Create(mapper.Map<TechProcess004>(techProcess004DTO));
            return (int)createTechProcess004.Id;
        }

        public void TechProcess004Update(TechProcess004DTO techProcess004DTO)
        {
            var techProcess004Update = techProcess004.GetAll().SingleOrDefault(c => c.Id == techProcess004DTO.Id);
            techProcess004.Update((mapper.Map<TechProcess004DTO, TechProcess004>(techProcess004DTO, techProcess004Update)));
        }

        public bool TechProcess004Delete(int id)
        {
            try
            {
                var techProcessDelete = techProcess004.GetAll().FirstOrDefault(c => c.Id == id);
                if (((TechProcess004)techProcessDelete).TechProcessName == 100040000)
                    return true;
                techProcess004.Delete(techProcess004.GetAll().FirstOrDefault(c => c.Id == id));
                if (!FileDelete(techProcessDelete.TechProcessPath))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region TechProcess005 CRUD method's

        public int TechProcess005Create(TechProcess005DTO techProcess005DTO)
        {
            var createTechProcess005 = techProcess005.Create(mapper.Map<TechProcess005>(techProcess005DTO));
            return (int)createTechProcess005.Id;
        }

        public void TechProcess005Update(TechProcess005DTO techProcess005DTO)
        {
            var techProcess005Update = techProcess005.GetAll().SingleOrDefault(c => c.Id == techProcess005DTO.Id);
            techProcess005.Update((mapper.Map<TechProcess005DTO, TechProcess005>(techProcess005DTO, techProcess005Update)));
        }

        public bool TechProcess005Delete(int id)
        {
            try
            {
                var techProcessDelete = techProcess005.GetAll().FirstOrDefault(c => c.Id == id);
                if (((TechProcess005)techProcessDelete).TechProcessName == 100050000)
                    return true;
                techProcess005.Delete(techProcess005.GetAll().FirstOrDefault(c => c.Id == id));
                if (!FileDelete(techProcessDelete.TechProcessPath))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}
