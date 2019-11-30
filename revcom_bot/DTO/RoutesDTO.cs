using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMKTerminalBot.DTO
{
    public class RoutesDTO
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int ProductionId { get; set; }
        public int LoadAreaId { get; set; }
        public int UnloadAreaId { get; set; }
        public int Distance { get; set; }
        public decimal Rate { get; set; }
    }
}
