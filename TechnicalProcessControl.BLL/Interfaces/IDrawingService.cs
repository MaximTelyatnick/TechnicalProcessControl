﻿using System;
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
        IEnumerable<DrawingsDTO> GetAllDrawingsByDrawingId(int drawingId);

        IEnumerable<DrawingsDTO> GetShortDrawing();

        IEnumerable<TypeDTO> GetType();

        //IEnumerable<DetailsDTO> GetDetails();

        //DrawingScanDTO GetDrawingScanById(int DrawingId);
        string GetParentName(int parentId);

        bool CheckStructuraName(DrawingsDTO drawingsDTO);


        IEnumerable<DrawingScanDTO> GetDravingScanById(int? drawingId);
        IEnumerable<DrawingsDTO> GetChildDrawings(DrawingsDTO drawingsDTO);

        string GetMaxStructuraNumber(DrawingsDTO fatherStructuraId);

        IEnumerable<RevisionsDTO> GetRevisions();

        DrawingsDTO GetDrawingsByStructuraId(int structuraId);

        DrawingDTO GetDrawingById(int drawingId);

        IEnumerable<DrawingsDTO> ReplaceDrawingIdInStructura(int replaceDrawingId, int currentDrawingId);

        bool CheckTechProcess001(string techProcesName);
        bool CheckTechProcess002(string techProcesName);
        bool CheckTechProcess003(string techProcesName);
        long GetLastTechProcess001();
        long GetLastTechProcess002();
        long GetLastTechProcess003();

        IEnumerable<TechProcess001DTO> GetAllTechProcess001();
        IEnumerable<TechProcess002DTO> GetAllTechProcess002();
        IEnumerable<TechProcess003DTO> GetAllTechProcess003();
        IEnumerable<TechProcess004DTO> GetAllTechProcess004();
        IEnumerable<TechProcess005DTO> GetAllTechProcess005();

        TechProcess001DTO GetTechProcess001ById(int drawingId);
        TechProcess002DTO GetTechProcess002ById(int drawingId);
        TechProcess003DTO GetTechProcess003ById(int drawingId);
        TechProcess004DTO GetTechProcess004ById(int drawingId);
        TechProcess005DTO GetTechProcess005ById(int drawingId);

        IEnumerable<DrawingDTO> GetAllDrawing();

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

        #region DrawingScan CRUD method's

        int DrawingScanCreate(DrawingScanDTO drawingScanDTO);

        void DrawingScanUpdate(DrawingScanDTO drawingScanDTO);

        bool DrawingScanDelete(int id);

        #endregion

        #region Drawing's CRUD method's

        int DrawingsCreate(DrawingsDTO drawingsDTO);

        void DrawingsUpdate(DrawingsDTO drawingsDTO);

        bool DrawingsDelete(int id);

        #endregion

        #region Type's CRUD method's

        int TypeCreate(TypeDTO typeDTO);

        void TypeUpdate(TypeDTO typeDTO);

        bool TypeDelete(int id);


        #endregion

        #region Drawing CRUD method's

        int DrawingCreate(DrawingDTO drawingDTO);
        bool DrawingUpdate(DrawingDTO drawingDTO);
        bool DrawingDelete(int id);

        #endregion





    }
}
