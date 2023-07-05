using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.RequestModels.SystemUserRMs
{
    public class SystemUserStatusUpdateRM : BaseRM
    {
        public UserStatus UserStatus { get; set; }
    }
}
