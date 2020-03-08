using System;

namespace TheraLang.BLL.DataTransferObjects.ChatDtos
{
    public class MessageDto
    {
        public string Text { get; set; }

        public DateTime Timestamp { get; set; }

        public string PosterName { get; set; }

        public Guid PosterId { get; set; }
    }
}
