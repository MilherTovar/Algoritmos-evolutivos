using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxeadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            Poblacion datos_poblacion = new Poblacion(5);
            datos_poblacion = datos_poblacion.generar_poblacion_inicial(5);
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            if (isnumeric(cantidad_individuos.Text))
            {
                Generar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Deberá ingresar solamente datos enteros","Error de ingreso");
            }
        }

        private bool isnumeric(string dato)
        {
            int resultado;
            if(int.TryParse(dato, out resultado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
