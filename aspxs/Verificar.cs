using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion_basedatos
{
    public class Verificar : IVerificar
    {
        public Boolean ValidarRegistro(string Registro)
        {
            Conectar conSql = new Conectar();
            IList<String> datosEstandarizados = new List<String>();

            IList<int> datosCUI = getCUI(conSql);
            IList<String> datosNombres = getNombres(conSql);
            IList<String> datosApellidos = getApellidos(conSql);
            IList<String> datosCorreos = getCorreos(conSql);

            string temp = "";
            for (int i = 0; i < Registro.Length; i++)
            {
                if (Registro[i] != '|')
                {
                    temp += Registro[i];
                }
                else
                {
                    datosEstandarizados.Add(temp);
                    temp = "";
                }
            }

            int cui = Int32.Parse(datosEstandarizados[0]);

            if (!datosCUI.Contains(cui))
            {
                return false;
            }
            if (!datosNombres.Contains(datosEstandarizados[1]))
            {
                return false;
            }
            if (!datosApellidos.Contains(datosEstandarizados[2]))
            {
                return false;
            }
            if (!datosCorreos.Contains(datosEstandarizados[3]))
            {
                return false;
            }

            return true;
        }

        private IList<int> getCUI(Conectar conSql)
        {
            IList<int> cuis = new List<int>();

            try
            {
                conSql.abrirConexion();

                SqlDataReader lector = conSql.hacerConsulta("select cui from alumnosepcc");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        cuis.Add((int)lector.GetInt32(0));
                    }
                }

                conSql.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return cuis;
        }

        private IList<String> getNombres(Conectar conSql)
        {
            IList<String> noms = new List<String>();

            try
            {
                conSql.abrirConexion();

                SqlDataReader lector = conSql.hacerConsulta("select nombres from alumnosepcc");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        noms.Add(lector.GetString(0));
                    }
                }

                conSql.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return noms;
        }

        private IList<String> getApellidos(Conectar conSql)
        {
            IList<String> apls = new List<String>();

            try
            {
                conSql.abrirConexion();

                SqlDataReader lector = conSql.hacerConsulta("select apellidos from alumnosepcc");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        apls.Add(lector.GetString(0));
                    }
                }

                conSql.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return apls;
        }

        private IList<String> getCorreos(Conectar conSql)
        {
            IList<String> cors = new List<String>();

            try
            {
                conSql.abrirConexion();

                SqlDataReader lector = conSql.hacerConsulta("select correo from alumnosepcc");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        cors.Add(lector.GetString(0));
                    }
                }

                conSql.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return cors;
        }
    }
}
