using Exercice_Formulaire_Etudiant.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Exercice_Formulaire_Etudiant.ViewModels
{
    public class EmployeIndexVM
    {
        [DisplayName("Nom")]
        public string Name { get; set; }

        [DisplayName("Age")]
        public int age { get; set; }

        [DisplayName("Date d'embauche")]
        [DataType(DataType.Date)]
        public DateTime dateEmbauche { get; set; } = DateTime.Today;
        [DisplayName("Salaire annuel")]
        public double annualSalary { get; set; }

        [DisplayName("Présentement à l’emploi?")]
        public bool actualEmploye { get; set; }

        public IList<Pays> pays { get; set; } = new List<Pays>();

        public IList<Departement> departements { get; set; } = new List<Departement>();

        [DisplayName("Pays d'origine")]
        public int paysId { get; set; }
        [DisplayName("Département de travail")]
        public int departementId { get; set; }


    }
}
