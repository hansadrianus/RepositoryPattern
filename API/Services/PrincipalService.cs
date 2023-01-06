using API.Exceptions;
using Application.Interfaces.Services;
using System.Security.Claims;

namespace API.Services
{
    public class PrincipalService : IPrincipalService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PrincipalService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserId
        {
            get
            {
                var claimsPrincipal = _httpContextAccessor.HttpContext?.User;
                if (claimsPrincipal == null)
                    throw new MissingClaimsPrincipalException();

                return claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0";
            }
        }
    }
}
