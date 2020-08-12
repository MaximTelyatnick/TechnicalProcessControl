namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class MessagesDTO
    {
        public int Id { get; set; }
        public long? UserTelegramId { get; set; }
        public string Text { get; set; }
        public bool Read { get; set; }
    }
}
