using System.ComponentModel.DataAnnotations;

namespace TechnicalProcessControl.DAL.Models
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
