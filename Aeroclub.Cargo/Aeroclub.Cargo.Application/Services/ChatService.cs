using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos.Chatting;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Interfaces;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;
using AutoMapper;

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

        public async void SendChat(ChatDto message)
        {
            if (!message.IsExistedUser.Value)
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
        
        public async Task<IReadOnlyList<TwillioParticipantConversation>> GetParticipantConversationAsync(string username)
        {
            List<TwillioParticipantConversation> list = new List<TwillioParticipantConversation>();
            var participantConversations = await _conversationService.ReadParticipantConversationAsync(new TwillioParticipant() { Identity= username });
            foreach (var participantConversation in participantConversations) 
            {
                list.Add(new TwillioParticipantConversation { 
                    ConversationSid = participantConversation.ConversationSid,
                    ChatServiceSid= participantConversation.ChatServiceSid,
                    ConversationCreatedBy=participantConversation.ConversationCreatedBy,
                    ConversationDateCreated=participantConversation.ConversationDateCreated,
                    ParticipantIdentity=participantConversation.ParticipantIdentity,
                    ParticipantSid  =participantConversation.ParticipantSid,
                    ParticipantUserSid = participantConversation.ParticipantUserSid
                }); 
            }
            return list;

        } 
        
        public async Task<IReadOnlyList<TwillioUser>> GetUserConversationAsync(string userId)
        {
            List<TwillioUser> list = new List<TwillioUser>();
            var users = await _conversationService.ReadUserAsync(1000);
            foreach (var user in users) 
                list.Add(new TwillioUser { Identity = user.Identity, Sid = user.Sid }); 
            
            return list;

        }

        public async Task<IReadOnlyList<TwillioMessage>> GetMessagesAsync(string pathConversationSid)
        {
            List<TwillioMessage> list = new List<TwillioMessage>();
            var messages = await _conversationService.ReadMessagesAsync(pathConversationSid);
            foreach (var message in messages)
                list.Add(new TwillioMessage()
                {
                    Auther = message.Author,
                    Body = message.Body,
                    Sid = message.Sid,
                    PathConversationSid = message.ConversationSid
                });

            return list;
        }
    }
}
