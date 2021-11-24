using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Estudiantes_1._1
{
    class EstudiantePrimaria:Estudiantes
    {
        public int ValorFijoAnual=100;

        public static void DatosPrimaria()
        {
            

            EstudiantePrimaria estudiantePrimaria = new EstudiantePrimaria();
            estudiantePrimaria.Nombre = "Mario";
            estudiantePrimaria.Apellido = "Alfredo";
            estudiantePrimaria.Cedula = "135834589-4";
            estudiantePrimaria.NombreInstitucion = "Luis Teodoro Cantos";
            estudiantePrimaria.ValorFijoAnual = 100;



            List<EstudiantePrimaria> listaPrimaria = new List<EstudiantePrimaria>();
            listaPrimaria.Add(estudiantePrimaria);

            foreach (EstudiantePrimaria item in listaPrimaria)
            {
                Console.WriteLine("Nombre: "+item.Nombre);
                Console.WriteLine("Apellido: " + item.Apellido);
                Console.WriteLine("Cedula: " + item.Cedula);
                Console.WriteLine("Escuela : " + item.NombreInstitucion);
                Console.WriteLine("Valor a pagar es : " + item.ValorFijoAnual);


            }
        }

    }
}
