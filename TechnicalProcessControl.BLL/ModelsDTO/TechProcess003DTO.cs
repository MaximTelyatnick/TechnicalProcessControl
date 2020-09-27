using System;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL
{
    public class TechProcess003DTO : ObjectBase
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? DrawingId { get; set; }
        public string DrawingNumber { get; set; }
        public string DrawingNumberWithRevision { get; set; }
        public long TechProcessName { get; set; }
        public string TechProcessPath { get; set; }
        public decimal? LaborIntensity001 { get; set; }
        public decimal? LaborIntensity002 { get; set; }
        public decimal? LaborIntensity003 { get; set; }
        public decimal? LaborIntensity004 { get; set; }
        public decimal? LaborIntensity005 { get; set; }
        public string TechProcessFullName { get; set; }
        public int? RevisionId { get; set; }
        public string RivisionName { get; set; }
        public short? TypeId { get; set; }

        public int? DrawingsId { get; set; }
        
        
    }
}
