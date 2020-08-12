using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalProcessControl.DAL.Models
{
    public class TextTelegram
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string TextPost { get; set; }
        public int PostId { get; set; }
        public DateTime TextDateTime { get; set; }
    }
}
