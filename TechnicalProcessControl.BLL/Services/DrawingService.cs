using AutoMapper;
using FirebirdSql.Data.FirebirdClient;
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

        public DrawingService(IUnitOfWork uow)
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
                cfg.CreateMap<Test, TestDTO>();
                cfg.CreateMap<Colors, ColorsDTO>();
                cfg.CreateMap<ColorsDTO, Colors>();
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

                cfg.CreateMap<DrawingsInfo, DrawingsInfoDTO>();
                cfg.CreateMap<DrawingsInfoDTO, DrawingsInfo>();
            });

            mapper = config.CreateMapper();
        }

        public bool FindDublicateDrawing(DrawingDTO drawingDTO)
        {
            return drawing.GetAll().Any(srt => srt.Number == drawingDTO.Number && srt.DetailId == drawingDTO.DetailId && srt.Id != drawingDTO.Id && srt.RevisionId == drawingDTO.RevisionId);
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

                              //join tcp001 in techProcess001.GetAll() on dr.Id equals tcp001.DrawingId
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
                          join colm in colorsMenu.GetAll() on drw.CurrentLevelMenuColorId equals colm.Id into colmm
                          from colm in colmm.DefaultIfEmpty()
                          join cold in colorsDrawing.GetAll() on drw.DrawingColorId equals cold.Id into coldd
                          from cold in coldd.DefaultIfEmpty()
                          join coldet in colorsDetail.GetAll() on drw.MaterialColorId equals coldet.Id into coldett
                          from coldet in coldett.DefaultIfEmpty()

                          where tcp001.ParentId == null  && tcp002.ParentId == null && tcp003.ParentId == null && tcp004.ParentId == null && tcp005.ParentId == null 
                          
                          //orderby drw.CurrentLevelMenu

                          select new DrawingsDTO
                          {
                              Id = drw.Id,
                              ParentId = drw.ParentId,
                              Quantity = drw.Quantity,
                              QuantityL = drw.QuantityL,
                              QuantityR = drw.QuantityR,
                              CurrentLevelMenu = drw.CurrentLevelMenu,
                              StructuraDisable = drw.StructuraDisable,
                              OccurrenceId = drw.OccurrenceId,
                              ReplaceDrawingId = drw.ReplaceDrawingId,
                               CurrentLevelMenuColorId = colm.Id,
                                CurrentLevelMenuColorName = colm.NameEng,
                                 DrawingColorId = cold.Id,
                                  DrawingColorName = cold.NameEng,
                                   MaterialColorId = coldet.Id,
                                    MaterialColorName = coldet.NameEng,


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



                              TechProcess001Id = tcp001.DrawingId != null ? tcp001.Id : (int?)null,
                              TechProcess002Id = tcp001.DrawingId != null ? tcp002.Id : (int?)null,
                              TechProcess003Id = tcp001.DrawingId != null ? tcp003.Id : (int?)null,
                              TechProcess004Id = tcp001.DrawingId != null ? tcp004.Id : (int?)null,
                              TechProcess005Id = tcp001.DrawingId != null ? tcp005.Id : (int?)null,
                              TechProcess001Name = tcp001.DrawingId != null ? tcp001.TechProcessName : (long?)null,
                              TechProcess002Name = tcp002.DrawingId != null ? tcp002.TechProcessName : (long?)null,
                              TechProcess003Name = tcp003.DrawingId != null ? tcp003.TechProcessName : (long?)null,
                              TechProcess004Name = tcp004.DrawingId != null ? tcp004.TechProcessName : (long?)null,
                              TechProcess005Name = tcp005.DrawingId != null ? tcp005.TechProcessName : (long?)null,
                              TechProcess001Path = tcp001.TechProcessPath,
                              TechProcess002Path = tcp002.TechProcessPath,
                              TechProcess003Path = tcp003.TechProcessPath,
                              TechProcess004Path = tcp004.TechProcessPath,
                              TechProcess005Path = tcp005.TechProcessPath,
                              TechProcess001Old = tcp001.OldTechProcess,
                              Revision001 = tcp001.DrawingId != null?rev001.Symbol : null,
                              Revision002 = tcp002.DrawingId != null ? rev002.Symbol : null,
                              Revision003 = tcp003.DrawingId != null ? rev003.Symbol : null,
                              Revision004 = tcp004.DrawingId != null ? rev004.Symbol : null,
                              Revision005 = tcp005.DrawingId != null ? rev005.Symbol : null,
                              ScanId = drws.DrawingId > 0 ? 1 : 0,
                              ParentName = drp.Number != "" ? drp.Number : dr.Number,
                              TechProcess001Type = tcp001.TypeId,
                              TechProcess002Type = tcp002.TypeId,
                              TechProcess003Type = tcp003.TypeId,
                              TechProcess004Type = tcp004.TypeId,
                              TechProcess005Type = tcp005.TypeId,
                              Welding10 = (tcp001.Welding10!=null? tcp001.Welding10:0) + (tcp002.Welding10 != null ? tcp002.Welding10 : 0) + (tcp003.Welding10 != null ? tcp003.Welding10 : 0) + (tcp004.Welding10 != null ? tcp004.Welding10 : 0) + (tcp005.Welding10 != null ? tcp005.Welding10 : 0),
                               Welding10Total = drw.Quantity>0? drw.Quantity * (tcp001.Welding10 != null ? tcp001.Welding10 : 0) + (tcp002.Welding10 != null ? tcp002.Welding10 : 0) + (tcp003.Welding10 != null ? tcp003.Welding10 : 0) + (tcp004.Welding10 != null ? tcp004.Welding10 : 0) + (tcp005.Welding10 != null ? tcp005.Welding10 : 0):
                               (drw.QuantityR+drw.QuantityL)* (tcp001.Welding10 != null ? tcp001.Welding10 : 0) + (tcp002.Welding10 != null ? tcp002.Welding10 : 0) + (tcp003.Welding10 != null ? tcp003.Welding10 : 0) + (tcp004.Welding10 != null ? tcp004.Welding10 : 0) + (tcp005.Welding10 != null ? tcp005.Welding10 : 0),
                              Welding12 = (tcp001.Welding12 != null ? tcp001.Welding12 : 0) + (tcp002.Welding12 != null ? tcp002.Welding12 : 0) + (tcp003.Welding12 != null ? tcp003.Welding12 : 0) + (tcp004.Welding12 != null ? tcp004.Welding12 : 0) + (tcp005.Welding12 != null ? tcp005.Welding12 : 0),
                              Welding12Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.Welding12 != null ? tcp001.Welding12 : 0) + (tcp002.Welding12 != null ? tcp002.Welding12 : 0) + (tcp003.Welding12 != null ? tcp003.Welding12 : 0) + (tcp004.Welding12 != null ? tcp004.Welding12 : 0) + (tcp005.Welding12 != null ? tcp005.Welding12 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.Welding12 != null ? tcp001.Welding12 : 0) + (tcp002.Welding12 != null ? tcp002.Welding12 : 0) + (tcp003.Welding12 != null ? tcp003.Welding12 : 0) + (tcp004.Welding12 != null ? tcp004.Welding12 : 0) + (tcp005.Welding12 != null ? tcp005.Welding12 : 0),
                              Welding16 = (tcp001.Welding16 != null ? tcp001.Welding16 : 0) + (tcp002.Welding16 != null ? tcp002.Welding16 : 0) + (tcp003.Welding16 != null ? tcp003.Welding16 : 0) + (tcp004.Welding16 != null ? tcp004.Welding16 : 0) + (tcp005.Welding16 != null ? tcp005.Welding16 : 0),
                              Welding16Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.Welding16 != null ? tcp001.Welding16 : 0) + (tcp002.Welding16 != null ? tcp002.Welding16 : 0) + (tcp003.Welding16 != null ? tcp003.Welding16 : 0) + (tcp004.Welding16 != null ? tcp004.Welding16 : 0) + (tcp005.Welding16 != null ? tcp005.Welding16 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.Welding16 != null ? tcp001.Welding16 : 0) + (tcp002.Welding16 != null ? tcp002.Welding16 : 0) + (tcp003.Welding16 != null ? tcp003.Welding16 : 0) + (tcp004.Welding16 != null ? tcp004.Welding16 : 0) + (tcp005.Welding16 != null ? tcp005.Welding16 : 0),
                              Welding20 = (tcp001.Welding20 != null ? tcp001.Welding20 : 0) + (tcp002.Welding20 != null ? tcp002.Welding20 : 0) + (tcp003.Welding20 != null ? tcp003.Welding20 : 0) + (tcp004.Welding20 != null ? tcp004.Welding20 : 0) + (tcp005.Welding20 != null ? tcp005.Welding20 : 0),
                              Welding20Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.Welding20 != null ? tcp001.Welding20 : 0) + (tcp002.Welding20 != null ? tcp002.Welding20 : 0) + (tcp003.Welding20 != null ? tcp003.Welding20 : 0) + (tcp004.Welding20 != null ? tcp004.Welding20 : 0) + (tcp005.Welding20 != null ? tcp005.Welding20 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.Welding20 != null ? tcp001.Welding20 : 0) + (tcp002.Welding20 != null ? tcp002.Welding20 : 0) + (tcp003.Welding20 != null ? tcp003.Welding20 : 0) + (tcp004.Welding20 != null ? tcp004.Welding20 : 0) + (tcp005.Welding20 != null ? tcp005.Welding20 : 0),
                               Welding20Steel = (tcp001.Welding20Steel != null ? tcp001.Welding20Steel : 0) + (tcp002.Welding20Steel != null ? tcp002.Welding20Steel : 0) + (tcp003.Welding20Steel != null ? tcp003.Welding20Steel : 0) + (tcp004.Welding20Steel != null ? tcp004.Welding20Steel : 0) + (tcp005.Welding20Steel != null ? tcp005.Welding20Steel : 0),
                              Welding20SteelTotal = drw.Quantity > 0 ? drw.Quantity * (tcp001.Welding20Steel != null ? tcp001.Welding20Steel : 0) + (tcp002.Welding20Steel != null ? tcp002.Welding20Steel : 0) + (tcp003.Welding20Steel != null ? tcp003.Welding20Steel : 0) + (tcp004.Welding20Steel != null ? tcp004.Welding20Steel : 0) + (tcp005.Welding20Steel != null ? tcp005.Welding20Steel : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.Welding20Steel != null ? tcp001.Welding20Steel : 0) + (tcp002.Welding20Steel != null ? tcp002.Welding20Steel : 0) + (tcp003.Welding20Steel != null ? tcp003.Welding20Steel : 0) + (tcp004.Welding20Steel != null ? tcp004.Welding20Steel : 0) + (tcp005.Welding20Steel != null ? tcp005.Welding20Steel : 0),
                               WeldingElektrod = (tcp001.WeldingElektrod != null ? tcp001.WeldingElektrod : 0) + (tcp002.WeldingElektrod != null ? tcp002.WeldingElektrod : 0) + (tcp003.WeldingElektrod != null ? tcp003.WeldingElektrod : 0) + (tcp004.WeldingElektrod != null ? tcp004.WeldingElektrod : 0) + (tcp005.WeldingElektrod != null ? tcp005.WeldingElektrod : 0),
                              WeldingElektrodTotal = drw.Quantity > 0 ? drw.Quantity * (tcp001.WeldingElektrod != null ? tcp001.WeldingElektrod : 0) + (tcp002.WeldingElektrod != null ? tcp002.WeldingElektrod : 0) + (tcp003.WeldingElektrod != null ? tcp003.WeldingElektrod : 0) + (tcp004.WeldingElektrod != null ? tcp004.WeldingElektrod : 0) + (tcp005.WeldingElektrod != null ? tcp005.WeldingElektrod : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.WeldingElektrod != null ? tcp001.WeldingElektrod : 0) + (tcp002.WeldingElektrod != null ? tcp002.WeldingElektrod : 0) + (tcp003.WeldingElektrod != null ? tcp003.WeldingElektrod : 0) + (tcp004.WeldingElektrod != null ? tcp004.WeldingElektrod : 0) + (tcp005.WeldingElektrod != null ? tcp005.WeldingElektrod : 0),
                               GasAr = (tcp001.GasAr != null ? tcp001.GasAr : 0) + (tcp002.GasAr != null ? tcp002.GasAr : 0) + (tcp003.GasAr != null ? tcp003.GasAr : 0) + (tcp004.GasAr != null ? tcp004.GasAr : 0) + (tcp005.GasAr != null ? tcp005.GasAr : 0),
                              GasArTotal = drw.Quantity > 0 ? drw.Quantity * (tcp001.GasAr != null ? tcp001.GasAr : 0) + (tcp002.GasAr != null ? tcp002.GasAr : 0) + (tcp003.GasAr != null ? tcp003.GasAr : 0) + (tcp004.GasAr != null ? tcp004.GasAr : 0) + (tcp005.GasAr != null ? tcp005.GasAr : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.GasAr != null ? tcp001.GasAr : 0) + (tcp002.GasAr != null ? tcp002.GasAr : 0) + (tcp003.GasAr != null ? tcp003.GasAr : 0) + (tcp004.GasAr != null ? tcp004.GasAr : 0) + (tcp005.GasAr != null ? tcp005.GasAr : 0),
                              GasArCO2 = (tcp001.GasArCO2 != null ? tcp001.GasArCO2 : 0) + (tcp002.GasArCO2 != null ? tcp002.GasArCO2 : 0) + (tcp003.GasArCO2 != null ? tcp003.GasArCO2 : 0) + (tcp004.GasArCO2 != null ? tcp004.GasArCO2 : 0) + (tcp005.GasArCO2 != null ? tcp005.GasArCO2 : 0),
                              GasArCO2Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.GasArCO2 != null ? tcp001.GasArCO2 : 0) + (tcp002.GasArCO2 != null ? tcp002.GasArCO2 : 0) + (tcp003.GasArCO2 != null ? tcp003.GasArCO2 : 0) + (tcp004.GasArCO2 != null ? tcp004.GasArCO2 : 0) + (tcp005.GasArCO2 != null ? tcp005.GasArCO2 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.GasArCO2 != null ? tcp001.GasArCO2 : 0) + (tcp002.GasArCO2 != null ? tcp002.GasArCO2 : 0) + (tcp003.GasArCO2 != null ? tcp003.GasArCO2 : 0) + (tcp004.GasArCO2 != null ? tcp004.GasArCO2 : 0) + (tcp005.GasArCO2 != null ? tcp005.GasArCO2 : 0),
                               GasCO3 = (tcp001.GasCO3 != null ? tcp001.GasCO3 : 0) + (tcp002.GasCO3 != null ? tcp002.GasCO3 : 0) + (tcp003.GasCO3 != null ? tcp003.GasCO3 : 0) + (tcp004.GasCO3 != null ? tcp004.GasCO3 : 0) + (tcp005.GasCO3 != null ? tcp005.GasCO3 : 0),
                              GasCO3Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.GasCO3 != null ? tcp001.GasCO3 : 0) + (tcp002.GasCO3 != null ? tcp002.GasCO3 : 0) + (tcp003.GasCO3 != null ? tcp003.GasCO3 : 0) + (tcp004.GasCO3 != null ? tcp004.GasCO3 : 0) + (tcp005.GasCO3 != null ? tcp005.GasCO3 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.GasCO3 != null ? tcp001.GasCO3 : 0) + (tcp002.GasCO3 != null ? tcp002.GasCO3 : 0) + (tcp003.GasCO3 != null ? tcp003.GasCO3 : 0) + (tcp004.GasCO3 != null ? tcp004.GasCO3 : 0) + (tcp005.GasCO3 != null ? tcp005.GasCO3 : 0),
                               GasN2 = (tcp001.GasN2 != null ? tcp001.GasN2 : 0) + (tcp002.GasN2 != null ? tcp002.GasN2 : 0) + (tcp003.GasN2 != null ? tcp003.GasN2 : 0) + (tcp004.GasN2 != null ? tcp004.GasN2 : 0) + (tcp005.GasN2 != null ? tcp005.GasN2 : 0),
                              GasN2Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.GasN2 != null ? tcp001.GasN2 : 0) + (tcp002.GasN2 != null ? tcp002.GasN2 : 0) + (tcp003.GasN2 != null ? tcp003.GasN2 : 0) + (tcp004.GasN2 != null ? tcp004.GasN2 : 0) + (tcp005.GasN2 != null ? tcp005.GasN2 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.GasN2 != null ? tcp001.GasN2 : 0) + (tcp002.GasN2 != null ? tcp002.GasN2 : 0) + (tcp003.GasN2 != null ? tcp003.GasN2 : 0) + (tcp004.GasN2 != null ? tcp004.GasN2 : 0) + (tcp005.GasN2 != null ? tcp005.GasN2 : 0),
                               GasNature = (tcp001.GasNature != null ? tcp001.GasNature : 0) + (tcp002.GasNature != null ? tcp002.GasNature : 0) + (tcp003.GasNature != null ? tcp003.GasNature : 0) + (tcp004.GasNature != null ? tcp004.GasNature : 0) + (tcp005.GasNature != null ? tcp005.GasNature : 0),
                              GasNatureTotal = drw.Quantity > 0 ? drw.Quantity * (tcp001.GasNature != null ? tcp001.GasNature : 0) + (tcp002.GasNature != null ? tcp002.GasNature : 0) + (tcp003.GasNature != null ? tcp003.GasNature : 0) + (tcp004.GasNature != null ? tcp004.GasNature : 0) + (tcp005.GasNature != null ? tcp005.GasNature : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.GasNature != null ? tcp001.GasNature : 0) + (tcp002.GasNature != null ? tcp002.GasNature : 0) + (tcp003.GasNature != null ? tcp003.GasNature : 0) + (tcp004.GasNature != null ? tcp004.GasNature : 0) + (tcp005.GasNature != null ? tcp005.GasNature : 0),
                               GasO2 = (tcp001.GasO2 != null ? tcp001.GasO2 : 0) + (tcp002.GasO2 != null ? tcp002.GasO2 : 0) + (tcp003.GasO2 != null ? tcp003.GasO2 : 0) + (tcp004.GasO2 != null ? tcp004.GasO2 : 0) + (tcp005.GasO2 != null ? tcp005.GasO2 : 0),
                              GasO2Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.GasO2 != null ? tcp001.GasO2 : 0) + (tcp002.GasO2 != null ? tcp002.GasO2 : 0) + (tcp003.GasO2 != null ? tcp003.GasO2 : 0) + (tcp004.GasO2 != null ? tcp004.GasO2 : 0) + (tcp005.GasO2 != null ? tcp005.GasO2 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.GasO2 != null ? tcp001.GasO2 : 0) + (tcp002.GasO2 != null ? tcp002.GasO2 : 0) + (tcp003.GasO2 != null ? tcp003.GasO2 : 0) + (tcp004.GasO2 != null ? tcp004.GasO2 : 0) + (tcp005.GasO2 != null ? tcp005.GasO2 : 0),
                               DilKapci2K = (tcp001.DilKapci2K != null ? tcp001.DilKapci2K : 0) + (tcp002.DilKapci2K != null ? tcp002.DilKapci2K : 0) + (tcp003.DilKapci2K != null ? tcp003.DilKapci2K : 0) + (tcp004.DilKapci2K != null ? tcp004.DilKapci2K : 0) + (tcp005.DilKapci2K != null ? tcp005.DilKapci2K : 0),
                              DilKapci2KTotal = drw.Quantity > 0 ? drw.Quantity * (tcp001.DilKapci2K != null ? tcp001.DilKapci2K : 0) + (tcp002.DilKapci2K != null ? tcp002.DilKapci2K : 0) + (tcp003.DilKapci2K != null ? tcp003.DilKapci2K : 0) + (tcp004.DilKapci2K != null ? tcp004.DilKapci2K : 0) + (tcp005.DilKapci2K != null ? tcp005.DilKapci2K : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.DilKapci2K != null ? tcp001.DilKapci2K : 0) + (tcp002.DilKapci2K != null ? tcp002.DilKapci2K : 0) + (tcp003.DilKapci2K != null ? tcp003.DilKapci2K : 0) + (tcp004.DilKapci2K != null ? tcp004.DilKapci2K : 0) + (tcp005.DilKapci2K != null ? tcp005.DilKapci2K : 0),
                               DilKapci880 = (tcp001.DilKapci880 != null ? tcp001.DilKapci880 : 0) + (tcp002.DilKapci880 != null ? tcp002.DilKapci880 : 0) + (tcp003.DilKapci880 != null ? tcp003.DilKapci880 : 0) + (tcp004.DilKapci880 != null ? tcp004.DilKapci880 : 0) + (tcp005.DilKapci880 != null ? tcp005.DilKapci880 : 0),
                              DilKapci880Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.DilKapci880 != null ? tcp001.DilKapci880 : 0) + (tcp002.DilKapci880 != null ? tcp002.DilKapci880 : 0) + (tcp003.DilKapci880 != null ? tcp003.DilKapci880 : 0) + (tcp004.DilKapci880 != null ? tcp004.DilKapci880 : 0) + (tcp005.DilKapci880 != null ? tcp005.DilKapci880 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.DilKapci880 != null ? tcp001.DilKapci880 : 0) + (tcp002.DilKapci880 != null ? tcp002.DilKapci880 : 0) + (tcp003.DilKapci880 != null ? tcp003.DilKapci880 : 0) + (tcp004.DilKapci880 != null ? tcp004.DilKapci880 : 0) + (tcp005.DilKapci880 != null ? tcp005.DilKapci880 : 0),
                               DilKapci881 = (tcp001.DilKapci881 != null ? tcp001.DilKapci881 : 0) + (tcp002.DilKapci881 != null ? tcp002.DilKapci881 : 0) + (tcp003.DilKapci881 != null ? tcp003.DilKapci881 : 0) + (tcp004.DilKapci881 != null ? tcp004.DilKapci881 : 0) + (tcp005.DilKapci881 != null ? tcp005.DilKapci881 : 0),
                              DilKapci881Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.DilKapci881 != null ? tcp001.DilKapci881 : 0) + (tcp002.DilKapci881 != null ? tcp002.DilKapci881 : 0) + (tcp003.DilKapci881 != null ? tcp003.DilKapci881 : 0) + (tcp004.DilKapci881 != null ? tcp004.DilKapci881 : 0) + (tcp005.DilKapci881 != null ? tcp005.DilKapci881 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.DilKapci881 != null ? tcp001.DilKapci881 : 0) + (tcp002.DilKapci881 != null ? tcp002.DilKapci881 : 0) + (tcp003.DilKapci881 != null ? tcp003.DilKapci881 : 0) + (tcp004.DilKapci881 != null ? tcp004.DilKapci881 : 0) + (tcp005.DilKapci881 != null ? tcp005.DilKapci881 : 0),
                               EnamelKapci6030 = (tcp001.EnamelKapci6030 != null ? tcp001.EnamelKapci6030 : 0) + (tcp002.EnamelKapci6030 != null ? tcp002.EnamelKapci6030 : 0) + (tcp003.EnamelKapci6030 != null ? tcp003.EnamelKapci6030 : 0) + (tcp004.EnamelKapci6030 != null ? tcp004.EnamelKapci6030 : 0) + (tcp005.EnamelKapci6030 != null ? tcp005.EnamelKapci6030 : 0),
                              EnamelKapci6030Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.EnamelKapci6030 != null ? tcp001.EnamelKapci6030 : 0) + (tcp002.EnamelKapci6030 != null ? tcp002.EnamelKapci6030 : 0) + (tcp003.EnamelKapci6030 != null ? tcp003.EnamelKapci6030 : 0) + (tcp004.EnamelKapci6030 != null ? tcp004.EnamelKapci6030 : 0) + (tcp005.EnamelKapci6030 != null ? tcp005.EnamelKapci6030 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.EnamelKapci6030 != null ? tcp001.EnamelKapci6030 : 0) + (tcp002.EnamelKapci6030 != null ? tcp002.EnamelKapci6030 : 0) + (tcp003.EnamelKapci6030 != null ? tcp003.EnamelKapci6030 : 0) + (tcp004.EnamelKapci6030 != null ? tcp004.EnamelKapci6030 : 0) + (tcp005.EnamelKapci6030 != null ? tcp005.EnamelKapci6030 : 0),
                               EnamelKapci641 = (tcp001.EnamelKapci641 != null ? tcp001.EnamelKapci641 : 0) + (tcp002.EnamelKapci641 != null ? tcp002.EnamelKapci641 : 0) + (tcp003.EnamelKapci641 != null ? tcp003.EnamelKapci641 : 0) + (tcp004.EnamelKapci641 != null ? tcp004.EnamelKapci641 : 0) + (tcp005.EnamelKapci641 != null ? tcp005.EnamelKapci641 : 0),
                              EnamelKapci641Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.EnamelKapci641 != null ? tcp001.EnamelKapci641 : 0) + (tcp002.EnamelKapci641 != null ? tcp002.EnamelKapci641 : 0) + (tcp003.EnamelKapci641 != null ? tcp003.EnamelKapci641 : 0) + (tcp004.EnamelKapci641 != null ? tcp004.EnamelKapci641 : 0) + (tcp005.EnamelKapci641 != null ? tcp005.EnamelKapci641 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.EnamelKapci641 != null ? tcp001.EnamelKapci641 : 0) + (tcp002.EnamelKapci641 != null ? tcp002.EnamelKapci641 : 0) + (tcp003.EnamelKapci641 != null ? tcp003.EnamelKapci641 : 0) + (tcp004.EnamelKapci641 != null ? tcp004.EnamelKapci641 : 0) + (tcp005.EnamelKapci641 != null ? tcp005.EnamelKapci641 : 0),
                               EnamelKapci670 = (tcp001.EnamelKapci670 != null ? tcp001.EnamelKapci670 : 0) + (tcp002.EnamelKapci670 != null ? tcp002.EnamelKapci670 : 0) + (tcp003.EnamelKapci670 != null ? tcp003.EnamelKapci670 : 0) + (tcp004.EnamelKapci670 != null ? tcp004.EnamelKapci670 : 0) + (tcp005.EnamelKapci670 != null ? tcp005.EnamelKapci670 : 0),
                              EnamelKapci670Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.EnamelKapci670 != null ? tcp001.EnamelKapci670 : 0) + (tcp002.EnamelKapci670 != null ? tcp002.EnamelKapci670 : 0) + (tcp003.EnamelKapci670 != null ? tcp003.EnamelKapci670 : 0) + (tcp004.EnamelKapci670 != null ? tcp004.EnamelKapci670 : 0) + (tcp005.EnamelKapci670 != null ? tcp005.EnamelKapci670 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.EnamelKapci670 != null ? tcp001.EnamelKapci670 : 0) + (tcp002.EnamelKapci670 != null ? tcp002.EnamelKapci670 : 0) + (tcp003.EnamelKapci670 != null ? tcp003.EnamelKapci670 : 0) + (tcp004.EnamelKapci670 != null ? tcp004.EnamelKapci670 : 0) + (tcp005.EnamelKapci670 != null ? tcp005.EnamelKapci670 : 0),
                               HardKapci126 = (tcp001.HardKapci126 != null ? tcp001.HardKapci126 : 0) + (tcp002.HardKapci126 != null ? tcp002.HardKapci126 : 0) + (tcp003.HardKapci126 != null ? tcp003.HardKapci126 : 0) + (tcp004.HardKapci126 != null ? tcp004.HardKapci126 : 0) + (tcp005.HardKapci126 != null ? tcp005.HardKapci126 : 0),
                              HardKapci126Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.HardKapci126 != null ? tcp001.HardKapci126 : 0) + (tcp002.HardKapci126 != null ? tcp002.HardKapci126 : 0) + (tcp003.HardKapci126 != null ? tcp003.HardKapci126 : 0) + (tcp004.HardKapci126 != null ? tcp004.HardKapci126 : 0) + (tcp005.HardKapci126 != null ? tcp005.HardKapci126 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.HardKapci126 != null ? tcp001.HardKapci126 : 0) + (tcp002.HardKapci126 != null ? tcp002.HardKapci126 : 0) + (tcp003.HardKapci126 != null ? tcp003.HardKapci126 : 0) + (tcp004.HardKapci126 != null ? tcp004.HardKapci126 : 0) + (tcp005.HardKapci126 != null ? tcp005.HardKapci126 : 0),
                               HardKapci2KMS651 = (tcp001.HardKapci2KMS651 != null ? tcp001.HardKapci2KMS651 : 0) + (tcp002.HardKapci2KMS651 != null ? tcp002.HardKapci2KMS651 : 0) + (tcp003.HardKapci2KMS651 != null ? tcp003.HardKapci2KMS651 : 0) + (tcp004.HardKapci2KMS651 != null ? tcp004.HardKapci2KMS651 : 0) + (tcp005.HardKapci2KMS651 != null ? tcp005.HardKapci2KMS651 : 0),
                              HardKapci2KMS651Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.HardKapci2KMS651 != null ? tcp001.HardKapci2KMS651 : 0) + (tcp002.HardKapci2KMS651 != null ? tcp002.HardKapci2KMS651 : 0) + (tcp003.HardKapci2KMS651 != null ? tcp003.HardKapci2KMS651 : 0) + (tcp004.HardKapci2KMS651 != null ? tcp004.HardKapci2KMS651 : 0) + (tcp005.HardKapci2KMS651 != null ? tcp005.HardKapci2KMS651 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.HardKapci2KMS651 != null ? tcp001.HardKapci2KMS651 : 0) + (tcp002.HardKapci2KMS651 != null ? tcp002.HardKapci2KMS651 : 0) + (tcp003.HardKapci2KMS651 != null ? tcp003.HardKapci2KMS651 : 0) + (tcp004.HardKapci2KMS651 != null ? tcp004.HardKapci2KMS651 : 0) + (tcp005.HardKapci2KMS651 != null ? tcp005.HardKapci2KMS651 : 0),
                               HardKapci881 = (tcp001.HardKapci881 != null ? tcp001.HardKapci881 : 0) + (tcp002.HardKapci881 != null ? tcp002.HardKapci881 : 0) + (tcp003.HardKapci881 != null ? tcp003.HardKapci881 : 0) + (tcp004.HardKapci881 != null ? tcp004.HardKapci881 : 0) + (tcp005.HardKapci881 != null ? tcp005.HardKapci881 : 0),
                              HardKapci881Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.HardKapci881 != null ? tcp001.HardKapci881 : 0) + (tcp002.HardKapci881 != null ? tcp002.HardKapci881 : 0) + (tcp003.HardKapci881 != null ? tcp003.HardKapci881 : 0) + (tcp004.HardKapci881 != null ? tcp004.HardKapci881 : 0) + (tcp005.HardKapci881 != null ? tcp005.HardKapci881 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.HardKapci881 != null ? tcp001.HardKapci881 : 0) + (tcp002.HardKapci881 != null ? tcp002.HardKapci881 : 0) + (tcp003.HardKapci881 != null ? tcp003.HardKapci881 : 0) + (tcp004.HardKapci881 != null ? tcp004.HardKapci881 : 0) + (tcp005.HardKapci881 != null ? tcp005.HardKapci881 : 0),
                               HardKapciHs6055 = (tcp001.HardKapciHs6055 != null ? tcp001.HardKapciHs6055 : 0) + (tcp002.HardKapciHs6055 != null ? tcp002.HardKapciHs6055 : 0) + (tcp003.HardKapciHs6055 != null ? tcp003.HardKapciHs6055 : 0) + (tcp004.HardKapciHs6055 != null ? tcp004.HardKapciHs6055 : 0) + (tcp005.HardKapciHs6055 != null ? tcp005.HardKapciHs6055 : 0),
                              HardKapciHs6055Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.HardKapciHs6055 != null ? tcp001.HardKapciHs6055 : 0) + (tcp002.HardKapciHs6055 != null ? tcp002.HardKapciHs6055 : 0) + (tcp003.HardKapciHs6055 != null ? tcp003.HardKapciHs6055 : 0) + (tcp004.HardKapciHs6055 != null ? tcp004.HardKapciHs6055 : 0) + (tcp005.HardKapciHs6055 != null ? tcp005.HardKapciHs6055 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.HardKapciHs6055 != null ? tcp001.HardKapciHs6055 : 0) + (tcp002.HardKapciHs6055 != null ? tcp002.HardKapciHs6055 : 0) + (tcp003.HardKapciHs6055 != null ? tcp003.HardKapciHs6055 : 0) + (tcp004.HardKapciHs6055 != null ? tcp004.HardKapciHs6055 : 0) + (tcp005.HardKapciHs6055 != null ? tcp005.HardKapciHs6055 : 0),
                               HardKapciPEPutty = (tcp001.HardKapciPEPutty != null ? tcp001.HardKapciPEPutty : 0) + (tcp002.HardKapciPEPutty != null ? tcp002.HardKapciPEPutty : 0) + (tcp003.HardKapciPEPutty != null ? tcp003.HardKapciPEPutty : 0) + (tcp004.HardKapciPEPutty != null ? tcp004.HardKapciPEPutty : 0) + (tcp005.HardKapciPEPutty != null ? tcp005.HardKapciPEPutty : 0),
                              HardKapciPEPuttyTotal = drw.Quantity > 0 ? drw.Quantity * (tcp001.HardKapciPEPutty != null ? tcp001.HardKapciPEPutty : 0) + (tcp002.HardKapciPEPutty != null ? tcp002.HardKapciPEPutty : 0) + (tcp003.HardKapciPEPutty != null ? tcp003.HardKapciPEPutty : 0) + (tcp004.HardKapciPEPutty != null ? tcp004.HardKapciPEPutty : 0) + (tcp005.HardKapciPEPutty != null ? tcp005.HardKapciPEPutty : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.HardKapciPEPutty != null ? tcp001.HardKapciPEPutty : 0) + (tcp002.HardKapciPEPutty != null ? tcp002.HardKapciPEPutty : 0) + (tcp003.HardKapciPEPutty != null ? tcp003.HardKapciPEPutty : 0) + (tcp004.HardKapciPEPutty != null ? tcp004.HardKapciPEPutty : 0) + (tcp005.HardKapciPEPutty != null ? tcp005.HardKapciPEPutty : 0),
                               PrimerKapci125 = (tcp001.PrimerKapci125 != null ? tcp001.PrimerKapci125 : 0) + (tcp002.PrimerKapci125 != null ? tcp002.PrimerKapci125 : 0) + (tcp003.PrimerKapci125 != null ? tcp003.PrimerKapci125 : 0) + (tcp004.PrimerKapci125 != null ? tcp004.PrimerKapci125 : 0) + (tcp005.PrimerKapci125 != null ? tcp005.PrimerKapci125 : 0),
                              PrimerKapci125Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.PrimerKapci125 != null ? tcp001.PrimerKapci125 : 0) + (tcp002.PrimerKapci125 != null ? tcp002.PrimerKapci125 : 0) + (tcp003.PrimerKapci125 != null ? tcp003.PrimerKapci125 : 0) + (tcp004.PrimerKapci125 != null ? tcp004.PrimerKapci125 : 0) + (tcp005.PrimerKapci125 != null ? tcp005.PrimerKapci125 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.PrimerKapci125 != null ? tcp001.PrimerKapci125 : 0) + (tcp002.PrimerKapci125 != null ? tcp002.PrimerKapci125 : 0) + (tcp003.PrimerKapci125 != null ? tcp003.PrimerKapci125 : 0) + (tcp004.PrimerKapci125 != null ? tcp004.PrimerKapci125 : 0) + (tcp005.PrimerKapci125 != null ? tcp005.PrimerKapci125 : 0),
                               PrimerKapci633 = (tcp001.PrimerKapci633 != null ? tcp001.PrimerKapci633 : 0) + (tcp002.PrimerKapci633 != null ? tcp002.PrimerKapci633 : 0) + (tcp003.PrimerKapci633 != null ? tcp003.PrimerKapci633 : 0) + (tcp004.PrimerKapci633 != null ? tcp004.PrimerKapci633 : 0) + (tcp005.PrimerKapci633 != null ? tcp005.PrimerKapci633 : 0),
                              PrimerKapci633Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.PrimerKapci633 != null ? tcp001.PrimerKapci633 : 0) + (tcp002.PrimerKapci633 != null ? tcp002.PrimerKapci633 : 0) + (tcp003.PrimerKapci633 != null ? tcp003.PrimerKapci633 : 0) + (tcp004.PrimerKapci633 != null ? tcp004.PrimerKapci633 : 0) + (tcp005.PrimerKapci633 != null ? tcp005.PrimerKapci633 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.PrimerKapci633 != null ? tcp001.PrimerKapci633 : 0) + (tcp002.PrimerKapci633 != null ? tcp002.PrimerKapci633 : 0) + (tcp003.PrimerKapci633 != null ? tcp003.PrimerKapci633 : 0) + (tcp004.PrimerKapci633 != null ? tcp004.PrimerKapci633 : 0) + (tcp005.PrimerKapci633 != null ? tcp005.PrimerKapci633 : 0),
                              PuttyKapci350 = (tcp001.PuttyKapci350 != null ? tcp001.PuttyKapci350 : 0) + (tcp002.PuttyKapci350 != null ? tcp002.PuttyKapci350 : 0) + (tcp003.PuttyKapci350 != null ? tcp003.PuttyKapci350 : 0) + (tcp004.PuttyKapci350 != null ? tcp004.PuttyKapci350 : 0) + (tcp005.PuttyKapci350 != null ? tcp005.PuttyKapci350 : 0),
                              PuttyKapci350Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.PuttyKapci350 != null ? tcp001.PuttyKapci350 : 0) + (tcp002.PuttyKapci350 != null ? tcp002.PuttyKapci350 : 0) + (tcp003.PuttyKapci350 != null ? tcp003.PuttyKapci350 : 0) + (tcp004.PuttyKapci350 != null ? tcp004.PuttyKapci350 : 0) + (tcp005.PuttyKapci350 != null ? tcp005.PuttyKapci350 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.PuttyKapci350 != null ? tcp001.PuttyKapci350 : 0) + (tcp002.PuttyKapci350 != null ? tcp002.PuttyKapci350 : 0) + (tcp003.PuttyKapci350 != null ? tcp003.PuttyKapci350 : 0) + (tcp004.PuttyKapci350 != null ? tcp004.PuttyKapci350 : 0) + (tcp005.PuttyKapci350 != null ? tcp005.PuttyKapci350 : 0),
                               UniversalSikaflex527 = (tcp001.UniversalSikaflex527 != null ? tcp001.UniversalSikaflex527 : 0) + (tcp002.UniversalSikaflex527 != null ? tcp002.UniversalSikaflex527 : 0) + (tcp003.UniversalSikaflex527 != null ? tcp003.UniversalSikaflex527 : 0) + (tcp004.UniversalSikaflex527 != null ? tcp004.UniversalSikaflex527 : 0) + (tcp005.UniversalSikaflex527 != null ? tcp005.UniversalSikaflex527 : 0),
                              UniversalSikaflex527Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.UniversalSikaflex527 != null ? tcp001.UniversalSikaflex527 : 0) + (tcp002.UniversalSikaflex527 != null ? tcp002.UniversalSikaflex527 : 0) + (tcp003.UniversalSikaflex527 != null ? tcp003.UniversalSikaflex527 : 0) + (tcp004.UniversalSikaflex527 != null ? tcp004.UniversalSikaflex527 : 0) + (tcp005.UniversalSikaflex527 != null ? tcp005.UniversalSikaflex527 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.UniversalSikaflex527 != null ? tcp001.UniversalSikaflex527 : 0) + (tcp002.UniversalSikaflex527 != null ? tcp002.UniversalSikaflex527 : 0) + (tcp003.UniversalSikaflex527 != null ? tcp003.UniversalSikaflex527 : 0) + (tcp004.UniversalSikaflex527 != null ? tcp004.UniversalSikaflex527 : 0) + (tcp005.UniversalSikaflex527 != null ? tcp005.UniversalSikaflex527 : 0),
                               LaborIntensity001 = (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0),
                              LaborIntensity001Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0),
                              LaborIntensity002 = (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0),
                              LaborIntensity002Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0),
                              LaborIntensity003 = (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0),
                              LaborIntensity003Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0),
                              LaborIntensity004 = (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0),
                              LaborIntensity004Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0),
                              LaborIntensity005 = (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0)
                              //LaborIntensity005Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0) :
                              // (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0),
                              //LaborIntensityGeneral  =  (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0)+
                              //                          (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0)+
                              //                          (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0)+
                              //                          (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0)+
                              //                          (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0),
                              // LaborIntensityGeneralTotal = (drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0) :
                              //                          (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0))+
                              //                          (drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0) :
                              //                          (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0))+
                              //                          (drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0) :
                              //                          (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0)) +
                              //                          (drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0) :
                              //                          (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0))+
                              //                          (drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0) :
                              //                          (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0))


                          }
                            ).ToList();



            //result.GroupBy(x => x.Id).Select(y => y.First());

            //return result;
            return result.GroupBy(x => x.Id).Select(y => y.First()).ToList();
        }

        //public IEnumerable<BankPaymentsInfoDTO> GetBankPaymentsJournal(DateTime beginDate, DateTime endDate)
        //{
            
        //}
        public IEnumerable<DrawingsInfoDTO> GetAllDrawingsProc()
        {
            FbParameter[] Parameters =
                {
                new FbParameter("BeginDate", DateTime.Now)
                };

            string procName = @"select * from ""GetDrawings""(@BeginDate)";

            return mapper.Map<IEnumerable<DrawingsInfo>, List<DrawingsInfoDTO>>(drawingsInfo.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<TestDTO> TestProc()
        {
            FbParameter[] Parameters =
                {
                new FbParameter("DateNow", DateTime.Now)
                };

            string procName = @"select * from ""TestProc""(@DateNow)";

            return mapper.Map<IEnumerable<Test>, List<TestDTO>>(test.SQLExecuteProc(procName, Parameters));


            //FbParameter[] Parameters =
            //    {
            //        new FbParameter("BeginDate", beginDate),
            //        new FbParameter("EndDate", endDate)
            //    };

            //string procName = @"select * from ""GetBankPayments""(@BeginDate, @EndDate)";

            //return mapper.Map<IEnumerable<BankPaymentsInfo>, List<BankPaymentsInfoDTO>>(bankPaymentsInfo.SQLExecuteProc(procName, Parameters));
        }


        public IEnumerable<DrawingsDTO> GetAllDrawingsWithoutMaterials()
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

                              //join tcp001 in techProcess001.GetAll() on dr.Id equals tcp001.DrawingId
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
                          join colm in colorsMenu.GetAll() on drw.CurrentLevelMenuColorId equals colm.Id into colmm
                          from colm in colmm.DefaultIfEmpty()
                          join cold in colorsDrawing.GetAll() on drw.DrawingColorId equals cold.Id into coldd
                          from cold in coldd.DefaultIfEmpty()
                          join coldet in colorsDetail.GetAll() on drw.MaterialColorId equals coldet.Id into coldett
                          from coldet in coldett.DefaultIfEmpty()

                              // where ((tcp001.ParentId == null && tcp001.Id==1 && tcp001.DrawingId == null) || (tcp001.ParentId == null && tcp001.DrawingId != null)) && tcp002.ParentId == null && tcp003.ParentId == null && tcp004.ParentId == null && tcp005.ParentId == null
                          where (tcp001.ParentId == null && tcp002.ParentId == null && tcp003.ParentId == null && tcp004.ParentId == null && tcp005.ParentId == null 
                          )
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
                              CurrentLevelMenuColorId = colm.Id,
                              CurrentLevelMenuColorName = colm.NameEng,
                              DrawingColorId = cold.Id,
                              DrawingColorName = cold.NameEng,
                              MaterialColorId = coldet.Id,
                              MaterialColorName = coldet.NameEng,


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



                              TechProcess001Id = tcp001.DrawingId != null ? tcp001.Id : (int?)null,
                              TechProcess002Id = tcp001.DrawingId != null ? tcp002.Id : (int?)null,
                              TechProcess003Id = tcp001.DrawingId != null ? tcp003.Id : (int?)null,
                              TechProcess004Id = tcp001.DrawingId != null ? tcp004.Id : (int?)null,
                              TechProcess005Id = tcp001.DrawingId != null ? tcp005.Id : (int?)null,
                              TechProcess001Name = tcp001.DrawingId != null ? tcp001.TechProcessName : (long?)null,
                              TechProcess002Name = tcp002.DrawingId != null ? tcp002.TechProcessName : (long?)null,
                              TechProcess003Name = tcp003.DrawingId != null ? tcp003.TechProcessName : (long?)null,
                              TechProcess004Name = tcp004.DrawingId != null ? tcp004.TechProcessName : (long?)null,
                              TechProcess005Name = tcp005.DrawingId != null ? tcp005.TechProcessName : (long?)null,
                              TechProcess001Path = tcp001.TechProcessPath,
                              TechProcess002Path = tcp002.TechProcessPath,
                              TechProcess003Path = tcp003.TechProcessPath,
                              TechProcess004Path = tcp004.TechProcessPath,
                              TechProcess005Path = tcp005.TechProcessPath,
                              TechProcess001Old = tcp001.OldTechProcess,
                              //TechProcess001Old = tcp002.OldTechProcess,
                              Revision001 = tcp001.DrawingId != null ? rev001.Symbol : null,
                              Revision002 = tcp002.DrawingId != null ? rev002.Symbol : null,
                              Revision003 = tcp003.DrawingId != null ? rev003.Symbol : null,
                              Revision004 = tcp004.DrawingId != null ? rev004.Symbol : null,
                              Revision005 = tcp005.DrawingId != null ? rev005.Symbol : null,
                              ScanId = drws.DrawingId > 0 ? 1 : 0,
                              ParentName = drp.Number != "" ? drp.Number : dr.Number,
                              TechProcess001Type = tcp001.TypeId,
                              TechProcess002Type = tcp002.TypeId,
                              TechProcess003Type = tcp003.TypeId,
                              TechProcess004Type = tcp004.TypeId,
                              TechProcess005Type = tcp005.TypeId

                          }
                            ).ToList();



            //result.GroupBy(x => x.Id).Select(y => y.First());


            return result.GroupBy(x => x.Id).Select(y => y.First()).ToList();
        }

        public IEnumerable<DrawingsDTO> GetAllDrawingsWithLaborIntensity()
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

                              //join tcp001 in techProcess001.GetAll() on dr.Id equals tcp001.DrawingId
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
                          join colm in colorsMenu.GetAll() on drw.CurrentLevelMenuColorId equals colm.Id into colmm
                          from colm in colmm.DefaultIfEmpty()
                          join cold in colorsDrawing.GetAll() on drw.DrawingColorId equals cold.Id into coldd
                          from cold in coldd.DefaultIfEmpty()
                          join coldet in colorsDetail.GetAll() on drw.MaterialColorId equals coldet.Id into coldett
                          from coldet in coldett.DefaultIfEmpty()

                              // where ((tcp001.ParentId == null && tcp001.Id==1 && tcp001.DrawingId == null) || (tcp001.ParentId == null && tcp001.DrawingId != null)) && tcp002.ParentId == null && tcp003.ParentId == null && tcp004.ParentId == null && tcp005.ParentId == null
                          where (tcp001.ParentId == null && tcp002.ParentId == null && tcp003.ParentId == null && tcp004.ParentId == null && tcp005.ParentId == null 

                          )
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
                              CurrentLevelMenuColorId = colm.Id,
                              CurrentLevelMenuColorName = colm.NameEng,
                              DrawingColorId = cold.Id,
                              DrawingColorName = cold.NameEng,
                              MaterialColorId = coldet.Id,
                              MaterialColorName = coldet.NameEng,


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



                              TechProcess001Id = tcp001.DrawingId != null ? tcp001.Id : (int?)null,
                              TechProcess002Id = tcp001.DrawingId != null ? tcp002.Id : (int?)null,
                              TechProcess003Id = tcp001.DrawingId != null ? tcp003.Id : (int?)null,
                              TechProcess004Id = tcp001.DrawingId != null ? tcp004.Id : (int?)null,
                              TechProcess005Id = tcp001.DrawingId != null ? tcp005.Id : (int?)null,
                              TechProcess001Name = tcp001.DrawingId != null ? tcp001.TechProcessName : (long?)null,
                              TechProcess002Name = tcp002.DrawingId != null ? tcp002.TechProcessName : (long?)null,
                              TechProcess003Name = tcp003.DrawingId != null ? tcp003.TechProcessName : (long?)null,
                              TechProcess004Name = tcp004.DrawingId != null ? tcp004.TechProcessName : (long?)null,
                              TechProcess005Name = tcp005.DrawingId != null ? tcp005.TechProcessName : (long?)null,
                              TechProcess001Path = tcp001.TechProcessPath,
                              TechProcess002Path = tcp002.TechProcessPath,
                              TechProcess003Path = tcp003.TechProcessPath,
                              TechProcess004Path = tcp004.TechProcessPath,
                              TechProcess005Path = tcp005.TechProcessPath,
                              TechProcess001Old = tcp001.OldTechProcess,
                              //TechProcess001Old = tcp002.OldTechProcess,
                              Revision001 = tcp001.DrawingId != null ? rev001.Symbol : null,
                              Revision002 = tcp002.DrawingId != null ? rev002.Symbol : null,
                              Revision003 = tcp003.DrawingId != null ? rev003.Symbol : null,
                              Revision004 = tcp004.DrawingId != null ? rev004.Symbol : null,
                              Revision005 = tcp005.DrawingId != null ? rev005.Symbol : null,
                              ScanId = drws.DrawingId > 0 ? 1 : 0,
                              ParentName = drp.Number != "" ? drp.Number : dr.Number,
                              TechProcess001Type = tcp001.TypeId,
                              TechProcess002Type = tcp002.TypeId,
                              TechProcess003Type = tcp003.TypeId,
                              TechProcess004Type = tcp004.TypeId,
                              TechProcess005Type = tcp005.TypeId,
                              //Welding10 = tcp001.Welding10 + tcp002.Welding10  + tcp003.Welding10 + tcp004.Welding10 + tcp005.Welding10,

                            
                              LaborIntensity001 = (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0),
                              LaborIntensity001Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0),
                              LaborIntensity002 = (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0),
                              LaborIntensity002Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0),
                              LaborIntensity003 = (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0),
                              LaborIntensity003Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0),
                              LaborIntensity004 = (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0),
                              LaborIntensity004Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0),
                              LaborIntensity005 = (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0),
                              LaborIntensity005Total = drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0) :
                               (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0),
                              LaborIntensityGeneral = (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0) +
                                                        (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0) +
                                                        (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0) +
                                                        (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0) +
                                                        (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0),
                              LaborIntensityGeneralTotal = (drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0) :
                                                        (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity001 != null ? tcp001.LaborIntensity001 : 0) + (tcp002.LaborIntensity001 != null ? tcp002.LaborIntensity001 : 0) + (tcp003.LaborIntensity001 != null ? tcp003.LaborIntensity001 : 0) + (tcp004.LaborIntensity001 != null ? tcp004.LaborIntensity001 : 0) + (tcp005.LaborIntensity001 != null ? tcp005.LaborIntensity001 : 0)) +
                                                        (drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0) :
                                                        (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity002 != null ? tcp001.LaborIntensity002 : 0) + (tcp002.LaborIntensity002 != null ? tcp002.LaborIntensity002 : 0) + (tcp003.LaborIntensity002 != null ? tcp003.LaborIntensity002 : 0) + (tcp004.LaborIntensity002 != null ? tcp004.LaborIntensity002 : 0) + (tcp005.LaborIntensity002 != null ? tcp005.LaborIntensity002 : 0)) +
                                                        (drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0) :
                                                        (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity003 != null ? tcp001.LaborIntensity003 : 0) + (tcp002.LaborIntensity003 != null ? tcp002.LaborIntensity003 : 0) + (tcp003.LaborIntensity003 != null ? tcp003.LaborIntensity003 : 0) + (tcp004.LaborIntensity003 != null ? tcp004.LaborIntensity003 : 0) + (tcp005.LaborIntensity003 != null ? tcp005.LaborIntensity003 : 0)) +
                                                        (drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0) :
                                                        (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity004 != null ? tcp001.LaborIntensity004 : 0) + (tcp002.LaborIntensity004 != null ? tcp002.LaborIntensity004 : 0) + (tcp003.LaborIntensity004 != null ? tcp003.LaborIntensity004 : 0) + (tcp004.LaborIntensity004 != null ? tcp004.LaborIntensity004 : 0) + (tcp005.LaborIntensity004 != null ? tcp005.LaborIntensity004 : 0)) +
                                                        (drw.Quantity > 0 ? drw.Quantity * (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0) :
                                                        (drw.QuantityR + drw.QuantityL) * (tcp001.LaborIntensity005 != null ? tcp001.LaborIntensity005 : 0) + (tcp002.LaborIntensity005 != null ? tcp002.LaborIntensity005 : 0) + (tcp003.LaborIntensity005 != null ? tcp003.LaborIntensity005 : 0) + (tcp004.LaborIntensity005 != null ? tcp004.LaborIntensity005 : 0) + (tcp005.LaborIntensity005 != null ? tcp005.LaborIntensity005 : 0))



                              //Welding12 = tcp001.Welding12 + tcp002.Welding12 + tcp003.Welding12 +tcp004.Welding12 + tcp005.Welding12
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
                          where drw.Id == structuraId && tcp001.ParentId == null && tcp002.ParentId == null && tcp003.ParentId == null && tcp004.ParentId == null && tcp005.ParentId == null
                 
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


        public IEnumerable<DrawingsDTO> GetDrawingsSimple()
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
        }



        /*public DrawingScanDTO GetDrawingScanById(int DrawingId)
        {
            return mapper.Map<DrawingScan, DrawingScanDTO>(drawingScan.GetAll().FirstOrDefault(s => s.DrawingId == DrawingId && s.Status == null));
        }*/

        

        public bool CheckTechProcess002(long techProcesName)
        {
            return techProcess002.GetAll().Any(chk => chk.TechProcessName == techProcesName);
        }



        public bool CheckTechProcess003(long techProcesName)
        {
            return techProcess003.GetAll().Any(chk =>  chk.TechProcessName == techProcesName);
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
        //получить все техпроцессы 001 и их ревизии 
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
                              DrawingNumber = tcp.DrawingId!=null?dr.Number:drCopy.Number,
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


        //получить техпроцесс 002 по айди техпроцесса с подробной информацией
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

        //получить техпроцесс 002 по айди техпроцесса с краткой информацией
        public TechProcess002DTO GetTechProcess002Simple(int techProcess002Id)
        {
            return mapper.Map<TechProcess002, TechProcess002DTO>(techProcess002.GetAll().FirstOrDefault(srt => srt.Id == techProcess002Id));
        }
        //получить техпроцесс 002 по айди техпроцесса с краткой информацией
        public IEnumerable<TechProcess002DTO> GetAllTechProcess002Simple()
        {
            return mapper.Map<IEnumerable<TechProcess002>, List<TechProcess002DTO>>(techProcess002.GetAll());
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


        #region TechProcess003

        //получить техпроцесс 003 по айди техпроцесса с подробной информацией
        public TechProcess003DTO GetTechProcess003ByIdFull(int techProcess003Id)
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
                          where tcp.Id == techProcess003Id
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

        //получить техпроцесс 003 по айди техпроцесса с краткой информацией
        public TechProcess003DTO GetTechProcess003Simple(int techProcess003Id)
        {
            return mapper.Map<TechProcess003, TechProcess003DTO>(techProcess003.GetAll().FirstOrDefault(srt => srt.Id == techProcess003Id));
        }
        //получить техпроцесс 003 по айди техпроцесса с краткой информацией
        public IEnumerable<TechProcess003DTO> GetAllTechProcess003Simple()
        {
            return mapper.Map<IEnumerable<TechProcess003>, List<TechProcess003DTO>>(techProcess003.GetAll());
        }
        // получить  ревизии техпроцесса 003 + актуальный по Id 
        public IEnumerable<TechProcess003DTO> GetAllTechProcess003RevisionWithActualTechprocess(int techProcessId)
        {
            List<TechProcess003DTO> allRevisiontechProcess003 = new List<TechProcess003DTO>();
            var techProcess003Actial = GetTechProcess003Simple(techProcessId);
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

        #endregion
















        //public IEnumerable<TechProcess003DTO> GetAllTechProcess003()
        //{
        //    var result = (from tcp in techProcess003.GetAll()
        //                  join rt in revisionsTechProcess003.GetAll() on tcp.RevisionId equals rt.Id into rtt
        //                  from rt in rtt.DefaultIfEmpty()
        //                  join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
        //                  from dr in drr.DefaultIfEmpty()
        //                  join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
        //                  from rd in rdd.DefaultIfEmpty()
        //                  select new TechProcess003DTO
        //                  {
        //                      Id = tcp.Id,
        //                      CreateDate = tcp.CreateDate,
        //                      ParentId = tcp.ParentId,
        //                      RevisionId = tcp.RevisionId,
        //                      LaborIntensity001 = tcp.LaborIntensity001,
        //                      LaborIntensity002 = tcp.LaborIntensity002,
        //                      LaborIntensity003 = tcp.LaborIntensity003,
        //                      LaborIntensity004 = tcp.LaborIntensity004,
        //                      LaborIntensity005 = tcp.LaborIntensity005,
        //                      TechProcessName = tcp.TechProcessName,
        //                      DrawingId = tcp.DrawingId,
        //                      DrawingNumber = dr.Number,
        //                      TechProcessFullName = tcp.TechProcessFullName,
        //                      TechProcessPath = tcp.TechProcessPath,
        //                      DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
        //                      RivisionName = rt.Symbol
        //                  }
        //                  ).ToList();

        //    return result;
        //}
        //public IEnumerable<TechProcess003DTO> GetAllTechProcessActual003()
        //{
        //    var result = (from tcp in techProcess003.GetAll()
        //                  join rt in revisionsTechProcess003.GetAll() on tcp.RevisionId equals rt.Id into rtt
        //                  from rt in rtt.DefaultIfEmpty()
        //                  join dr in drawing.GetAll() on tcp.DrawingId equals dr.Id into drr
        //                  from dr in drr.DefaultIfEmpty()
        //                  join rd in revisions.GetAll() on dr.RevisionId equals rd.Id into rdd
        //                  from rd in rdd.DefaultIfEmpty()
        //                  where tcp.ParentId == null
        //                  select new TechProcess003DTO
        //                  {
        //                      Id = tcp.Id,
        //                      CreateDate = tcp.CreateDate,
        //                      ParentId = tcp.ParentId,
        //                      RevisionId = tcp.RevisionId,
        //                      LaborIntensity001 = tcp.LaborIntensity001,
        //                      LaborIntensity002 = tcp.LaborIntensity002,
        //                      LaborIntensity003 = tcp.LaborIntensity003,
        //                      LaborIntensity004 = tcp.LaborIntensity004,
        //                      LaborIntensity005 = tcp.LaborIntensity005,
        //                      TechProcessName = tcp.TechProcessName,
        //                      DrawingId = tcp.DrawingId,
        //                      DrawingNumber = dr.Number,
        //                      TechProcessFullName = tcp.TechProcessFullName,
        //                      TechProcessPath = tcp.TechProcessPath,
        //                      DrawingNumberWithRevision = rd.Symbol == null ? dr.Number : (dr.Number + "_" + rd.Symbol),
        //                      RivisionName = rt.Symbol
        //                  }
        //                  ).ToList();

        //    return result;
        //}


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
                var techProcessDelete = techProcess001.GetAll().FirstOrDefault(c => c.Id == id);
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

        public int? CheckDrawings(string currentLevelMenu)
        {
            var createDrawings = drawings.GetAll().SingleOrDefault(c => c.CurrentLevelMenu == currentLevelMenu);
            return createDrawings.Id;
        }

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

        public int? CheckType(string typeName)
        {
            var createType = type.GetAll().SingleOrDefault(c => c.TypeName == typeName);
            return createType.Id;
        }

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

        public int? CheckDrawing(string drawingNumber)
        {
            var checkDrawing = drawing.GetAll().SingleOrDefault(c => c.Number == drawingNumber);
            return checkDrawing.Id;
        }

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
