using conexion_basedatos;
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
            Objeto c = new Objeto();
            IList<String> ciudaes = c.getDetalles();

            if (ciudaes == null)
            {
                Console.WriteLine("Nada");
                return;
            }

            for (int i = 0; i < ciudaes.Count; i++)
            {
                Console.WriteLine(ciudaes[i]);
            }
        }
    }
}