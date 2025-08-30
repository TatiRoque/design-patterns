using PdD_Ejercicio_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdD_Ejercicio_Factory.Google
{
    public class GoogleGeocoder : IGeocoder
    {
        public string Buscar(string textoDireccion) =>  $"Coords GM: -38.00, -57.55 para\r\n{textoDireccion}";
    }
}
