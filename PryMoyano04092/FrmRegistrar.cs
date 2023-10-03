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
    public partial class FrmRegistrar : Form
    {
        private object rutaArchivoGrilla;

        public FrmRegistrar()
        {
            InitializeComponent();
        }

      
       

        private void btngrabar_Click(object sender, EventArgs e)
        {
            FrmRegistrar FrmRegistrar = new FrmRegistrar();

            
           // int contadoraDeFilas = DtgGrillaMostrar.Rows.Count;
            //string ultimoNumero = DtgGrillaMostrar.Rows[contadoraDeFilas - 1].Cells[0].Value.ToString();
            //int numeroDelTxt = Convert.ToInt32(ultimoNumero) + 1;
         //   FrmRegistrar.txtnumero.Text = numeroDelTxt.ToString();
           // FrmRegistrar.txtnumero.ReadOnly = true;


            //FrmRegistrar.btnmodificar.Visible = false;
            FrmRegistrar.btngrabar.Visible = true;
            //FrmRegistrar.rutaArchivoAbm = rutaArchivoGrilla;
            FrmRegistrar.Show();
            this.Hide();
        }
    }
}
