using PdD_Ejercicio_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdD_Ejercicio_Factory.Google
{
    public class GoogleMapa : IMap
    {
        public void Render(string ubicacion) => Console.WriteLine($"GoogleMaps mostrando: {ubicacion}");
    }
}
