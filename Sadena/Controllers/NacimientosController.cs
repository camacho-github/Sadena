using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sadena.Models;

namespace Sadena.Controllers
{
    public class NacimientosController : Controller
    {
        public IActionResult Comparar()
        {
            return View();
        }

        public IActionResult Consultar()
        {
            return View();
        }

        public IActionResult Importar()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
