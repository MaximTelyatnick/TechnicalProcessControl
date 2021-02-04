using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.BLL.Interfaces
{
    public interface IDrawingService
    {
        bool FindDublicateDrawing(DrawingDTO drawingDTO);

        IEnumerable<DrawingsDTO> GetAllDrawings();
        IEnumerable<DrawingsDTO> GetAllDrawingsWithoutMaterials();
        IEnumerable<DrawingsDTO> GetAllDrawingsWithLaborIntensity();
        IEnumerable<DrawingsInfoDTO> GetAllDrawingsProc();
        IEnumerable<TestDTO> TestProc();

        IEnumerable<DrawingDTO> GetAllDrawingActual();
        IEnumerable<DrawingsDTO> GetAllDrawingsByDrawingId(int drawingId);
        IEnumerable<DrawingsDTO> GetAllDrawingsByDrawingIdForDrawingRevisionProcess(int drawingId);

        IEnumerable<DrawingsDTO> GetDrawingsSimple();

        DrawingDTO GetDrawingByName(string drawingName);


        IEnumerable<TypeDTO> GetType();

        IEnumerable<DrawingScanDTO> GetDrawingScan();
        IEnumerable<DrawingScanDTO> GetDrawingScanWithaoutScan();
        IEnumerable<DrawingScanDTO> GetDrawingScanWithDrawingNumber();
        DrawingScanDTO GetDrawingScanById(int scanId);
        IEnumerable<DrawingScanDTO> GetDrawingScanByDrawingId(int drawingId);

        //IEnumerable<DetailsDTO> GetDetails();

        //DrawingScanDTO GetDrawingScanById(int DrawingId);
        string GetParentName(int parentId);

        bool CheckStructuraName(DrawingsDTO drawingsDTO);

        IEnumerable<DrawingDTO> GetDrawingParentByDrawingChildId(int drawingId);

        IEnumerable<DrawingScanDTO> GetDravingScanById(int? drawingId);
        IEnumerable<DrawingsDTO> GetChildDrawings(DrawingsDTO drawingsDTO);

        string GetMaxStructuraNumber(int fatherStructura);

        DrawingDTO GetDrawingChildByParentId(int drawingId);

        IEnumerable<RevisionsDTO> GetRevisions();

        DrawingsDTO GetDrawingsByStructuraId(int structuraId);

        DrawingDTO GetDrawingById(int drawingId);

        IEnumerable<DrawingsDTO> ReplaceDrawingIdInStructura(int replaceDrawingId, int currentDrawingId);

        bool CheckTechProcess001(long techProcesName);
        bool CheckTechProcess002(long techProcesName);
        bool CheckTechProcess003(long techProcesName);
        long GetLastTechProcess001();
        long GetLastTechProcess002();
        long GetLastTechProcess003();

        TechProcess001DTO GetTechProcess001ByIdFull(int techProcess001Id);
        TechProcess001DTO GetTechProcess001Simple(int techProcess001Id);
        TechProcess001DTO GetTechProcess001RevisionByIdFull(int techProcess001Id);
        TechProcess001DTO GetTechProcess001RevisionByIdSimple(int techProcess001Id);


        IEnumerable<TechProcess001DTO> GetAllTechProcess001Revision(int techProcessId);
        //IEnumerable<TechProcess001DTO> GetAllTechProcess001RevisionSetActive(int techProcessId, bool setActive);
        IEnumerable<TechProcess001DTO> GetAllTechProcess001RevisionWithActualTechprocess(int techProcessId);
        IEnumerable<TechProcess001DTO> GetAllTechProcess001();        
        IEnumerable<TechProcess001DTO> GetAllTechProcessActual001();

        TechProcess002DTO GetTechProcess002ByIdFull(int techProcess002Id);
        IEnumerable<TechProcess002DTO> GetAllTechProcess002Simple();
        TechProcess002DTO GetTechProcess002RevisionByIdFull(int techProcess002Id);

        IEnumerable<TechProcess002DTO> GetAllTechProcess002Revision(int techProcessId);
        IEnumerable<TechProcess002DTO> GetAllTechProcess002RevisionWithActualTechprocess(int techProcessId);
        IEnumerable<TechProcess002DTO> GetAllTechProcess002();
        IEnumerable<TechProcess002DTO> GetAllTechProcessActual002();



        TechProcess003DTO GetTechProcess003ByIdFull(int techProcess003Id);

        IEnumerable<TechProcess003DTO> GetAllTechProcess003();

        IEnumerable<TechProcess003DTO> GetAllTechProcessActual003();

        IEnumerable<TechProcess003DTO> GetAllTechProcess003Revision(int techProcessId);

        List<TechProcess003DTO> TechProcess003Revision(TechProcess003DTO techProcess003, List<TechProcess003DTO> alltechProcessRevision);

        TechProcess003DTO GetTechProcess003RevisionByIdFull(int techProcess003Id);

        //получить техпроцесс 003 по айди техпроцесса с краткой информацией
        TechProcess003DTO GetTechProcess003Simple(int techProcess003Id);
        //получить техпроцесс 003 по айди техпроцесса с краткой информацией
        IEnumerable<TechProcess003DTO> GetAllTechProcess003Simple();
        // получить  ревизии техпроцесса 003 + актуальный по Id 
        IEnumerable<TechProcess003DTO> GetAllTechProcess003RevisionWithActualTechprocess(int techProcessId);



        //IEnumerable<TechProcess003DTO> GetAllTechProcess003();
        //IEnumerable<TechProcess003DTO> GetAllTechProcessActual003();

        //получить техпроцесс 004 по айди техпроцесса с подробной информацией
        TechProcess004DTO GetTechProcess004ByIdFull(int techProcess004Id);
        IEnumerable<TechProcess004DTO> GetAllTechProcess004();
        IEnumerable<TechProcess004DTO> GetAllTechProcessActual004();
        //получить техпроцесс 004 по айди техпроцесса с краткой информацией
        TechProcess004DTO GetTechProcess004Simple(int techProcess004Id);
        // получить  ревизии техпроцесса 004 + актуальный по Id 
        IEnumerable<TechProcess004DTO> GetAllTechProcess004RevisionWithActualTechprocess(int techProcessId);
        TechProcess004DTO GetTechProcess004RevisionByIdFull(int techProcess004Id);
        List<TechProcess004DTO> TechProcess004Revision(TechProcess004DTO techProcess004, List<TechProcess004DTO> alltechProcessRevision);



        //получить техпроцесс 005 по айди техпроцесса с подробной информацией
        TechProcess005DTO GetTechProcess005ByIdFull(int techProcess005Id);
        //получить техпроцесс 004 по айди техпроцесса с краткой информацией
        TechProcess005DTO GetTechProcess005Simple(int techProcess005Id);
        // получить  ревизии техпроцесса 005 + актуальный по Id 
        IEnumerable<TechProcess005DTO> GetAllTechProcess005RevisionWithActualTechprocess(int techProcessId);
        TechProcess005DTO GetTechProcess005RevisionByIdFull(int techProcess005Id);
        List<TechProcess005DTO> TechProcess005Revision(TechProcess005DTO techProcess005, List<TechProcess005DTO> alltechProcessRevision);

        IEnumerable<TechProcess005DTO> GetAllTechProcess005();
        IEnumerable<TechProcess005DTO> GetAllTechProcessActual005();


        TechProcess001DTO GetTechProcess001ByDrawingId(int drawingId);
        TechProcess002DTO GetTechProcess002ByDrawingId(int drawingId);
        TechProcess003DTO GetTechProcess003ByDrawingId(int drawingId);
        TechProcess004DTO GetTechProcess004ByDrawingId(int drawingId);
        TechProcess005DTO GetTechProcess005ByDrawingId(int drawingId);

        IEnumerable<DrawingDTO> GetAllDrawing();

        bool CheckDrawingContainAnyTechProcess(int drawingId);

        bool CheckDrivingChild(int drivingId);

        bool FileDelete(string URI);

        #region TechProcess001 CRUD method's

        int TechProcess001Create(TechProcess001DTO techProcess001DTO);
        void TechProcess001Update(TechProcess001DTO techProcess001DTO);
        bool TechProcess001Delete(int id);

        #endregion

        #region TechProcess002 CRUD method's

        int TechProcess002Create(TechProcess002DTO techProcess002DTO);
        void TechProcess002Update(TechProcess002DTO techProcess002DTO);
        bool TechProcess002Delete(int id);

        #endregion

        #region TechProcess003 CRUD method's
        int TechProcess003Create(TechProcess003DTO techProcess003DTO);

        void TechProcess003Update(TechProcess003DTO techProcess003DTO);

        bool TechProcess003Delete(int id);
        #endregion

        #region TechProcess004 CRUD method's
        int TechProcess004Create(TechProcess004DTO techProcess004DTO);

        void TechProcess004Update(TechProcess004DTO techProcess004DTO);

        bool TechProcess004Delete(int id);
        #endregion

        #region TechProcess005 CRUD method's
        int TechProcess005Create(TechProcess005DTO techProcess005DTO);

        void TechProcess005Update(TechProcess005DTO techProcess005DTO);

        bool TechProcess005Delete(int id);
        #endregion



        #region DrawingScan CRUD method's

        int DrawingScanCreate(DrawingScanDTO drawingScanDTO);

        void DrawingScanUpdate(DrawingScanDTO drawingScanDTO);

        bool DrawingScanDelete(int id);

        #endregion

        #region Drawing's CRUD method's

        int? CheckDrawings(string currentLevelMenu);

        int DrawingsCreate(DrawingsDTO drawingsDTO);

        void DrawingsUpdate(DrawingsDTO drawingsDTO);

        bool DrawingsDelete(int id);



        #endregion

        #region Type's CRUD method's

        int? CheckType(string typeName);

        int TypeCreate(TypeDTO typeDTO);

        void TypeUpdate(TypeDTO typeDTO);

        bool TypeDelete(int id);


        #endregion

        #region Drawing CRUD method's
        int? CheckDrawing(string drawingNumber);
        int DrawingCreate(DrawingDTO drawingDTO);
        bool DrawingUpdate(DrawingDTO drawingDTO);
        bool DrawingParseUpdate(DrawingDTO drawingDTO);
        bool DrawingDelete(int id);

        #endregion





    }
}
