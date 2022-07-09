using ExamenFinalBurgaFInanzas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamenFinalBurgaFInanzas.ConexionDB.Maps
{
    public class IngresosMap: IEntityTypeConfiguration<Ingresos>
    {
        public void Configure(EntityTypeBuilder<Ingresos> builder)
        {
            builder.ToTable("Ingresos");
            builder.HasKey(o => o.Id);

         

        }
    }
}
