using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    public class Persona
    {
        public string DNI { get; }
        public string Nombre { get; }

        public Persona(string dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"{Nombre} (dni: {DNI})";
        }
    }
}
