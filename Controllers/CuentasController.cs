using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoBanca.Models;
using ProyectoBanca.Data;

namespace ProyectoBanca.Controllers
{
    public class CuentasController : Controller
    {
        private readonly ILogger<CuentasController> _logger;
        private readonly ApplicationDbContext _context;


        public CuentasController(ILogger<CuentasController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarCuenta(Cuentas cuenta)
        {
            _logger.LogDebug("Ingreso a Enviar Mensaje");

            //Se registran los datos del objeto a la base datos
            _context.Add(cuenta);
            _context.SaveChanges();

            ViewData["Message"] = "!!!! Se realizo el registro exitosamente !!!!";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}