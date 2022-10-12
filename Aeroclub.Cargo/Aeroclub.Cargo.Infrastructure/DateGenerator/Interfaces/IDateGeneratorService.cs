
using Aeroclub.Cargo.Infrastructure.DateGenerator.Models;

namespace Aeroclub.Cargo.Infrastructure.DateGenerator.Interfaces
{
    public interface IDateGeneratorService
    {
        public List<DateTime> GetDates(DateGeneratorRM dto);
    }
}
