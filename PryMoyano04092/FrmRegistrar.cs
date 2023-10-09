using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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



        claseCargar Cargar = new claseCargar();
        private void btngrabar_Click(object sender, EventArgs e)
        {
            Cargar.Grabar(txtnumero.Text, txtentidad.Text, txtapertura.Text, txtNdeexpendiente.Text, txtjuzgado.Text, txtjurisdiccion.Text, txtdireccion.Text, txtLresponsable.Text);
            MessageBox.Show("Se ah cargado el proveedor");
            txtnumero.Text = "";
            txtentidad.Text = "";
            txtapertura.Text = "";
            txtNdeexpendiente.Text = "";
            txtjuzgado.Text = "";
            txtjurisdiccion.Text = "";
            txtdireccion.Text = "";
            txtLresponsable.Text = "";
            //FrmRegistrar FrmRegistrar = new FrmRegistrar();


            // int contadoraDeFilas = DtgGrillaMostrar.Rows.Count;
            //string ultimoNumero = DtgGrillaMostrar.Rows[contadoraDeFilas - 1].Cells[0].Value.ToString();
            //int numeroDelTxt = Convert.ToInt32(ultimoNumero) + 1;
            //   FrmRegistrar.txtnumero.Text = numeroDelTxt.ToString();
            // FrmRegistrar.txtnumero.ReadOnly = true;


            //FrmRegistrar.btnmodificar.Visible = false;
            // FrmRegistrar.btngrabar.Visible = true;
            //FrmRegistrar.rutaArchivoAbm = rutaArchivoGrilla;
            // FrmRegistrar.Show();
            //this.Hide();
        }
        public static string rutafinal;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string ID = txtnumero.Text;
            List<string> LineaArchivo = new List<string>();

            using (StreamReader leer = new StreamReader(rutafinal))
            {
                string line;
                while ((line = leer.ReadLine()) != null) 
                {
                    string[] parametros = line.Split(';');
                    if (parametros [0] != ID)
                    {
                        LineaArchivo.Add(line);                    
                    }
                    else 
                    {
                     string nuevalinea = txtnumero.Text + ";" + txtentidad.Text + ";" + txtapertura.Text+ ";" + txtNdeexpendiente.Text + ";" + txtjuzgado.Text + ";" + txtjurisdiccion.Text + ";" + txtdireccion.Text + ";" + txtLresponsable.Text + ";";
                        LineaArchivo.Add(nuevalinea);
                    }
                }
            }
            using (StreamWriter escribir = new StreamWriter(rutafinal)) 
            {
              foreach (string line in LineaArchivo) { escribir.WriteLine(line); }
            }
            MessageBox.Show("Modificado exitosamente");
        }
         
        private void btnvolver_Click(object sender, EventArgs e)
        {
           

            frmdatosgrilla volver = new frmdatosgrilla();
            volver.Show();
            this.Hide();
        }
    }
}
