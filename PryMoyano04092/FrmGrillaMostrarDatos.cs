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
    public partial class frmdatosgrilla : Form
    {
        public frmdatosgrilla()
        {
            InitializeComponent();
        }

        public string rutaArchivoGrilla { get; internal set; }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            Frminicioprincipal Ventana = new Frminicioprincipal();
            Ventana.ShowDialog();
        }

        private void btnmodificar1_Click(object sender, EventArgs e)
        {
            int n = DtgGrillaMostrar.CurrentCell.RowIndex;

            FrmRegistrar modifico = new FrmRegistrar();

            modifico.txtnumero.ReadOnly = true;

            modifico.txtnumero.Text = DtgGrillaMostrar.Rows[n].Cells[0].Value.ToString();
            modifico.txtentidad.Text = DtgGrillaMostrar.Rows[n].Cells[1].Value.ToString();
            modifico.txtapertura.Text = DtgGrillaMostrar.Rows[n].Cells[2].Value.ToString();
            modifico.txtNdeexpendiente.Text = DtgGrillaMostrar.Rows[n].Cells[3].Value.ToString();
            modifico.txtjuzgado.Text = DtgGrillaMostrar.Rows[n].Cells[4].Value.ToString();
            modifico.txtjurisdiccion.Text = DtgGrillaMostrar.Rows[n].Cells[5].Value.ToString();
            modifico.txtdireccion.Text = DtgGrillaMostrar.Rows[n].Cells[6].Value.ToString();
            modifico.txtLresponsable.Text = DtgGrillaMostrar.Rows[n].Cells[7].Value.ToString();

            string ID = Convert.ToString(DtgGrillaMostrar.Rows[n].Cells[0].Value);

            modifico.Show();
            this.Hide();
           modifico.btnmodificar.Visible = true;
        }

        private void DtgGrillaMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int n = DtgGrillaMostrar.CurrentCell.RowIndex;

            if (n != -1 ) 
            {
                string ID = Convert.ToString(DtgGrillaMostrar.Rows[n].Cells[0].Value);

                List<string> Lineas = new List<string>();

                using (StreamReader reader = new StreamReader(rutaArchivoGrilla))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] parametros = linea.Split(',');
                        if (parametros[0] != ID) 
                        {
                            Lineas.Add(linea);
                        }

                    }
                }

                using(StreamWriter writer = new StreamWriter(rutaArchivoGrilla))
                {
                    foreach (string elementro in Lineas) 
                    {
                      writer.WriteLine(elementro);
                    }
                }
                MessageBox.Show("Se ah eliminado correctamente el registro seleccionado");
               
                    DtgGrillaMostrar.Rows.RemoveAt(n);
            }
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            FrmRegistrar cargar = new FrmRegistrar();
            cargar.Show();
            this.Hide();
            cargar.btngrabar.Visible = true;
        }
    }
}
