﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.DAL.Models
{
    public class TechProcess001
    {
        [Key]
        public int Id { get; set; }
        public int? DrawingId { get; set; }
        public int? RevisionId { get; set; }
        public int? ParentId { get; set; }
        public long TechProcessName { get; set; }
        public string TechProcessPath { get; set; }
        public decimal? TH { get; set; }
        public decimal? W { get; set; }
        public decimal? W2 { get; set; }
        public decimal? L { get; set; }
        public decimal? Weight { get; set; }
        public string TechProcessFullName { get; set; }
        public DateTime? CreateDate { get; set; }
        public short? TypeId { get; set; }
        public bool? OldTechProcess { get; set; }
    }
}
