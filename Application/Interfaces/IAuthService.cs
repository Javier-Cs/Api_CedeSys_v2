using Api_CedeSys_v2.Application.Dtos.Auth;

namespace Api_CedeSys_v2.Application.Interfaces
{
    public interface IAuthService
    {
        public Task<Response_UsuarioLoginDto> LoginAsync(Request_UsuarioLoginDto request_UsuarioLoginDto, string ip, CancellationToken ct);
    }
}
