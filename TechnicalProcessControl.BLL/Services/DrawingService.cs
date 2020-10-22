using AutoMapper;
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
    public class DrawingService: IDrawingService
    {
        private IUnitOfWork Database { get; set; }

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

        private IMapper mapper;

        public DrawingService(IUnitOfWork uow)
        {
            Database = uow;

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
                cfg.CreateMap<Materials, MaterialsDTO>();
                cfg.CreateMap<MaterialsDTO, Materials>();
                cfg.CreateMap<Drawing, DrawingDTO>();
                cfg.CreateMap<DrawingDTO, Drawing>();
                cfg.CreateMap<Revisions, RevisionsDTO>();
                cfg.CreateMap<RevisionsDTO, Revisions>();
                cfg.CreateMap<Users, UsersDTO>();
                cfg.CreateMap<UsersDTO, Users>();
            });

            mapper = config.CreateMapper();
        }

        public bool FindDublicateDrawing(DrawingDTO drawingDTO)
        {
            return drawing.GetAll().Any(srt => srt.Number == drawingDTO.Number && srt.Id != drawingDTO.Id && srt.RevisionId == drawingDTO.RevisionId);
        }

        public IEnumerable<DrawingsDTO> GetAllDrawingsByDrawingId(int drawingId)
        {
            var result = (from drw in drawings.GetAll()
                          join dr in drawing.GetAll() on drw.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rev in revisions.GetAll() on dr.RevisionId equals rev.Id into revv
                          from rev in revv.DefaultIfEmpty()
                          join rdr in replacementDrawing.GetAll() on drw.ReplaceDrawingId equals rdr.Id into rdrr
                          from rdr in rdrr.DefaultIfEmpty()
                          join fudr in firstUseDrawing.GetAll() on drw.OccurrenceId equals fudr.Id into fudrr
                          from fudr in fudrr.DefaultIfEmpty()
                          join tp in type.GetAll() on dr.TypeId equals tp.Id into tpp
                          from tp in tpp.DefaultIfEmpty()
                          join det in details.GetAll() on dr.DetailId equals det.Id into dett
                          from det in dett.DefaultIfEmpty()
                          join mat in materials.GetAll() on dr.MaterialId equals mat.Id into matt
                          from mat in matt.DefaultIfEmpty()
                          join tcp001 in techProcess001.GetAll() on dr.Id equals tcp001.DrawingId into tcpp001
                          from tcp001 in tcpp001.DefaultIfEmpty()
                          join tcp002 in techProcess002.GetAll() on dr.Id equals tcp002.DrawingId into tcpp002
                          from tcp002 in tcpp002.DefaultIfEmpty()
                          join tcp003 in techProcess003.GetAll() on dr.Id equals tcp003.DrawingId into tcpp003
                          from tcp003 in tcpp003.DefaultIfEmpty()
                          join tcp004 in techProcess004.GetAll() on dr.Id equals tcp004.DrawingId into tcpp004
                          from tcp004 in tcpp004.DefaultIfEmpty()
                          join tcp005 in techProcess005.GetAll() on dr.Id equals tcp005.DrawingId into tcpp005
                          from tcp005 in tcpp005.DefaultIfEmpty()
                          join drws in drawingScan.GetAll() on dr.Id equals drws.DrawingId into drwss
                          from drws in drwss.DefaultIfEmpty()
                          join pdrw in parentDrawings.GetAll() on drw.ParentId equals pdrw.Id into pdrww
                          from pdrw in pdrww.DefaultIfEmpty()
                          join drp in drawing.GetAll() on pdrw.DrawingId equals drp.Id into drpp
                          from drp in drpp.DefaultIfEmpty()
                          where dr.Id == drawingId

                          select new DrawingsDTO
                          {
                              Id = drw.Id,
                              ParentId = drw.ParentId,
                              TypeName = tp.TypeName,
                              CurrentLevelMenu = drw.CurrentLevelMenu,
                              DetailName = det.DetailName,
                              Quantity = drw.Quantity,
                              QuantityL = drw.QuantityL,
                              QuantityR = drw.QuantityL,
                              Number = dr.Number,
                              NumberWithRevisionName = dr.RevisionId == null ? dr.Number : dr.Number + "_" + rev.Symbol,
                              TH = dr.TH,
                              L = dr.L,
                              W = dr.W,
                              W2 = dr.W2,
                              DetailWeight = dr.DetailWeight,
                              MaterialName = mat.MaterialName,
                              DrawingId = dr.Id,
                              OccurrenceId = drw.OccurrenceId,
                              ReplaceDrawingId = drw.ReplaceDrawingId,
                              TechProcess001Id = tcp001.Id,
                              TechProcess002Id = tcp002.Id,
                              TechProcess003Id = tcp003.Id,
                              TechProcess004Id = tcp004.Id,
                              TechProcess005Id = tcp005.Id,
                              TechProcess001Name = tcp001.TechProcessName,
                              TechProcess002Name = tcp002.TechProcessName,
                              TechProcess003Name = tcp003.TechProcessName,
                              TechProcess004Name = tcp004.TechProcessName,
                              TechProcess005Name = tcp005.TechProcessName,
                              TechProcess001Path = tcp001.TechProcessPath,
                              TechProcess002Path = tcp002.TechProcessPath,
                              TechProcess003Path = tcp003.TechProcessPath,
                              TechProcess004Path = tcp004.TechProcessPath,
                              TechProcess005Path = tcp005.TechProcessPath,
                              ScanId = drws.DrawingId > 0 ? 1 : 0,
                              ParentName = drp.Number != "" ? drp.Number : dr.Number

                          }
                            ).ToList();

            return result.GroupBy(x => x.Id).Select(y => y.First()).ToList();
        }

        public IEnumerable<DrawingsDTO> GetAllDrawings()
        {
            var result = (from drw in drawings.GetAll()
                          join dr in drawing.GetAll() on drw.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rev in revisions.GetAll() on dr.RevisionId equals rev.Id into revv
                          from rev in revv.DefaultIfEmpty()
                          join rdr in replacementDrawing.GetAll() on drw.ReplaceDrawingId equals rdr.Id into rdrr
                          from rdr in rdrr.DefaultIfEmpty()
                          join fudr in firstUseDrawing.GetAll() on drw.OccurrenceId equals fudr.Id into fudrr
                          from fudr in fudrr.DefaultIfEmpty()
                          join tp in type.GetAll() on dr.TypeId equals tp.Id into tpp
                          from tp in tpp.DefaultIfEmpty()
                          join det in details.GetAll() on dr.DetailId equals det.Id into dett
                          from det in dett.DefaultIfEmpty()
                          join mat in materials.GetAll() on dr.MaterialId equals mat.Id into matt
                          from mat in matt.DefaultIfEmpty()
                          join tcp001 in techProcess001.GetAll() on dr.Id equals tcp001.DrawingId into tcpp001
                          from tcp001 in tcpp001.DefaultIfEmpty()
                          join rev001 in revisionsTechProcess001.GetAll() on tcp001.RevisionId equals rev001.Id into revv001
                          from rev001 in revv001.DefaultIfEmpty()
                          join tcp002 in techProcess002.GetAll() on dr.Id equals tcp002.DrawingId into tcpp002
                          from tcp002 in tcpp002.DefaultIfEmpty()
                          join rev002 in revisionsTechProcess002.GetAll() on tcp002.RevisionId equals rev002.Id into revv002
                          from rev002 in revv002.DefaultIfEmpty()
                          join tcp003 in techProcess003.GetAll() on dr.Id equals tcp003.DrawingId into tcpp003
                          from tcp003 in tcpp003.DefaultIfEmpty()
                          join rev003 in revisionsTechProcess003.GetAll() on tcp003.RevisionId equals rev003.Id into revv003
                          from rev003 in revv003.DefaultIfEmpty()
                          join tcp004 in techProcess004.GetAll() on dr.Id equals tcp004.DrawingId into tcpp004
                          from tcp004 in tcpp004.DefaultIfEmpty()
                          join rev004 in revisionsTechProcess004.GetAll() on tcp004.RevisionId equals rev004.Id into revv004
                          from rev004 in revv004.DefaultIfEmpty()
                          join tcp005 in techProcess005.GetAll() on dr.Id equals tcp005.DrawingId into tcpp005
                          from tcp005 in tcpp005.DefaultIfEmpty()
                          join rev005 in revisionsTechProcess005.GetAll() on tcp005.RevisionId equals rev005.Id into revv005
                          from rev005 in revv005.DefaultIfEmpty()
                          join drws in drawingScan.GetAll() on dr.Id equals drws.DrawingId into drwss
                          from drws in drwss.DefaultIfEmpty()
                          join pdrw in parentDrawings.GetAll() on drw.ParentId equals pdrw.Id into pdrww
                          from pdrw in pdrww.DefaultIfEmpty()
                          join drp in drawing.GetAll() on pdrw.DrawingId equals drp.Id into drpp
                          from drp in drpp.DefaultIfEmpty()
                          where tcp001.ParentId == null && tcp002.ParentId == null && tcp003.ParentId == null && tcp004.ParentId == null && tcp005.ParentId == null
                          //orderby drw.CurrentLevelMenu

                          select new DrawingsDTO
                          {
                              Id = drw.Id,
                              ParentId = drw.ParentId,
                              Quantity = drw.Quantity,
                              QuantityL = drw.QuantityL,
                              QuantityR = drw.QuantityL,
                              CurrentLevelMenu = drw.CurrentLevelMenu,
                              StructuraDisable = drw.StructuraDisable,
                              OccurrenceId = drw.OccurrenceId,
                              ReplaceDrawingId = drw.ReplaceDrawingId,


                              DrawingId = dr.Id,
                              Number = dr.Number,
                              TypeName = tp.TypeName,
                              DetailName = det.DetailName,
                              NumberWithRevisionName = dr.RevisionId == null ? dr.Number : dr.Number + "_" + rev.Symbol,
                              RevisionName = rev.Symbol,
                              TH = dr.TH,
                              L = dr.L,
                              W = dr.W,
                              W2 = dr.W2,
                              DetailWeight = dr.DetailWeight,
                              MaterialName = mat.MaterialName,
                              CreateDate = dr.CreateDate,
                              NoteName = dr.Note,



                              TechProcess001Id = tcp001.Id,
                              TechProcess002Id = tcp002.Id,
                              TechProcess003Id = tcp003.Id,
                              TechProcess004Id = tcp004.Id,
                              TechProcess005Id = tcp005.Id,
                              TechProcess001Name = tcp001.Id != 1 ? tcp001.TechProcessName : (long?)null,
                              TechProcess002Name = tcp002.Id != 1 ? tcp002.TechProcessName : (long?)null,
                              TechProcess003Name = tcp003.Id != 1 ? tcp003.TechProcessName : (long?)null,
                              TechProcess004Name = tcp004.Id != 1 ? tcp004.TechProcessName : (long?)null,
                              TechProcess005Name = tcp005.Id != 1 ? tcp005.TechProcessName : (long?)null,
                              TechProcess001Path = tcp001.TechProcessPath,
                              TechProcess002Path = tcp002.TechProcessPath,
                              TechProcess003Path = tcp003.TechProcessPath,
                              TechProcess004Path = tcp004.TechProcessPath,
                              TechProcess005Path = tcp005.TechProcessPath,
                              TechProcess001Old = tcp001.OldTechProcess,
                              //TechProcess001Old = tcp002.OldTechProcess,
                              Revision001 = rev001.Symbol,
                              Revision002 = rev002.Symbol,
                              Revision003 = rev003.Symbol,
                              Revision004 = rev004.Symbol,
                              Revision005 = rev005.Symbol,
                              ScanId = drws.DrawingId > 0 ? 1 : 0,
                              ParentName = drp.Number != "" ? drp.Number : dr.Number,
                              TechProcess001Type = tcp001.TypeId,
                              TechProcess002Type = tcp002.TypeId,
                              TechProcess003Type = tcp003.TypeId,
                              TechProcess004Type = tcp004.TypeId,
                              TechProcess005Type = tcp005.TypeId

                              //TotalWeight = drw.Quantity > 0 ? drw.Quantity * dr.DetailWeight : 0

                          }
                            ).ToList();

       

            //result.GroupBy(x => x.Id).Select(y => y.First());


            return result.GroupBy(x => x.Id).Select(y => y.First()).ToList();
        }

        public DrawingsDTO GetDrawingsByStructuraId(int structuraId)
        {
            var result = (from drw in drawings.GetAll()
                          join dr in drawing.GetAll() on drw.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rdr in replacementDrawing.GetAll() on drw.ReplaceDrawingId equals rdr.Id into rdrr
                          from rdr in rdrr.DefaultIfEmpty()
                          join fudr in firstUseDrawing.GetAll() on drw.OccurrenceId equals fudr.Id into fudrr
                          from fudr in fudrr.DefaultIfEmpty()
                          join tp in type.GetAll() on dr.TypeId equals tp.Id into tpp
                          from tp in tpp.DefaultIfEmpty()
                          join det in details.GetAll() on dr.DetailId equals det.Id into dett
                          from det in dett.DefaultIfEmpty()
                          join mat in materials.GetAll() on dr.MaterialId equals mat.Id into matt
                          from mat in matt.DefaultIfEmpty()
                          join tcp001 in techProcess001.GetAll() on drw.Id equals tcp001.DrawingId into tcpp001
                          from tcp001 in tcpp001.DefaultIfEmpty()
                          join tcp002 in techProcess002.GetAll() on drw.Id equals tcp002.DrawingId into tcpp002
                          from tcp002 in tcpp002.DefaultIfEmpty()
                          join tcp003 in techProcess003.GetAll() on drw.Id equals tcp003.DrawingId into tcpp003
                          from tcp003 in tcpp003.DefaultIfEmpty()
                          join tcp004 in techProcess004.GetAll() on drw.Id equals tcp004.DrawingId into tcpp004
                          from tcp004 in tcpp004.DefaultIfEmpty()
                          join tcp005 in techProcess005.GetAll() on drw.Id equals tcp005.DrawingId into tcpp005
                          from tcp005 in tcpp005.DefaultIfEmpty()
                          join drws in drawingScan.GetAll() on dr.Id equals drws.DrawingId into drwss
                          from drws in drwss.DefaultIfEmpty()
                          join pdrw in parentDrawings.GetAll() on drw.ParentId equals pdrw.Id into pdrww
                          from pdrw in pdrww.DefaultIfEmpty()
                          join drp in drawing.GetAll() on pdrw.DrawingId equals drp.Id into drpp
                          from drp in drpp.DefaultIfEmpty()
                          where drw.Id == structuraId
                          select new DrawingsDTO
                          {
                              Id = drw.Id,
                              ParentId = drw.ParentId,
                              TypeName = tp.TypeName,
                              CurrentLevelMenu = drw.CurrentLevelMenu,
                              DetailName = det.DetailName,
                              Quantity = drw.Quantity,
                              QuantityL = drw.QuantityL,
                              QuantityR = drw.QuantityL,
                              Number = dr.Number,
                              TH = dr.TH,
                              L = dr.L,
                              W = dr.W,
                              W2 = dr.W2,
                              DetailWeight = dr.DetailWeight,
                              MaterialName = mat.MaterialName,
                              DrawingId = dr.Id,
                              OccurrenceId = drw.OccurrenceId,
                              ReplaceDrawingId = drw.ReplaceDrawingId,
                               CreateDate = dr.CreateDate,
                                NoteName = dr.Note,
                              //GasConsumption = drw.GasConsumption,
                              //PaintConsumption = drw.PaintConsumption,
                              //WireConsumption = drw.WireConsumption,
                              //LaborIntensity001Total = drw.LaborIntensity001Total,
                              //LaborIntensity002Total = drw.LaborIntensity002Total,
                              //LaborIntensity003Total = drw.LaborIntensity003Total,
                              //LaborIntensity004Total = drw.LaborIntensity004Total,
                              //LaborIntensity005Total = drw.LaborIntensity005Total,
                              //LaborIntensityTotal = drw.LaborIntensityTotal,
                              TechProcess001Id = tcp001.Id,
                              TechProcess002Id = tcp002.Id,
                              TechProcess003Id = tcp003.Id,
                              TechProcess004Id = tcp004.Id,
                              TechProcess005Id = tcp005.Id,
                              TechProcess001Name = tcp001.TechProcessName,
                              TechProcess002Name = tcp002.TechProcessName,
                              TechProcess003Name = tcp003.TechProcessName,
                              TechProcess004Name = tcp004.TechProcessName,
                              TechProcess005Name = tcp005.TechProcessName,
                              TechProcess001Path = tcp001.TechProcessPath,
                              TechProcess002Path = tcp002.TechProcessPath,
                              TechProcess003Path = tcp003.TechProcessPath,
                              TechProcess004Path = tcp004.TechProcessPath,
                              TechProcess005Path = tcp005.TechProcessPath,
                              ScanId = drws.DrawingId > 0 ? 1 : 0,
                              
                              ParentName = drp.Number != "" ? drp.Number : dr.Number

                          }
                            );

            return (DrawingsDTO)result;
        }

        public IEnumerable<DrawingDTO> GetAllDrawing()
        {
            var result = (from drw in drawing.GetAll()
                          join tp in type.GetAll() on drw.TypeId equals tp.Id into tpp
                          from tp in tpp.DefaultIfEmpty()
                          join det in details.GetAll() on drw.DetailId equals det.Id into dett
                          from det in dett.DefaultIfEmpty()
                          join mat in materials.GetAll() on drw.MaterialId equals mat.Id into matt
                          from mat in matt.DefaultIfEmpty()
                          join rev in revisions.GetAll() on drw.RevisionId equals rev.Id into revv
                          from rev in revv.DefaultIfEmpty()
                          join drws in drawingScan.GetAll() on drw.Id equals drws.DrawingId into drwss
                          from drws in drwss.DefaultIfEmpty()

                          select new DrawingDTO
                          {
                              Id = drw.Id,
                              Number = drw.Number,
                              Assembly = drw.Assembly,
                              //AssemblyName = drw.Assembly == false ? "Не сборка" : "Сборка",
                              TypeId = tp.Id,
                              TypeName = tp.TypeName,
                              DetailId = det.Id,
                              DetailName = det.DetailName,
                              MaterialId = mat.Id,
                              MaterialName = mat.MaterialName,
                              
                              TH = drw.TH,
                              L = drw.L,
                              W = drw.W,
                              W2 = drw.W2,
                              DetailWeight = drw.DetailWeight,
                              RevisionId = drw.RevisionId,
                              RevisionName = rev.Symbol,
                              CreateDate = drw.CreateDate,
                              ParentId = drw.ParentId,
                              Note = drw.Note,
                              FullName = rev.Symbol == null ? drw.Number : (drw.Number + "_" + rev.Symbol),
                              ScanId = drws.DrawingId > 0 ? 1 : 0
                          }
                          ).ToList();

            return result.GroupBy(x => x.Id).Select(y => y.First()).ToList();
        }

        public IEnumerable<DrawingDTO> GetAllDrawingActual()
        {
            var result = (from drw in drawing.GetAll()
                          join tp in type.GetAll() on drw.TypeId equals tp.Id into tpp
                          from tp in tpp.DefaultIfEmpty()
                          join det in details.GetAll() on drw.DetailId equals det.Id into dett
                          from det in dett.DefaultIfEmpty()
                          join mat in materials.GetAll() on drw.MaterialId equals mat.Id into matt
                          from mat in matt.DefaultIfEmpty()
                          join rev in revisions.GetAll() on drw.RevisionId equals rev.Id into revv
                          from rev in revv.DefaultIfEmpty()
                          join drws in drawingScan.GetAll() on drw.Id equals drws.DrawingId into drwss
                          from drws in drwss.DefaultIfEmpty()
                          where drw.ParentId == null

                          select new DrawingDTO
                          {
                              Id = drw.Id,
                              Number = drw.Number,
                              Assembly = drw.Assembly,
                              //AssemblyName = drw.Assembly == false ? "Не сборка" : "Сборка",
                              TypeId = tp.Id,
                              TypeName = tp.TypeName,
                              DetailId = det.Id,
                              DetailName = det.DetailName,
                              MaterialId = mat.Id,
                              MaterialName = mat.MaterialName,
                              
                              TH = drw.TH,
                              L = drw.L,
                              W = drw.W,
                              W2 = drw.W2,
                              DetailWeight = drw.DetailWeight,
                              RevisionId = drw.RevisionId,
                              RevisionName = rev.Symbol,
                              CreateDate = drw.CreateDate,
                              ParentId = drw.ParentId,
                              Note = drw.Note,
                              FullName = rev.Symbol == null ? drw.Number : (drw.Number + "_" + rev.Symbol),
                              ScanId = drws.DrawingId > 0 ? 1 : 0
                          }
                          ).ToList();

            return result.GroupBy(x => x.Id).Select(y => y.First()).ToList();
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

        //по id чертежа получить все чертежи-сборки куда он входит
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
                          where drch.Id == drawingId && dr.Id!= null

                          select new DrawingDTO
                          {
                              Id = dr.Id == null ? -1:dr.Id,
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


        public IEnumerable<DrawingsDTO> GetShortDrawing()
        {
            return mapper.Map<IEnumerable<Drawings>, List<DrawingsDTO>>(drawings.GetAll());
        }

        public IEnumerable<TypeDTO> GetType()
        {
            return mapper.Map<IEnumerable<DAL.Models.Type>, List<TypeDTO>>(type.GetAll());
        }

        public IEnumerable<RevisionsDTO> GetRevisions()
        {
            return mapper.Map<IEnumerable<Revisions>, List<RevisionsDTO>>(revisions.GetAll());
        }

        public bool CheckDrivingChild(int drivingId)
        {
            var allStructure = mapper.Map<IEnumerable<Drawings>, List<DrawingsDTO>>(drawings.GetAll());
            var structureDrawingId = allStructure.First(bdsm => bdsm.DrawingId == drivingId).Id;
            return allStructure.Any(bdsm => bdsm.ParentId == structureDrawingId);
        }

        //получить чертеж по id с подробной информацией
        public DrawingDTO GetDrawingById(int drawingId)
        {

            var result = (from drw in drawing.GetAll()
                          join tp in type.GetAll() on drw.TypeId equals tp.Id into tpp
                          from tp in tpp.DefaultIfEmpty()
                          join det in details.GetAll() on drw.DetailId equals det.Id into dett
                          from det in dett.DefaultIfEmpty()
                          join mat in materials.GetAll() on drw.MaterialId equals mat.Id into matt
                          from mat in matt.DefaultIfEmpty()
                          join rev in revisions.GetAll() on drw.RevisionId equals rev.Id into revv
                          from rev in revv.DefaultIfEmpty()
                          where drw.Id == drawingId

                          select new DrawingDTO
                          {
                              Id = drw.Id,
                              Number = drw.Number,
                              TypeId = tp.Id,
                              TypeName = tp.TypeName,
                              DetailId = det.Id,
                              DetailName = det.DetailName,
                              MaterialId = mat.Id,
                              MaterialName = mat.MaterialName,
                              
                              TH = drw.TH,
                              L = drw.L,
                              W = drw.W,
                              W2 = drw.W2,
                              DetailWeight = drw.DetailWeight,
                              RevisionId = drw.RevisionId,
                              RevisionName = rev.Symbol,
                              CreateDate = drw.CreateDate,
                              ParentId = drw.ParentId,
                              Note = drw.Note,
                              FullName = rev.Symbol == null ? drw.Number : (drw.Number + "_" + rev.Symbol),
                              ScanId = 0,
                              Assembly = drw.Assembly
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }

        public DrawingDTO GetDrawingChildByParentId(int drawingId)
        {
            return mapper.Map<Drawing, DrawingDTO>(drawing.GetAll().FirstOrDefault(srt => srt.ParentId == drawingId));
        }


        public string GetMaxStructuraNumber(int fatherStructura)
        {
            var childStructuraList = drawings.GetAll().Where(bdsm => bdsm.ParentId == fatherStructura).ToList();
            if (childStructuraList == null || childStructuraList.Count() == 0)
            {
                return drawings.GetAll().FirstOrDefault(srt => srt.Id == fatherStructura).CurrentLevelMenu + ".1";
            }
            string maxChildStructura = childStructuraList.OrderBy(bdsm => Convert.ToInt32(bdsm.CurrentLevelMenu.Split('.').Last())).Last().CurrentLevelMenu;
            string[] maxChildStructuraSplit = maxChildStructura.Split('.');

            try
            {
                int partOfMaxChildStructuraSplit = Int32.Parse(maxChildStructuraSplit.Last());
                ++partOfMaxChildStructuraSplit;
                maxChildStructuraSplit[maxChildStructuraSplit.Length - 1] = partOfMaxChildStructuraSplit.ToString();
                return string.Join(".", maxChildStructuraSplit);
            }
            catch (FormatException e)
            {
                return "";
            }

            ////var childStructuraList = drawings.GetAll().Where(bdsm => bdsm.ParentId == fatherStructura.Id);
            ////if(childStructuraList==null || childStructuraList.Count() == 0)
            ////{
            ////    return fatherStructura.CurrentLevelMenu + ".1";
            ////}
            ////string maxChildStructura = childStructuraList.OrderByDescending(x => x.CurrentLevelMenu).First().CurrentLevelMenu;
            ////string[] maxChildStructuraSplit = maxChildStructura.Split('.');

            ////try
            ////{
            ////    int partOfMaxChildStructuraSplit = Int32.Parse(maxChildStructuraSplit.Last());
            ////    ++partOfMaxChildStructuraSplit;
            ////    maxChildStructuraSplit[maxChildStructuraSplit.Length - 1] = partOfMaxChildStructuraSplit.ToString();
            ////    return string.Join(".", maxChildStructuraSplit);
            ////}
            ////catch (FormatException e)
            ////{
            ////    return "";
            ////}
        }



        /*public DrawingScanDTO GetDrawingScanById(int DrawingId)
        {
            return mapper.Map<DrawingScan, DrawingScanDTO>(drawingScan.GetAll().FirstOrDefault(s => s.DrawingId == DrawingId && s.Status == null));
        }*/

        

        public bool CheckTechProcess002(string techProcesName)
        {
            return techProcess002.GetAll().Any(chk => chk.TechProcessFullName == techProcesName);
        }

        public bool CheckTechProcess003(string techProcesName)
        {
            return techProcess003.GetAll().Any(chk => chk.TechProcessFullName == techProcesName);
        }

        

        public long GetLastTechProcess002()
        {
            long maxValue = techProcess002.GetAll().Select(bdsm => bdsm.TechProcessName).Max();
            ++maxValue;
            return maxValue;
        }

        public long GetLastTechProcess003()
        {
            long maxValue = techProcess003.GetAll().Select(bdsm => bdsm.TechProcessName).Max();
            ++maxValue;
            return maxValue;
        }

        public IEnumerable<DrawingScanDTO> GetDravingScanById(int? drawingId)
        {
            return mapper.Map<IEnumerable<DrawingScan>, List<DrawingScanDTO>>(drawingScan.GetAll().Where(bdsm => bdsm.DrawingId == drawingId));
        }

        
        public TechProcess002DTO GetTechProcess002ByDrawingId(int drawingId)
        {
            return mapper.Map<TechProcess002, TechProcess002DTO>(techProcess002.GetAll().FirstOrDefault(bdsm => bdsm.DrawingId == drawingId && bdsm.ParentId == null));
        }
        public TechProcess003DTO GetTechProcess003ByDrawingId(int drawingId)
        {
            var techProcess = mapper.Map<TechProcess003, TechProcess003DTO>(techProcess003.GetAll().FirstOrDefault(bdsm => bdsm.DrawingId == drawingId && bdsm.ParentId == null));
            if (techProcess != null)
            {
                if (techProcess.RevisionId != null)
                {
                    techProcess.RivisionName = mapper.Map<Revisions, RevisionsDTO>(revisions.GetAll().FirstOrDefault(bdsm => bdsm.Id == techProcess.RevisionId)).Symbol;
                    if (techProcess.RivisionName != null)
                        techProcess.TechProcessFullName = techProcess.TechProcessName.ToString() + "_" + techProcess.RivisionName;
                    else
                        techProcess.TechProcessFullName = techProcess.TechProcessName.ToString();
                }
            }
            return techProcess;

            //return mapper.Map<TechProcess003, TechProcess003DTO>(techProcess003.GetAll().FirstOrDefault(bdsm => bdsm.DrawingId == drawingId && bdsm.ParentId == null));
        }
        public TechProcess004DTO GetTechProcess004ByDrawingId(int drawingId)
        {
            return mapper.Map<TechProcess004, TechProcess004DTO>(techProcess004.GetAll().FirstOrDefault(bdsm => bdsm.DrawingId == drawingId && bdsm.ParentId == null));
        }
        public TechProcess005DTO GetTechProcess005ByDrawingId(int drawingId)
        {
            return mapper.Map<TechProcess005, TechProcess005DTO>(techProcess005.GetAll().FirstOrDefault(bdsm => bdsm.DrawingId == drawingId && bdsm.ParentId == null));
        }

        //получить техпроцесс 001 по айди техпроцесса с подробной информацией
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
        //получить техпроцесс 001 по айди техпроцесса с краткой информацией
        public TechProcess001DTO GetTechProcess001Simple(int techProcess001Id)
        {
            return mapper.Map<TechProcess001, TechProcess001DTO>(techProcess001.GetAll().FirstOrDefault(srt => srt.Id == techProcess001Id));
        }
        //получить ревизию техпроцесс 001 по айди техпроцесса с подробной информацией
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
        //получить ревизию техпроцесса 001 по айди техпроцесса с краткой информацией
        public TechProcess001DTO GetTechProcess001RevisionByIdSimple(int techProcess001Id)
        {
            return mapper.Map<TechProcess001, TechProcess001DTO>(techProcess001.GetAll().FirstOrDefault(srt => srt.ParentId == techProcess001Id));
        }
        //получить техпроцесс 001 по айди техпроцесса с краткой информацией
        public IEnumerable<TechProcess001DTO> GetAllTechProcess001Simple()
        {
            return mapper.Map<IEnumerable<TechProcess001>, List<TechProcess001DTO>>(techProcess001.GetAll());
        }
        //получить техпроцесс 001 по айди чертежа  с подробной информацией
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
                              //OldTechProcess = tcp.OldTechProcess,
                              UserId = usr.Id,
                              UserName = usr.Name,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName
                          }
                          ).ToList();

            return result.FirstOrDefault();
        }
        //получить все техпроцессы 001 и их ревизии 
        public IEnumerable<TechProcess001DTO> GetAllTechProcess001()
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
                              TypeId = tcp.TypeId,
                              OldTechProcess = tcp.OldTechProcess,
                              RevisionDocumentName = tcp.RevisionDocumentName
                          }
                          ).ToList();

            return result;
        }
        //получить только актуальные техпроцессы 001 без ревизий
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
        //проверить наличие техпроцесса 001 по его номеру
        public bool CheckTechProcess001(long techProcesName)
        {
            return techProcess001.GetAll().Any(chk => chk.TechProcessName == techProcesName);
        }
        //получить номер техпроцесса 001 которого еще не существует в базе
        public long GetLastTechProcess001()
        {
            long maxValue = techProcess001.GetAll().Where(srt => srt.TechProcessName < 200000000).Select(bdsm => bdsm.TechProcessName).Max();
            ++maxValue;
            return maxValue;
        }
        // получить ревизии техпроцесса 001 по Id родителя
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


        public IEnumerable<TechProcess002DTO> GetAllTechProcess002()
        {
            var result = (from tcp in techProcess002.GetAll()
                          join rt in revisionsTechProcess002.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          select new TechProcess002DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol
                          }
                          ).ToList();

            return result;
        }
        public IEnumerable<TechProcess002DTO> GetAllTechProcessActual002()
        {
            var result = (from tcp in techProcess002.GetAll()
                          join rt in revisionsTechProcess002.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          where tcp.ParentId == null
                          select new TechProcess002DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol
                          }
                          ).ToList();

            return result;
        }


        public IEnumerable<TechProcess003DTO> GetAllTechProcess003()
        {
            var result = (from tcp in techProcess003.GetAll()
                          join rt in revisionsTechProcess003.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          select new TechProcess003DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol
                          }
                          ).ToList();

            return result;
        }
        public IEnumerable<TechProcess003DTO> GetAllTechProcessActual003()
        {
            var result = (from tcp in techProcess003.GetAll()
                          join rt in revisionsTechProcess003.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          where tcp.ParentId == null
                          select new TechProcess003DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol
                          }
                          ).ToList();

            return result;
        }


        public IEnumerable<TechProcess004DTO> GetAllTechProcess004()
        {
            var result = (from tcp in techProcess004.GetAll()
                          join rt in revisionsTechProcess004.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          select new TechProcess004DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol
                          }
                          ).ToList();

            return result;
        }
        public IEnumerable<TechProcess004DTO> GetAllTechProcessActual004()
        {
            var result = (from tcp in techProcess004.GetAll()
                          join rt in revisionsTechProcess004.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          where tcp.ParentId == null
                          select new TechProcess004DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol
                          }
                          ).ToList();

            return result;
        }


        public IEnumerable<TechProcess005DTO> GetAllTechProcess005()
        {
            var result = (from tcp in techProcess005.GetAll()
                          join rt in revisionsTechProcess005.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          select new TechProcess005DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol
                          }
                          ).ToList();

            return result;
        }
        public IEnumerable<TechProcess005DTO> GetAllTechProcessActual005()
        {
            var result = (from tcp in techProcess005.GetAll()
                          join rt in revisionsTechProcess005.GetAll() on tcp.RevisionId equals rt.Id into rtt
                          from rt in rtt.DefaultIfEmpty()
                          join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
                          join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
                          from rd in rdd.DefaultIfEmpty()
                          where tcp.ParentId == null
                          select new TechProcess005DTO
                          {
                              Id = tcp.Id,
                              CreateDate = tcp.CreateDate,
                              ParentId = tcp.ParentId,
                              RevisionId = tcp.RevisionId,
                              LaborIntensity001 = tcp.LaborIntensity001,
                              LaborIntensity002 = tcp.LaborIntensity002,
                              LaborIntensity003 = tcp.LaborIntensity003,
                              LaborIntensity004 = tcp.LaborIntensity004,
                              LaborIntensity005 = tcp.LaborIntensity005,
                              TechProcessName = tcp.TechProcessName,
                              DrawingId = tcp.DrawingId,
                              DrawingNumber = dr.Number,
                              TechProcessFullName = tcp.TechProcessFullName,
                              TechProcessPath = tcp.TechProcessPath,
                              DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
                              RivisionName = rt.Symbol
                          }
                          ).ToList();

            return result;
        }

        // проверяет прикреплен ли к чертежу хоть один техпроцесс
        public bool CheckDrawingContainAnyTechProcess(int drawingId)
        {
            if (GetAllTechProcess001().Any(bdsm => bdsm.DrawingId == drawingId))
                return true;

            if (GetAllTechProcess002().Any(bdsm => bdsm.DrawingId == drawingId))
                return true;

            if (GetAllTechProcess003().Any(bdsm => bdsm.DrawingId == drawingId))
                return true;

            if (GetAllTechProcess004().Any(bdsm => bdsm.DrawingId == drawingId))
                return true;

            if (GetAllTechProcess005().Any(bdsm => bdsm.DrawingId == drawingId))
                return true;

            return false;
        }

        public string GetParentName(int parentId)
        {
            var parentDravingId = drawings.GetAll().First(bdsm => bdsm.Id == parentId).DrawingId;

            return drawing.GetAll().First(bdsm => bdsm.Id == parentDravingId).Number;
        }

        public bool CheckStructuraName(DrawingsDTO drawingsDTO)
        {
            return drawings.GetAll().Any(srt => srt.CurrentLevelMenu == drawingsDTO.CurrentLevelMenu && srt.Id != drawingsDTO.Id);
        }

        public IEnumerable<DrawingsDTO> ReplaceDrawingIdInStructura(int replaceDrawingId, int currentDrawingId)
        {
            var structura = mapper.Map < IEnumerable<Drawings>, List< DrawingsDTO >> (drawings.GetAll().Where(bdsm => bdsm.DrawingId == replaceDrawingId && bdsm.StructuraDisable == false)).ToList();

            foreach (var item in structura)
            {
                try
                {
                    item.DrawingId = currentDrawingId;
                    DrawingsUpdate(item);
                }
                catch (Exception)
                {
                    return null;
                }
            }

            return structura;
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
                techProcess001.Delete(techProcess001.GetAll().FirstOrDefault(c => c.Id == id));
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
                techProcess002.Delete(techProcess002.GetAll().FirstOrDefault(c => c.Id == id));
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
                techProcess003.Delete(techProcess003.GetAll().FirstOrDefault(c => c.Id == id));
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
                techProcess004.Delete(techProcess004.GetAll().FirstOrDefault(c => c.Id == id));
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
                techProcess005.Delete(techProcess005.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region DrawingScan CRUD method's

        public int DrawingScanCreate(DrawingScanDTO drawingScanDTO)
        {
            var createDrawingScan = drawingScan.Create(mapper.Map<DrawingScan>(drawingScanDTO));
            return (int)createDrawingScan.Id;
        }

        

        public void DrawingScanUpdate(DrawingScanDTO drawingScanDTO)
        {
            var updateDrawingScan = drawingScan.GetAll().SingleOrDefault(c => c.Id == drawingScanDTO.Id);
            drawingScan.Update((mapper.Map<DrawingScanDTO, DrawingScan>(drawingScanDTO, updateDrawingScan)));
        }

        public bool DrawingScanDelete(int id)
        {
            try
            {
                drawingScan.Delete(drawingScan.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Drawing's CRUD method's

        public int DrawingsCreate(DrawingsDTO drawingsDTO)
        {
            var createDrawings = drawings.Create(mapper.Map<Drawings>(drawingsDTO));
            return (int)createDrawings.Id;
        }

        public void DrawingsUpdate(DrawingsDTO drawingsDTO)
        {
            var updateDrawings = drawings.GetAll().SingleOrDefault(c => c.Id == drawingsDTO.Id);
            drawings.Update((mapper.Map<DrawingsDTO, Drawings>(drawingsDTO, updateDrawings)));
        }

        public bool DrawingsDelete(int id)
        {
            try
            {
                drawings.Delete(drawings.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Type's CRUD method's

        public int TypeCreate(TypeDTO typeDTO)
        {
            var createType = type.Create(mapper.Map<DAL.Models.Type>(typeDTO));
            return (int)createType.Id;
        }

        public void TypeUpdate(TypeDTO typeDTO)
        {
            var updateType = type.GetAll().SingleOrDefault(c => c.Id == typeDTO.Id);
            type.Update((mapper.Map<TypeDTO, DAL.Models.Type>(typeDTO, updateType)));
        }

        public bool TypeDelete(int id)
        {
            try
            {
                type.Delete(type.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Drawing CRUD method's

        public int DrawingCreate(DrawingDTO drawingDTO)
        {
            var createDrawing = drawing.Create(mapper.Map<Drawing>(drawingDTO));
            return (int)createDrawing.Id;
        }

        public bool DrawingUpdate(DrawingDTO drawingDTO)
        {
            try
            {
                var updateDrawing = drawing.GetAll().SingleOrDefault(c => c.Id == drawingDTO.Id);
                drawing.Update((mapper.Map<DrawingDTO, Drawing>(drawingDTO, updateDrawing)));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool DrawingDelete(int id)
        {
            try
            {
                drawing.Delete(drawing.GetAll().FirstOrDefault(c => c.Id == id));
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
