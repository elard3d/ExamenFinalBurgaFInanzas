using System;

namespace ExamenFinalBurgaFInanzas.Models
{
    public class Cuenta
    {
        
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Categoria { get; set; }
        public double SaldoInicial { get; set; }
        public double SaldoTotal { get; set; }
        public String Moneda { get; set; }
        public int IdPropietario { get; set; }
    }
}