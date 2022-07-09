using ExamenFinalBurgaFInanzas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamenFinalBurgaFInanzas.ConexionDB.Maps
{
    public class GastoMap: IEntityTypeConfiguration<Gasto>
    {
        public void Configure(EntityTypeBuilder<Gasto> builder)
        {
            builder.ToTable("Gasto");
            builder.HasKey(o => o.Id);

         

        }
    }
}
