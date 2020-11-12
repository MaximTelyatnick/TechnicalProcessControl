using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.DAL.Models
{
    public class TechProcess002
    {
        [Key]
        public int Id { get; set; }
        public int? DrawingId { get; set; }
        public int? CopyDrawingId { get; set; }
        public int? RevisionId { get; set; }
        public int? ParentId { get; set; }
        public long TechProcessName { get; set; }
        public string TechProcessPath { get; set; }
        public string TH { get; set; }
        public string W { get; set; }
        public string W2 { get; set; }
        public string L { get; set; }
        public decimal? Weight { get; set; }
        public string TechProcessFullName { get; set; }
        public DateTime? CreateDate { get; set; }
        public short? TypeId { get; set; }
        public bool? OldTechProcess { get; set; }
        public int? UserId { get; set; }
        public string RevisionDocumentName { get; set; }


        #region TechProcess Materials
        public decimal Welding20Steel { get; set; }
        public decimal? Welding10 { get; set; }
        public decimal Welding12 { get; set; }
        public decimal Welding16 { get; set; }
        public decimal Welding20 { get; set; }
        public decimal GasArCO2 { get; set; }
        public decimal GasCO3 { get; set; }
        public decimal GasAr { get; set; }
        public decimal WeldingElektrod { get; set; }
        public decimal GasO2 { get; set; }
        public decimal GasNature { get; set; }
        public decimal GasN2 { get; set; }
        public decimal HardKapci881 { get; set; }
        public decimal HardKapciHs6055 { get; set; }
        public decimal HardKapci126 { get; set; }
        public decimal HardKapciPEPutty { get; set; }
        public decimal HardKapci2KMS651 { get; set; }
        public decimal DilKapci881 { get; set; }
        public decimal DilKapci2K { get; set; }
        public decimal DilKapci880 { get; set; }
        public decimal PrimerKapci125 { get; set; }
        public decimal PrimerKapci633 { get; set; }
        public decimal EnamelKapci641 { get; set; }
        public decimal EnamelKapci670 { get; set; }
        public decimal EnamelKapci6030 { get; set; }
        public decimal UniversalSikaflex527 { get; set; }
        public decimal PuttyKapci350 { get; set; }
        public decimal LaborIntensity001 { get; set; }
        public decimal LaborIntensity002 { get; set; }
        public decimal LaborIntensity003 { get; set; }
        public decimal LaborIntensity004 { get; set; }
        public decimal LaborIntensity005 { get; set; }
        #endregion
    }
}
