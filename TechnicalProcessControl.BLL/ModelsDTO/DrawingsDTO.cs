using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class DrawingsDTO : ObjectBase
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string CurrentLevelMenu { get; set; }
        public int? DrawingId { get; set; }
        public int? ReplaceDrawingId { get; set; }
        public int? OccurrenceId { get; set; }
        public int? ScanId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityR { get; set; }
        public decimal? QuantityL { get; set; }



        public string Number { get; set; }
        public decimal? DetailWeight { get; set; }
        public decimal? TH { get; set; }
        public decimal? W { get; set; }
        public decimal? W2 { get; set; }
        public decimal? L { get; set; }
        public string DetailName { get; set; }
        public string TypeName { get; set; }
        public string ParentName { get; set; }
        public string MaterialName { get; set; }
        public string NoteName { get; set; }
        public DateTime? CreateDate { get; set; }



        public int? TechProcess001Id { get; set; }
        public int? TechProcess002Id { get; set; }
        public int? TechProcess003Id { get; set; }
        public int? TechProcess004Id { get; set; }
        public int? TechProcess005Id { get; set; }
        public long? TechProcess001Name { get; set; }
        public long? TechProcess002Name { get; set; }
        public long? TechProcess003Name { get; set; }
        public long? TechProcess004Name { get; set; }
        public long? TechProcess005Name { get; set; }
        public string TechProcess001Path { get; set; }
        public string TechProcess002Path { get; set; }
        public string TechProcess003Path { get; set; }
        public string TechProcess004Path { get; set; }
        public string TechProcess005Path { get; set; }
        public string TechProcess001PathOld { get; set; }
        public string TechProcess002PathOld { get; set; }
        public string TechProcess003PathOld { get; set; }
        public string TechProcess004PathOld { get; set; }
        public string TechProcess005PathOld { get; set; }


    }
}
