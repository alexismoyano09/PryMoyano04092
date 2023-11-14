using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMoyano04092
{
    public partial class Frmregistrarusuario : Form
    {
        private string connectionString;
        private OleDbConnection connection;
        public static string nombre;
        public static string contraseña;
        public static string contraseña2;
        public string contraseñaigual;
        public static string perfil;

        public Frmregistrarusuario()
        {
            InitializeComponent();
        }

        private void txtcontraseña1_TextChanged(object sender, EventArgs e)
        {
            txtcontraseña1.PasswordChar = '*';
            txtcontraseña2.PasswordChar = '*';
        }

        private void CBmostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (CBmostrar.Checked)
            {
                txtcontraseña1.PasswordChar = '\0';
                txtcontraseña2.PasswordChar = '\0';
            }
            else
            {
                txtcontraseña1.PasswordChar = '*';
                txtcontraseña2.PasswordChar = '*';
            }
        }
        
        private void btnregistrarse1_Click(object sender, EventArgs e)
        {
          
            nombre = txtusuario1.Text;
            contraseña = txtcontraseña1.Text;
            contraseña2 = txtcontraseña2.Text;
            perfil = txtperfil.Text;

            Cliniciodesesion cliniciodesesion = new Cliniciodesesion();
            clsclub objRegistrar = new clsclub();

            if (contraseña == contraseña2)
            {
                contraseñaigual = contraseña;

                MessageBox.Show("Cuenta creada exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.None);



                objRegistrar.Registrarusuarionuevo();


            }
            else
            {
                MessageBox.Show("No se ah logrado registrar con exito,intente nuevamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void Frmregistrarusuario_Load(object sender, EventArgs e)
        {
           
        }
    }
    
}
