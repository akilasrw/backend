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
        Task<MessageDto> UpdateMessageAsync(MessageDto message);
        Task<IReadOnlyList<TwillioConversation>> GetConversationsAsync();
        Task<IReadOnlyList<TwillioUser>> GetUsersAsync();
        Task<IReadOnlyList<TwillioParticipantConversation>> GetParticipantConversationAsync(string username);
        Task<IReadOnlyList<TwillioParticipant>> GetParticipantAsync(string pathConversationSid);
        Task<IReadOnlyList<MessageViewDto>> GetMessagesAsync(string pathConversationSid);
        Task<IReadOnlyList<TwillioUserConversation>> GetUserConversationAsync(string identity);
    }
}
