using System;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class TextTelegramDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TextPost { get; set; }
        public int PostId { get; set; }
        public DateTime TextDateTime { get; set; }
    }
}
