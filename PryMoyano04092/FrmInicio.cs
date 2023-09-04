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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            fbdcarpetas = new FolderBrowserDialog();
            fbdcarpetas.ShowDialog();
            lbldireccioncarpeta.Text = fbdcarpetas.SelectedPath;


        }
    }
}
