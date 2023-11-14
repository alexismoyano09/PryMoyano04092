using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace PryMoyano04092
{
    internal class Cliniciodesesion
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS;

        string rutaArchivo;
        public string estadoConexion;
        public static bool acceso;
        public Cliniciodesesion()
        {
            try
            {
                rutaArchivo = @"../../Archivos/EL_CLUB.accdb";
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
                conexionBD.Open();

                objDS = new DataSet();

                estadoConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }

        public void RegistroLogInicioSesion()
        {
            try
            {

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "LOGS";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                objDS = new DataSet();

                adaptadorBD.Fill(objDS, "LOGS");

                DataTable objTabla = objDS.Tables["LOGS"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["USUARIO"] = "Inicio Sesión";
                nuevoRegistro["FECHA"] = DateTime.Now;
                nuevoRegistro["ACCION"] = "Inicio exitoso";

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "LOGS");

                estadoConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }

        }

        public void ValidarUsuario(string nombre, string contraseña)
        {
            // try
            //{
            //  conexionBD.Open();

            //comandoBD = new OleDbCommand();

            //comandoBD.Connection = conexionBD;
            //comandoBD.CommandType = System.Data.CommandType.TableDirect;
            //comandoBD.CommandText = "Usuario";

            //lectorBD = comandoBD.ExecuteReader();

            //if (lectorBD.HasRows)
            //{
            //  while (lectorBD.Read())
            //{
            //  string usuarioBD = lectorBD[1].ToString();
            //string contraseñaBD = lectorBD[2].ToString();
            // if (usuarioBD == Frminiciodesesion.usuario & contraseñaBD == Frminiciodesesion.contraseña)
            //{
            //  acceso = true;
            // break;
            //}
            //else
            //{
            //  acceso = false;
            //}
            //}
            //}
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Usuario";

                lectorBD = comandoBD.ExecuteReader();

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD[1].ToString() == Frminiciodesesion.usuario && lectorBD[2].ToString() == Frminiciodesesion.contraseña)
                        {
                            estadoConexion = "Usuario EXISTE";
                        }
                    }
                }

            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }

        }

       

    
        public void RegistroLogInicioFallidoSesion()
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "LOGS";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "LOGS");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["USUARIO"] = "usuario";
                nuevoRegistro["FECHA"] = DateTime.Now;
                nuevoRegistro["ACCION"] = "error al iniciar";

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "LOGS");

                estadoConexion = "Registro fallos de inicio de sesion";
            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }

        }

        public void RegistroLogIngresoAlSistema()
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "LOGS";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "LOGS");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["USUARIO"] = "usuario";
                nuevoRegistro["FECHA"] = DateTime.Now;
                nuevoRegistro["ACCION"] = "ingreso menu";

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "LOGS");

                estadoConexion = "ingreso menu";
            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }


        }

        public void RegistroLogInicioSesionProveedores()
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "LOGS";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "LOGS");

                DataTable objTabla = objDS.Tables["LOGS"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["USUARIO"] = "usuario";
                nuevoRegistro["FECHA"] = DateTime.Now;
                nuevoRegistro["ACCION"] = "Inicio exitoso";

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "LOGS");

                estadoConexion = "Registro exitoso ";
            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }
        }

       
        
    }
}
