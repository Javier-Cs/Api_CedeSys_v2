using Api_CedeSys_v2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api_CedeSys_v2.Infraestructure.DataBase
{
    public class CedeSysDbCenterContext : DbContext
    {
        // implementamos DbContext
        public CedeSysDbCenterContext(DbContextOptions<CedeSysDbCenterContext> options): base(options) { }


        // nos permite tener acceso a los registros del usuario   y empresa mediante este dbContext
        // nos permitira realizar consultas LINQ a SQL segun la el contexto de la entidad   
        public DbSet<Empresa> Empresa => Set<Empresa>();
        public DbSet<Usuario> Usuario => Set<Usuario>();

        // en objeto ModelBuilder nos permite configurar el modelo completo global
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ApplyConfigurationsFromAssambly nos permite mapear toda las configuraciones de EF Core existentes 
            // en el ensamblado y aplicarlas  
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CedeSysDbCenterContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
