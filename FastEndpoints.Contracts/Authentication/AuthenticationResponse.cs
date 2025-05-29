namespace FastEndpoints.Contracts.Authentication;

public record AuthenticationResponse(
    string FirstName,
    string LastName,
    string Role,
    string Email,
    string Token)
{
}