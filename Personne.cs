using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal abstract class Personne
    {
        public int code {  get; set; }
        public String nom {  get; set; }
        public String prenom
        {
            get; set;
        }

        public Personne(int code, string nom, string prenom)
        {
            this.code = code;
            this.nom = nom;
            this.prenom = prenom;
        }


    }
}
