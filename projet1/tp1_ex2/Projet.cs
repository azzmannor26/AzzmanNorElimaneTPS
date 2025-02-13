using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet1.tp1_ex2
{
    internal class Projet
    {
        public string Code { get; set; }
        public string Sujet { get; set; }
        public int DureeSemaines { get; set; }
        private List<Programmeur> programmeurs;
        private Dictionary<int, List<int>> consommations; // ID du programmeur et liste de consommations par semaine

        public Projet(string code, string sujet, int dureeSemaines)
        {
            Code = code;
            Sujet = sujet;
            DureeSemaines = dureeSemaines;
            programmeurs = new List<Programmeur>();
            consommations = new Dictionary<int, List<int>>();
        }

        public void AjouterProgrammeur(Programmeur p)
        {
            programmeurs.Add(p);
            consommations[p.Id] = new List<int>(new int[DureeSemaines]);
            Console.WriteLine("Programmeur ajouté.");
        }

        public Programmeur RechercherProgrammeur(int id)
        {
            return programmeurs.Find(p => p.Id == id);
        }

        public void AfficherProgrammeur(int id)
        {
            Programmeur p = RechercherProgrammeur(id);
            if (p != null)
            {
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("Programmeur introuvable.");
            }
        }

        public void AfficherListeProgrammeurs()
        {
            foreach (var p in programmeurs)
            {
                Console.WriteLine(p);
            }
        }

        public void AjouterConsommation(int id, int semaine, int tasses)
        {
            if (consommations.ContainsKey(id) && semaine <= DureeSemaines)
            {
                consommations[id][semaine - 1] += tasses;
                Console.WriteLine("Consommation ajoutée.");
            }
            else
            {
                Console.WriteLine("Programmeur ou semaine invalide.");
            }
        }

        public void AfficherConsommationTotale(int semaine)
        {
            int total = 0;
            foreach (var consommation in consommations.Values)
            {
                total += consommation[semaine - 1];
            }
            Console.WriteLine($"Consommation totale de café pour la semaine {semaine}: {total} tasses.");
        }

        public void SupprimerProgrammeur(int id)
        {
            Programmeur p = RechercherProgrammeur(id);
            if (p != null)
            {
                programmeurs.Remove(p);
                consommations.Remove(id);
                Console.WriteLine("Programmeur supprimé.");
            }
            else
            {
                Console.WriteLine("Programmeur introuvable.");
            }
        }
    }
}
