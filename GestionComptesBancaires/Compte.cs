using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComptesBancaires
{
    internal class Compte
    {
        public int Numero { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public double Solde { get; set; }
        public List<string> Historique { get; set; }

        public Compte(int numero, string nom, string prenom)
        {
            Numero = numero;
            Nom = nom;
            Prenom = prenom;
            Solde = 0;
            Historique = new List<string>();
        }

        public void Crediter(double montant)
        {
            Solde += montant;
            Historique.Add($"Crédit de {montant} dhs le {DateTime.Now}");
        }

        public void Debiter(double montant)
        {
            if (montant <= Solde)
            {
                Solde -= montant;
                Historique.Add($"Débit de {montant} dhs le {DateTime.Now}");
            }
            else
            {
                Console.WriteLine("Solde insuffisant.");
            }
        }

        public void AfficherHistorique()
        {
            foreach (var operation in Historique)
            {
                Console.WriteLine(operation);
            }
        }
    

}
}
