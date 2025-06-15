using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seno_y_coseno
{
    public partial class Form1 : Form
    {
        double AnguloEnRadianes = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularSeno_Click(object sender, EventArgs e)
        {
            double SenoAngulo;
            AnguloEnRadianes = double.Parse(txt1.Text);
                SenoAngulo = Math.Sin(AnguloEnRadianes);
            txt2.Text = SenoAngulo.ToString("N2");
            txt1.Clear();
            txt3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
        }

        private void btnCalcularCoseno_Click(object sender, EventArgs e)
        {
            double CosenoAngulo;
            AnguloEnRadianes = double.Parse(txt1.Text);
            CosenoAngulo = Math.Cos(AnguloEnRadianes);
            txt3.Text = CosenoAngulo.ToString("N2");
            txt1.Clear();
            txt2.Text = string.Empty;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCosenoAngulo_Click(object sender, EventArgs e)
        {

        }
    }
}
