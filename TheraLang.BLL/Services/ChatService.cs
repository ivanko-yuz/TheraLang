using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common;
using Common.Constants;
using Common.Enums;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects.ChatDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ChatService : IChatService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthenticateService _authenticateService;

        public ChatService(IUnitOfWork unitOfWork, IAuthenticateService authenticateService)
        {
            _unitOfWork = unitOfWork;
            _authenticateService = authenticateService;
        }

        public async Task<MessageDto> CreateMessage(MessageCreateDto messageCreateDto)
        {
            var userId = (await _authenticateService.GetAuthUser()).Id;
            var message = new Message
            {
                ChatId = messageCreateDto.ChatId,
                Text = messageCreateDto.Text,
                PosterId = userId,
                Timestamp = DateTime.Now
            };

            _unitOfWork.Repository<Message>().Add(message);
            await _unitOfWork.SaveChangesAsync();

            var posterName = (await _unitOfWork.Repository<User>().GetAll()
                .Include(u => u.Details)
                .SingleOrDefaultAsync(u => u.Id == userId)).Details.FirstName;

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Message, MessageDto>()
                   .ForMember(m => m.PosterName, opt => opt.MapFrom(sm => posterName)))
                .CreateMapper();

            var messageDto = mapper.Map<Message, MessageDto>(message);

            return messageDto;
        }

        public async Task<IEnumerable<MessageDto>> GetMessages(int chatId, PaginationParams parameters)
        {
            var messages = await _unitOfWork.Repository<Message>().GetAll()
                .Include(m => m.Chat)
                .Include(m => m.Poster)
                .ThenInclude(u => u.Details)
                .Where(m => m.ChatId == chatId)
                .OrderByDescending(m => m.Timestamp)
                .Skip(parameters.Skip)
                .Take(parameters.Take)
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Message, MessageDto>()
                .ForMember(m => m.PosterName, opt => opt.MapFrom(m => m.Poster.Details.FirstName))).CreateMapper();

            var messagesDto = mapper.Map<IEnumerable<Message>, IEnumerable<MessageDto>>(messages);

            return messagesDto;
        }

        public async Task<ChatDto> GetChat(int id)
        {
            var userId = (await _authenticateService.GetAuthUser()).Id;

            var chat = await _unitOfWork.Repository<Chat>().GetAll()
                .Include(x => x.Messages)
                .Include(x => x.Participants)
                .Where(x => x.Participants.Any(p => p.UserId == userId))
                .FirstOrDefaultAsync(x => x.Id == id);

            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Chat, ChatDto>()
                    .ForMember(m => m.PagesCount, opt => opt
                        .MapFrom(m => (int)Math.Ceiling((double)m.Messages.Count() / PaginationConstants.MessagesPerPage)));
            }).CreateMapper();

            var chatDto = mapper.Map<Chat, ChatDto>(chat);

            return chatDto;
        }

        public async Task<int> CreateChat(string name)
        {
            var userId = (await _authenticateService.GetAuthUser()).Id;
            var chat = new Chat
            {
                Name = name,
                Type = ChatType.Room
            };

            chat.Participants.Add(new ChatUser
            {
                UserId = userId,
                UserRole = ChatUserRole.Admin
            });

            _unitOfWork.Repository<Chat>().Add(chat);
            await _unitOfWork.SaveChangesAsync();

            return chat.Id;
        }

        public async Task JoinToChat(int chatId, Guid userId)
        {
            var chatUser = new ChatUser
            {
                ChatId = chatId,
                UserId = userId,
                UserRole = ChatUserRole.Member
            };

            _unitOfWork.Repository<ChatUser>().Add(chatUser);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<ChatDto>> GetOwnChats()
        {
            var userId = (await _authenticateService.GetAuthUser()).Id;

            var chats = await _unitOfWork.Repository<Chat>().GetAll()
                .Include(x => x.Participants)
                .Where(x => x.Participants.Any(p => p.UserId == userId))
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Chat, ChatDto>()).CreateMapper();
            var chatsDto = mapper.Map<IEnumerable<Chat>, IEnumerable<ChatDto>>(chats);

            return chatsDto;
        }
    }
}
