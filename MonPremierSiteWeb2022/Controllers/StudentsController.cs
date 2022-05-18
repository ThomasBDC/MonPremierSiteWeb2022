using Microsoft.AspNetCore.Mvc;
using MonPremierSiteWeb2022.Models;
using MonPremierSiteWeb2022.Models.Students.Cours;

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


        public IActionResult CoursForStudent(int idStudent)
        {
            var allCours = CoursRepository.GetCoursForStudents(idStudent);

            var vm = new CoursViewModel()
            {
                listCours = allCours
            };

            return View(vm);
        }
    }
}
