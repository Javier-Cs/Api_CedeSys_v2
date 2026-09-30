namespace Api_CedeSys_v2.Application.Dtos.Auth
{
    public class Request_UsuarioLoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string CodeEmpresa { get; set; } = string.Empty;
    }
}
