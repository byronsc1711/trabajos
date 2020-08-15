using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AfectacionMedioAmbiental.Models;

namespace AfectacionMedioAmbiental.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Celular> Celulares { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Automovil> Automoviles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioAutomovil> UsuarioAutomoviles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioAutomovil>()
                .HasKey(ua => new { ua.UsuarioId, ua.AutomovilId });

            modelBuilder.Entity<UsuarioAutomovil>()
                .HasOne(ua => ua.Automovil)
                .WithMany(a => a.UsuarioAutomoviles)
                .HasForeignKey(ua => ua.AutomovilId);

            modelBuilder.Entity<UsuarioAutomovil>()
               .HasOne(ua => ua.Usuario)
               .WithMany(u => u.UsuarioAutomoviles)
               .HasForeignKey(ua => ua.UsuarioId);

        }
    }
}
