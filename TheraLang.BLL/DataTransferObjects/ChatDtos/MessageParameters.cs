using System;

namespace TheraLang.BLL.DataTransferObjects.ChatDtos
{
    public class MessageParameters
    {
        public int ChatId { get; set; }

        public Guid UserId { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }
    }
}
