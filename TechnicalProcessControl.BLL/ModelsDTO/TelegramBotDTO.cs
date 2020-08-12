namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class TelegramBotDTO
    {
        public int Id { get; set; }
        public string NameBot { get; set; }
        public string UserNameBot { get; set; }
        public string BotToken { get; set; }
        public string Description { get; set; }
        public short Status { get; set; }
    }
}
