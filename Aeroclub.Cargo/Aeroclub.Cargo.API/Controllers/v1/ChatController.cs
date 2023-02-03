using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos.Chatting;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    public class ChatController : BaseApiController
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("SendChat")]
        public async Task<IActionResult> SendChatAsync([FromBody]ChatDto message)
        {
            _chatService.SendChat(message);
            return Ok();
        }
        
        
        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUserAsync([FromBody]string userName)
        {
            return Ok(await _chatService.CreateUserAsync(userName));
        }
        
        [HttpPost("createParticipant")]
        public async Task<IActionResult> CreateParticipantAsync([FromBody] string userName)
        {
            await _chatService.CreateParticipantAsync(userName);
            return Ok();
        }
        
        [HttpPost("createConversation")]
        public async Task<IActionResult> CreateConversationAsync([FromBody] ChatDto message)
        {
            await _chatService.CreateParticipantAsync(message.ParticipantEmail);
            return Ok();
        }

        [HttpGet("GetUserList")]
        public async Task<ActionResult<IReadOnlyList<TwillioUser>>> GetUserListAsync()
        {
            return Ok(await _chatService.GetUsersAsync());
        }   
        
        [HttpGet("GetParticipantConversation")]
        public async Task<ActionResult<IReadOnlyList<TwillioParticipantConversation>>> GetParticipantConversationAsync([FromQuery] string userName)
        {
            return Ok(await _chatService.GetParticipantConversationAsync(userName));
        }
        
        [HttpGet("GetMessages")]
        public async Task<ActionResult<IReadOnlyList<TwillioMessage>>> GetMessagesAsync([FromBody] string pathConversationSid)
        {
            return Ok(await _chatService.GetMessagesAsync(pathConversationSid));
        }

    }
}
