using System;
using System.Collections.Generic;
using ExamenFinalBurgaFInanzas.Models;
using ExamenFinalBurgaFInanzas.Repository;
using ExamenFinalBurgaFInanzas.Service;
using Microsoft.AspNetCore.Mvc;

namespace ExamenFinalBurgaFInanzas.Controllers
{
    public class FinanzasController : Controller
    {
        private readonly IUsuarioRepository _usuario;
        private readonly ICuentaRepository _cuenta;
        private readonly ICookieAuthService _cookieAuthService;
        
        public FinanzasController(IUsuarioRepository _usuario,ICuentaRepository _cuenta, ICookieAuthService _cookieAuthService)
        {
            this._cuenta = _cuenta;
            this._usuario = _usuario;
            this._cookieAuthService = _cookieAuthService;
        }
        public IActionResult Index()
        {
            ViewBag.listaDeCuentas = _cuenta.ListarCuentas(LoggedUser().Id);
            
            return View();
        }
        public IActionResult RegistroCuentaI()
        {
            ViewBag.Categoria = Categorias();
            ViewBag.Moneda = Monedas();
            return View();
        }
        public IActionResult RegistroCuenta(Cuenta cuenta)
        {
            cuenta.IdPropietario = LoggedUser().Id;
            _cuenta.RegistrarCuenta(cuenta);
            
            return RedirectToAction("Index");
        }
        public IActionResult DetalleCuenta(int IdCuenta)
        {
            ViewBag.cuenta=_cuenta.BuscarCuenta(IdCuenta);
            ViewBag.cuentaEnSoles = _cuenta.MontoEnSoles(IdCuenta);
            return View();
        }
        public IActionResult IngresoDineroI(int IdCuenta)
        {
            ViewBag.IdCuenta = IdCuenta;
            return View();
        }
        public IActionResult IngresoDinero(Ingresos ingresos)
        {
            
            _cuenta.ingresarDinero(ingresos);
            return RedirectToAction("Index");
        }
        public IActionResult IngresarGastoI(int IdCuenta)
        {
            ViewBag.IdCuenta = IdCuenta;
            return View();
        }
        public IActionResult IngresarGasto(Gasto gasto)
        {
            _cuenta.Gasto(gasto);
            return RedirectToAction("Index");
        }
        public IActionResult MostrarGastos(int IdCuenta)
        {
            ViewBag.listaDeGastos = _cuenta.Gastos(IdCuenta);
            return View();
        }
        public IActionResult MostrarIngresos(int IdCuenta)
        {
            ViewBag.listaDeIngresos = _cuenta.ListaIngresosCuenta(IdCuenta);
            return View();
        }
        
        
        
        private Usuario LoggedUser()
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            var claim = _cookieAuthService.ObtenerClaim();
            var user = _usuario.ObtenerUsuarioLogin(claim);
            return user;
        }

        public List<String> Categorias()
        {
            List<String> nueva = new List<string>();
            nueva.Add("Propia");
            nueva.Add("Credito");
            return nueva;

        }
        
        public List<String> Monedas()
        {
            List<String> nueva = new List<string>();
            nueva.Add("Soles");
            nueva.Add("Dolares");
            nueva.Add("Euro");
            return nueva;

        }

    }
}