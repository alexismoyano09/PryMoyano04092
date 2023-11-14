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
    public partial class Frmclub : Form
    {
        clsclub objbasededatos;
        public Frmclub()
        {
            InitializeComponent();
        }

        private void Frmclub_Load(object sender, EventArgs e)
        {
            objbasededatos = new clsclub();
            objbasededatos.Baseconectada();
            lblestado1.Text = objbasededatos.EstadoConexion;
            lblestado1.ForeColor = Color.MidnightBlue;
            objbasededatos.MostrarDatos(dgvgrillasocios);
        }
    }
}
