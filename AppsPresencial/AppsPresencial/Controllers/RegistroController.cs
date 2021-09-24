using AppsPresencial.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPresencial.Controllers
{
    public class RegistroController : Controller
    {
        public IActionResult Indexxx()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();

        }

        public IActionResult Index(ClsValidez Validacion)
        {

            if (ModelState.IsValid)
            {
                return View("Registro");
            }
               


            else
            {
                return View("Index");
            }

        }
    }
}
