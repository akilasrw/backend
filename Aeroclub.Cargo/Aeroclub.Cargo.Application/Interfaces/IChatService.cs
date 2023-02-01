using Aeroclub.Cargo.Application.Models.Dtos.Chatting;
using Aeroclub.Cargo.Application.Models.ViewModels.ChatVMs;
using Aeroclub.Cargo.Application.Services;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Interfaces;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IChatService
    { 
        void SendChat(ChatVM message);
        Task<ChatUserDto> CreateUserAsync(string email);
        Task<ParticipantDto> CreateParticipantAsync(string email);
        Task<IReadOnlyList<TwillioUser>> GetUsersAsync();
    }
}
