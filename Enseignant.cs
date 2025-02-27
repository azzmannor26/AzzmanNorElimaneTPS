using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class Enseignant:Personnel
    {
        string grade {  get; set; }
        int  VH { get; set; }
        int nb_heures;
        Dictionary<string, Groupe> Groupes; // Dictionnaire stockant les groupes



        public Enseignant(int code, string nom, string prenom, string bureau, double salaire, double prime, string grade, int volumeHoraire)
            : base(code, nom, prenom, bureau, salaire, prime)
        {
            this.grade = grade;  // ✅ Ensure Grade is assigned
            this.VH = volumeHoraire;  // ✅ Ensure VolumeHoraire is assigned
            this.Groupes = new Dictionary<string, Groupe>(); // ✅ Ensure Groupes is initialized
        }


        public void AjouterGroupe(Groupe groupe)
        {
            if (!Groupes.ContainsKey(groupe.nom))
            {
                Groupes[groupe.nom] = groupe;
                Console.WriteLine($"✅ Groupe {groupe.nom} ajouté à {nom} {prenom}.");
            }
        }

        // Implémentation correcte de 'CalculerSalaire'
        public override double calculersalaire()
        {
            double tarifHoraire = 0;

            // Utilisation de switch-case pour définir le tarif en fonction du grade
            switch (grade.ToUpper())
            {
                case "PA":
                    tarifHoraire = 300;
                    break;
                case "PH":
                    tarifHoraire = 350;
                    break;
                case "PES":
                    tarifHoraire = 400;
                    break;
                default:
                    Console.WriteLine("Grade invalide !");
                    return 0; // Retourne 0 si le grade est incorrect
            }

            // Calcul du salaire total
            return this.salaire + this.prime + (this.VH* tarifHoraire);
        }


        public Groupe this[string nomGroupe]
        {
            get => Groupes.ContainsKey(nomGroupe) ? Groupes[nomGroupe] : null;
        }

        public override string ToString()
        {
            return $"👨‍🏫 Enseignant: {nom} {prenom} | Bureau: {bureau} | Grade: {grade} | Salaire: {calculersalaire()} DH";
        }

    }
}
