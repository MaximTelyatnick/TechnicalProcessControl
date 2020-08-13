using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.DAL.Models
{
    public class DrawingScan
    {
        [Key]
        public int Id { get; set; }
        public int DrawingId { get; set; }
        public byte[] Scan { get; set; }
        public string FileName { get; set; }
        public short? Status { get; set; }
    }
}
