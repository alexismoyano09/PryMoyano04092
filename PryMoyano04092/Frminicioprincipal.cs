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
        }

        private void verProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmmain Ventana = new Frmmain();
            Ventana.ShowDialog();
        }
    }
}
