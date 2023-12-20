using Insurance.Auto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Auto.Domain.Abstractions
{
    internal interface IContratAuto: IRepository<ContratAuto>
    {
        Task AjouterSouscripteur(Souscripteur souscripteur);
        Task AjouterVoiture(Voiture voiture);
    }
}
