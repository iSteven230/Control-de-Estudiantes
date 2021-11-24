using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Estudiantes_1._1
{
    class EstudianteUniversidad:Estudiantes
    {
        public int CantidadDeCreditos;
        public int PrecioCredito = 7;
        public int Total;

        public static void DatosUniversidad()
        {


            int total = 455 * 7;
            EstudianteUniversidad estudianteUniversidad= new EstudianteUniversidad();
            estudianteUniversidad.Nombre = "Pablo";
            estudianteUniversidad.Apellido = "Cedeño";
            estudianteUniversidad.Cedula = "136454589-1";
            estudianteUniversidad.NombreInstitucion = "Eloy Alafaro";
            estudianteUniversidad.CantidadDeCreditos = 455;
            estudianteUniversidad.Total = total;


            List<EstudianteUniversidad> listaUniversidad = new List<EstudianteUniversidad>();
            listaUniversidad.Add(estudianteUniversidad);

            foreach (EstudianteUniversidad item in listaUniversidad)
            {
                Console.WriteLine("Nombre: " + item.Nombre);
                Console.WriteLine("Apellido: " + item.Apellido);
                Console.WriteLine("Cedula: " + item.Cedula);
                Console.WriteLine("Escuela : " + item.NombreInstitucion);
                Console.WriteLine("Creditos : " + item.CantidadDeCreditos);
                Console.WriteLine("Valor a pagar es : " + item.Total);

            }
        }





    }
}
