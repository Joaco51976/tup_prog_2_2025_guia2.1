using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer2
{
    public partial class FrmLiquidaciones : Form
    {
        public FrmLiquidaciones()
        {
            InitializeComponent();
        }

        Empleado empleadoSeleccionado;

        private void lstLiquidaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Liquidacion liq = new Liquidacion(
                empleadoSeleccionado,
                int.Parse(tbMes.Text),
                int.Parse(tbAnio.Text),
                int.Parse(tbHorasExtras50.Text),
                int.Parse(tbHorasExtras100.Text)
            );

            // Mostrar en el ListBox
            lstLiquidaciones.Items.Add(
                $"Empleado: {liq.Empleado.Nombre} | {liq.Mes}/{liq.Anio} | Nominal: {liq.Nominal:C} | Neto: {liq.Neto:C}"
            );
        }

        private void lstLiquidaciones_DoubleClick(object sender, EventArgs e)
        {
            if (lstLiquidaciones.SelectedItem != null)
            {
                MessageBox.Show(lstLiquidaciones.SelectedItem.ToString(), "Detalle de Liquidación");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmLiquidaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
