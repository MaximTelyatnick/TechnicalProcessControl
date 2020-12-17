using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class DrawingScanDTO : ObjectBase
    {
        public int Id { get; set; }
        public int? DrawingId { get; set; }
        public byte[] Scan { get; set; }
        public string FileName { get; set; }
        public short? Status { get; set; }
        public string FileNamePath { get; set; }
        public bool? Check { get; set; }
        public string DrawingName { get; set; }
    }
}
