using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using ExamenFinalBurgaFInanzas.ConexionDB;
using ExamenFinalBurgaFInanzas.Models;

namespace ExamenFinalBurgaFInanzas.Repository
{
    
    public interface ICuentaRepository
    {
        public void RegistrarCuenta(Cuenta cuenta);
        public void Gasto(Gasto gasto);
        public List<Gasto> Gastos(int IdCuenta);
        public Cuenta BuscarCuenta(int IdCuenta);
        
        public List<Cuenta> ListarCuentas (int IdUsuario);

        public double MontoEnSoles(int IdCuenta);
        public void ingresarDinero(Ingresos ingresos);

        public List<Ingresos> ListaIngresosCuenta(int IdCuenta);
        

    }
    public class CuentaRepository: ICuentaRepository
    {
        private FinalContext _context;

        public CuentaRepository(FinalContext context)
        {
            _context = context;
        }


        public void RegistrarCuenta(Cuenta cuenta)
        {
            Cuenta nueva = new Cuenta();
            nueva.Nombre = cuenta.Nombre;
            nueva.Categoria = cuenta.Categoria;
            nueva.Moneda = cuenta.Moneda;
            nueva.IdPropietario = cuenta.IdPropietario;
            nueva.SaldoInicial = cuenta.SaldoTotal;
            nueva.SaldoTotal = cuenta.SaldoTotal;
            _context.Cuentas.Add(nueva);
            _context.SaveChanges();

        }

        public void Gasto(Gasto gasto)
        {
            Gasto nuevo = new Gasto();
          
            var cuenta = BuscarCuenta(gasto.IdCuenta);
            if (cuenta.Categoria=="Propia")
            {
                nuevo.monto = gasto.monto;
                nuevo.Descripcion = gasto.Descripcion;
                nuevo.IdCuenta = cuenta.Id;
                nuevo.FechaYHora = DateTime.Now;

                if (cuenta.SaldoTotal>=gasto.monto)
                {
                    cuenta.SaldoTotal = cuenta.SaldoTotal - gasto.monto;
                    _context.Gastos.Add(nuevo);
                    _context.Cuentas.Update(cuenta);
                    _context.SaveChanges();
                }
            }
            else
            {
                nuevo.monto = gasto.monto;
                nuevo.Descripcion = gasto.Descripcion;
                nuevo.IdCuenta = cuenta.Id;
                nuevo.FechaYHora = DateTime.Now;
                cuenta.SaldoTotal = cuenta.SaldoTotal - gasto.monto;
                _context.Gastos.Add(nuevo);
                
                _context.Cuentas.Update(cuenta);
                _context.SaveChanges();
            }
        }

        public List<Gasto> Gastos(int IdCuenta)
        {
            List<Gasto> misGastos = new List<Gasto>();
            var gastos = _context.Gastos.ToList();
            foreach (var item in gastos)
            {
                if (item.IdCuenta==IdCuenta)
                {
                    misGastos.Add(item);
                }
            }

            return misGastos;
        }
   

        public Cuenta BuscarCuenta(int IdCuenta)
        {
            var cuenta = _context.Cuentas.Where(o => o.Id == IdCuenta).FirstOrDefault();
            return cuenta;
        }

        public List<Cuenta> ListarCuentas(int IdUsuario)
        {
            List<Cuenta> misCuentas = new List<Cuenta>();
            var cuentas = _context.Cuentas.ToList();
            foreach (var item in cuentas)
            {
                if (item.IdPropietario==IdUsuario)
                {
                    misCuentas.Add(item);
                }
            }

            return misCuentas;
        }

        public double MontoEnSoles(int IdCuenta)
        {
            var cuenta = BuscarCuenta(IdCuenta);
            Double total = new Double();
            if (cuenta.Categoria=="Soles")
            {
                total = cuenta.SaldoTotal;
            }
            else if ((cuenta.Categoria == "Dolares"))
            {
                total = cuenta.SaldoTotal*3.85;
            }
            else if ((cuenta.Categoria == "Euro"))
            {
                total = cuenta.SaldoTotal*3.95;
            }

            return total;

        }

        public void ingresarDinero(Ingresos ingresos)
        {
            Ingresos nuevo = new Ingresos();
            var cuenta = BuscarCuenta(ingresos.IdCuenta);
            cuenta.SaldoTotal = cuenta.SaldoTotal + ingresos.monto;
            nuevo.IdCuenta = ingresos.IdCuenta;
            nuevo.FechaYHora = DateTime.Now;
            nuevo.monto = ingresos.monto;
            nuevo.Descripcion = ingresos.Descripcion;
            nuevo.IdPropietario = ingresos.IdPropietario;
            _context.Ingresoss.Add(nuevo);
            _context.Cuentas.Update(cuenta);
            _context.SaveChanges();
        }

        public List<Ingresos> ListaIngresosCuenta(int IdCuenta)
        {
            List<Ingresos> misin = new List<Ingresos>();
            var ingresos = _context.Ingresoss.ToList();
            foreach (var item in ingresos)
            {
                if (item.IdCuenta==IdCuenta)
                {
                    misin.Add(item);
                }
            }

            return misin;
        }
    }
}
