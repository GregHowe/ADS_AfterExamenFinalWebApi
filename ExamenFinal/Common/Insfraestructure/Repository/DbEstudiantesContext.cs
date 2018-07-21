using Microsoft.EntityFrameworkCore;

namespace ExamenFinal.Common.Insfraestructure.Repository
{
    using ExamenFinal.Estudiante.domain.entity;

    public class DbEstudiantesContext : DbContext
    {
        public DbEstudiantesContext()
        {
        }

        public DbEstudiantesContext(DbContextOptions<DbEstudiantesContext> options) : base(options)
        {
        }

        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<NivelEstudio> NivelEstudios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstudiantePreGrado>();
            modelBuilder.Entity<EstudianteMaestria>();
            modelBuilder.Entity<EstudianteDoctorado>();
            modelBuilder.Entity<NivelEstudio>();
            base.OnModelCreating(modelBuilder);

        }
    }
}
