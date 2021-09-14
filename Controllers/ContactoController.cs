using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc2_marangon_fabio.Models;

namespace pc2_marangon_fabio.Controllers
{
    public class ContactoController : Controller
    {
        
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear()
        {
            return RedirectToAction("Confirmacion");
        }

        public IActionResult Confirmacion(string a)
        {
            return View();
        }

    }
}