using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class DrawingScanDTO
    {
        public int Id { get; set; }
        public int DrawingId { get; set; }
        public byte[] Scan { get; set; }
        public string FileName { get; set; }
        public short? Status { get; set; }
    }
}
