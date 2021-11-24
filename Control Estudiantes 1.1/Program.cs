using System;
using System.Collections.Generic;

namespace Control_Estudiantes_1._1
{
    class Program
    {
        public static void MenuPrincipal()
        {
            Console.WriteLine("***Control de Estudiante***");
            Console.WriteLine("1. Primaria ");
            Console.WriteLine("2. Secundaria ");
            Console.WriteLine("3. Universidad ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("***Menu***");
                    Estudiantes.MostrarDatosPrimaria();

                    break;

                case 2:

                    Console.Clear();
                    Console.WriteLine("***Menu***");
                    Estudiantes.MostrarDatosSecundaria();


                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("***Menu***");
                    Estudiantes.MostrarDatosUniversidad();
                    break;
            }
        }
        static void Main(string[] args)
        {
            Program.MenuPrincipal();
        }
    }
}
