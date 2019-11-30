using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMKTelegramBot.DTO
{
    public class MessagesDTO
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public short Read { get; set; }
    }
}
