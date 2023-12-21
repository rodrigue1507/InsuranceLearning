using Insurance.Auto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Auto.Domain.Ports.Driving
{
    internal interface ICreerAutoService
    {
        Task<Souscripteur> Create();
    }
}
