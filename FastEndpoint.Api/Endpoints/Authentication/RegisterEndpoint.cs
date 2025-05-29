using FastEndpoint.Application.Common.Interfaces.Services;
using FastEndpoints;
using FastEndpoints.Contracts.Authentication;

namespace FastEndpoint.Test.Endpoints.Authentication;

public class RegisterEndpoint : Endpoint<RegisterRequest, AuthenticationResponse>
{
    private readonly IJwtTokenProvider _jwtTokenProvider;

    public RegisterEndpoint(IJwtTokenProvider jwtTokenProvider)
    {
        _jwtTokenProvider = jwtTokenProvider;
    }

    public override void Configure()
    {
        Post("/api/auth/register");
        // AllowAnonymous();
    }

    public override async Task HandleAsync(RegisterRequest req, CancellationToken ct)
    {
        var token = _jwtTokenProvider.GenerateToken(req.FirstName, req.LastName, req.Role, req.Email);
        AuthenticationResponse response = new(req.FirstName, req.LastName, req.Role, req.Email, token);

        await SendAsync(response, cancellation: ct);
    }
}