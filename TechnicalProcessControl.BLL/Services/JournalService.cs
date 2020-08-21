using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.DAL.Interfaces;
using TechnicalProcessControl.DAL.Models;

namespace TechnicalProcessControl.BLL.Services
{
    public class JournalService
    {
        //private IUnitOfWork Database { get; set; }

        //private IRepository<Drawings> drawings;
        //private IRepository<Drawings> parentDrawings;
        //private IRepository<DrawingScan> drawingScan;
        //private IRepository<Details> details;
        //private IRepository<DAL.Models.Type> type;
        //private IRepository<TechProcess001> techProcess001;
        //private IRepository<TechProcess002> techProcess002;
        //private IRepository<TechProcess003> techProcess003;
        //private IRepository<TechProcess004> techProcess004;
        //private IRepository<TechProcess005> techProcess005;

        //private IMapper mapper;

        //public DrawingService(IUnitOfWork uow)
        //{
        //    Database = uow;

        //    drawings = Database.GetRepository<Drawings>();
        //    parentDrawings = Database.GetRepository<Drawings>();
        //    drawingScan = Database.GetRepository<DrawingScan>();
        //    details = Database.GetRepository<Details>();
        //    type = Database.GetRepository<DAL.Models.Type>();
        //    techProcess001 = Database.GetRepository<TechProcess001>();
        //    techProcess002 = Database.GetRepository<TechProcess002>();
        //    techProcess003 = Database.GetRepository<TechProcess003>();
        //    techProcess004 = Database.GetRepository<TechProcess004>();
        //    techProcess005 = Database.GetRepository<TechProcess005>();


        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<Drawings, DrawingsDTO>();
        //        cfg.CreateMap<DrawingsDTO, Drawings>();
        //        cfg.CreateMap<DrawingScan, DrawingScanDTO>();
        //        cfg.CreateMap<DrawingScanDTO, DrawingScan>();
        //        cfg.CreateMap<Details, DetailsDTO>();
        //        cfg.CreateMap<DetailsDTO, Details>();
        //        cfg.CreateMap<DAL.Models.Type, TypeDTO>();
        //        cfg.CreateMap<TypeDTO, DAL.Models.Type>();
        //        cfg.CreateMap<Details, DetailsDTO>();
        //        cfg.CreateMap<DetailsDTO, Details>();
        //        cfg.CreateMap<TechProcess001, TechProcess001DTO>();
        //        cfg.CreateMap<TechProcess001DTO, TechProcess001>();
        //        cfg.CreateMap<TechProcess002, TechProcess002DTO>();
        //        cfg.CreateMap<TechProcess002DTO, TechProcess002>();
        //        cfg.CreateMap<TechProcess003, TechProcess003DTO>();
        //        cfg.CreateMap<TechProcess003DTO, TechProcess003>();
        //        cfg.CreateMap<TechProcess004, TechProcess004DTO>();
        //        cfg.CreateMap<TechProcess004DTO, TechProcess004>();
        //        cfg.CreateMap<TechProcess005, TechProcess005DTO>();
        //        cfg.CreateMap<TechProcess005DTO, TechProcess005>();

        //    });

        //    mapper = config.CreateMapper();
        //}

    }
}
