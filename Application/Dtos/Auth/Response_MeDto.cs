namespace Api_CedeSys_v2.Application.Dtos.Auth
{
    public sealed class Response_MeDto
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
        public string UrlImgUsuario { get; set; } = string.Empty;
        public Response_EmpresaDto Empresa { get; set; } = null!;
    }
}