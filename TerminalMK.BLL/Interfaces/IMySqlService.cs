using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMK.BLL.ModelsDTO;

namespace TerminalMK.BLL.Interfaces
{
    public interface IMySqlService
    {
        //IEnumerable<CityDTO> GetCity();
        IEnumerable<ProductionDTO> GetProduction();
    }
}
