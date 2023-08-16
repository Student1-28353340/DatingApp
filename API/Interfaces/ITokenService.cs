using API.Entities;

namespace API.Interfaces;

public interface ITokenService
{
    /// <summary>
    /// Create a JWT for authentication
    /// </summary>
    /// <param name="user">User for which a jWT should be crated</param>
    /// <returns>Returns a string that represents a JWT</returns>
    string CreateToken(AppUser user);
}
