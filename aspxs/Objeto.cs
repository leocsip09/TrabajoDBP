using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion_basedatos
{
    public class Objeto : IObjeto
    {
        public IList<String> getImplementos()
        {
            Conectar conSQL = new Conectar();
            IList<String> objetos = new List<String>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select objeto from DataObjetos");

                if(lector.HasRows)
                {
                    while(lector.Read())
                    {
                        objetos.Add(lector.GetString(0));
                    }
                }

                conSQL.cerrarConexion();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return objetos;
        }

        public IList<String> getDeporte()
        {
            Conectar conSQL = new Conectar();
            IList<String> objetos = new List<String>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select deporte from DataObjetos");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        objetos.Add(lector.GetString(0));
                    }
                }

                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return objetos;
        }

        public IList<int> getCantidades()
        {
            Conectar conSQL = new Conectar();
            IList<int> objetos = new List<int>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select cantidad from DataObjetos");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        objetos.Add((int)lector.GetInt32(0));
                    }
                }

                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return objetos;
        }

        public IList<String> getDetalles()
        {
            Conectar conSQL = new Conectar();
            IList<String> objetos = new List<String>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select observacion from DataObjetos");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        if(lector.IsDBNull(0))
                        {
                            objetos.Add("Sin observaciones");
                        }
                        else
                        {
                            objetos.Add(lector.GetString(0));
                        }
                    }
                }

                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return objetos;
        }

        public IList<Boolean> getEstado()
        {
            Conectar conSQL = new Conectar();
            IList<Boolean> objetos = new List<Boolean>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select estado from DataObjetos");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        objetos.Add((bool)lector.GetSqlBoolean(0));
                    }
                }

                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return objetos;
        }
    }
}
