using System.ComponentModel.DataAnnotations;

namespace TechnicalProcessControl.DAL.Models
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
