using Microsoft.AspNetCore.Identity;

namespace AUTHULU.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}
