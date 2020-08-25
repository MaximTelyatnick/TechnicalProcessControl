using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class TechProcess004DTO
    {
        public int Id { get; set; }
        public int? DrawingId { get; set; }
        public long TechProcessName { get; set; }
        public string TechProcessPath { get; set; }
        public decimal? LaborIntensity001 { get; set; }
        public decimal? LaborIntensity002 { get; set; }
        public decimal? LaborIntensity003 { get; set; }
        public decimal? LaborIntensity004 { get; set; }
        public decimal? LaborIntensity005 { get; set; }
        public string TechProcessFullName { get; set; }
        public string Article { get; set; }
        public short? Status { get; set; }
    }
}
