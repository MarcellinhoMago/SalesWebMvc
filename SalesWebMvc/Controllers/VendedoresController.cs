using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorServicos _vendedorServicos;

        public VendedoresController(VendedorServicos vendedorServicos)
        {
            _vendedorServicos = vendedorServicos;
        }

        public IActionResult Index()
        {
            var list = _vendedorServicos.FindAll();
            return View(list);
        }
    }
}
