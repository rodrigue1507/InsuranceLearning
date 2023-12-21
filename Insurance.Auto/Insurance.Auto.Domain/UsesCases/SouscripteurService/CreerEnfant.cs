using Insurance.Auto.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Auto.Domain.UsesCases.Souscripteur
{
    internal class CreerEnfant
    {
        public Enfant Creer(PersonneBase personneBase)
        {
            var enfant = new Enfant
            {
                Nom = personneBase.Nom,
                Prenom = personneBase.Prenom,
                Adresse = personneBase.Adresse,
                DateDeNaissance = personneBase.DateDeNaissance,
                Sexe = personneBase.Sexe
            };
            return enfant;
        }
    }
}
