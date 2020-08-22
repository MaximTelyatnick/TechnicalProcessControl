using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class MaterialsDTO : ObjectBase
    {
        public int Id { get; set; }
        public string MaterialName { get; set; }
    }
}
