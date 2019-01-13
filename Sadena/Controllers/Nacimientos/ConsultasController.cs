using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sadena.Controllers.Nacimientos.Consultas
{

    public class ConsultasController : Controller
    {

        // GET: Consultas
        public ActionResult Consultar()
        {
            return View();
        }


    }
}