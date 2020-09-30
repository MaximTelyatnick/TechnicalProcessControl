using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.DAL.Models
{
    public class Drawing
    {
        [Key]
        public int Id { get; set; }
        public string Number { get; set; }
        public bool? Assembly { get; set; }

        public int? DetailId { get; set; }
        public int? MaterialId { get; set; }
        public int? TypeId { get; set; }
        public int? RevisionId { get; set; }

        public decimal? DetailWeight { get; set; }
        public decimal? TH { get; set; }
        public decimal? W { get; set; }
        public decimal? W2 { get; set; }
        public decimal? L { get; set; }
        public short? Quantity { get; set; }
        public short? QuantityR { get; set; }
        public short? QuantityL { get; set; }

        public DateTime? CreateDate { get; set; }
        public int? ParentId { get; set; }
        public string Note { get; set; }
    }
}
