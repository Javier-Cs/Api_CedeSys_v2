namespace Api_CedeSys_v2.Application.Dtos.Auth
{
    public class Response_UsuarioLoginDto
    {
        public string Token { get; set; } = string.Empty;
        public DateTime Expiracion { get; set; }
        public Response_UserDto UsuarioResponseDto { get; set; } = null!;

    }
}
