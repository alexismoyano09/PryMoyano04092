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

        public static string usuario;
        public static string contraseña;
        int contador = 0;
        private void btniniciar_Click(object sender, EventArgs e)
        {
            usuario = txtusuario.Text;
            contraseña = txtcontraseña.Text;

            Cliniciodesesion objUsuario = new Cliniciodesesion();

            objUsuario.ValidarUsuario(usuario, contraseña);

            if (Cliniciodesesion.acceso == true)
            {
               
                //MessageBox.Show("Ingrese al sistema...");
                objUsuario.RegistroLogInicioSesion();
                this.Hide();
                Frminicioprincipal Frminicioprincipal = new Frminicioprincipal();
                Frminicioprincipal.Show();
            }
            else
            {
               
                objUsuario.RegistroLogInicioFallidoSesion();

                contador = contador + 1;
                MessageBox.Show("Usuario o contraeña incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (contador == 2)
                {
                    MessageBox.Show("Queda un solo intento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                if (contador > 2)
                {
                    btniniciar.Enabled = false;
                    txtusuario.Enabled = false;
                    txtcontraseña.Enabled = false;
                    MessageBox.Show("El ingreso ah sido bloqueado por su seguridad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contador = 0;
                }
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

        private void txtcontraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                usuario = txtusuario.Text;
                contraseña = txtcontraseña.Text;

                Cliniciodesesion objUsuario = new Cliniciodesesion();

                objUsuario.ValidarUsuario(usuario, contraseña);

                if (Cliniciodesesion.acceso == true)
                {

                    //MessageBox.Show("Ingrese al sistema...");
                    objUsuario.RegistroLogInicioSesion();
                    this.Hide();
                    Frminicioprincipal Frminicioprincipal = new Frminicioprincipal();
                    Frminicioprincipal.Show();
                }
                else
                {

                    objUsuario.RegistroLogInicioFallidoSesion();

                    contador = contador + 1;
                    MessageBox.Show("Usuario o contraeña incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (contador == 2)
                    {
                        MessageBox.Show("Queda un solo intento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (contador > 2)
                    {
                        btniniciar.Enabled = false;
                        txtusuario.Enabled = false;
                        txtcontraseña.Enabled = false;
                        MessageBox.Show("El ingreso ah sido bloqueado por su seguridad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        contador = 0;
                    }
                }

            }
        }

        private void Frminiciodesesion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            txtcontraseña.PasswordChar = '*';
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            Frmregistrarusuario Ventana = new Frmregistrarusuario();
            Ventana.ShowDialog();
        }
    }
}
