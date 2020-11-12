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
        string CreateTemplateTechProcess001Exp(UsersDTO usersDTO, DrawingDTO techProces001Drawing, List<DrawingDTO> techProcess001DrawingParent, List<TechProcess001DTO> techProcess001Revision, TechProcess001DTO techProcess001, TechProcess001DTO techProcess001Old = null);
        string UpdateTemplateTechProcess001(DrawingsDTO drawingsDTO);
        string ResaveFileTechProcess001(TechProcess001DTO techProcess001, string fullPathExistingFile);

        

        string CreateTemplateTechProcess002(DrawingsDTO drawingsDTO);
        string CreateTemplateTechProcess002Exp(UsersDTO usersDTO, DrawingDTO techProces002Drawing, List<DrawingDTO> techProcess002DrawingParent, List<TechProcess002DTO> techProcess002Revision, TechProcess002DTO techProcess002, TechProcess002DTO techProcess002Old = null);
        string UpdateTemplateTechProcess002(DrawingsDTO drawingsDTO);
        string ResaveFileTechProcess002(TechProcess002DTO techProcess002, string fullPathExistingFile);


        string CreateTemplateTechProcess003Exp(UsersDTO usersDTO, DrawingDTO techProces003Drawing, List<DrawingDTO> techProcess003DrawingParent, List<TechProcess003DTO> techProcess003Revision, TechProcess003DTO techProcess003, TechProcess003DTO techProcess003Old = null);
        string CreateTemplateTechProcess003(DrawingsDTO drawingsDTO, List<DrawingsDTO> drawingsListDTO, TechProcess003DTO techProcess003OldDTO = null);
        string ResaveFileTechProcess003(TechProcess003DTO techProcess003, string fullPathExistingFile);

        void OpenExcelFile(string fullPath);

        string TechProcesNameToStr(long? techProcessName);

    }
}
