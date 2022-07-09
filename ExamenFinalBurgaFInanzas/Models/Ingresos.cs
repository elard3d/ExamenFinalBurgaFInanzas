using System;

namespace ExamenFinalBurgaFInanzas.Models
{
    public class Ingresos
    {
        public int Id { get; set; }
        public int IdCuenta { get; set; }
        public DateTime FechaYHora { get; set; }
        public double monto { get; set; }
        public String Descripcion { get; set; }
        public int IdPropietario { get; set; }
    }
}