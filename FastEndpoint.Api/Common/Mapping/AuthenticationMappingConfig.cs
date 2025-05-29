using Mapster;

namespace FastEndpoint.Test.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        // config.NewConfig<LoginRequest, LoginQuery>();

        // config.NewConfig<RegisterRequest, RegisterCommand>();

        // config.NewConfig<AuthenticationResult, AuthenticationResponse>()
        //     .Map(dest => dest, src => src.User);
    }
}