using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones_basicas
{
    public partial class Form1 : Form
    {
        //Variable globales
        double numero_uno, numero_dos, resultado;

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt1.Text, out numero_uno)&& double.TryParse(txt2.Text, out numero_dos))
            {
                resultado = numero_uno+numero_dos;
                lblResultados.Text = resultado.ToString("N2");
            }
            else { lblResultados.Text = "Esto no es posible veriica que ingreses datos valiedos"; }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt1.Text, out numero_uno)&&double.TryParse(txt2.Text, out numero_dos))
            {
                if (numero_dos != 0)
                {
                    resultado = numero_uno / numero_dos;
                    lblResultados.Text = resultado.ToString("N2");
                }
                else
                {
                    lblResultados.Text = "Error esto no es posible";
                }
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt1.Text, out numero_uno)&&double.TryParse(txt2.Text, out numero_dos))
            {
                if (numero_uno != 0 || numero_dos != 0)
                {
                    resultado = numero_uno - numero_dos;
                    lblResultados.Text = resultado.ToString("N2");
                }
                else
                {
                    lblResultados.Text = "No se puede realizar esta operación";
                }
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txt1.Text, out numero_uno) && double.TryParse(txt2.Text, out numero_dos))
            {
                if (numero_uno >= 0 && numero_dos >= 0)
                {
                    resultado = numero_uno * numero_dos;
                    lblResultados.Text = resultado.ToString("N2");
                }
                else
                {
                    lblResultados.Text = "No se pudo realizar esta operación";
                }
            }
        }

        private void lbldatos_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
