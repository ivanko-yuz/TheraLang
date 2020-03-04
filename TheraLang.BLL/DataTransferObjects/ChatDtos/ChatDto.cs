using System.Collections.Generic;
using Common.Enums;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects.ChatDtos
{
    public class ChatDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ChatType Type { get; set; }

        public IEnumerable<MessageDto> Messages { get; set; }
    }
}
