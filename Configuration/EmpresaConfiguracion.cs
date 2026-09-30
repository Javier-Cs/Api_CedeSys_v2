using Api_CedeSys_v2.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_CedeSys_v2.Configuration
{
    public class EmpresaConfiguracion : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder) {

            builder.ToTable("empresa_tbl");

            builder.HasKey(x => x.IdEmpresa);

            builder.Property(x => x.IdEmpresa)
                .HasColumnName("id_empresa")
                .IsRequired();
            
            builder.Property(x => x.CodeEmpresa)
                .HasColumnName("code_empresa")
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.NombreEmpresa)
                .HasColumnName("nombre_empresa")
                .HasMaxLength(70)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.DireccionEmpresa)
                .HasColumnName("direccion_empresa")
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.RucEmpresa)
                .HasColumnName("ruc_empresa")
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.UrlImgEmpresa)
                .HasColumnName("url_img_empresa")
                .HasMaxLength(300)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.EstadoEmpresa)
                .HasColumnName("estado_empresa")
                .HasDefaultValue(true)
                .IsRequired();

            builder.Property(x => x.IsDeleted)
                .HasColumnName("is_deleted")
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.FechaCreacionEmpresa)
                .HasColumnName("fecha_creacion_empresa")
                .HasDefaultValueSql("SYSUTCDATETIME()")
                .IsRequired();

            builder.Property(x => x.FechaModificacionEmpresa)
                .HasColumnName("fecha_modificacion")
                .HasDefaultValueSql("SYSUTCDATETIME()")
                .IsRequired();

            builder.HasIndex(x => x.NombreEmpresa)
                .IsUnique();


        }
    }
}
