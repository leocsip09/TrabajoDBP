using base_datos;
using System;
using System.Collections.Generic;

namespace lab_6
{
    class ConexionDB
    {
        public static void Main(string[] args)
        {
            ConexionDB db = new ConexionDB();
            db.query();

            Console.ReadKey();
        }

        private void query()
        {
            Ciudad c = new Ciudad();
            IList<string> ciudaes = c.getCiudades();

            if (ciudaes == null)
            {
                Console.WriteLine("Nada");
                return;
            }

            for (int i = 0; i < ciudaes.Count; i++)
            {
                Console.WriteLine(ciudaes[i]);
            }

            Ingresar ingresar = new Ingresar();
            ingresar.IngresarBaseDatos("krg|abzabz|mas|email|-|6|juego|");
        }
    }
}