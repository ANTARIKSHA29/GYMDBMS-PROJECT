using GYMDBMS.Models;
using Microsoft.AspNetCore.Mvc;
using SkyhawkFitnessClub.ViewModels;
namespace SkyhawkFitness.Controllers
{
    public class SearchController : Controller
    {
        private readonly GYMContext _context;

        public SearchController(GYMContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
   
}