namespace Api_CedeSys_v2.Application.Dtos.Auth
{
    public sealed class Response_EmpresaDto
    {
        public int IdEmpresa { get; set; }
        public string CodeEmpresa { get; set; } = string.Empty;
        public string NombreEmpresa { get; set; } = string.Empty;
        public string UrlImgEmpresa { get; set; } = string.Empty;
    }
}