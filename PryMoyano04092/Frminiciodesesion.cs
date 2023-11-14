using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PryMoyano04092
{
    public partial class Frminiciodesesion : Form
    {
        public Frminiciodesesion()
        {
            InitializeComponent();
        }

        private void Frminiciodesesion_Load(object sender, EventArgs e)
        {
            Cliniciodesesion objEstado = new Cliniciodesesion();
            lblestado.Text = objEstado.estadoConexion;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            Cliniciodesesion objUsuario = new Cliniciodesesion();

            objUsuario.ValidarUsuario(txtusuario.Text, txtcontraseña.Text);

            if (objUsuario.estadoConexion == "Usuario EXISTE")
            {
               
                //MessageBox.Show("Ingrese al sistema...");
                objUsuario.RegistroLogInicioSesion();
                this.Hide();
                Frminicioprincipal Frminicioprincipal = new Frminicioprincipal();
                Frminicioprincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
                objUsuario.RegistroLogInicioSesion();
            }
        }

        private void CBmostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (CBmostrar.Checked)
            {
                txtcontraseña.PasswordChar = '\0';
            }
            else
            {
                txtcontraseña.PasswordChar = '*';
            }
        }
    }
}
