using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class DrawingDTO : ObjectBase, Infrastructure.ICloneable
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string FullName { get; set; }
        public bool? Assembly { get; set; }
        public string AssemblyName { get; set; }

        public int? DetailId { get; set; }
        public string DetailName { get; set; }
        public int? MaterialId { get; set; }
        public string MaterialName { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public int? RevisionId { get; set; }
        public string RevisionName { get; set; }

        public decimal? DetailWeight { get; set; }
        public string TH { get; set; }
        public string W { get; set; }
        public string W2 { get; set; }
        public string L { get; set; }
        public short? Quantity { get; set; }
        public short? QuantityR { get; set; }
        public short? QuantityL { get; set; }

        public DateTime? CreateDate { get; set; }
        public int? ParentId { get; set; }
        public string Note { get; set; }
        public int? ScanId { get; set; }
        public string NumberWithRevisionName { get; set; }

        public DrawingDTO()
        {
            this.NumberWithRevisionName = this.RevisionId == null ? this.Number : this.Number + "_" + this.RevisionName;
        }

        

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
