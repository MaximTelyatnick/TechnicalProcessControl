using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.DAL.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
    }
}
