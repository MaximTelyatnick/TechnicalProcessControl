using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMKTelegramBot.Models
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
