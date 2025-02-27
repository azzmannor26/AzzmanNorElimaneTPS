using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 📌 Création du gestionnaire des ressources humaines
            RessourceHumaine rh = new RessourceHumaine();

            // 📌 Ajout d'enseignants
            Enseignant e1 = new Enseignant(101, "Ali", "Bennani", "Bureau 12", 5000, 1000, "PA", 20);
            Enseignant e2 = new Enseignant(102, "Kenza", "Amrani", "Bureau 14", 5500, 1200, "PES", 30);
            rh.AjouterPersonnel(e1);
            rh.AjouterPersonnel(e2);

            // 📌 Affichage des enseignants
            Console.WriteLine("\n🔹 Liste des enseignants :");
            rh.AfficherEnseignants();

            // 📌 Ajout de groupes aux enseignants
            Groupe groupeA = new Groupe("Groupe A");
            Groupe groupeB = new Groupe("Groupe B");
            Groupe groupeC = new Groupe("Groupe C");

            e1.AjouterGroupe(groupeA);
            e1.AjouterGroupe(groupeB);
            e2.AjouterGroupe(groupeC);

            // 📌 Ajout d'étudiants aux groupes
            Etudiant et1 = new Etudiant(201, "Ahmed", "Omar", "Master", 15);
            Etudiant et2 = new Etudiant(202, "Fatima", "Zahra", "Licence", 16);
            Etudiant et3 = new Etudiant(203, "Mehdi", "Tazi", "Master", 17);

            e1["Groupe A"]?.AjouterEtudiant(et1);
            e1["Groupe B"]?.AjouterEtudiant(et2);
            e2["Groupe C"]?.AjouterEtudiant(et3);

            // 📌 Affichage des enseignants après l'ajout des groupes et étudiants
            Console.WriteLine("\n📌 Affichage des enseignants avec leurs groupes :");
            rh.AfficherEnseignants();

            // 📌 Affichage des groupes d'un enseignant
            Console.WriteLine("\n📌 Affichage des groupes de l'enseignant Ali Bennani :");
            groupeA.AfficherEtudiants();
            groupeB.AfficherEtudiants();

            Console.WriteLine("\n📌 Affichage des groupes de l'enseignant Kenza Amrani :");
            groupeC.AfficherEtudiants();

            // 📌 Recherche d'un enseignant existant
            Console.WriteLine("\n🔎 Recherche de l'enseignant avec code 101 :");
            int position = rh.RechercherEnseignant(101);
            Console.WriteLine(position != -1 ? $"✅ Enseignant trouvé à la position {position}" : "❌ Enseignant non trouvé.");

            // 📌 Recherche d'un enseignant inexistant
            Console.WriteLine("\n🔎 Recherche de l'enseignant avec code 999 :");
            int positionInexistante = rh.RechercherEnseignant(999);
            Console.WriteLine(positionInexistante != -1 ? $"✅ Enseignant trouvé à la position {positionInexistante}" : "❌ Enseignant non trouvé.");
        }
    }
    }

