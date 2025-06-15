using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolares_a_PesosMX
{
    public partial class Form1: Form
    {
        int Pesos, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesosDolar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out Pesos))
            {
                resultado = Pesos * 18;
                lblResultado.Text = resultado.ToString("N2");
            }
        }
    }
}
