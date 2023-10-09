using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryMoyano04092
{
    internal class claseCargar
    {
        public static string RutaFull;

        public void Grabar(string numero, string entidad, string apertura, string Nexpediente, string juzgado, string jurisdiccion, string direccion, string liquidador)
        {






            DirectoryInfo info = new DirectoryInfo(@"../../" + "Resources");
            string ruta = info.Name;

            StreamWriter Listado = new StreamWriter((ruta + "/" + RutaFull), true);
            Listado.Write(numero);
            Listado.Write(";");
            Listado.Write(entidad);
            Listado.Write(";");
            Listado.Write(apertura);
            Listado.Write(";");
            Listado.Write(Nexpediente);
            Listado.Write(";");
            Listado.Write(juzgado);
            Listado.Write(";");
            Listado.Write(jurisdiccion);
            Listado.Write(";");
            Listado.Write(direccion);
            Listado.Write(";");
            Listado.WriteLine(liquidador);
            Listado.Close();
            Listado.Dispose();
        }

    }
}
