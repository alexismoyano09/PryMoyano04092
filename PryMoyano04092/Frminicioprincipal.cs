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
    public partial class Frminicioprincipal : Form
    {
        public Frminicioprincipal()
        {
            InitializeComponent();
        }

        private void cargarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cargarProveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistrar Ventana = new FrmRegistrar();
            Ventana.ShowDialog();
            Ventana.btngrabar.Visible = true;
        }

        private void verProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmmain Ventana = new Frmmain();
            Ventana.ShowDialog();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frminicioprincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
              
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Frminicioprincipal_Load(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void elCLUBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmclub club = new Frmclub();
            club.ShowDialog();
            
        }
    }
}
