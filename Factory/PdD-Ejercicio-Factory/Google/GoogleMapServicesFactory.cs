using PdD_Ejercicio_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdD_Ejercicio_Factory.Google
{
    public class GoogleMapServicesFactory : IMapServicesFactory
    {
        public IMap CreateMap() => new GoogleMapa();
        public IGeocoder CreateGeocoder() => new GoogleGeocoder();
    }
}
