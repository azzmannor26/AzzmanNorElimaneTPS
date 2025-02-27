using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace GestionRH
{
    internal class Etudiant:Personne
    {
        String niveau {  get; set; }
        int moyenne { get; set; }

        public Etudiant(int code, string nom, string prenom, string niveau, int moyenne)
           : base(code, nom, prenom)
        {
            niveau = niveau;
            moyenne = moyenne;
        }

        public override string ToString()
        {
            return $"{code} - {nom} {prenom}, Niveau: {niveau}, Moyenne: {moyenne}";
        }




    }
}
