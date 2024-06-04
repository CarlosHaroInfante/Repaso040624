using EduRecuperacionC.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// Interfaz que contiene los métodos de la operativa de la aplicación.
    /// Carlos Haro Infante - 28/05/24
    /// </summary>

    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método que contiene la operativa del alta alumno, y lo añade a la lista de alumnos.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        public void altaAlumno();

        /// <summary>
        /// Método que dará de baja el alumno por el campo del dni.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        public void bajaAlumno();

        /// <summary>
        /// Método que mostrará el alumno por consola.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        public void mostrarAlumno();

        /// <summary>
        /// Método que escribirá el fichero por consola.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        public void escribirFicheroAlumno();

        /// <summary>
        /// Método que modificará a un alumno por su dni.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        public void modificarAlumno();

    }


}
