using Insurance.Auto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Auto.Domain.Ports.Driving
{
    internal interface ICreerSouscripteur
    {
        Task<Souscripteur> Create(Souscripteur souscripteur, Conjoint conjoint, List<Enfant> enfants);
    }
}
