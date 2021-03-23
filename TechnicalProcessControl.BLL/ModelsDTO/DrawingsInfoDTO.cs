using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class DrawingsInfoDTO
    {
            //структура
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
            public bool StructuraDisable { get; set; }


            //чертёж
            public string Number { get; set; }
            public string RevisionName { get; set; }
            public string NumberWithRevisionName { get; set; }
            public decimal? DetailWeight { get; set; }
            public string TH { get; set; }
            public string W { get; set; }
            public string W2 { get; set; }
            public string L { get; set; }
            public string DetailName { get; set; }
            public string TypeName { get; set; }
            public string ParentName { get; set; }
            public string MaterialName { get; set; }
            public string NoteName { get; set; }
            public DateTime? CreateDate { get; set; }
            public bool? Assembly { get; set; }



            //техпроцессы
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

            public string TechProcess001NameString { get; set; }
            public string TechProcess002NameString { get; set; }
            public string TechProcess003NameString { get; set; }
            public string TechProcess004NameString { get; set; }
            public string TechProcess005NameString { get; set; }

        public string Revision001 { get; set; }
            public string Revision002 { get; set; }
            public string Revision003 { get; set; }
            public string Revision004 { get; set; }
            public string Revision005 { get; set; }
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
            public bool? TechProcess001Old { get; set; }
            public bool? TechProcess002Old { get; set; }
            public bool? TechProcess003Old { get; set; }
            public bool? TechProcess004Old { get; set; }
            public bool? TechProcess005Old { get; set; }

            public short? TechProcess001Type { get; set; }
            public short? TechProcess002Type { get; set; }
            public short? TechProcess003Type { get; set; }
            public short? TechProcess004Type { get; set; }
            public short? TechProcess005Type { get; set; }

            public int? CurrentLevelMenuColorId { get; set; }
            public string CurrentLevelMenuColorName { get; set; }
            public int? DrawingColorId { get; set; }
            public string DrawingColorName { get; set; }
            public int? MaterialColorId { get; set; }
            public string MaterialColorName { get; set; }

            //материалы для техпроцессов
            public decimal? Welding20Steel { get; set; }
            public decimal? Welding10 { get; set; }
            public decimal? Welding12 { get; set; }
            public decimal? Welding16 { get; set; }
            public decimal? Welding20 { get; set; }
            public decimal? GasArCO2 { get; set; }
            public decimal? GasCO3 { get; set; }
            public decimal? GasAr { get; set; }
            public decimal? WeldingElektrod { get; set; }
            public decimal? GasO2 { get; set; }
            public decimal? GasNature { get; set; }
            public decimal? GasN2 { get; set; }
            public decimal? HardKapci881 { get; set; }
            public decimal? HardKapciHs6055 { get; set; }
            public decimal? HardKapci126 { get; set; }
            public decimal? HardKapciPEPutty { get; set; }
            public decimal? HardKapci2KMS651 { get; set; }
            public decimal? DilKapci881 { get; set; }
            public decimal? DilKapci2K { get; set; }
            public decimal? DilKapci880 { get; set; }
            public decimal? PrimerKapci125 { get; set; }
            public decimal? PrimerKapci633 { get; set; }
            public decimal? EnamelKapci641 { get; set; }
            public decimal? EnamelKapci670 { get; set; }
            public decimal? EnamelKapci6030 { get; set; }
            public decimal? UniversalSikaflex527 { get; set; }
            public decimal? PuttyKapci350 { get; set; }
            public decimal? LaborIntensity001 { get; set; }
            public decimal? LaborIntensity002 { get; set; }
            public decimal? LaborIntensity003 { get; set; }
            public decimal? LaborIntensity004 { get; set; }
            public decimal? LaborIntensity005 { get; set; }
            public decimal? LaborIntensityGeneral { get; set; }


            public decimal? Welding20SteelTotal { get; set; }
            public decimal? Welding10Total { get; set; }
            public decimal? Welding12Total { get; set; }
            public decimal? Welding16Total { get; set; }
            public decimal? Welding20Total { get; set; }
            public decimal? GasArCO2Total { get; set; }
            public decimal? GasCO3Total { get; set; }
            public decimal? GasArTotal { get; set; }
            public decimal? WeldingElektrodTotal { get; set; }
            public decimal? GasO2Total { get; set; }
            public decimal? GasNatureTotal { get; set; }
            public decimal? GasN2Total { get; set; }
            public decimal? HardKapci881Total { get; set; }
            public decimal? HardKapciHs6055Total { get; set; }
            public decimal? HardKapci126Total { get; set; }
            public decimal? HardKapciPEPuttyTotal { get; set; }
            public decimal? HardKapci2KMS651Total { get; set; }
            public decimal? DilKapci881Total { get; set; }
            public decimal? DilKapci2KTotal { get; set; }
            public decimal? DilKapci880Total { get; set; }
            public decimal? PrimerKapci125Total { get; set; }
            public decimal? PrimerKapci633Total { get; set; }
            public decimal? EnamelKapci641Total { get; set; }
            public decimal? EnamelKapci670Total { get; set; }
            public decimal? EnamelKapci6030Total { get; set; }
            public decimal? UniversalSikaflex527Total { get; set; }
            public decimal? PuttyKapci350Total { get; set; }
            public decimal? LaborIntensity001Total { get; set; }
            public decimal? LaborIntensity002Total { get; set; }
            public decimal? LaborIntensity003Total { get; set; }
            public decimal? LaborIntensity004Total { get; set; }
            public decimal? LaborIntensity005Total { get; set; }
            public decimal? LaborIntensityGeneralTotal { get; set; }
        
    }
}
