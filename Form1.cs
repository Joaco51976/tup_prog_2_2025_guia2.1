using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer1
{
    public partial class Form1 : Form
    {
        private DepartamentoVehicular depto = new DepartamentoVehicular();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string dni = tbDni.Text;
            string nombre = tbNombre.Text;

            Persona p = new Persona(dni, nombre);
            RegistroVehiculo reg = depto.RegistrarVehiculo(p);

            MessageBox.Show("Vehículo registrado:\n" + reg.VerDetalle());
        }

        private void btnListarRegistros_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var r in depto.ListarRegistros())
            {
                listBox1.Items.Add(r);
            }
        }
    }
}