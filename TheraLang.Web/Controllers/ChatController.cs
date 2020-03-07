using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TheraLang.BLL.DataTransferObjects.ChatDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.Hubs;

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

        //api/chats
        [HttpGet]
        public async Task<IActionResult> GetChats()
        {
            var authUserId = (await _authenticateService.GetAuthUser()).Id;
            var chats = await _chatService.GetChats(authUserId);

            return Ok(chats);
        }

        //?
        [HttpGet("private")]
        public async Task<IActionResult> GetPrivateChats()
        {
            var authUserId = (await _authenticateService.GetAuthUser()).Id;
            var chats = await _chatService.GetPrivateChats(authUserId);

            return Ok(chats);
        }

        //?
        [HttpPost("private")]
        public async Task<IActionResult> CreatePrivateChat([FromBody]Guid targetUserId)
        {
            var userId = (await _authenticateService.GetAuthUser()).Id;
            var id = await _chatService.CreatePrivateChat(userId, userId);

            return Ok();
        }

        //chats/id??
        [HttpGet("{id}")]
        public async Task<IActionResult> Chat(int id)
        {
            var authUserId = (await _authenticateService.GetAuthUser()).Id;
            var chat = await _chatService.GetChat(id, authUserId);

            if (chat == null)
            {
                return NotFound("Chat not found");
            }

            return Ok(chat);
        }

        //api/chats
        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody]string name)
        {
            var authUserId = (await _authenticateService.GetAuthUser()).Id;
            await _chatService.CreateRoom(name, authUserId);

            return Ok();
        }

        //api/chats/join
        [HttpPost("join")]
        public async Task<IActionResult> JoinRoom([FromBody]int chatId)
        {
            var authUserId = (await _authenticateService.GetAuthUser()).Id;
            await _chatService.JoinRoom(chatId, authUserId);

            return Ok();
        }

        //api/chats/message
        [HttpPost("message")]
        public async Task<IActionResult> SendMessage([FromBody]MessageCreateDto messageCreateDto, [FromServices] IHubContext<ChatHub> chat)
        {
            var userId = (await _authenticateService.GetAuthUser()).Id;
            var message = await _chatService.CreateMessage(messageCreateDto, userId);

            await chat.Clients.Group(messageCreateDto.ChatId.ToString()).SendAsync("RecieveMessage", new
            {
                Text = message.Text,
                PosterName = message.PosterName,
                Timestamp = message.Timestamp.ToString("dd/MM/yyyy hh:mm:ss"),
                PosterId = userId
            });

            return Ok(message);
        }

        //api/chats/message
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