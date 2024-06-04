using EduRecuperacionC.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Utils
{
    internal class Utilidades : UtilidadesInterfaz
    {

         static public string crearNombreLog()
        {
           
            try { 

            DateTime fecha = DateTime.Now;

            string fechaFormateada = fecha.ToString("ddMMyyyy");

            string nombreLog = $"log-{fechaFormateada}.txt";

            return nombreLog;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error al crear el nombre del fichero " + ex.Message);
                throw;
            }
            
        }

        static public string crearNombreCarpetaAlumno()
        {

            try
            {

                DateTime fecha = DateTime.Now;

                string fechaFormateada = fecha.ToString("ddMMyyyy");

                string nombreAlumn = $"alumnos-{fechaFormateada}.txt";

                return nombreAlumn;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error al crear el nombre del fichero " + ex.Message);
                throw;
            }

        }
    }
}
