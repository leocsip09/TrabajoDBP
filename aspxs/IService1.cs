using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace servicio_basedatos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IList<String> getObjetosBD();

        [OperationContract]
        IList<String> getDeporteBD();

        [OperationContract]
        IList<int> getCantidadBD();

        [OperationContract]
        IList<String> getDetallesBD();

        [OperationContract]
        IList<Boolean> getEstadoBD();

        [OperationContract]
        Boolean ValidarReg(string Registro);
    }
}
