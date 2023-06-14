using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos.Chatting;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Interfaces;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;
using AutoMapper;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
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

        public async void SendChat(ChatDto message)
        {
            if (!message.IsExistedUser.Value)
            {               
            }
        }

        public async Task<MessageDto> CreateMessageAsync(MessageDto message)
        {
            var res = await _conversationService
                .CreateMessageAsync(MapMessage(message));

            return new MessageDto().MapMessage(res.ConversationSid, res.Body, res.Author, res.Sid, res.Attributes);
        }
        
        public async Task<MessageDto> UpdateMessageAsync(MessageDto message)
        {
            var res = await _conversationService
                .UpdateMessageAsync(MapMessage(message));

            return new MessageDto().MapMessage(res.ConversationSid, res.Body, res.Author, res.Sid, res.Attributes);
        }

        public async Task<ChatUserDto> CreateUserAsync(string email)
        {
            var res = await _conversationService.CreateUserAsync(new TwillioUser() {  Identity = email });            
            return new ChatUserDto().MapChatUser(res.Sid, res.AccountSid, res.Identity, res.FriendlyName,res.Url);
        }
        
        public async Task<ParticipantDto> CreateParticipantAsync(ParticipantDto participant)
        {
            var res =  await _conversationService.CreateParticipantAsync(
                new TwillioParticipant() { Identity = participant.Identity, PathConversationSid = participant.ConversationSid });
            return new ParticipantDto().MapParticipant(res.Sid,res.AccountSid, res.Identity);
        }

        public async Task<ConversationDto> CreateConversationAsync(ConversationDto conversation)
        {
           var res =  await _conversationService.CreateConversationAsync(new TwillioConversation() { FriendlyName= conversation.FriendlyName, UniqueName=  conversation.FriendlyName });
            return new ConversationDto().MapConversation(res.Sid,res.FriendlyName, res.UniqueName);
        }

        public async Task<IReadOnlyList<TwillioConversation>> GetConversationsAsync()
        {
            List<TwillioConversation> list = new List<TwillioConversation>();
            var res =  await _conversationService.ReadConversationsAsync();
            foreach (var item in res)
                list.Add(new TwillioConversation() { Sid = item.Sid, FriendlyName = item.FriendlyName, UniqueName = item.UniqueName });

             return list;
        }

        public async Task<IReadOnlyList<TwillioUser>> GetUsersAsync()
        {
            List<TwillioUser> list = new List<TwillioUser>();
            var users = await _conversationService.ReadUserAsync(1000);
            foreach (var user in users) 
            {
                list.Add(new TwillioUser { Identity = user.Identity, Sid = user.Sid, ChatServiceSid = user.ChatServiceSid }); 
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
        
        public async Task<IReadOnlyList<TwillioUserConversation>> GetUserConversationAsync(string identity, string pathConversationSid)
        {
            List<TwillioUserConversation> list = new List<TwillioUserConversation>();
            var users = await _conversationService.ReadUserConversationAsync(identity, pathConversationSid);
            foreach (var user in users) 
                list.Add(new TwillioUserConversation { 
                    ConversationSid = user.ConversationSid, 
                    ParticipantSid = user.ParticipantSid, 
                    CreatedBy=user.CreatedBy,
                    ChatServiceSid=user.ChatServiceSid,
                    FriendlyName=user.FriendlyName,
                    UniqueName=user.UniqueName,
                    UserSid = user.UserSid,
                    Created = user.DateCreated
                }); 
            
            return list.OrderByDescending(x=>x.Created).ToList();

        }

        public async Task<IReadOnlyList<MessageViewDto>> GetMessagesAsync(string pathConversationSid)
        {
            List<MessageViewDto> list = new List<MessageViewDto>();
            var messages = await _conversationService.ReadMessagesAsync(pathConversationSid);
            foreach (var message in messages)
                list.Add(new MessageViewDto()
                {
                    Auther = message.Author,
                    Body = message.Body,
                    Sid = message.Sid,
                    PathSid = message.Sid,
                    PathConversationSid = message.ConversationSid,
                    Created = message.DateCreated.Value,
                    Index = message.Index.Value,
                    ChatStatus = JsonConvert.DeserializeObject<ChatStatus>(message.Attributes),
                });

            return list.OrderBy(x=>x.Index).ToList();
        }

        private TwillioMessage MapMessage(MessageDto message)
        {
           return  new TwillioMessage()
           {
               Auther = message.Auther,
               PathConversationSid = message.PathConversationSid,
               Body = message.Body,
               Attributes = message.ChatStatus != null ? JsonConvert.SerializeObject(message.ChatStatus) : null,
               Sid = message.PathSid == null ? string.Empty : message.PathSid,
               pathSid = message.PathSid
           };
        }
    }
}
