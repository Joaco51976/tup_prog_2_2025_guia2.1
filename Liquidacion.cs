using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    public class Liquidacion
    {
        public Empleado Empleado { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int HorasExtras50 { get; set; }
        public int HorasExtras100 { get; set; }

        private const int AniosMaximos = 30; 

        public Liquidacion(Empleado empleado, int mes, int anio, int horas50, int horas100)
        {
            Empleado = empleado;
            Mes = mes;
            Anio = anio;
            HorasExtras50 = horas50;
            HorasExtras100 = horas100;
        }

        public double ValorHora => Empleado.Basico / 40;

        public double PorcentajeAntiguedad
        {
            get
            {
                int aniosTrabajados = Anio - Empleado.AnioIngreso;
                if (aniosTrabajados < 0) aniosTrabajados = 0;
                return (double)aniosTrabajados / AniosMaximos;
            }
        }

        public double Nominal
        {
            get
            {
                double montoAntiguedad = Empleado.Basico * PorcentajeAntiguedad;
                double montoExtras50 = HorasExtras50 * ValorHora * 1.5;
                double montoExtras100 = HorasExtras100 * ValorHora * 2;
                return Empleado.Basico + montoAntiguedad + montoExtras50 + montoExtras100;
            }
        }

        public double Descuentos => Nominal * (0.03 + 0.18 + 0.015);

        public double Neto => (Nominal - Descuentos) * 1.30;
    }
}