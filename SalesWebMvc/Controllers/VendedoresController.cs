using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
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
        private readonly DepartamentoServicos _departamentoServicos;

        public VendedoresController(VendedorServicos vendedorServicos, DepartamentoServicos departamentoServicos)
        {
            _vendedorServicos = vendedorServicos;
            _departamentoServicos = departamentoServicos;
        }

        public IActionResult Index()
        {
            var list = _vendedorServicos.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departamentos = _departamentoServicos.FindAll();
            var viewModel = new VendedorFromViewModel { Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorServicos.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
