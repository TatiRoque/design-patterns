using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdD_Ejercicio_Factory.Interfaces
{
    public interface IMapServicesFactory
    {
        IMap CreateMap();
        IGeocoder CreateGeocoder();
    }
}
