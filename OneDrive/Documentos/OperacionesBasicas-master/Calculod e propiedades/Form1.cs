using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_propiedades
{
    public partial class FmrSistemadeNotas : Form
    {
        public FmrSistemadeNotas()
        {
            InitializeComponent();
            lblerror.Text = "";
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double nota_uno, nota_dos, nota_tres, promedio;
            if (string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox2.Text)||string.IsNullOrEmpty(textBox3.Text))
            {
                lblerror.Text = "Existe un campo vacio, Porfavor Ingresa un dato Númerico";
            }
            else
            {
                nota_uno = double.Parse(textBox1.Text);
                nota_dos = double.Parse(textBox2.Text);
                nota_tres = double.Parse(textBox3.Text);
                if ((nota_uno > 10|| nota_uno < 0 || nota_dos > 10 || nota_dos < 0 || nota_tres > 10 || nota_tres < 0))
                {
                    lblerror.Text = "Porfavor ingresa un valor entre 0 y 10";
                }
                else
                {
                    promedio = (nota_uno + nota_dos + nota_tres) / 3;
                    textBox4.Text = promedio.ToString("N2");
                    lblerror.Text = "";
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
