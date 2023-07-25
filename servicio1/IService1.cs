using base_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace servicio1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IList<String> getCiudades();

        [OperationContract]

        void EnviarService(string datos);
    }
}