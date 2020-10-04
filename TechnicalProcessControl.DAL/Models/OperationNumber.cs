using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.DAL.Models
{
    public class OperationNumber
    {
        [Key]
        public int Id { get; set; }
        public string TableId { get; set; }
        public string OperationNumberName { get; set; }
    }
}
