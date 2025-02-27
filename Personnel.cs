using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal abstract class Personnel:Personne
    {
        public String bureau {  get; set; }
        public double salaire {  get; set; }
        public double prime {  get; set; }

        public Personnel(int code, string nom, string prenom,string bureau, double salaire, double prime): base(code, nom, prenom)
        {
            this.bureau = bureau;
            this.salaire = salaire;
            this.prime = prime;
        }

        public abstract double calculersalaire();
    }
}
