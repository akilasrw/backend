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
        
        [HttpPost("CreateMessage")]
        public async Task<IActionResult> CreateMessageAsync([FromBody]MessageDto message)
        {
            return Ok(await _chatService.CreateMessageAsync(message));
        }
        
        
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUserAsync([FromBody]string userName)
        {
            return Ok(await _chatService.CreateUserAsync(userName));
        }
        
        [HttpPost("CreateParticipant")]
        public async Task<IActionResult> CreateParticipantAsync([FromBody] ParticipantDto participant)
        {
            return Ok(await _chatService.CreateParticipantAsync(participant));
        }
        
        [HttpPost("CreateConversation")]
        public async Task<IActionResult> CreateConversationAsync([FromBody] ConversationDto conversation)
        {
            return Ok(await _chatService.CreateConversationAsync(conversation));
        }

        [HttpPut("UpdateMessage")]
        public async Task<IActionResult> UpdateMessageAsync([FromBody] MessageDto message)
        {
            return Ok(await _chatService.UpdateMessageAsync(message));
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
        
        [HttpGet("GetUserConversation")]
        public async Task<ActionResult<IReadOnlyList<TwillioUserConversation>>> GetUserConversationAsync([FromQuery] string identity)
        {
            return Ok(await _chatService.GetUserConversationAsync(identity));
        } 
        
        [HttpGet("GetConversations")]
        public async Task<ActionResult<IReadOnlyList<TwillioConversation>>> GetConversationAsync()
        {
            return Ok(await _chatService.GetConversationsAsync());
        }
        
        [HttpGet("GetMessages")]
        public async Task<ActionResult<IReadOnlyList<MessageViewDto>>> GetMessagesAsync([FromQuery] string pathConversationSid)
        {
            return Ok(await _chatService.GetMessagesAsync(pathConversationSid));
        }

    }
}
