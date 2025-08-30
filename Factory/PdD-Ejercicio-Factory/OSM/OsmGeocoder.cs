using PdD_Ejercicio_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdD_Ejercicio_Factory.OSM
{
    public class OsmGeocoder : IGeocoder
    {
        public string Buscar(string textoDireccion) => $"Coords OSM: -38.01,\r\n-57.54 para {textoDireccion}";

    }
}
