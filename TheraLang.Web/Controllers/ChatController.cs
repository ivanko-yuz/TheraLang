﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TheraLang.BLL.DataTransferObjects.ChatDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.Hubs;
using TheraLang.Web.ViewModels.Chat;

namespace TheraLang.Web.Controllers
{
    [Authorize]
    [Route("api/chats")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;
        private readonly IAuthenticateService _authenticateService;

        public ChatController(IChatService chatService, IAuthenticateService authenticateService)
        {
            _chatService = chatService;
            _authenticateService = authenticateService;
        }

        [HttpGet]
        public async Task<IActionResult> GetChats()
        {
            var chats = await _chatService.GetOwnChats();

            return Ok(chats);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Chat(int id)
        {
            var chat = await _chatService.GetChat(id);

            if (chat == null)
            {
                return NotFound("Chat not found");
            }

            return Ok(chat);
        }

        [HttpPost]
        public async Task<IActionResult> CreateChat([FromBody]ChatCreateViewModel chatModel)
        {
            await _chatService.CreateChat(chatModel.ChatName);

            return Ok();
        }

        [HttpPost("message")]
        public async Task<IActionResult> SendMessage([FromBody]MessageCreateDto messageCreateDto, [FromServices] IHubContext<ChatHub> chat)
        {
            var message = await _chatService.CreateMessage(messageCreateDto);

            await chat.Clients.Group(messageCreateDto.ChatId.ToString()).SendAsync("RecieveMessage", new
            {
                Text = message.Text,
                PosterName = message.PosterName,
                Timestamp = message.Timestamp,
                PosterId = message.PosterId
            });

            return Ok(message);
        }

        [HttpGet("{chatId}/{pageNumber}/{pageSize}")]
        public async Task<IActionResult> GetMessages(int chatId, int pageNumber, int pageSize)
        {
            var userId = (await _authenticateService.GetAuthUser()).Id;
            var parameters = new MessageParameters()
            {
                ChatId = chatId,
                PageNumber = pageNumber,
                PageSize = pageSize,
                UserId = userId
            };

            var messages = await _chatService.GetMessages(parameters);

            return Ok(messages);
        }
    }
}