using System;
using projet1.tp1_ex1;
using projet1.tp1_ex2;

class Program
{
    static void Main(string[] args)
    {
        bool continuer = true;
        while (continuer)
        {
            Console.WriteLine("\nMenu Principal :");
            Console.WriteLine("1. Exercice 1 - Gestion de Répertoire");
            Console.WriteLine("2. Exercice 2 - Gestion des Programmeurs");
            Console.WriteLine("3. Quitter");
            Console.Write("Choisissez une option : ");
            int choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    Exercice1();
                    break;

                case 2:
                    Exercice2();
                    break;

                case 3:
                    continuer = false;
                    break;

                default:
                    Console.WriteLine("Option invalide.");
                    break;
            }
        }
    }

    static void Exercice1()
    {
        Console.WriteLine("\n--- Exercice 1 : Gestion de Répertoire ---");
        Repertoire monRepertoire = new Repertoire("Mes Documents");

        monRepertoire.Ajouter(new Fichier("cours", "pdf", 500));
        monRepertoire.Ajouter(new Fichier("notes", "docx", 300));
        monRepertoire.Ajouter(new Fichier("presentation", "pdf", 700));

        monRepertoire.Afficher();

        Console.WriteLine($"\nTaille totale du répertoire : {monRepertoire.GetTaille()} Mo");

        Console.WriteLine("\nRecherche du fichier 'notes':");
        int index = monRepertoire.Rechercher("notes");
        Console.WriteLine(index != -1 ? $"Fichier trouvé à l'indice {index}." : "Fichier introuvable.");

        Console.WriteLine("\nRecherche des fichiers avec l'extension PDF:");
        monRepertoire.RechercherExtensionPDF();

        Console.WriteLine("\nModification du nom du fichier 'notes' en 'memo':");
        monRepertoire.Renommer("notes", "memo");
        monRepertoire.Afficher();

        Console.WriteLine("\nModification de la taille du fichier 'memo':");
        monRepertoire.ModifierTaille("memo", 400);
        monRepertoire.Afficher();

        Console.WriteLine("\nSuppression du fichier 'memo':");
        monRepertoire.Supprimer("memo");
        monRepertoire.Afficher();
    }

    static void Exercice2()
    {
        Console.WriteLine("\n--- Exercice 2 : Gestion des Programmeurs ---");
        Projet projet = new Projet("P123", "Gestion des consommations de café", 4);

        bool continuer = true;
        while (continuer)
        {
            Console.WriteLine("\nMenu :");
            Console.WriteLine("1. Ajouter un programmeur");
            Console.WriteLine("2. Rechercher un programmeur");
            Console.WriteLine("3. Afficher la liste des programmeurs");
            Console.WriteLine("4. Ajouter une consommation");
            Console.WriteLine("5. Afficher la consommation totale pour une semaine");
            Console.WriteLine("6. Supprimer un programmeur");
            Console.WriteLine("7. Retour au menu principal");
            Console.Write("Choisissez une option : ");
            int choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    Console.Write("ID : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nom : ");
                    string nom = Console.ReadLine();
                    Console.Write("Prénom : ");
                    string prenom = Console.ReadLine();
                    Console.Write("Bureau : ");
                    int bureau = int.Parse(Console.ReadLine());
                    projet.AjouterProgrammeur(new Programmeur(id, nom, prenom, bureau));
                    break;

                case 2:
                    Console.Write("ID du programmeur : ");
                    int idRecherche = int.Parse(Console.ReadLine());
                    projet.AfficherProgrammeur(idRecherche);
                    break;

                case 3:
                    projet.AfficherListeProgrammeurs();
                    break;

                case 4:
                    Console.Write("ID du programmeur : ");
                    int idConsommation = int.Parse(Console.ReadLine());
                    Console.Write("Semaine : ");
                    int semaine = int.Parse(Console.ReadLine());
                    Console.Write("Nombre de tasses : ");
                    int tasses = int.Parse(Console.ReadLine());
                    projet.AjouterConsommation(idConsommation, semaine, tasses);
                    break;

                case 5:
                    Console.Write("Semaine : ");
                    int semaineTotale = int.Parse(Console.ReadLine());
                    projet.AfficherConsommationTotale(semaineTotale);
                    break;

                case 6:
                    Console.Write("ID du programmeur à supprimer : ");
                    int idSuppression = int.Parse(Console.ReadLine());
                    projet.SupprimerProgrammeur(idSuppression);
                    break;

                case 7:
                    continuer = false;
                    break;

                default:
                    Console.WriteLine("Option invalide.");
                    break;
            }
        }
    }
}
