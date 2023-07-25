using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using base_datos;


namespace servicio1
{
    public class Service1 : IService1
    {
        public IList<String> getCiudades()
        {
            Ciudad ciudad = new Ciudad();
            IList<String> Ciudades = new List<String>();
            Ciudades = ciudad.getCiudades();
            return Ciudades;
        }

        public void EnviarService(string datos)
        {
            Ingresar aBaseDatos = new Ingresar();
            aBaseDatos.IngresarBaseDatos(datos);
        }
    }
}
