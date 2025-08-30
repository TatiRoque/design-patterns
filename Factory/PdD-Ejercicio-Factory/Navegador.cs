using PdD_Ejercicio_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PdD_Ejercicio_Factory
{
    public class Navegador
    {
        private readonly IMap _map;
        private readonly IGeocoder _geocoder;
        public Navegador(IMapServicesFactory factory)
        {
            _map = factory.CreateMap();
            _geocoder = factory.CreateGeocoder();
        }
        public void Explore(string ubicacion, string consultaDireccion)
        {
            _map.Render(ubicacion);
            Console.WriteLine($"{_geocoder.Buscar(consultaDireccion)}");
            
        }
    }
}
