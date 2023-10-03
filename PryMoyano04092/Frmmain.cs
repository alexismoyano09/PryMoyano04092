using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace PryMoyano04092
{
    public partial class Frmmain : Form
    {
        public Frmmain() // constructor
        {
            InitializeComponent();
            LlenarTreeview();
            this.treeView1.NodeMouseClick +=
            new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }
        public string ruta = "";
        private void LlenarTreeview()
        {
            TreeNode rootNode; //root node nombre del nodo, treenode tipo del node


            DirectoryInfo info = new DirectoryInfo(@"../../" + "Resources");
            if (info.Exists == true)  //por defecto el if pregunta true
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                ObtenerCarpetas(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }
        private void ObtenerCarpetas(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;

            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";

                //recursiva - se llama a si mismo para
                //buscar màs carpetas
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    ObtenerCarpetas(subSubDirs, aNode);
                }

                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode newSelected = e.Node;
            lstvista.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                lstvista.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                lstvista.Items.Add(item);
            }

            lstvista.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            //frmdatosgrilla ventanaGrilla = new frmdatosgrilla();
            //ventanaGrilla.Show();
            //for (int indice = 0; indice < SepararDatos.Length; indice++)
            //{
                //usar la grilla para cargar
              //  ventanaGrilla.GrillaMostrar.Rows.Add(SepararDatos[indice], SepararDatos[indice]);

            //}
            //while (sr.EndOfStream == false)
            //{
             //   LeerLinea = sr.ReadLine();
               // SepararDatos = LeerLinea.Split(';');
                //ventanaGrilla.GrillaMostrar.Rows.Add(SepararDatos);
            //}
            //sr.Close();

        }

        private void Frmmain_MouseDoubleClick(object sender, MouseEventArgs e)
        {


        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Obtengo el texto que tiene el item seleccionado lstView
            string i = lstvista.SelectedItems[0].Text.ToString();
            
            //En una variable concateno la ruta del treeview + el nombre del archivo anterior
            string rutaArchivoParcial = Path.Combine(ruta, i);

            //Aca esta la ruta final del archivo
            string rutaArchivoFinal = Path.Combine(@"../../" + "Resources", rutaArchivoParcial);

            //Instanciar la ventana de la grilla
            frmdatosgrilla frmdatosgrilla = new frmdatosgrilla();

            // Abre el archivo para lectura
            using (StreamReader reader = new StreamReader(rutaArchivoFinal))
            {
                // Lee y descarta la primera línea (encabezado)
                reader.ReadLine();

                // Lee el resto de las líneas
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    // Procesa la línea actual aquí
                    string[] parametros = linea.Split(';');
                    //agregar a la datagrid
                   frmdatosgrilla.DtgGrillaMostrar.Rows.Add(parametros);
                }
            }
            frmdatosgrilla.rutaArchivoGrilla = rutaArchivoFinal;

            frmdatosgrilla.Show();
            this.Hide();
        }
    }
}
