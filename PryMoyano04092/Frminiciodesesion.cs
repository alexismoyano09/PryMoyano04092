using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
