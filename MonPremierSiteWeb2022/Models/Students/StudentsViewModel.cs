using System.Collections.Generic;

namespace MonPremierSiteWeb2022.Models
{
    //Modèle de vue
    public class StudentsViewModel
    {
        public List<StudentsModel> lstStudents { get; set; }
    }

    //Modèle de domaine
    public class StudentsModel
    {
        public StudentsModel(string nom, string prenom, string promo)
        {
            Nom = nom;
            Prenom = prenom;
            Promo = promo;
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Promo { get; set; }
    }

    //Notre BDD
    public static class StudentsDatas
    {
        public static List<StudentsModel> allStudents = new List<StudentsModel>
        {
            new StudentsModel("BUTIN", "Dominique", "Full stack"),
            new StudentsModel("DISS", "Christelle", "C# .net"),
            new StudentsModel("DAUCE", "Laurent", "Full stack"),
            new StudentsModel("DAUCE", "Laurent", "Web"),
            new StudentsModel("ALPHONSE", "Rooldy", "Java"),
            new StudentsModel("CANUEL", "Stéphanie", "C# .net"),
            new StudentsModel("CLEMENCEY", "Yann", "C# .net")
        };
    }
}
