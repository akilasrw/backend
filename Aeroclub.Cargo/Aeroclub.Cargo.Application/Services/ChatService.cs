using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos.Chatting;
using Aeroclub.Cargo.Application.Models.ViewModels.ChatVMs;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Interfaces;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;
using AutoMapper;
using Twilio.TwiML.Messaging;

namespace Aeroclub.Cargo.Application.Services
{
    public class ChatService: BaseService, IChatService
    {
        private readonly IConversationService _conversationService;

        public ChatService(IConversationService conversationService, 
            IUnitOfWork unitOfWork, 
            IMapper mapper) :
            base(unitOfWork, mapper)
        {
            _conversationService = conversationService;
        }

        public async void SendChat(ChatVM message)
        {
            if (!message.isExistedUser.Value)
            {               
                await CreateParticipantAsync(message.ParticipantEmail);
                await CreateUserAsync( message.ParticipantEmail);
            }
        }

        public async Task<ChatUserDto> CreateUserAsync(string email)
        {
            var res = await _conversationService.CreateUserAsync(new TwillioUser() {  Identity = email });            
            return new ChatUserDto().MapChatUser(res.Sid, res.AccountSid, res.Identity, res.FriendlyName,res.Url);
        }
        
        public async Task<ParticipantDto> CreateParticipantAsync(string email)
        {
            var res =  await _conversationService.CreateParticipantAsync(new TwillioParticipant() { Identity = email});
            return new ParticipantDto().MapParticipant(res.Sid,res.AccountSid, res.Identity);
        }

        public async Task<IReadOnlyList<TwillioUser>> GetUsersAsync()
        {
            List<TwillioUser> list = new List<TwillioUser>();
            var users = await _conversationService.ReadUserAsync(1000);
            foreach (var user in users) 
            {
                list.Add(new TwillioUser { Identity = user.Identity, Sid = user.Sid }); 
            }
            return list;

        } 
        
        public async Task<IReadOnlyList<TwillioUser>> GetUserConversationAsync(string userId)
        {
            List<TwillioUser> list = new List<TwillioUser>();
            var users = await _conversationService.ReadUserAsync(1000);
            foreach (var user in users) 
            {
                list.Add(new TwillioUser { Identity = user.Identity, Sid = user.Sid }); 
            }
            return list;

        }
    }
}
