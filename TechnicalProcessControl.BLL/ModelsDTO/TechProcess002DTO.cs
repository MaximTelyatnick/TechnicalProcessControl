using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class TechProcess002DTO : ObjectBase, Infrastructure.ICloneable
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? DrawingId { get; set; }
        public int? CopyDrawingId { get; set; }
        public string DrawingNumber { get; set; }
        public string DrawingNumberWithRevision { get; set; }
        public long TechProcessName { get; set; }
        public string TechProcessPath { get; set; }
        public string TH { get; set; }
        public string W { get; set; }
        public string W2 { get; set; }
        public string L { get; set; }
        public decimal? Weight { get; set; }
        public string TechProcessFullName { get; set; }
        public int? RevisionId { get; set; }
        public string RivisionName { get; set; }
        public short? TypeId { get; set; }
        public bool? OldTechProcess { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        //public bool Active { get; set; }

        public int? DrawingsId { get; set; }
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

        public TechProcess002DTO()
        {
            this.Weight = 0;
            this.TypeId = 1;
            this.Welding20Steel = 0;
            this.Welding10 = 0;
            this.Welding12 = 0;
            this.Welding16 = 0;
            this.Welding20 = 0;
            this.GasArCO2 = 0;
            this.GasCO3 = 0;
            this.GasAr = 0;
            this.WeldingElektrod = 0;
            this.GasO2 = 0;
            this.GasNature = 0;
            this.GasN2 = 0;
            this.HardKapci881 = 0;
            this.HardKapciHs6055 = 0;
            this.HardKapci126 = 0;
            this.HardKapciPEPutty = 0;
            this.HardKapci2KMS651 = 0;
            this.DilKapci881 = 0;
            this.DilKapci2K = 0;
            this.DilKapci880 = 0;
            this.PrimerKapci125 = 0;
            this.PrimerKapci633 = 0;
            this.EnamelKapci641 = 0;
            this.EnamelKapci670 = 0;
            this.EnamelKapci6030 = 0;
            this.UniversalSikaflex527 = 0;
            this.PuttyKapci350 = 0;
            this.LaborIntensity001 = 0;
            this.LaborIntensity002 = 0;
            this.LaborIntensity003 = 0;
            this.LaborIntensity004 = 0;
            this.LaborIntensity005 = 0;

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
