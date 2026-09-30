using Api_CedeSys_v2.Application.Dtos.Auth;
using Api_CedeSys_v2.Application.Interfaces;

namespace Api_CedeSys_v2.Application.Services
{
    public class AuthService : IAuthService
    {
        public Task<Response_UsuarioLoginDto> LoginAsync(Request_UsuarioLoginDto request_UsuarioLoginDto, string ip, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
