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
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prbPorcentaje.Increment(13);
            lblporcentaje.Text = prbPorcentaje.Value.ToString() + "%";

            if (prbPorcentaje.Value == prbPorcentaje.Maximum) 
            {
                timer1.Stop();
                this.Hide();
                 Frminicioprincipal Frminicioprincipal = new Frminicioprincipal();
                Frminicioprincipal.Show();
                // Frminiciodesesion Frminiciodesesion = new Frminiciodesesion();
                //Frminiciodesesion.Show();
            }


        }

        private void prbPorcentaje_Click(object sender, EventArgs e)
        {

        }

        private void lblporcentaje_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogo_Load(object sender, EventArgs e)
        {

        }
    }
}
