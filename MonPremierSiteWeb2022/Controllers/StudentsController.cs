using Microsoft.AspNetCore.Mvc;
using MonPremierSiteWeb2022.Models;

namespace MonPremierSiteWeb2022.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult IndexStudents()
        {
            //Récupération des données en BDD (ici une liste) modèle de domaine
            var tousMesEleves = StudentsDatas.allStudents;

            //On transforme notre modèle de domaine en modèle de vue
            var vm = new StudentsViewModel()
            {
                lstStudents = tousMesEleves
            };

            //On passe le viewModel à la vue
            return View(vm);
        }
    }
}
