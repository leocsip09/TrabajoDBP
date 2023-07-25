using base_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_datos
{
    public class Ciudad : ICiudad
    {
        public IList<string> getCiudades()
        {
            Conectar conSQL = new Conectar();
            IList<string> result = new List<string>();

            try
            {
                conSQL.iniciar();
                SqlDataReader reader = conSQL.nuevaConsulta("select ciudad from DataCiudad");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }

                conSQL.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return result;
        }
    }
}