using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Dto
{
    /// <summary>
    /// Dto del alumnos que contiene los campos con sus campos con sus valores predeterminados, los getters y setters y el constructor vacío.
    /// Carlos Haro Infante - 28/05/24
    /// </summary>
    internal class AlumnoDto
    {
        long id;

        string nombre = "aaaaa";

        string apellido1 = "aaaaa";

        string apellido2 = "aaaaa";

        string dni = "aaaaa";

        string direccion = "aaaaa";

        string telefono = "aaaaa";

        string email = "aaaaa";

        DateTime fechaNac = new DateTime(9999, 12, 31);


        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }

        public AlumnoDto()
        {
            
        }

        
        public override string ToString()
        {
            string alumnos = this.dni + ";" + this.nombre + ";" + this.apellido1 + ";" + this.apellido2 + ";" + 
                this.direccion + ";" + this.telefono + ";" + this.email + ";" + this.fechaNac.Day + "/" + this.fechaNac.Month + "/" + this.fechaNac.Year;

            return alumnos;
        }
    }
}
