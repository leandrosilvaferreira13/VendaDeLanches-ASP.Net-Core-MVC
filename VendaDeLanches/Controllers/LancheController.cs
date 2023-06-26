using Microsoft.AspNetCore.Mvc;
using VendaDeLanches.Repositories;
using VendaDeLanches.Repositories.Interfaces;

namespace VendaDeLanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
           _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;

            var lanches = _lancheRepository.Lanches;
            var totalLanches = lanches.Count();

            ViewBag.Total = "Total de Lanches";
            ViewBag.TotalLanches = totalLanches;
            return View(lanches);
        }
    }
}
