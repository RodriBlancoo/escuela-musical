using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_el_descuento
{
    public partial class Form1: Form
    {
        double precio, preciofinal, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
        }

        private void lblAclaración_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt1.Text, out precio))
            {
                if (precio <= 0)
                {
                    lblDescuento.Text = "No se puede realizar este procedimiento";
                }
                else
                {
                    resultado = ((precio * 65) / 100);
                    lblDescuento.Text = resultado.ToString("N2");
                    preciofinal = precio - resultado;
                    lblPrecioFinal.Text = preciofinal.ToString("N2");
                }
            }
        }
    }
}
