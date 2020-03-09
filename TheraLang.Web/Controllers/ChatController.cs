using System.Threading.Tasks;
using AutoMapper;
using Common;
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
        public async Task<IActionResult> SendMessage([FromBody]MessageCreateViewModel messageModel, [FromServices] IHubContext<ChatHub> chat)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<MessageCreateViewModel, MessageCreateDto>()).CreateMapper();
            var messageDto = mapper.Map<MessageCreateViewModel, MessageCreateDto>(messageModel);

            var message = await _chatService.CreateMessage(messageDto);

            await chat.Clients.Group(messageModel.ChatId.ToString()).SendAsync("ReceiveMessage", new
            {
                Text = message.Text,
                PosterName = message.PosterName,
                Timestamp = message.Timestamp,
                PosterId = message.PosterId
            });

            return Ok(message);
        }

        [HttpGet("{chatId}/messages")]
        public async Task<IActionResult> GetMessages(int chatId, [FromQuery]PaginationParams paginationParams)
        {
            var messages = await _chatService.GetMessages(chatId, paginationParams);

            return Ok(messages);
        }
    }
}