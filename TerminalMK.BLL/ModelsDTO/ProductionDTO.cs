using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMK.BLL.Infrastructure;

namespace TerminalMK.BLL.ModelsDTO
{
    public class ProductionDTO : ObjectBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
    }
}
