using Exercice_Formulaire_Etudiant.Models;

namespace Exercice_Formulaire_Etudiant.ViewModels
{
    public class EmployeIndexVM
    {
        public string Name { get; set; }

        public int age { get; set; }

        public DateTimeOffset dateEmbauche { get; set; } = DateTimeOffset.Now;

        public double annualSalary { get; set; }

        public bool actualEmploye { get; set; }

        public IList<Pays> pays { get; set; } = new List<Pays>();

        public IList<Departement> departements { get; set; } = new List<Departement>();

        public int paysId { get; set; }

        public int departementId { get; set; }
    }
}
