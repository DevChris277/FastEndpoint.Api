namespace FastEndpoints.Contracts.Authentication;

public record RegisterRequest(
    string FirstName,
    string LastName,
    string Role,
    string Email,
    string Password);