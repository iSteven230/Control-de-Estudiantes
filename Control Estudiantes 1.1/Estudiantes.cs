using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Estudiantes_1._1
{
    class Estudiantes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreInstitucion { get; set; }
        public string Cedula { get; set; }
        public int valor { get; set; }

        public static void MostrarDatosPrimaria()
        {
            EstudiantePrimaria.DatosPrimaria();
        }
        public static void MostrarDatosSecundaria()
        {
            EstudianteSecundaria.DatosSecundaria();
        }
        public static void MostrarDatosUniversidad()
        {
            EstudianteUniversidad.DatosUniversidad();
        }




    }
}
