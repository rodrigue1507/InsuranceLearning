using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Auto.Domain.Models
{
    internal class Voiture
    {
        public String Modele { get; set; }
        public int NbPortes { get; set; }
        public String Immatriculation { get; set; }
        public DateTime DateDeConstruction { get; set; }
    }
}
