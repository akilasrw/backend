using System;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAircraftService
    {
        Task<string> GetAircraftRegNo(Guid id);
    }
}