using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.DAL.Interfaces;
using TechnicalProcessControl.DAL.Models;

namespace TechnicalProcessControl.BLL.Services
{
    public class JournalService : IJournalService
    {
        private IUnitOfWork Database { get; set; }

        private IRepository<Drawings> drawings;
        private IRepository<Drawings> parentDrawings;
        private IRepository<DrawingScan> drawingScan;
        private IRepository<Details> details;
        private IRepository<Materials> materials;

        private IMapper mapper;

        public JournalService(IUnitOfWork uow)
        {
            Database = uow;

            drawings = Database.GetRepository<Drawings>();
            parentDrawings = Database.GetRepository<Drawings>();
            drawingScan = Database.GetRepository<DrawingScan>();
            materials = Database.GetRepository<Materials>();
            details = Database.GetRepository<Details>();




            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Drawings, DrawingsDTO>();
                cfg.CreateMap<DrawingsDTO, Drawings>();
                cfg.CreateMap<DrawingScan, DrawingScanDTO>();
                cfg.CreateMap<DrawingScanDTO, DrawingScan>();
                cfg.CreateMap<Details, DetailsDTO>();
                cfg.CreateMap<DetailsDTO, Details>();
                cfg.CreateMap<Materials, MaterialsDTO>();
                cfg.CreateMap<MaterialsDTO, Materials>();

            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<DetailsDTO> GetDetails()
        {
            return mapper.Map<IEnumerable<Details>, List<DetailsDTO>>(details.GetAll());
        }

        

        public IEnumerable<MaterialsDTO> GetMaterials()
        {
            return mapper.Map<IEnumerable<Materials>, List<MaterialsDTO>>(materials.GetAll());
        }

        public bool CheckDetailName(DetailsDTO detailsDTO)
        {
            return details.GetAll().Any(srt => srt.DetailName == detailsDTO.DetailName && srt.Id!= detailsDTO.Id);
        }


        public bool CheckMaterialName(MaterialsDTO materialsDTO)
        {
            return materials.GetAll().Any(srt => srt.MaterialName == materialsDTO.MaterialName && srt.Id != materialsDTO.Id);
        }

        #region Materials CRUD method's

        public int MaterialsCreate(MaterialsDTO materialsDTO)
        {
            var createMaterials = materials.Create(mapper.Map<Materials>(materialsDTO));
            return (int)createMaterials.Id;
        }

        public void MaterialsUpdate(MaterialsDTO materialsDTO)
        {
            var updateMaterials = materials.GetAll().SingleOrDefault(c => c.Id == materialsDTO.Id);
            materials.Update((mapper.Map<MaterialsDTO, Materials>(materialsDTO, updateMaterials)));
        }

        public bool MaterialsDelete(int id)
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

        #region Detail's CRUD method's

        public int DetailCreate(DetailsDTO detailsDTO)
        {
            var createDetail = details.Create(mapper.Map<Details>(detailsDTO));
            return (int)createDetail.Id;
        }

        public void DetailsUpdate(DetailsDTO detailsDTO)
        {
            var updateDetail = details.GetAll().SingleOrDefault(c => c.Id == detailsDTO.Id);
            details.Update((mapper.Map<DetailsDTO, Details>(detailsDTO, updateDetail)));
        }

        public bool DetailDelete(int id)
        {
            try
            {
                details.Delete(details.GetAll().FirstOrDefault(c => c.Id == id));
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
