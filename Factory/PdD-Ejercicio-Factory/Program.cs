using PdD_Ejercicio_Factory.Google;
using PdD_Ejercicio_Factory.Interfaces;
using PdD_Ejercicio_Factory.OSM;
using System;

namespace PdD_Ejercicio_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMapServicesFactory factory = new OsmMapServicesFactory();
            var app = new Navegador(factory);
            app.Explore("Mar de Plata", "Corrientes 2700");
            
        }
    }
}
