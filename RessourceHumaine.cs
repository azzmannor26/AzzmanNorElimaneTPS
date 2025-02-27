using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class RessourceHumaine : IRessourceHumaine
    {

        private List<Personnel> GRH = new List<Personnel>();

        public void AjouterPersonnel(Personnel p)
        {
            GRH.Add(p);
        }

        public void AfficherEnseignants()
        {
            Console.WriteLine("\n📌 Liste des Enseignants :");
            bool found = false;

            foreach (var p in GRH)
            {
                if (p is Enseignant ens)
                {
                    Console.WriteLine(ens.ToString());
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("⚠️ Aucun enseignant trouvé !");
            }
        }

        public int RechercherEnseignant(int code)
        {
            return GRH.FindIndex(p => p is Enseignant && p.code == code);
        }
    }
}