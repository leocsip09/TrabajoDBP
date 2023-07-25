using conexion_basedatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace servicio_basedatos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public IList<String> getObjetosBD()
        {
            Objeto obj = new Objeto();
            IList<String> Implementos = new List<String>();
            Implementos = obj.getImplementos();
            return Implementos;
        }

        public IList<String> getDeporteBD()
        {
            Objeto obj = new Objeto();
            IList<String> Deportes = new List<String>();
            Deportes = obj.getDeporte();
            return Deportes;
        }

        public IList<int> getCantidadBD()
        {
            Objeto obj = new Objeto();
            IList<int> Cantidad = new List<int>();
            Cantidad = obj.getCantidades();
            return Cantidad;
        }

        public IList<String> getDetallesBD()
        {
            Objeto obj = new Objeto();
            IList<String> Detalles = new List<String>();
            Detalles = obj.getDetalles();
            return Detalles;
        }

        public IList<Boolean> getEstadoBD()
        {
            Objeto obj = new Objeto();
            IList<Boolean> Estado = new List<Boolean>();
            Estado = obj.getEstado();
            return Estado;
        }
    }
}
