using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Estudiantes_1._1
{
    
    class EstudianteSecundaria:Estudiantes
    {
        public int Nivel=2;
        public int Precio=20;
        public int Total;


        public static void DatosSecundaria()
        {


            int total = 2 * 20;
            EstudianteSecundaria estudianteSecundaria = new EstudianteSecundaria();
            estudianteSecundaria.Nombre = "Mario";
            estudianteSecundaria.Apellido = "Acosta";
            estudianteSecundaria.Cedula = "136854589-9";
            estudianteSecundaria.NombreInstitucion = "Manta";
            estudianteSecundaria.Nivel = 2;
            estudianteSecundaria.Total = total;
     

            List<EstudianteSecundaria> listaSecundaria = new List<EstudianteSecundaria>();
            listaSecundaria.Add(estudianteSecundaria);

            foreach (EstudianteSecundaria item in listaSecundaria)
            {
                Console.WriteLine("Nombre: " + item.Nombre);
                Console.WriteLine("Apellido: " + item.Apellido);
                Console.WriteLine("Cedula: " + item.Cedula);
                Console.WriteLine("Escuela : " + item.NombreInstitucion);
                Console.WriteLine("Nivel : " + item.Nivel);
                Console.WriteLine("Valor a pagar es : " + item.Total);

            }
        }

    }
}
