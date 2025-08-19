using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Basico { get; set; }
        public int AnioIngreso { get; set; }

        public Empleado(string nombre, string categoria, double basico, int anioIngreso)
        {
            Nombre = nombre;
            Basico = basico;
            AnioIngreso = anioIngreso;
        }

        public Empleado() { }
    }
}