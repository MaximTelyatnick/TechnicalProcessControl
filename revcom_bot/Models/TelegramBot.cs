using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMKTelegramBot.Models
{
    public class TelegramBot
    {
        [Key]
        public int Id { get; set; }
        public string NameBot { get; set; }
        public string UserNameBot { get; set; }
        public string BotToken { get; set; }
        public string Description { get; set; }

        public short Status { get; set; }
    }
}
