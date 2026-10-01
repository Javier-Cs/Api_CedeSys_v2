using Api_CedeSys_v2.Application.Dtos.Auth;

namespace Api_CedeSys_v2.Application.Services.Auth
{
    public class AuthService : IAuthService
    {
        public Task<Response_UsuarioLoginDto> LoginAsync(Request_UsuarioLoginDto request_UsuarioLoginDto, string ip, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
