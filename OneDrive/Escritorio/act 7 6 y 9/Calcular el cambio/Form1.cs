using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_el_cambio
{
    public partial class Form1: Form
    {
        double dinero, coste, resultado;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txtDinero.Clear();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDinero.Text, out dinero)&&double.TryParse(textBox1.Text, out coste))
            {
                if (dinero <= 0 || coste <= 0)
                {
                    lblRespuestavuelto.Text = "No se puede hacer eso";
                }
                else
                {
                    resultado = dinero - coste;
                    lblRespuestavuelto.Text = resultado.ToString("N2");
                }
            }
        }
    }
}
