using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimetro_de_un_cuadrado
{
    public partial class Form1: Form
    {
        double medida_uno, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out medida_uno))
            {
                resultado = (medida_uno * 4);
                lblRespuesta.Text = resultado.ToString("N2");
            }
            else
            {
                lblResultado.Text = "Esto no es posible de realizar";
                    }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblLado_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
