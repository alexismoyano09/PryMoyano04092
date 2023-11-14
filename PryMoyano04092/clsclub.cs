using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Data.OleDb;
using System.ComponentModel.Design;
using System.Reflection;

namespace PryMoyano04092
{
    internal class clsclub
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS;

        
        public string estadoConexion;
        public string rutaArchivo;
        public string EstadoConexion;
        public string Datosocios;
        public string tiposexo;

        //Cliniciodesesion rutaArchivo = new Cliniciodesesion();

        public void Registrarusuarionuevo()
        {

            
          
            try
            {
               OleDbCommand comandoBD = new OleDbCommand();

                OleDbDataAdapter adaptadorBD;

                DataSet objDS = new DataSet();

                conexionBD = new OleDbConnection();
                string rutaArchivo = @"../../Archivos/EL_CLUB.accdb";
                string Conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

                conexionBD.ConnectionString = Conexion;
                conexionBD.Open();
                EstadoConexion = "Conectado";

                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "USERS";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "USERS");

                DataTable objTabla = objDS.Tables["USERS"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["nombreUsuario"] = Frmregistrarusuario.nombre;
                nuevoRegistro["contraseña"] = Frmregistrarusuario.contraseña;
                nuevoRegistro["perfil"] = Frmregistrarusuario.perfil;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "USERS");

                
                estadoConexion = "REGISTRADO EXITOSAMENTE";
                MessageBox.Show("REGISTRADO EXITOSAMENTE");
            }
            catch (Exception error)
            {
                
                estadoConexion = error.Message;
                MessageBox.Show("Error al registrar");
            }


        }

        public void MostrarDatos(DataGridView Grilla)
        {
            string EstadoCliente = "";
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";//tabla solicitada dek access elclub
            lectorBD = comandoBD.ExecuteReader();
           
            Grilla.Columns.Add("ID", "ID");
            Grilla.Columns.Add("Nombre", "Nombre");
            Grilla.Columns.Add("Apellido", "Apellido");
            Grilla.Columns.Add("Lugar Nacimiento", "Lugar Nacimiento");
            Grilla.Columns.Add("Edad", "Edad");
            Grilla.Columns.Add("Sexo", "Sexo");
            Grilla.Columns.Add("Ingreso", "Ingreso");
            Grilla.Columns.Add("Puntaje", "Puntaje");
            Grilla.Columns.Add("Estado", "Estado");

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    if (lectorBD.GetBoolean(8) == true)
                    {
                        EstadoCliente = "Activo";
                    }
                    else
                    {
                        EstadoCliente = "Inactivo";
                    }

                    if (lectorBD.GetBoolean(5) == true) 
                    {
                        tiposexo = "Masculino";
                    }
                    else 
                    {
                        tiposexo = "Femenino";
                    }
                    Datosocios += "-" + lectorBD[1];
                    Grilla.Rows.Add(lectorBD[0],lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7], EstadoCliente);
                }
            }

        }
        public void Baseconectada() 
        {
            try
            {
                string rutaArchivo = @"../../Archivos/EL_CLUB.accdb";
                string Conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = Conexion;
                conexionBD.Open();
                EstadoConexion = "Conectado";
            }
            catch(Exception EX) 
            {
                estadoConexion = "error" + EX.Message;
            }
        }

        public void BuscarPorid(int IDsocio, DataGridView Grilla)
        {
            comandoBD = new OleDbCommand();
            
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows) 
            {
                bool idusuario = false;
                while (lectorBD.Read())
                {
                    if (int.Parse(lectorBD[0].ToString()) == IDsocio)
                    {
                        MessageBox.Show("existe", "consulta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        idusuario = true;
                        
                    }
                    Grilla.Rows.Clear();
                    Grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7], lectorBD[8]);
                    idusuario = true;
                    
                    break;

                }

                if (idusuario == false)
                {
                    MessageBox.Show("No Existe",
                        "Consulta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        public void BuscarPorApellido(string apellido, DataGridView Grilla)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows)
            {
                bool idusuario = false;
                while (lectorBD.Read())
                {
                    if (lectorBD[2].ToString() == apellido)
                    {
                        MessageBox.Show("existe", "consulta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        idusuario = true;

                    }
                    Grilla.Rows.Clear();
                    Grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7], lectorBD[8]);
                    idusuario = true;
                    
                    break;

                }

                if (idusuario == false)
                {
                    MessageBox.Show("No Existe",
                        "Consulta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
