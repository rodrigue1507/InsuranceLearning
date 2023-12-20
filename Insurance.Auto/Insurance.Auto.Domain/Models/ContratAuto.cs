using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Auto.Domain.Models
{
    internal class ContratAuto
    {
        public string Numero { get; set; }
        public DateTime DateSouscription { get;set; }
        public DateTime DateDePriseEffet { get; set; }
        public DateTime DateResiliation { get;set; }
        public Souscripteur Souscripteur { get; set; }
        public List<Voiture> VoituresAssurees { get; set;}
    }
}
