using Api_CedeSys_v2.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_CedeSys_v2.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder) {
            builder.ToTable("usuario_tbl");

            builder.HasKey(x => x.IdUsuario);

            builder.Property(x => x.IdUsuario)
                .HasColumnName("id_usuario")
                .IsRequired();

            builder.Property(x => x.EmpresaId)
                .HasColumnName("id_empresa")
                .IsRequired();

            builder.Property(x => x.NombreUsuario)
                .HasColumnName("nombre_user")
                .HasMaxLength(70)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.Rol)
                .HasColumnName("rol")
                .HasConversion<string>()
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnName("email")
                .HasMaxLength(70)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.PassHash)
                .HasColumnName("pass_hash")
                .HasMaxLength(300)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.DireccionUsuario)
                .HasColumnName("direccion_user")
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.Cedula)
                .HasColumnName("cedula_user")
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.UrlImgUsuario)
                .HasColumnName("url_img_user")
                .HasMaxLength(300)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.EstadoUsuario)
                .HasColumnName("estado_user")
                .HasDefaultValue(true)
                .IsRequired();

            builder.Property(x => x.IsDeleted)
                .HasColumnName("is_deleted")
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.UltimoLogin)
                .HasColumnName("ultimo_login")
                .IsRequired(false);

            builder.Property(x => x.FechaCreacionUsuario)
                .HasColumnName("fecha_creacion_usuario")
                .HasDefaultValueSql("SYSUTCDATETIME()")
                .IsRequired();

            builder.Property(x => x.FechaModificacionUsuario)
                .HasColumnName("fecha_modificacion")
                .HasDefaultValueSql("SYSUTCDATETIME()")
                .IsRequired();

            builder.HasIndex(x => new
            {
                x.EmpresaId,
                x.Email
            }).IsUnique();

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.Usuarios)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);




        }
    }
}
