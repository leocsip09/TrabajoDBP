using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion_basedatos
{
    public interface IObjeto
    {
        IList<String> getImplementos();

        IList<String> getDeporte();

        IList<int> getCantidades();

        IList<String> getDetalles();

        IList<Boolean> getEstado();
    }
}
