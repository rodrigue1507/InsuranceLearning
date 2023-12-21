
using Insurance.Auto.Domain.Models;
using Insurance.Auto.Domain.Ports.Driven;
using Insurance.Auto.Domain.Ports.Driving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Auto.Domain.UsesCases.SouscripteurService
{
    internal class CreerSouscripteur 
    {
        public Models.Souscripteur Create(PersonneBase personne, Conjoint conjoint, List<Enfant> enfants)
        {
            var souscripteur = new Models.Souscripteur()
            {
                Nom = personne.Nom,
                Prenom = personne.Prenom,
                Adresse = personne.Adresse,
                DateDeNaissance = personne.DateDeNaissance,
                Sexe = personne.Sexe,
                Conjoint = conjoint,
                Enfants = enfants
            };
            return souscripteur;
        }

        //private bool IsAddConjointValid(DateTime dateDePriseEffet)
        //{
        //    var result = false;
        //    if (IsDateDePriseEffet(dateDePriseEffet)) result = true;
        //    return result;
        //}
        //private bool IsAddEnfantValid(DateTime dateDePriseEffet)
        //{
        //    var result = false;
        //    if (IsDateDePriseEffet(dateDePriseEffet)) result = true;
        //    return result;
        //}

        //public bool IsDateDePriseEffet(DateTime dateDePriseEffet)
        //{            
        //    var result = false;
        //    var compareDate = DateTime.Now.Date.Subtract(dateDePriseEffet.Date);
        //    if (compareDate.Days <= 0) result = true;
        //    return result;
        //}
    }
}
