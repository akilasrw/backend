using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AirportQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirportVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ChatVMs;
using Aeroclub.Cargo.Application.Services;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> SendChatAsync([FromBody]ChatVM message)
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
        public async Task<IActionResult> CreateParticipantAsync([FromBody]ChatVM message)
        {
            await _chatService.CreateParticipantAsync(message.ParticipantEmail);
            return Ok();
        }

        [HttpGet("GetUserList")]
        public async Task<ActionResult<Pagination<AirportVM>>> GetUserListAsync()
        {
            return Ok(await _chatService.GetUsersAsync());
        }
    }
}
