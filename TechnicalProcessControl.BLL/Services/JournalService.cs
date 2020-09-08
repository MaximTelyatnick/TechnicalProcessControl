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
        private IRepository<OperationName> operationName;

        private IMapper mapper;

        public JournalService(IUnitOfWork uow)
        {
            Database = uow;

            drawings = Database.GetRepository<Drawings>();
            parentDrawings = Database.GetRepository<Drawings>();
            drawingScan = Database.GetRepository<DrawingScan>();
            materials = Database.GetRepository<Materials>();
            details = Database.GetRepository<Details>();
            operationName = Database.GetRepository<OperationName>();




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
                cfg.CreateMap<OperationName, OperationNameDTO>();
                cfg.CreateMap<OperationNameDTO, OperationName>();

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

        public IEnumerable<OperationNumberDTO> GetOperationNumber()
        {
            List<OperationNumberDTO> operationNumberList = new List<OperationNumberDTO>() {
            new OperationNumberDTO() { Id = 1, TableId = "SNO1", OperationNumber = "005"},
            new OperationNumberDTO() { Id = 2, TableId = "SNO2", OperationNumber = "010"},
            new OperationNumberDTO() { Id = 3, TableId = "SNO3", OperationNumber = "015"},
            new OperationNumberDTO() { Id = 4, TableId = "SNO4", OperationNumber = "020"},
            new OperationNumberDTO() { Id = 5, TableId = "SNO5", OperationNumber = "025"},
            new OperationNumberDTO() { Id = 6, TableId = "SNO6", OperationNumber = "030"},
            new OperationNumberDTO() { Id = 7, TableId = "SNO7", OperationNumber = "035"},
            new OperationNumberDTO() { Id = 8, TableId = "SNO8", OperationNumber = "040"},
            new OperationNumberDTO() { Id = 9, TableId = "SNO9", OperationNumber = "045"},
            new OperationNumberDTO() { Id = 10, TableId = "SNO10", OperationNumber = "050"},
            new OperationNumberDTO() { Id = 11, TableId = "SNO11", OperationNumber = "055"},
            new OperationNumberDTO() { Id = 12, TableId = "SNO12", OperationNumber = "060"},
            new OperationNumberDTO() { Id = 13, TableId = "SNO13", OperationNumber = "065"},
            new OperationNumberDTO() { Id = 14, TableId = "SNO14", OperationNumber = "070"},
            new OperationNumberDTO() { Id = 15, TableId = "SNO15", OperationNumber = "075"},
            new OperationNumberDTO() { Id = 16, TableId = "SNO16", OperationNumber = "080"},
            new OperationNumberDTO() { Id = 17, TableId = "SNO17", OperationNumber = "085"},
            new OperationNumberDTO() { Id = 18, TableId = "SNO18", OperationNumber = "090"},
            new OperationNumberDTO() { Id = 19, TableId = "SNO19", OperationNumber = "095"},
            };
               

            return operationNumberList;
        }

        public IEnumerable<OperationPaintMaterialDTO> GetOperationPaintMaterial()
        {
            List<OperationPaintMaterialDTO> operationPaintMaterialList = new List<OperationPaintMaterialDTO>() {
            new OperationPaintMaterialDTO() { Id = 1, Code = "PaM01", NameEng ="Priming", NameRus = "Грунт ", Type ="Kapci 880 2K Epoxy Primer"},
            new OperationPaintMaterialDTO() { Id = 2, Code = "PaM02", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci 881 Epoxy Hardener"},
            new OperationPaintMaterialDTO() { Id = 3, Code = "PaM03", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 881 Epoxy Thinner"},
            new OperationPaintMaterialDTO() { Id = 4, Code = "PaM04", NameEng ="Primer - enamel", NameRus = "Грунт- эмаль  ", Type ="Kapci 125 Structure Paint"},
            new OperationPaintMaterialDTO() { Id = 5, Code = "PaM05", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci 126 Hardener"},
            new OperationPaintMaterialDTO() { Id = 6, Code = "PaM06", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 2K Thinner 600 normal"},
            new OperationPaintMaterialDTO() { Id = 7, Code = "PaM07", NameEng ="Universal joint compound", NameRus = "Универсальный шовный герметик ", Type ="Sikaflex 527 AT"},
            new OperationPaintMaterialDTO() { Id = 8, Code = "PaM08", NameEng ="Acrylic filler", NameRus = "Акриловый наполнитель ", Type ="Kapci 633 2K HS Akrilic Filler"},
            new OperationPaintMaterialDTO() { Id = 9, Code = "PaM09", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci 2К MS Hardener 651 normal "},
            new OperationPaintMaterialDTO() { Id = 10, Code = "PaM10", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 2K Thinner 600 normal"},
            new OperationPaintMaterialDTO() { Id = 11, Code = "PaM11", NameEng ="Enamel", NameRus = "Эмаль ", Type ="Эмаль  Kapcicryl 641 2K Acrylik"},
            new OperationPaintMaterialDTO() { Id = 12, Code = "PaM12", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci 2К MS Hardener 651 normal "},
            new OperationPaintMaterialDTO() { Id = 13, Code = "PaM13", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 2K Thinner 600 normal"},
            new OperationPaintMaterialDTO() { Id = 14, Code = "PaM14", NameEng ="Enamel", NameRus = "Эмаль ", Type ="Эмаль  Kapcibase 670 Basecoat "},
            new OperationPaintMaterialDTO() { Id = 15, Code = "PaM15", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 2K Thinner 600 normal"},
            new OperationPaintMaterialDTO() { Id = 16, Code = "PaM16", NameEng ="Enamel", NameRus = "Эмаль  ", Type ="Kapci 6030 2K HS Clearcoat VOC Compliant"},
            new OperationPaintMaterialDTO() { Id = 17, Code = "PaM17", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci HS Hardener 6055 normal"},
            new OperationPaintMaterialDTO() { Id = 18, Code = "PaM18", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 2K Thinner 600 normal"},
            new OperationPaintMaterialDTO() { Id = 19, Code = "PaM19", NameEng ="Putty", NameRus = "Шпатлевка ", Type ="Kapci 350 PE Putty"},
            new OperationPaintMaterialDTO() { Id = 20, Code = "PaM20", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci PE Putty Hardener"}
            };


            return operationPaintMaterialList;
        }



        public bool CheckDetailName(DetailsDTO detailsDTO)
        {
            return details.GetAll().Any(srt => srt.DetailName == detailsDTO.DetailName && srt.Id!= detailsDTO.Id);
        }


        public bool CheckMaterialName(MaterialsDTO materialsDTO)
        {
            return materials.GetAll().Any(srt => srt.MaterialName == materialsDTO.MaterialName && srt.Id != materialsDTO.Id);
        }

        public IEnumerable<OperationNameDTO> GetOperationName()
        {
            return mapper.Map<IEnumerable<OperationName>, List<OperationNameDTO>>(operationName.GetAll());
        }

        public bool CheckOperationName(OperationNameDTO operationNameDTO)
        {
            return operationName.GetAll().Any(srt => srt.NameRus == operationNameDTO.NameRus && srt.Id != operationNameDTO.Id);
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

        #region OperationName's CRUD method's

        public int OperationNameCreate(OperationNameDTO operationNameDTO)
        {
            var createOperationName = operationName.Create(mapper.Map<OperationName>(operationNameDTO));
            return (int)createOperationName.Id;
        }

        public void OperationNameUpdate(OperationNameDTO operationNameDTO)
        {
            var updateOperationName = operationName.GetAll().SingleOrDefault(c => c.Id == operationNameDTO.Id);
            operationName.Update((mapper.Map<OperationNameDTO, OperationName>(operationNameDTO, updateOperationName)));
        }

        public bool OperationNameDelete(int id)
        {
            try
            {
                operationName.Delete(operationName.GetAll().FirstOrDefault(c => c.Id == id));
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
