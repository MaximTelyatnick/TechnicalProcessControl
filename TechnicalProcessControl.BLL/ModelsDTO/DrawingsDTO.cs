﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class DrawingsDTO
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int? TypeId { get; set; }
        public string CurrentLevelMenu { get; set; }
        public string Number { get; set; }
        public int? DetailId { get; set; }
        public int? TechProcess001Id { get; set; }
        public int? TechProcess002Id { get; set; }
        public int? TechProcess003Id { get; set; }
        public int? TechProcess004Id { get; set; }
        public int? TechProcess005Id { get; set; }
        public decimal? DetailWeight { get; set; }
        public decimal? TH { get; set; }
        public decimal? W { get; set; }
        public decimal? W2 { get; set; }
        public decimal? L { get; set; }
        public decimal? WireConsumption { get; set; }
        public decimal? GasConsumption { get; set; }
        public decimal? PaintConsumption { get; set; }
        public decimal? LaborIntensityTotal { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? LaborIntensity001Total { get; set; }
        public decimal? LaborIntensity002Total { get; set; }
        public decimal? LaborIntensity003Total { get; set; }
        public decimal? LaborIntensity004Total { get; set; }
        public decimal? LaborIntensity005Total { get; set; }

        public string TechProcess001Name { get; set; }
        public string TechProcess002Name { get; set; }
        public string TechProcess003Name { get; set; }
        public string TechProcess004Name { get; set; }
        public string TechProcess005Name { get; set; }

        public string DetailName { get; set; }
        public string TypeName { get; set; }
    }
}
