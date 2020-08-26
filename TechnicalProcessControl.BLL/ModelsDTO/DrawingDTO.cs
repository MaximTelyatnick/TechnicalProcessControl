using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class DrawingDTO : ObjectBase
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public int? DetailId { get; set; }
        public string DetailName { get; set; }
        public int? MaterialId { get; set; }
        public string MaterialName { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }

        public decimal? DetailWeight { get; set; }
        public decimal? TH { get; set; }
        public decimal? W { get; set; }
        public decimal? W2 { get; set; }
        public decimal? L { get; set; }
        public short? Quantity { get; set; }
        public short? QuantityR { get; set; }
        public short? QuantityL { get; set; }
    }
}
