using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace GestionComptesBancaires
{
    internal class Program
    {
        static Dictionary<int, Compte> comptes = new Dictionary<int, Compte>();

        static void Main(string[] args)
        {
            ChargerComptes();

            bool continuer = true;
            while (continuer)
            {
                Console.WriteLine("\nMenu principal :");
                Console.WriteLine("1) Ajouter un nouveau compte");
                Console.WriteLine("2) Rechercher un compte");
                Console.WriteLine("3) Supprimer un compte");
                Console.WriteLine("4) Opération sur un compte");
                Console.WriteLine("5) Afficher tous les comptes");
                Console.WriteLine("6) Quitter le programme");
                Console.Write("Choisissez une option : ");
                int choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        AjouterCompte();
                        break;
                    case 2:
                        RechercherCompte();
                        break;
                    case 3:
                        SupprimerCompte();
                        break;
                    case 4:
                        OperationCompte();
                        break;
                    case 5:
                        AfficherTousLesComptes();
                        break;
                    case 6:
                        continuer = false;
                        SauvegarderComptes();
                        break;
                    default:
                        Console.WriteLine("Option invalide.");
                        break;
                }
            }
        }

        static void AjouterCompte()
        {
            Console.Write("Entrez le numéro du compte : ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entrez le nom du client : ");
            string nom = Console.ReadLine();
            Console.Write("Entrez le prénom du client : ");
            string prenom = Console.ReadLine();

            if (!comptes.ContainsKey(numero))
            {
                comptes[numero] = new Compte(numero, nom, prenom);
                Console.WriteLine("Création de compte effectuée.");
            }
            else
            {
                Console.WriteLine("Le compte existe déjà.");
            }
        }

        static void RechercherCompte()
        {
            Console.Write("Entrez le numéro du compte : ");
            int numero = int.Parse(Console.ReadLine());

            if (comptes.ContainsKey(numero))
            {
                Compte c = comptes[numero];
                Console.WriteLine($"Compte trouvé : {c.Nom} {c.Prenom}, Solde : {c.Solde} dhs");
            }
            else
            {
                Console.WriteLine("Le compte n'existe pas.");
            }
        }

        static void SupprimerCompte()
        {
            Console.Write("Entrez le numéro du compte à supprimer : ");
            int numero = int.Parse(Console.ReadLine());

            if (comptes.Remove(numero))
            {
                Console.WriteLine("Compte supprimé.");
            }
            else
            {
                Console.WriteLine("Le compte n'existe pas.");
            }
        }

        static void OperationCompte()
        {
            Console.Write("Entrez le numéro du compte : ");
            int numero = int.Parse(Console.ReadLine());

            if (comptes.ContainsKey(numero))
            {
                Compte compte = comptes[numero];
                Console.WriteLine("\nMenu des opérations :");
                Console.WriteLine("1) Créditer");
                Console.WriteLine("2) Débiter");
                Console.WriteLine("3) Historique");
                Console.Write("Choisissez une option : ");
                int choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        Console.Write("Entrez le montant à créditer : ");
                        double montant = double.Parse(Console.ReadLine());
                        compte.Crediter(montant);
                        break;

                    case 2:
                        Console.Write("Entrez le montant à débiter : ");
                        montant = double.Parse(Console.ReadLine());
                        compte.Debiter(montant);
                        break;

                    case 3:
                        compte.AfficherHistorique();
                        break;

                    default:
                        Console.WriteLine("Option invalide.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Le compte n'existe pas.");
            }
        }

        static void AfficherTousLesComptes()
        {
            foreach (var compte in comptes.Values)
            {
                Console.WriteLine($"{compte.Numero} - {compte.Nom} {compte.Prenom}, Solde : {compte.Solde} dhs");
            }
        }

        static void ChargerComptes()
        {
            if (File.Exists("comptes.json"))
            {
                string json = File.ReadAllText("comptes.json");
                comptes = JsonConvert.DeserializeObject<Dictionary<int, Compte>>(json);
            }
        }

        static void SauvegarderComptes()
        {
            string json = JsonConvert.SerializeObject(comptes, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("comptes.json", json);
        }
    
}
}
