using PdD_Ejercicio_Factory.Google;
using PdD_Ejercicio_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdD_Ejercicio_Factory.OSM
{
    public class OsmMapServicesFactory : IMapServicesFactory
    {
        public IMap CreateMap() => new OsmMap();
        public IGeocoder CreateGeocoder() => new OsmGeocoder();
    }
}
