using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.BLL.Interfaces
{
    public interface IReportService
    {
        string CreateTemplateTechProcess001(UsersDTO usersDTO, DrawingsDTO drawingsDTO, TechProcess001DTO techProcess001OldDTO = null, List<DrawingDTO> listParentDrawings = null);
        string UpdateTemplateTechProcess001(DrawingsDTO drawingsDTO);
        string ResaveFileTechProcess001(DrawingsDTO drawingsDTO, string fullPathExistingFile);

        string CreateTemplateTechProcess002(DrawingsDTO drawingsDTO);
        string UpdateTemplateTechProcess002(DrawingsDTO drawingsDTO);

        string CreateTemplateTechProcess003(DrawingsDTO drawingsDTO, List<DrawingsDTO> drawingsListDTO, TechProcess003DTO techProcess003OldDTO = null);

        void OpenExcelFile(string fullPath);

        string TechProcesNameToStr(long? techProcessName);

    }
}
