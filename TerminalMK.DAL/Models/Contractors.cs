using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMK.DAL.Models
{
    public class Contractors
    {
        [Key]

        public int Id { get; set; }
        public string NameContractors { get; set; }
    }
}
