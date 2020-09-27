using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.DAL.Models
{
    public class Drawings
    {
        [Key]
        public int Id { get; set; }

        public int? ParentId { get; set; }
        //public int? TypeId { get; set; }

        public string CurrentLevelMenu { get; set; }
        public int? DrawingId { get; set; }
        public int? ReplaceDrawingId { get; set; }
        public int? OccurrenceId { get; set; }

        public decimal? Quantity { get; set; }
        public decimal? QuantityR { get; set; }
        public decimal? QuantityL { get; set; }
        public bool StructuraDisable { get; set; }

        //public string Number { get; set; }

        //public int? DetailId { get; set; }
        //public int? MaterialId { get; set; }

        //public decimal? DetailWeight { get; set; }
        //public decimal? TH { get; set; }

        //public decimal? W { get; set; }

        //public decimal? W2 { get; set; }

        //public decimal? L { get; set; }
        //public decimal? WireConsumption { get; set; }
        //public decimal? GasConsumption { get; set; }
        //public decimal? PaintConsumption { get; set; }
        //public decimal? LaborIntensityTotal { get; set; }
        //public decimal? Quantity { get; set; }
        //public decimal? LaborIntensity001Total { get; set; }
        //public decimal? LaborIntensity002Total { get; set; }
        //public decimal? LaborIntensity003Total { get; set; }
        //public decimal? LaborIntensity004Total { get; set; }
        //public decimal? LaborIntensity005Total { get; set; }




    }
}
