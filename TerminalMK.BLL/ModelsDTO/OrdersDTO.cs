using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMK.BLL.ModelsDTO
{
    public class OrdersDTO
    {
        public int Id { get; set; }
        public long Number { get; set; }
        public int ContractorId { get; set; }
        public int ProductionId { get; set; }
        public int LoadAreaId { get; set; }
        public int UnloadAreaId { get; set; }
        public DateTime Date { get; set; }
        public int StatusId { get; set; }
    }
}
