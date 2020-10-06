﻿using System;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class TechProcess001DTO : ObjectBase,Infrastructure.ICloneable
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? DrawingId { get; set; }
        public string DrawingNumber { get; set; }
        public string DrawingNumberWithRevision { get; set; }
        public long TechProcessName { get; set; }
        public string TechProcessPath { get; set; }
        public decimal? TH { get; set; }
        public decimal? W { get; set; }
        public decimal? W2 { get; set; }
        public decimal? L { get; set; }
        public decimal? Weight { get; set; }
        public string TechProcessFullName { get; set; }
        public int? RevisionId { get; set; }
        public string RivisionName { get; set; }
        public short? TypeId { get; set; }
        public bool? OldTechProcess { get; set; }

        public int? DrawingsId { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
