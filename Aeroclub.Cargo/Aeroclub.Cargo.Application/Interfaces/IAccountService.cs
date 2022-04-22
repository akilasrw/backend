using Aeroclub.Cargo.Application.Models.RequestModels;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAccountService
    {
        void Register(RegisterRequestRM model, string origin);
    }
}
