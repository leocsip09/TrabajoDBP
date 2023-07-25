using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_datos
{
    class Conectar
    {
        private SqlConnection conexion;
        private String path;

        public Conectar()
        {
            path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\AppData\Local\Microsoft\VisualStudio\SSDT\lab_dbp.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public Boolean iniciar()
        {
            try
            {
                conexion = new SqlConnection(path);
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public void cerrar()
        {
            conexion.Close();
        }

        public SqlDataReader nuevaConsulta(String consulta)
        {
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();
                return lector;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
