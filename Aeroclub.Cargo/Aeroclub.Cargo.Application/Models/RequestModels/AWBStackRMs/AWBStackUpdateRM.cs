namespace Aeroclub.Cargo.Application.Models.RequestModels.AWBStackRMs
{
    public class AWBStackUpdateRM
    {
        public Guid CargoAgentId { get; set; }
        public int LastUsedSequenceNumber { get; set; }

    }
}
