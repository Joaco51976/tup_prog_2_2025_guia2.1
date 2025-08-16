using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    public class DepartamentoVehicular
    {
        private List<RegistroVehiculo> registros = new List<RegistroVehiculo>();
        private int contadorSerie = 0;

        public int CantidadRegistros => registros.Count;

        private string GenerarPatente()
        {
            Random rnd = new Random();
            char letra1 = (char)rnd.Next('A', 'Z' + 1);
            char letra2 = (char)rnd.Next('A', 'Z' + 1);
            int numeros = rnd.Next(0, 1000);
            return $"{letra1}{letra2}{numeros:D3}";
        }

        private string GenerarSerie()
        {
            contadorSerie++;
            return contadorSerie.ToString("D9");
        }

        public RegistroVehiculo RegistrarVehiculo(Persona propietario)
        {
            string patente = GenerarPatente();
            string serie = GenerarSerie();
            var reg = new RegistroVehiculo(patente, propietario, serie);
            registros.Add(reg);
            return reg;
        }

        public List<string> ListarRegistros()
        {
            List<string> lista = new List<string>();
            foreach (var r in registros)
            {
                lista.Add(r.VerDetalle());
            }
            return lista;
        }
    }
}