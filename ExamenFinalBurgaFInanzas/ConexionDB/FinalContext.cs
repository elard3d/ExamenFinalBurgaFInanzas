using ExamenFinalBurgaFInanzas.ConexionDB.Maps;
using ExamenFinalBurgaFInanzas.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenFinalBurgaFInanzas.ConexionDB
{
    public class FinalContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Ingresos> Ingresoss { get; set; }
     
        public FinalContext(DbContextOptions<FinalContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new GastoMap());
            modelBuilder.ApplyConfiguration(new CuentaMap());
            modelBuilder.ApplyConfiguration(new IngresosMap());
        }
    }
}