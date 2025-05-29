using FastEndpoint.Infrastructure;
using FastEndpoint.Test;
using FastEndpoints;
using FastEndpoints.Security;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder();
{
    builder.Services
        .AddPresentation(builder.Configuration)
        .AddInfrastructure(builder.Configuration)
        .AddAuthenticationJwtBearer(s => s.SigningKey = builder.Configuration["JwtSettings:Secret"])
        .AddAuthorization()
        .AddFastEndpoints()
        .SwaggerDocument();
}

var app = builder.Build();
{
    app
        .UseAuthentication()
        .UseAuthorization()
        .UseFastEndpoints()
        .UseSwaggerGen();
    app.Run();
}