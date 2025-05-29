namespace FastEndpoint.Application.Common.Interfaces.Services;

public interface IJwtTokenProvider
{
    // string GenerateToken(User user);
    string GenerateToken(string firstName, string lastName, string role, string email);
}