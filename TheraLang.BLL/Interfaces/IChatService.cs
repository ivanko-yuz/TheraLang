using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.ChatDtos;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IChatService
    {
        Task<ChatDto> GetChat(int id, Guid userId);
        Task CreateRoom(string name, Guid userId);
        Task JoinRoom(int chatId, Guid userId);
        Task<IEnumerable<ChatDto>> GetChats(Guid userId);
        Task<int> CreatePrivateChat(Guid rootId, Guid targetId);
        Task<IEnumerable<ChatDto>> GetPrivateChats(Guid userId);
        Task<MessageDto> CreateMessage(MessageCreateDto message, Guid posterId);
    }
}
