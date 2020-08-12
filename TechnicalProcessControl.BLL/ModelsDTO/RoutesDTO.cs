using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class RoutesDTO : ObjectBase
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public string ContractorName { get; set; }
        public int ProductionId { get; set; }
        public string ProductionName { get; set; }
        public int LoadAreaId { get; set; }
        public string LoadAreaName { get; set; }
        public int UnloadAreaId { get; set; }
        public string UnloadAreaName { get; set; }
        public int Distance { get; set; }
        public decimal Rate { get; set; }
    }
}
