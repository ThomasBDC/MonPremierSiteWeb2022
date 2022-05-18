using System.Collections.Generic;
using System.Linq;

namespace MonPremierSiteWeb2022.Models.Students.Cours
{
    public static class CoursRepository
    {
        //La classe repository est la classe qui va se charger d'aller chercher les données en base de donées

        public static List<CoursModel> bddCours = new List<CoursModel>()
        {
            new CoursModel(1, "La PO1", "C#", 1),
            new CoursModel(2, "La PO4", "C#", 1),
            new CoursModel(3, "La PO4", "C#", 2),
            new CoursModel(4, "La PO8", "C#", 2),
            new CoursModel(5, "La PO5", "C#", 3),
            new CoursModel(6, "La PO6", "C#", 4),
        };

        public static List<CoursModel> GetCoursForStudents(int idStudent)
        {
            var maListeDeCours = bddCours;

            var listToReturn = from cours in maListeDeCours
                               where cours.idStudentPresentation == idStudent
                               select cours;

            return listToReturn.ToList();
        }
    }
}
