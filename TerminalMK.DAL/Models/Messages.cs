using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMK.DAL.Models
{
    public class Messages
    {
        [Key]
        public int Id { get; set; }
        public long? UserTelegramId { get; set; }
        public string Text { get; set; }
        public bool Read { get; set; }


    }
}
