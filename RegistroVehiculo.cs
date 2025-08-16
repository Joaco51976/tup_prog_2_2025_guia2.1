using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    public class RegistroVehiculo
    {
        public string Patente { get; }
        public string Serie { get; }
        public Persona Propietario { get; }

        public RegistroVehiculo(string patente, Persona propietario, string serie)
        {
            Patente = patente;
            Serie = serie;
            Propietario = propietario;
        }

        public string VerDetalle()
        {
            return $"{Patente} \"{Serie}\" {Propietario}";
        }
    }
}
