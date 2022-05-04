using Aeroclub.Cargo.Infrastructure.UserResolver.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Aeroclub.Cargo.Infrastructure.UserResolver.Services
{
    public class UserResolverService : IUserResolverService
    {
        private readonly IHttpContextAccessor _context;

        public UserResolverService(IHttpContextAccessor context)
        {
            _context = context;
        }

        public Guid GetUserId()
        {
            var idClaim = _context.HttpContext.User?.FindFirst("Userid");

            return idClaim != null ? Guid.Parse(idClaim.Value) : Guid.Empty;
        }
    }
}
