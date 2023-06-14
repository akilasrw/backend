namespace Aeroclub.Cargo.Application.Models.Dtos.Chatting
{
    public class MessageViewDto : MessageDto
    {
        public string? Sid { get; set; }
        public DateTime? Created { get; set; }
        public int? Index { get; set; }
    }
}
