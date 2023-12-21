using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Auto.Domain.Models
{
    public enum Sexe
    {
        Homme,
        Femme
    }
    internal class PersonneBase
    {
        public string NumeroSecuriteSocial { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public Sexe Sexe {  get; set; }
        public Adresse Adresse { get; set; }
    }
}
