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
        private IRepository<OperationNumber> operationNumber;
        private IRepository<OperationPaintMaterial> operationPaintMaterial;
        private IRepository<Colors> colors;

        private IMapper mapper;

        public JournalService(IUnitOfWork uow)
        {
            Database = uow;

            colors = Database.GetRepository<Colors>();
            drawings = Database.GetRepository<Drawings>();
            parentDrawings = Database.GetRepository<Drawings>();
            drawingScan = Database.GetRepository<DrawingScan>();
            materials = Database.GetRepository<Materials>();
            details = Database.GetRepository<Details>();
            operationName = Database.GetRepository<OperationName>();
            operationNumber = Database.GetRepository<OperationNumber>();
            operationPaintMaterial = Database.GetRepository<OperationPaintMaterial>();



            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Colors, ColorsDTO>();
                cfg.CreateMap<ColorsDTO, Colors>();
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
                cfg.CreateMap<OperationNumber, OperationNumberDTO>();
                cfg.CreateMap<OperationNumberDTO, OperationNumber>();
                cfg.CreateMap<OperationPaintMaterial, OperationPaintMaterialDTO>();
                cfg.CreateMap<OperationPaintMaterialDTO, OperationPaintMaterial>();

            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<DetailsDTO> GetDetails()
        {
            return mapper.Map<IEnumerable<Details>, List<DetailsDTO>>(details.GetAll());
        }

        public IEnumerable<ColorsDTO> GetColors()
        {
            return mapper.Map<IEnumerable<Colors>, List<ColorsDTO>>(colors.GetAll());
        }

        public IEnumerable<MaterialsDTO> GetMaterials()
        {
            return mapper.Map<IEnumerable<Materials>, List<MaterialsDTO>>(materials.GetAll());
        }

        public IEnumerable<OperationNumberDTO> GetOperationNumber()
        {
            return mapper.Map<IEnumerable<OperationNumber>, List<OperationNumberDTO>>(operationNumber.GetAll());
        }

        public bool CheckMaterialName(MaterialsDTO materialsDTO)
        {
            return materials.GetAll().Any(srt => srt.MaterialName == materialsDTO.MaterialName && srt.Id != materialsDTO.Id);
        }

        public IEnumerable<OperationPaintMaterialDTO> GetOperationPaintMaterial()
        {


            //List<OperationPaintMaterialDTO> operationPaintMaterialList = new List<OperationPaintMaterialDTO>() {
            //new OperationPaintMaterialDTO() { Id = 1, Code = "PaM01", NameEng ="Priming", NameRus = "Грунт ", Type ="Kapci 880 2K Epoxy Primer"},
            //new OperationPaintMaterialDTO() { Id = 2, Code = "PaM02", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci 881 Epoxy Hardener"},
            //new OperationPaintMaterialDTO() { Id = 3, Code = "PaM03", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 881 Epoxy Thinner"},
            //new OperationPaintMaterialDTO() { Id = 4, Code = "PaM04", NameEng ="Primer - enamel", NameRus = "Грунт- эмаль  ", Type ="Kapci 125 Structure Paint"},
            //new OperationPaintMaterialDTO() { Id = 5, Code = "PaM05", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci 126 Hardener"},
            //new OperationPaintMaterialDTO() { Id = 6, Code = "PaM06", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 2K Thinner 600 normal"},
            //new OperationPaintMaterialDTO() { Id = 7, Code = "PaM07", NameEng ="Universal joint compound", NameRus = "Универсальный шовный герметик ", Type ="Sikaflex 527 AT"},
            //new OperationPaintMaterialDTO() { Id = 8, Code = "PaM08", NameEng ="Acrylic filler", NameRus = "Акриловый наполнитель ", Type ="Kapci 633 2K HS Akrilic Filler"},
            //new OperationPaintMaterialDTO() { Id = 9, Code = "PaM09", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci 2К MS Hardener 651 normal "},
            //new OperationPaintMaterialDTO() { Id = 10, Code = "PaM10", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 2K Thinner 600 normal"},
            //new OperationPaintMaterialDTO() { Id = 11, Code = "PaM11", NameEng ="Enamel", NameRus = "Эмаль ", Type ="Эмаль  Kapcicryl 641 2K Acrylik"},
            //new OperationPaintMaterialDTO() { Id = 12, Code = "PaM12", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci 2К MS Hardener 651 normal "},
            //new OperationPaintMaterialDTO() { Id = 13, Code = "PaM13", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 2K Thinner 600 normal"},
            //new OperationPaintMaterialDTO() { Id = 14, Code = "PaM14", NameEng ="Enamel", NameRus = "Эмаль ", Type ="Эмаль  Kapcibase 670 Basecoat "},
            //new OperationPaintMaterialDTO() { Id = 15, Code = "PaM15", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 2K Thinner 600 normal"},
            //new OperationPaintMaterialDTO() { Id = 16, Code = "PaM16", NameEng ="Enamel", NameRus = "Эмаль  ", Type ="Kapci 6030 2K HS Clearcoat VOC Compliant"},
            //new OperationPaintMaterialDTO() { Id = 17, Code = "PaM17", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci HS Hardener 6055 normal"},
            //new OperationPaintMaterialDTO() { Id = 18, Code = "PaM18", NameEng ="Diluent", NameRus = "Разбавитель ", Type ="Kapci 2K Thinner 600 normal"},
            //new OperationPaintMaterialDTO() { Id = 19, Code = "PaM19", NameEng ="Putty", NameRus = "Шпатлевка ", Type ="Kapci 350 PE Putty"},
            //new OperationPaintMaterialDTO() { Id = 20, Code = "PaM20", NameEng ="Hardener", NameRus = "Отвердитель ", Type ="Kapci PE Putty Hardener"}
            //};


            return mapper.Map<IEnumerable<OperationPaintMaterial>, List<OperationPaintMaterialDTO>>(operationPaintMaterial.GetAll());
        }



        public bool CheckDetailName(DetailsDTO detailsDTO)
        {
            return details.GetAll().Any(srt => srt.DetailName == detailsDTO.DetailName && srt.Id!= detailsDTO.Id);
        }


        

        public IEnumerable<OperationNameDTO> GetOperationName()
        {
            return mapper.Map<IEnumerable<OperationName>, List<OperationNameDTO>>(operationName.GetAll());
        }

        public bool CheckOperationName(OperationNameDTO operationNameDTO)
        {
            return operationName.GetAll().Any(srt => srt.NameRus == operationNameDTO.NameRus && srt.Id != operationNameDTO.Id);
        }

        public bool CheckOperationNumber(OperationNumberDTO operationNumberDTO)
        {
            return operationNumber.GetAll().Any(srt => srt.TableId == operationNumberDTO.TableId && srt.Id != operationNumberDTO.Id);
        }

        public bool CheckOperationPaintMaterial(OperationPaintMaterialDTO operationPaintMaterialDTO)
        {
            return operationPaintMaterial.GetAll().Any(srt => srt.Code == operationPaintMaterialDTO.Code && srt.Id != operationPaintMaterialDTO.Id);
        }

        #region Materials CRUD method's

        public int? CheckMaterial(string materiallName)
        {
            var checkMaterial = materials.GetAll().SingleOrDefault(c => c.MaterialName == materiallName);
            return checkMaterial.Id;
        }

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
                materials.Delete(materials.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Detail's CRUD method's

        public int? CheckDetail(string detailName)
        {
            var checkDetail = details.GetAll().SingleOrDefault(c => c.DetailName== detailName);
            return checkDetail.Id;
        }

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

        #region OperationNumber's CRUD method's

        public int OperationNumberCreate(OperationNumberDTO operationNumberDTO)
        {
            var createOperationNumber = operationNumber.Create(mapper.Map<OperationNumber>(operationNumberDTO));
            return (int)createOperationNumber.Id;
        }

        public void OperationNumberUpdate(OperationNumberDTO operationNumberDTO)
        {
            var updateOperationNumber = operationNumber.GetAll().SingleOrDefault(c => c.Id == operationNumberDTO.Id);
            operationNumber.Update((mapper.Map<OperationNumberDTO, OperationNumber>(operationNumberDTO, updateOperationNumber)));
        }

        public bool OperationNumberDelete(int id)
        {
            try
            {
                operationNumber.Delete(operationNumber.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region OperationMaterialName's CRUD method's

        public int OperationPaintMaterialCreate(OperationPaintMaterialDTO operationPaintMaterialDTO)
        {
            var createOperationPaintMaterial = operationPaintMaterial.Create(mapper.Map<OperationPaintMaterial>(operationPaintMaterialDTO));
            return (int)createOperationPaintMaterial.Id;
        }

        public void OperationPaintMaterialUpdate(OperationPaintMaterialDTO operationPaintMaterialDTO)
        {
            var updateOperationPaintMaterial = operationPaintMaterial.GetAll().SingleOrDefault(c => c.Id == operationPaintMaterialDTO.Id);
            operationPaintMaterial.Update((mapper.Map<OperationPaintMaterialDTO, OperationPaintMaterial>(operationPaintMaterialDTO, updateOperationPaintMaterial)));
        }

        public bool OperationPaintMaterialDelete(int id)
        {
            try
            {
                operationPaintMaterial.Delete(operationPaintMaterial.GetAll().FirstOrDefault(c => c.Id == id));
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
