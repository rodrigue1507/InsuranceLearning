using Insurance.Auto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Auto.Domain.UsesCases.Souscripteur
{
    internal class CreerConjoint
    {
        public Conjoint Creer(PersonneBase personneBase)
        {
            var conjoint = new Conjoint
            {
                Nom = personneBase.Nom,
                Prenom = personneBase.Prenom,
                Adresse = personneBase.Adresse,
                DateDeNaissance = personneBase.DateDeNaissance,
                Sexe = personneBase.Sexe
            };
            return conjoint;
        }
    }
}
