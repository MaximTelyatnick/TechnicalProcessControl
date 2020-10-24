using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.DAL.Models
{
    public class Colors
    {
        [Key]
        public int Id { get; set; }
        public string NameRus { get; set; }
        public string Code { get; set; }
        public string NameEng { get; set; }
        public string NameAr { get; set; }
    }
}
