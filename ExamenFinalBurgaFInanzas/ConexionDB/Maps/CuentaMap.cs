using ExamenFinalBurgaFInanzas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamenFinalBurgaFInanzas.ConexionDB.Maps
{
    public class CuentaMap: IEntityTypeConfiguration<Cuenta>
    {
        public void Configure(EntityTypeBuilder<Cuenta> builder)
        {
            builder.ToTable("Cuenta");
            builder.HasKey(o => o.Id);

         

        }
    }
}
