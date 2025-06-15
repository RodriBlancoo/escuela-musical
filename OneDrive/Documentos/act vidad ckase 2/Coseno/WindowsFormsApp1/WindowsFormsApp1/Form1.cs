using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCalcularSeno_Click(object sender, EventArgs e)
        {
            double SenoAngulo;
            AnguloEnRadianes = double.Parse(txt1.Text);
            SenoAngulo = Math.Sin(AnguloEnRadianes);
            txt2.Text = SenoAngulo.ToString("N2");
            txt1.Clear();
            txt3.Text = string.Empty;
        }
    }
}
