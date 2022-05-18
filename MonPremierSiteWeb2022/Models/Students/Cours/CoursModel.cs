using System.Collections.Generic;

namespace MonPremierSiteWeb2022.Models
{
    public class CoursModel
    {
        public CoursModel(int coursId, string coursName, string matiere, int idStudentPresentation)
        {
            CoursId = coursId;
            CoursName = coursName;
            Matiere = matiere;
            this.idStudentPresentation = idStudentPresentation;
        }

        public int CoursId { get; set; }
        public string CoursName { get; set; }
        public string Matiere { get; set; }
        public int idStudentPresentation { get; set; }
    }
}
