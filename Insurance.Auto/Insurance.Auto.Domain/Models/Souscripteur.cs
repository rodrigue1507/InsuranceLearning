using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Auto.Domain.Models
{
    internal class Souscripteur : PersonneBase
    {
        public Conjoint Conjoint { get; set; }
        public List<Enfant> Enfants { get; set; }
    }
}
