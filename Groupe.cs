using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class Groupe
    {
        public string nom;
        public List<Etudiant> E;

        public Groupe(string nom)
        {
            this.nom = nom;
            this.E = new List<Etudiant>();
        }

        public void AjouterEtudiant(Etudiant etudiant)
        {
            if (!E.Contains(etudiant))
            {
                E.Add(etudiant);
                Console.WriteLine($"✅ Étudiant {etudiant.nom} ajouté au groupe {nom}.");
            }
        }

        public void AfficherEtudiants()
        {
            Console.WriteLine($"\n📌 Groupe: {nom}");
            foreach (var etudiant in E)
            {
                Console.WriteLine(etudiant);
            }
        }

    }
}

