

using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberRMs
{
    public class AWBStackRM
    {
        [Required(ErrorMessage = "Starting sequence number required")]
        public int StartSequenceNumber { get; set; }

        [Required(ErrorMessage = "Ending sequence number required")]
        public int EndSequenceNumber { get; set; }

        [Required(ErrorMessage = "Cargo agent Id required")]
        public Guid CargoAgentId { get; set; }

    }
}
