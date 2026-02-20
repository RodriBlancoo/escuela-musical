using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin.cs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;
            string clave = txtPass.Text;

            if (usuario == "Ronald" && clave == "Guillen")
            {
                Inicio dashboard = new Inicio();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
