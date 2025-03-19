using Exercice_Formulaire_Etudiant.Data;
using Exercice_Formulaire_Etudiant.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Exercice_Formulaire_Etudiant.Controllers
{
    public class EmployeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View(new EmployeIndexVM());
        }

        [HttpPost]
        public IActionResult Create(EmployeIndexVM vm)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}

