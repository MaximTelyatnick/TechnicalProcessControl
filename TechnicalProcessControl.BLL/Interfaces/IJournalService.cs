using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.BLL.Interfaces
{
    public interface IJournalService
    {
        IEnumerable<DetailsDTO> GetDetails();
        IEnumerable<MaterialsDTO> GetMaterials();

        bool CheckDetailName(DetailsDTO detailName);
        bool CheckMaterialName(MaterialsDTO materialName);
        bool CheckOperationPaintMaterial(OperationPaintMaterialDTO operationPaintMaterialDTO);

        IEnumerable<OperationNameDTO> GetOperationName();
        bool CheckOperationName(OperationNameDTO operationNameDTO);

        IEnumerable<OperationNumberDTO> GetOperationNumber();
        bool CheckOperationNumber(OperationNumberDTO operationNumberDTO);

        IEnumerable<OperationPaintMaterialDTO> GetOperationPaintMaterial();

        int MaterialsCreate(MaterialsDTO materialsDTO);
        void MaterialsUpdate(MaterialsDTO materialsDTO);
        bool MaterialsDelete(int id);

        int DetailCreate(DetailsDTO detailsDTO);
        void DetailsUpdate(DetailsDTO detailsDTO);
        bool DetailDelete(int id);

        int OperationNameCreate(OperationNameDTO operationNameDTO);
        void OperationNameUpdate(OperationNameDTO operationNameDTO);
        bool OperationNameDelete(int id);

        int OperationNumberCreate(OperationNumberDTO operationNumberDTO);
        void OperationNumberUpdate(OperationNumberDTO operationNumberDTO);
        bool OperationNumberDelete(int id);

        int OperationPaintMaterialCreate(OperationPaintMaterialDTO operationPaintMaterialDTO);
        void OperationPaintMaterialUpdate(OperationPaintMaterialDTO operationPaintMaterialDTO);
        bool OperationPaintMaterialDelete(int id);
    }
}
