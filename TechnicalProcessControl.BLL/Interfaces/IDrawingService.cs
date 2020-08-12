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

        IEnumerable<DrawingsDTO> GetAllDrawings();

        IEnumerable<DrawingsDTO> GetShortDrawing();

        IEnumerable<TypeDTO> GetType();

        IEnumerable<DetailsDTO> GetDetails();

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

        #region Detail's CRUD method's

        int DetailCreate(DetailsDTO detailsDTO)

        void DetailsUpdate(DetailsDTO detailsDTO);

        bool DetailDelete(int id);


        #endregion

    }
}
