using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TheraLang.BLL.DataTransferObjects.ChatDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.Hubs;
using TheraLang.Web.ViewModels.Chat;

namespace TheraLang.Web.Controllers
{
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
            var authUserId = (await _authenticateService.GetAuthUserAsync()).Id;
            var chats = await _chatService.GetChats(authUserId);

            return Ok(chats);
        }

        //?
        [HttpGet("private")]
        public async Task<IActionResult> GetPrivateChats()
        {
            var authUserId = (await _authenticateService.GetAuthUserAsync()).Id;
            var chats = await _chatService.GetPrivateChats(authUserId);

            return Ok(chats);
        }

        //?
        [HttpPost("private")]
        public async Task<IActionResult> CreatePrivateChat([FromBody]Guid userId)
        {
            var authUserId = (await _authenticateService.GetAuthUserAsync()).Id;
            var id = await _chatService.CreatePrivateChat(authUserId, userId);

            return Ok();
        }

        //chats/id??
        [HttpGet("{id}")]
        public async Task<IActionResult> Chat(int id)
        {
            var authUserId = (await _authenticateService.GetAuthUserAsync()).Id;
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
            var authUserId = (await _authenticateService.GetAuthUserAsync()).Id;
            await _chatService.CreateRoom(name, authUserId);

            return Ok();
        }

        //api/chats/join
        [HttpPost("join")]
        public async Task<IActionResult> JoinRoom([FromBody]int chatId)
        {
            var authUserId = (await _authenticateService.GetAuthUserAsync()).Id;
            await _chatService.JoinRoom(chatId, authUserId);

            return Ok();
        }

        //api/chats/message
        [HttpPost("message")]
        public async Task<IActionResult> SendMessage([FromBody]MessageCreateDto messageCreateDto, [FromServices] IHubContext<ChatHub> chat)
        {
            var authUserId = (await _authenticateService.GetAuthUserAsync()).Id;
            var message = await _chatService.CreateMessage(messageCreateDto, authUserId);

            await chat.Clients.Group(messageCreateDto.ChatId.ToString()).SendAsync("RecieveMessage", new
            {
                Text = message.Text,
                PosterName = message.PosterName,
                Timestamp = message.Timestamp.ToString("dd/MM/yyyy hh:mm:ss")
            });

            return Ok(message);
        }
    }
}