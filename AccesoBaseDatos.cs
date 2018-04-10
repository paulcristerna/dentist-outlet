using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ProyectoConsultorioDental
{
    public class AccesoBaseDatos
    {
        public MySqlConnection con;
        public MySqlCommand com;

        public AccesoBaseDatos()
        {
            con = new MySqlConnection();
            con.ConnectionString = "Server=localhost;Database=ConsultorioDental;Uid=root;Pwd=";           
        }
        
        public AccesoBaseDatos(string cadenaConexion)
        {
            con = new MySqlConnection();
            con.ConnectionString = cadenaConexion;
        }

        public int EjecutaComando(string SQL)
        {
            int resultado = 0;

            com = new MySqlCommand(SQL, con);

            try
            {
                con.Open();
                resultado = com.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                con.Close();
            }
            return resultado;
        }

        public void EjecutaConsulta(string SQL, System.Data.DataTable dt)
        {
            // Se especifica la instrucción que se lanzará al servidor
            com = new MySqlCommand(SQL, con);

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = com;

            dt.Clear();
            try
            {
                adaptador.Fill(dt);
            }
            catch (Exception error)
            {
                throw error;
            }
        }     
    }
}
