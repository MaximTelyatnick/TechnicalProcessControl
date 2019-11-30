using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMK.DAL.Models
{
    public class Routes
    {
        [Key]

        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int ProductionId { get; set; }
        public int LoadAreaId { get; set; }
        public int UnloadAreaId { get; set; }
        public int Distance { get; set; }
        public decimal Rate { get; set; }
    }
}
