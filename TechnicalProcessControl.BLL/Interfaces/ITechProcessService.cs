using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.BLL.Interfaces
{
    public interface ITechProcessService
    {
        #region TechProcess001 method's

        //получить все техпроцессы 001 по айди техпроцесса с краткой информацией ok
        IEnumerable<TechProcess001DTO> GetAllTechProcess001Simple();

        //получить техпроцесс 001 по айди техпроцесса с подробной информацией   ok
        TechProcess001DTO GetTechProcess001ByIdFull(int techProcess001Id);

        //получить техпроцесс 001 по айди техпроцесса с краткой информацией   ok
        TechProcess001DTO GetTechProcess001Simple(int techProcess001Id);

        //получить ревизию техпроцесса 001 по айди техпроцесса с краткой информацией ok
        TechProcess001DTO GetTechProcess001RevisionByIdSimple(int techProcess001Id);

        //получить ревизию техпроцесса 001 по айди техпроцесса с подробной информацией ok
        TechProcess001DTO GetTechProcess001RevisionByIdFull(int techProcess001Id);


        //получить актуальный техпроцесс 001 по айди чертежа  с подробной информацией (материалы и трудоёмкость)
        TechProcess001DTO GetTechProcess001ByDrawingId(int drawingId);

        //получить все техпроцессы 001 и их ревизии с подробной информацией (без материалов и трудоёмкости)
        IEnumerable<TechProcess001DTO> GetAllTechProcess001();

        //получить только актуальные техпроцессы 001 без ревизий с подробной информацией
        IEnumerable<TechProcess001DTO> GetAllTechProcessActual001();

        //проверить наличие техпроцесса 001 по его номеру ok
        bool CheckTechProcess001(long techProcesName);

        //получить номер техпроцесса 001 которого еще не существует в базе (максимальный + 1) ok
        long GetLastTechProcess001();

        // получить ревизии техпроцесса 001 по Id родителя ok
        IEnumerable<TechProcess001DTO> GetAllTechProcess001Revision(int techProcessId);

        List<TechProcess001DTO> TechProcess001Revision(TechProcess001DTO techProcess001, List<TechProcess001DTO> alltechProcessRevision);

        // получить  ревизии техпроцесса 001 + актуальный по Id 
        IEnumerable<TechProcess001DTO> GetAllTechProcess001RevisionWithActualTechprocess(int techProcessId);

        bool CheckTechProcess001Drawing(int drawingId);

        #endregion

        #region TechProcess002 method's

        //получить все техпроцессы 002 по айди техпроцесса с краткой информацией ok
        IEnumerable<TechProcess002DTO> GetAllTechProcess002Simple();

        //получить техпроцесс 002 по айди техпроцесса с подробной информацией   ok
        TechProcess002DTO GetTechProcess002ByIdFull(int techProcess002Id);

        //получить техпроцесс 002 по айди техпроцесса с краткой информацией   ok
        TechProcess002DTO GetTechProcess002Simple(int techProcess002Id);
        

        //получить ревизию техпроцесса 002 по айди техпроцесса с краткой информацией ok
        TechProcess002DTO GetTechProcess002RevisionByIdSimple(int techProcess002Id);
        
        //получить ревизию техпроцесса 002 по айди техпроцесса с подробной информацией ok
        TechProcess002DTO GetTechProcess002RevisionByIdFull(int techProcess002Id);


        //получить актуальный техпроцесс 002 по айди чертежа  с подробной информацией (материалы и трудоёмкость)
        TechProcess002DTO GetTechProcess002ByDrawingId(int drawingId);

        //получить все техпроцессы 001 и их ревизии с подробной информацией (без материалов и трудоёмкости)
        IEnumerable<TechProcess002DTO> GetAllTechProcess002();

        //получить только актуальные техпроцессы 002 без ревизий с подробной информацией
        IEnumerable<TechProcess002DTO> GetAllTechProcessActual002();
        
        //проверить наличие техпроцесса 002 по его номеру ok
        bool CheckTechProcess002(long techProcesName);
        
        //получить номер техпроцесса 002 которого еще не существует в базе (максимальный + 1) ok
        long GetLastTechProcess002();

        // получить ревизии техпроцесса 002 по Id родителя ok
        IEnumerable<TechProcess002DTO> GetAllTechProcess002Revision(int techProcessId);

        // получить  ревизии техпроцесса 002 + актуальный по Id 
        IEnumerable<TechProcess002DTO> GetAllTechProcess002RevisionWithActualTechprocess(int techProcessId);

        bool CheckTechProcess002Drawing(int drawingId);

        #endregion

        #region TechProcess003 method's

        //получить актуальный техпроцесс 003 по айди чертежа  с подробной информацией (материалы и трудоёмкость)
        TechProcess003DTO GetTechProcess003ByDrawingId(int drawingId);

        //получить номер техпроцесса 003 которого еще не существует в базе (максимальный + 1) ok
        long GetLastTechProcess003();

        //проверить наличие техпроцесса 003 по его номеру ok
        bool CheckTechProcess003(long techProcesName);

        //получить все техпроцессы 003 по айди техпроцесса с краткой информацией ok
        IEnumerable<TechProcess003DTO> GetAllTechProcess003Simple();

        bool CheckTechProcess003Drawing(int drawingId);

        IEnumerable<TechProcess003DTO> GetAllTechProcess003();
        #endregion

        #region TechProcess004 method's

        //получить актуальный техпроцесс 004 по айди чертежа  с подробной информацией (материалы и трудоёмкость)
        TechProcess004DTO GetTechProcess004ByDrawingId(int drawingId);

        //получить номер техпроцесса 004 которого еще не существует в базе (максимальный + 1) ok
        long GetLastTechProcess004();

        //проверить наличие техпроцесса 004 по его номеру ok
        bool CheckTechProcess004(long techProcesName);

        //получить все техпроцессы 004 по айди техпроцесса с краткой информацией ok
        IEnumerable<TechProcess004DTO> GetAllTechProcess004Simple();

        bool CheckTechProcess004Drawing(int drawingId);

        IEnumerable<TechProcess004DTO> GetAllTechProcess004();

        #endregion

        #region TechProcess005 method's

        //получить актуальный техпроцесс 005 по айди чертежа  с подробной информацией (материалы и трудоёмкость)
        TechProcess005DTO GetTechProcess005ByDrawingId(int drawingId);

        //получить номер техпроцесса 005 которого еще не существует в базе (максимальный + 1) ok
        long GetLastTechProcess005();

        //проверить наличие техпроцесса 005 по его номеру ok
        bool CheckTechProcess005(long techProcesName);

        //получить все техпроцессы 005 по айди техпроцесса с краткой информацией ok
        IEnumerable<TechProcess005DTO> GetAllTechProcess005Simple();

        bool CheckTechProcess005Drawing(int drawingId);

        //получить ревизию техпроцесса 005 по айди техпроцесса с подробной информацией ok
        TechProcess005DTO GetTechProcess005RevisionByIdFull(int techProcess005Id);

        IEnumerable<TechProcess005DTO> GetAllTechProcess005();

        IEnumerable<TechProcess005DTO> GetAllTechProcess005Revision(int techProcessId);

        List<TechProcess005DTO> TechProcess005Revision(TechProcess005DTO techProcess005, List<TechProcess005DTO> alltechProcessRevision);

        #endregion

        string ResaveFileTechProcess(string techProcesspath, string fullPathExistingFile);
        bool FileDelete(string URI);

        #region TechProcess001CRUD

        int TechProcess001Create(TechProcess001DTO techProcess001DTO);
        void TechProcess001Update(TechProcess001DTO techProcess001DTO);
        bool TechProcess001Delete(int id);

        #endregion

        #region TechProcess002CRUD

        int TechProcess002Create(TechProcess002DTO techProcess002DTO);

        void TechProcess002Update(TechProcess002DTO techProcess002DTO);

        bool TechProcess002Delete(int id);


        #endregion

        #region TechProcess003CRUD

        int TechProcess003Create(TechProcess003DTO techProcess003DTO);

        void TechProcess003Update(TechProcess003DTO techProcess003DTO);

        bool TechProcess003Delete(int id);


        #endregion

        #region TechProcess004CRUD

        int TechProcess004Create(TechProcess004DTO techProcess004DTO);

        void TechProcess004Update(TechProcess004DTO techProcess004DTO);

        bool TechProcess004Delete(int id);


        #endregion

        #region TechProcess005CRUD

        int TechProcess005Create(TechProcess005DTO techProcess005DTO);

        void TechProcess005Update(TechProcess005DTO techProcess005DTO);

        bool TechProcess005Delete(int id);


        #endregion


    }
}
