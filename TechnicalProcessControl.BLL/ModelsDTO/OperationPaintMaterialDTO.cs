using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class OperationPaintMaterialDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameEng { get; set; }
        public string NameRus{ get; set; }
        public string Type { get; set; }
    }
}
