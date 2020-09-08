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

        IEnumerable<OperationNameDTO> GetOperationName();
        bool CheckOperationName(OperationNameDTO operationNameDTO);

        IEnumerable<OperationNumberDTO> GetOperationNumber();

        int MaterialsCreate(MaterialsDTO materialsDTO);
        void MaterialsUpdate(MaterialsDTO materialsDTO);
        bool MaterialsDelete(int id);

        int DetailCreate(DetailsDTO detailsDTO);
        void DetailsUpdate(DetailsDTO detailsDTO);
        bool DetailDelete(int id);

        int OperationNameCreate(OperationNameDTO operationNameDTO);
        void OperationNameUpdate(OperationNameDTO operationNameDTO);
        bool OperationNameDelete(int id);
    }
}
