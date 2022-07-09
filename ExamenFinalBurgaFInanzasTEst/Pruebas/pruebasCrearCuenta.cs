using System.Collections.Generic;
using ExamenFinalBurgaFInanzas.Controllers;
using ExamenFinalBurgaFInanzas.Models;
using ExamenFinalBurgaFInanzas.Repository;
using ExamenFinalBurgaFInanzas.Service;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace ExamenFinalBurgaFInanzasTEst.Pruebas
{
    public class pruebasCrearCuenta
    {
        [Test]
        public void RegistroCuenta()
        {
            var controller = new FinanzasController(null, null, null);
            var view = controller.RegistroCuentaI() as ViewResult;


            Assert.IsInstanceOf<ViewResult>(view);
        }
    
      
       
        [Test]
        public void RegistroGasto()
        {
            var usuario = new Usuario();
            Gasto gasto = new Gasto();
            usuario.Password = "admin";
            usuario.Username = "admin";
            List<Cuenta> listaCuentas = new List<Cuenta>();

            var userMock = new Mock<IUsuarioRepository>();
            var cookMock = new Mock<ICookieAuthService>();
            var cuentaMock = new Mock<ICuentaRepository>();
            cuentaMock.Setup(o => o.Gasto(gasto));
            

            var finanzasController = new FinanzasController(null,cuentaMock.Object,null);
            var log = finanzasController.IngresarGasto(gasto);

            Assert.IsInstanceOf<RedirectToActionResult>(log);
        }
        [Test]
        public void ListarGasto()
        {
            var usuario = new Usuario();
            Gasto gasto = new Gasto();
            usuario.Password = "admin";
            usuario.Username = "admin";
            List<Cuenta> listaCuentas = new List<Cuenta>();

            var userMock = new Mock<IUsuarioRepository>();
            var cookMock = new Mock<ICookieAuthService>();
            var cuentaMock = new Mock<ICuentaRepository>();
            cuentaMock.Setup(o => o.Gastos(1));
            

            var finanzasController = new FinanzasController(null,cuentaMock.Object,null);
            var log = finanzasController.MostrarGastos(1);

            Assert.IsInstanceOf<ViewResult>(log);
        }
        [Test]
        public void DetalleCuenta()
        {
            var usuario = new Usuario();
            Gasto gasto = new Gasto();
            usuario.Password = "admin";
            usuario.Username = "admin";
            List<Cuenta> listaCuentas = new List<Cuenta>();

            var userMock = new Mock<IUsuarioRepository>();
            var cookMock = new Mock<ICookieAuthService>();
            var cuentaMock = new Mock<ICuentaRepository>();
            cuentaMock.Setup(o => o.BuscarCuenta(1));
            

            var finanzasController = new FinanzasController(null,cuentaMock.Object,null);
            var log = finanzasController.DetalleCuenta(1);

            Assert.IsInstanceOf<ViewResult>(log);
        }
        [Test]
        public void IngresoDinero()
        {
            var usuario = new Usuario();
            List<Ingresos> nueva = new List<Ingresos>();
            usuario.Password = "admin";
            usuario.Username = "admin";
            List<Cuenta> listaCuentas = new List<Cuenta>();

            var userMock = new Mock<IUsuarioRepository>();
            var cookMock = new Mock<ICookieAuthService>();
            var cuentaMock = new Mock<ICuentaRepository>();
            cuentaMock.Setup(o => o.ingresarDinero(new Ingresos()));
            

            var finanzasController = new FinanzasController(null,cuentaMock.Object,null);
            var log = finanzasController.IngresoDinero(new Ingresos());

            Assert.IsInstanceOf<RedirectToActionResult>(log);
        }

    }
}