using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet1.tp1_ex1
{
    internal class Repertoire
    {
        public string Nom { get; set; }
        public int NbrFichiers { get; private set; }  // Nombre de fichiers dans le répertoire
        private Fichier[] fichiers;

        public Repertoire(string nom)
        {
            Nom = nom;
            fichiers = new Fichier[30];  // Tableau de 30 références vers des objets de type Fichier
            NbrFichiers = 0;
        }

        public void Afficher()
        {
            Console.WriteLine($"Répertoire: {Nom}");
            for (int i = 0; i < NbrFichiers; i++)
            {
                Console.WriteLine(fichiers[i]);
            }
        }

        public int Rechercher(string nomFichier)
        {
            for (int i = 0; i < NbrFichiers; i++)
            {
                if (fichiers[i].Nom.Equals(nomFichier, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        public void Ajouter(Fichier fichier)
        {
            if (NbrFichiers < 30)
            {
                fichiers[NbrFichiers] = fichier;
                NbrFichiers++;
                Console.WriteLine("Fichier ajouté.");
            }
            else
            {
                Console.WriteLine("Le répertoire est plein.");
            }
        }

        public void RechercherExtensionPDF()
        {
            Console.WriteLine("Fichiers avec l'extension PDF:");
            for (int i = 0; i < NbrFichiers; i++)
            {
                if (fichiers[i].Extension.Equals("pdf", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(fichiers[i]);
                }
            }
        }

        public void Supprimer(string nomFichier)
        {
            int index = Rechercher(nomFichier);
            if (index != -1)
            {
                for (int i = index; i < NbrFichiers - 1; i++)
                {
                    fichiers[i] = fichiers[i + 1];
                }
                fichiers[NbrFichiers - 1] = null;
                NbrFichiers--;
                Console.WriteLine("Fichier supprimé.");
            }
            else
            {
                Console.WriteLine("Fichier introuvable.");
            }
        }

        public void Renommer(string ancienNom, string nouveauNom)
        {
            int index = Rechercher(ancienNom);
            if (index != -1)
            {
                fichiers[index].Nom = nouveauNom;
                Console.WriteLine("Nom du fichier modifié.");
            }
            else
            {
                Console.WriteLine("Fichier introuvable.");
            }
        }

        public void ModifierTaille(string nomFichier, float nouvelleTaille)
        {
            int index = Rechercher(nomFichier);
            if (index != -1)
            {
                fichiers[index].Taille = nouvelleTaille;
                Console.WriteLine("Taille du fichier modifiée.");
            }
            else
            {
                Console.WriteLine("Fichier introuvable.");
            }
        }

        public float GetTaille()
        {
            float tailleTotale = 0;
            for (int i = 0; i < NbrFichiers; i++)
            {
                tailleTotale += fichiers[i].Taille;
            }
            return tailleTotale / 1024;  // Conversion en Mo
        }
    }
}
