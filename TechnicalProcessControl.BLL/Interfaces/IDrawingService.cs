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

        IEnumerable<DrawingsDTO> GetAllDrawings();

        IEnumerable<DrawingsDTO> GetShortDrawing();

        IEnumerable<TypeDTO> GetType();

        //IEnumerable<DetailsDTO> GetDetails();

        //DrawingScanDTO GetDrawingScanById(int DrawingId);
        string GetParentName(int parentId);

        IEnumerable<DrawingScanDTO> GetDravingScanById(int drawingId);
        bool CheckTechProcess001(string techProcesName);
        long GetLastTechProcess001();
        long GetLastTechProcess002();

        IEnumerable<TechProcess001DTO> GetAllTechProcess001();
        IEnumerable<TechProcess002DTO> GetAllTechProcess002();
        IEnumerable<TechProcess003DTO> GetAllTechProcess003();
        IEnumerable<TechProcess004DTO> GetAllTechProcess004();
        IEnumerable<TechProcess005DTO> GetAllTechProcess005();


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

        #region DrawingScan CRUD method's

        int DrawingScanCreate(DrawingScanDTO drawingScanDTO);

        void DrawingScanUpdate(DrawingScanDTO drawingScanDTO);

        bool DrawingScanDelete(int id);

        #endregion

        #region Drawing's CRUD method's

        int DrawingCreate(DrawingsDTO drawingsDTO);

        void DrawingUpdate(DrawingsDTO drawingsDTO);

        bool RouteDelete(int id);

        #endregion

        #region Type's CRUD method's

        int TypeCreate(TypeDTO typeDTO);

        void TypeUpdate(TypeDTO typeDTO);

        bool TypeDelete(int id);


        #endregion



    }
}
