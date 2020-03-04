﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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

        public ChatService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<MessageDto> CreateMessage(MessageCreateDto messageCreateDto, Guid posterId)
        {
            var message = new Message
            {
                ChatId = messageCreateDto.ChatId,
                Text = messageCreateDto.Text,
                PosterId = posterId,
                Timestamp = DateTime.Now
            };

            _unitOfWork.Repository<Message>().Add(message);
            await _unitOfWork.SaveChangesAsync();

            var posterName = (await _unitOfWork.Repository<User>().GetAll()
                .Include(u => u.Details)
                .SingleOrDefaultAsync(u => u.Id == posterId)).Details.FirstName;

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Message, MessageDto>()
                   .ForMember(m => m.PosterName, opt => opt.MapFrom(sm => posterName)))
                .CreateMapper();

            var messageDto = mapper.Map<Message, MessageDto>(message);

            return messageDto;
        }

        public async Task<ChatDto> GetChat(int id, Guid userId)
        {
            var chat = await _unitOfWork.Repository<Chat>().GetAll()
                .Include(x => x.Messages)
                .Include(x => x.Participants)
                .ThenInclude(x => x.User)
                .ThenInclude(x => x.Details)
                .Where(x => x.Participants.Any(p => p.UserId == userId))
                .FirstOrDefaultAsync(x => x.Id == id);

            var newMapper = new MapperConfiguration(cfg => {
                cfg.CreateMap<Chat, ChatDto>();
                cfg.CreateMap<Message, MessageDto>()
                    .ForMember(m => m.PosterName, opt => opt.MapFrom(m => m.Poster.Details.FirstName));
            }).CreateMapper();

            var dest = newMapper.Map<Chat, ChatDto>(chat);

            //var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Chat, ChatDto>()).CreateMapper();
            //var chatDto = mapper.Map<Chat, ChatDto>(chat);

            return dest;
        }

        public async Task CreateRoom(string name, Guid userId)
        {
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
        }

        public async Task JoinRoom(int chatId, Guid userId)
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

        //??
        public async Task<IEnumerable<ChatDto>> GetChats(Guid userId)
        {
            var chats = await _unitOfWork.Repository<Chat>().GetAll()
                .Include(x => x.Participants)
                .Where(x => x.Participants.Any(p => p.UserId == userId))
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Chat, ChatDto>()).CreateMapper();
            var chatsDto = mapper.Map<IEnumerable<Chat>, IEnumerable<ChatDto>>(chats);

            return chatsDto;
        }

        public async Task<int> CreatePrivateChat(Guid rootId, Guid targetId)
        {
            var chat = new Chat
            {
                Type = ChatType.Private
            };

            chat.Participants.Add(new ChatUser
            {
                UserId = targetId
            });

            chat.Participants.Add(new ChatUser
            {
                UserId = rootId
            });

            _unitOfWork.Repository<Chat>().Add(chat);

            await _unitOfWork.SaveChangesAsync();

            return chat.Id;
        }

        public async Task<IEnumerable<ChatDto>> GetPrivateChats(Guid userId)
        {
            var chats =  await _unitOfWork.Repository<Chat>().GetAll()
                .Include(x => x.Participants)
                .ThenInclude(x => x.User)
                .Where(x => x.Type == ChatType.Private && x.Participants.Any(y => y.UserId == userId))
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Chat, ChatDto>()).CreateMapper();
            var chatsDto = mapper.Map<IEnumerable<Chat>, IEnumerable<ChatDto>>(chats);

            return chatsDto;
        }
    }
}
