using System;
using Newtonsoft.Json;

namespace TheraLang.BLL.DataTransferObjects.ChatDtos
{
    public class MessageCreateDto
    {
        public int ChatId { get; set; }
        public string Text { get; set; }
    }
}
