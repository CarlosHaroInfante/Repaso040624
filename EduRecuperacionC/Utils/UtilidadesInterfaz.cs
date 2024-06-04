using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Utils
{
    /// <summary>
    /// Interfaz que contiene el método relacionado con la creación del nombre del fichero log.
    /// Carlos Haro Infante - 28/05/24
    /// </summary>
    internal interface UtilidadesInterfaz
    {

        /// <summary>
        /// Método que a partir de la fecha se crea el fichero log con el nombre.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        abstract static public string crearNombreLog();

        /// <summary>
        /// Método que a partir de la fecha se crea el fichero con los alumnos.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        abstract static public string crearNombreCarpetaAlumno();

    }
}
