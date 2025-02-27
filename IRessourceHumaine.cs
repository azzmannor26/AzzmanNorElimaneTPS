using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal interface IRessourceHumaine
    {
        void AfficherEnseignants();
        int RechercherEnseignant(int code);

    }
}
