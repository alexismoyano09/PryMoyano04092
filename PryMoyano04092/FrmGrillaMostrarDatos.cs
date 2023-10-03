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
    public partial class frmdatosgrilla : Form
    {
        public frmdatosgrilla()
        {
            InitializeComponent();
        }

        public string rutaArchivoGrilla { get; internal set; }
    }
}
