using Aeroclub.Cargo.Application.Models.Dtos.Chatting;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IChatService
    { 
        void SendChat(ChatDto message);
        Task<ChatUserDto> CreateUserAsync(string email);
        Task<ParticipantDto> CreateParticipantAsync(string email);
        Task<IReadOnlyList<TwillioUser>> GetUsersAsync();
        Task<IReadOnlyList<TwillioParticipantConversation>> GetParticipantConversationAsync(string username);
        Task<IReadOnlyList<TwillioMessage>> GetMessagesAsync(string pathConversationSid);
    }
}
