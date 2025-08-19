using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace Ejer2
{
    internal class Empresa
    {
        public int AnioActual { get; set; } = DateTime.Now.Year;

        private readonly List<Empleado> _empleados = new List<Empleado>();
        private readonly List<Liquidacion> _liquidaciones = new List<Liquidacion>();

        public Empleado RegistrarEmpleado(string apellido, string nombre, int anioContrato, double basicoNominal)
        {
            var e = new Empleado(apellido, nombre, anioContrato, basicoNominal);
            _empleados.Add(e);
            return e;
        }

        public void GenerarLiquidaciones(int mes, int anio)
        {
            _liquidaciones.RemoveAll(l => l.anio == anio && l.Mes == mes);

            foreach (var e in _empleados)
            {
                _liquidaciones.Add(new Liquidacion(e, anio, mes));
            }
        }

        public List<Liquidacion> ListarLiquidaciones(int mes, int anio)
        {
            return _liquidaciones
                   .Where(l => l.anio == anio && l.Mes == mes)
                   .ToList();
        }

        public string MostrarRecibosDeSueldo(int anio, int mes, int inicio = 1)
        {
            var liqs = ListarLiquidaciones(mes, anio);
            var sb = new System.Text.StringBuilder();

            int n = inicio;
            foreach (var l in liqs)
            {
                sb.AppendLine("--" + n++);
                sb.AppendLine(l.VerImpreso());
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
*/