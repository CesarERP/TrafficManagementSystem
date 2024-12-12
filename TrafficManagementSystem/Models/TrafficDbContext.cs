using Microsoft.EntityFrameworkCore;

namespace TrafficManagementSystem.Models
{
    public class TrafficDbContext : DbContext // Heredar de DbContext
    {
        public TrafficDbContext(DbContextOptions<TrafficDbContext> options) : base(options) { }

        // DbSets para tus tablas
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Conductor> Conductores { get; set; }
        public DbSet<Peaje> Peajes { get; set; }
        public DbSet<RegistroTrafico> RegistrosTrafico { get; set; }
        public DbSet<Multa> Multas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Definir claves primarias explícitamente (opcional si están bien definidas en las clases)
            modelBuilder.Entity<Vehiculo>().HasKey(v => v.IDVehiculo);
            modelBuilder.Entity<Conductor>().HasKey(c => c.IDConductor);
            modelBuilder.Entity<Peaje>().HasKey(p => p.IDPeaje);
            modelBuilder.Entity<RegistroTrafico>().HasKey(rt => rt.IDTráfico);
            modelBuilder.Entity<Multa>().HasKey(m => m.IDMulta);
        }
    }
}
