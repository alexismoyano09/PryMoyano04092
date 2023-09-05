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
    public partial class Frmmain : Form
    {
        public Frmmain() // constructor
        {
            InitializeComponent();
            LlenarTreeview();
        }
        private void LlenarTreeview()
        {
            TreeNode rootNode; //root node nombre del nodo, treenode tipo del node

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists == true)  //por defecto el if pregunta true
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
               //GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }
        private void ObtenerCarpetas(DirectoryInfo[] subDirs,TreeNode nodeToAddTo) 
        {
         
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
