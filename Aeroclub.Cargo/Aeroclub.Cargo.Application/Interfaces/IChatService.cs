using Aeroclub.Cargo.Application.Models.Dtos.Chatting;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IChatService
    { 
        void SendChat(ChatDto message);
        Task<ChatUserDto> CreateUserAsync(string email);
        Task<ParticipantDto> CreateParticipantAsync(ParticipantDto participant);
        Task<ConversationDto> CreateConversationAsync(ConversationDto conversation);
        Task<MessageDto> CreateMessageAsync(MessageDto message);
        Task<IReadOnlyList<TwillioConversation>> GetConversationsAsync();
        Task<IReadOnlyList<TwillioUser>> GetUsersAsync();
        Task<IReadOnlyList<TwillioParticipantConversation>> GetParticipantConversationAsync(string username);
        Task<IReadOnlyList<TwillioMessage>> GetMessagesAsync(string pathConversationSid);
        Task<IReadOnlyList<TwillioUserConversation>> GetUserConversationAsync(string identity, string pathConversationSid);
    }
}
