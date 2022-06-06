using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AWBStackVMs
{
    public class AWBStackVM : BaseVM
    {
        public int StartSequenceNumber { get; set; }
        public int EndSequenceNumber { get; set; }
        public int LastUsedSequenceNumber { get; set; }
        public bool IsSequenceCompleted { get; set; }
        public string? CargoAgentName { get; set; }
        public Guid CargoAgentId { get; set; }

    }
}
