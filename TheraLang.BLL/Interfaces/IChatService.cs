using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common;
using TheraLang.BLL.DataTransferObjects.ChatDtos;

namespace TheraLang.BLL.Interfaces
{
    public interface IChatService
    {
        Task<ChatDto> GetChat(int id);
        Task<int> CreateChat(string name);
        Task JoinToChat(int chatId, Guid userId);
        Task<IEnumerable<ChatDto>> GetOwnChats();
        Task<MessageDto> CreateMessage(MessageCreateDto message);
        Task<IEnumerable<MessageDto>> GetMessages (int chatId, PaginationParams parameters);
    }
}
