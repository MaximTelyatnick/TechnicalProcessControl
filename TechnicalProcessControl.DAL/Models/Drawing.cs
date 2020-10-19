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
        public string TH { get; set; }
        public string W { get; set; }
        public string W2 { get; set; }
        public string L { get; set; }

        public DateTime? CreateDate { get; set; }
        public int? ParentId { get; set; }
        public string Note { get; set; }
    }
}
