using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menu() {
            FicheroInterfaz fichero = new FicheroImplementacion();
            string mensaje;
            try
            {
                Console.WriteLine("Menu de la aplicación");
                Console.WriteLine("---------------------");
                Console.WriteLine("[0] - Cerrar menú");
                Console.WriteLine("[1] - Alta de alumno");
                Console.WriteLine("[2] - Baja de alumno");
                Console.WriteLine("[3] - Mostrar alumnos");
                Console.WriteLine("[4] - Escribir alumnos en fichero");
                Console.WriteLine("[5] - Modificar alumnos");
                Console.WriteLine("---------------------");

                int op = Convert.ToInt32(Console.ReadLine());
                mensaje = "El usuario ha elegido una opción del menú";
                fichero.escribirFichero(mensaje);
                return op;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al elegir la opción del usuario " + ex.Message);
                mensaje = "Error al elegir la opción del usuario";
                fichero.escribirFichero(mensaje);
                throw;
            }
            


        }
    }
}
