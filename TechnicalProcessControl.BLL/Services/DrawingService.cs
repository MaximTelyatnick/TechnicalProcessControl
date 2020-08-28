using AutoMapper;
using System;
using System.Collections.Generic;
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

        private IMapper mapper;

        public DrawingService(IUnitOfWork uow)
        {
            Database = uow;

            drawings = Database.GetRepository<Drawings>();
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
            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<DrawingsDTO> GetAllDrawings()
        {
            var result = (from drw in drawings.GetAll()
                          join dr in drawing.GetAll() on drw.DrawingId equals dr.Id into drr
                          from dr in drr.DefaultIfEmpty()
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
                              ScanId = drws.Id>0 ? 1 : 0,
                              ParentName = drp.Number != "" ? drp.Number : dr.Number

                          }
                            ).ToList();

       

            //result.GroupBy(x => x.Id).Select(y => y.First());


            return result.GroupBy(x => x.Id).Select(y => y.First()).ToList();
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
                              Quantity = drw.Quantity,
                              QuantityL = drw.QuantityL,
                              QuantityR = drw.QuantityR,
                              TH = drw.TH,
                              L = drw.L,
                              W = drw.W,
                              W2 = drw.W2,
                              DetailWeight = drw.DetailWeight,
                          }
                          ).ToList();

            return result;
        }


        public IEnumerable<DrawingsDTO> GetShortDrawing()
        {
            return mapper.Map<IEnumerable<Drawings>, List<DrawingsDTO>>(drawings.GetAll());
        }

        public IEnumerable<TypeDTO> GetType()
        {
            return mapper.Map<IEnumerable<DAL.Models.Type>, List<TypeDTO>>(type.GetAll());
        }

        

        /*public DrawingScanDTO GetDrawingScanById(int DrawingId)
        {
            return mapper.Map<DrawingScan, DrawingScanDTO>(drawingScan.GetAll().FirstOrDefault(s => s.DrawingId == DrawingId && s.Status == null));
        }*/

        public bool CheckTechProcess001(string techProcesName)
        {      
            return techProcess001.GetAll().Any(chk => chk.TechProcessFullName == techProcesName);
        }

        public long GetLastTechProcess001()
        {
            long maxValue = techProcess001.GetAll().Where(srt => srt.TechProcessName < 200000000).Select(bdsm => bdsm.TechProcessName).Max();
            ++maxValue;
            return maxValue;
        }

        public long GetLastTechProcess002()
        {
            long maxValue = techProcess002.GetAll().Select(bdsm => bdsm.TechProcessName).Max();
            ++maxValue;
            return maxValue;
        }

        public IEnumerable<DrawingScanDTO> GetDravingScanById(int drawingId)
        {
            return mapper.Map<IEnumerable<DrawingScan>, List<DrawingScanDTO>>(drawingScan.GetAll().Where(bdsm => bdsm.DrawingId == drawingId));
        }

        public IEnumerable<TechProcess001DTO> GetAllTechProcess001()
        {
            return mapper.Map<IEnumerable<TechProcess001>, List<TechProcess001DTO>>(techProcess001.GetAll());
        }

        public IEnumerable<TechProcess002DTO> GetAllTechProcess002()
        {
            return mapper.Map<IEnumerable<TechProcess002>, List<TechProcess002DTO>>(techProcess002.GetAll());
        }

        public IEnumerable<TechProcess003DTO> GetAllTechProcess003()
        {
            return mapper.Map<IEnumerable<TechProcess003>, List<TechProcess003DTO>>(techProcess003.GetAll());
        }

        public IEnumerable<TechProcess004DTO> GetAllTechProcess004()
        {
            return mapper.Map<IEnumerable<TechProcess004>, List<TechProcess004DTO>>(techProcess004.GetAll());
        }

        public IEnumerable<TechProcess005DTO> GetAllTechProcess005()
        {
            return mapper.Map<IEnumerable<TechProcess005>, List<TechProcess005DTO>>(techProcess005.GetAll());
        }

        public string GetParentName(int parentId)
        {
            var parentDravingId = drawings.GetAll().First(bdsm => bdsm.Id == parentId).DrawingId;

            return drawing.GetAll().First(bdsm => bdsm.Id == parentDravingId).Number;
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

        public bool RouteDelete(int id)
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

        public void DrawingUpdate(DrawingDTO drawingDTO)
        {
            var updateDrawing = drawing.GetAll().SingleOrDefault(c => c.Id == drawingDTO.Id);
            drawing.Update((mapper.Map<DrawingDTO, Drawing>(drawingDTO, updateDrawing)));
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
