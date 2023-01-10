using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.ViewModels.ChatVMs;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class ChatService: BaseService, IChatService
    {
        private readonly IConversationService _conversationService;

        public ChatService(IConversationService conversationService, IUnitOfWork unitOfWork, IMapper mapper) :
            base(unitOfWork, mapper)
        {
            _conversationService = conversationService;
        }

        public void SendChat(ChatVM message)
        {
            throw new NotImplementedException();
        }
    }
}
