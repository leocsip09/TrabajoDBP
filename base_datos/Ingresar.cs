using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_datos
{
    public class Ingresar : IEnter
    {
        public void IngresarBaseDatos(string data)
        {
            Conectar conSQL = new Conectar();
            IList<String> datosEstandarizados = new List<String>();
            string consulta = "";

            string temp = "";
            for(int i=0; i < data.Length; i++)
            {
                if (data[i] != '|')
                {
                    temp+= data[i];
                }
                else
                {
                    datosEstandarizados.Add(temp);
                    temp = "";
                }
            }

            for(int i=0;i < datosEstandarizados.Count; i++)
            {
                Console.WriteLine(datosEstandarizados[i].ToString());
            }

            consulta = "insert into RegistroAlumnos values (";

            consulta += "\'" + datosEstandarizados[0] + "\'" + ",";
            consulta += "\'" + datosEstandarizados[1] + "\'" + ",";
            consulta += "\'" + datosEstandarizados[2] + "\'" + ",";
            consulta += "\'" + datosEstandarizados[3] + "\'" + ",";
            if (datosEstandarizados[4] == "-")
            {
                consulta += "NULL,";
            }
            else
            {
                consulta += "\'" + datosEstandarizados[4] + "\'" + ",";
            }
            consulta += datosEstandarizados[5] + ",";
            if (datosEstandarizados[6] == "-")
            {
                consulta += "NULL";
            }
            else
            {
                consulta += "\'" + datosEstandarizados[6] + "\'";
            }
            consulta += ");";

            try
            {
                conSQL.iniciar();
                SqlDataReader reader = conSQL.nuevaConsulta(consulta);
                conSQL.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
