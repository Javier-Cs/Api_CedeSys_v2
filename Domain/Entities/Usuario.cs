using Api_CedeSys_v2.Domain.Enum;

namespace Api_CedeSys_v2.Domain.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int EmpresaId { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public RolUsuario Rol { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PassHash { get; set; } = string.Empty;
        public string DireccionUsuario { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public string UrlImgUsuario { get; set; } = string.Empty;
        public bool EstadoUsuario { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime? UltimoLogin { get; set; }
        public DateTime FechaCreacionUsuario { get; set; }
        public DateTime FechaModificacionUsuario { get; set; }

        // Navegacion
        public Empresa Empresa { get; set; } = null!;
    }
}
