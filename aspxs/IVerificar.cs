﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conexion_basedatos;

namespace conexion_basedatos
{
    public interface IVerificar
    {
        Boolean ValidarRegistro(string Registro);

    }
}
