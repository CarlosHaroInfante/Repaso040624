using EduRecuperacionC.Dto;
using EduRecuperacionC.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void escribirFichero(string mensaje)
        {


            try
            {
                string rutaCarpetaLogs = "C:\\Users\\Carlos\\Desktop\\Programación\\EduRecuperacionC\\CarpetaLog\\";

                string rutaFicheroLog2 = string.Concat(rutaCarpetaLogs, Utilidades.crearNombreLog());

                using (StreamWriter escribir = new StreamWriter(rutaFicheroLog2, true))
                {

                    escribir.Write(mensaje + "\n");
                    escribir.Close();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear/escribir en el fichero log " + ex.Message);

            }
        }

        public void alumnosFichero(string alumno)
        {

            try
            {
                string rutaCarpetaAlumnos = "C:\\Users\\Carlos\\Desktop\\Programación\\EduRecuperacionC\\alumnos.txt";
                List<string> alumnosExistentes = new List<string>();


                using (StreamReader leerAlumnos = new StreamReader(rutaCarpetaAlumnos))
                {
                    string linea;
                    while ((linea = leerAlumnos.ReadLine()) != null)
                    {
                        alumnosExistentes.Add(linea);
                    }
                }

                if (!alumnosExistentes.Contains(alumno))
                {
                    using (StreamWriter escribirAlumnos2 = new StreamWriter(rutaCarpetaAlumnos, true))
                    {
                        escribirAlumnos2.WriteLine(alumno);
                        escribirAlumnos2.Close();
                    }
                    Console.WriteLine("Se ha escrito correctamente");
                }
                else
                {
                    Console.WriteLine("El alumno ya existe en el fichero.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir en el fichero de alumnos " + ex.Message);

            }

        }

        
        public void cargaInicial()
        {

            string carga = "C:\\Users\\Carlos\\Desktop\\Programación\\EduRecuperacionC\\alumnos.txt";
            try
            {
                using (StreamReader leer = new StreamReader(carga))
                {

                    string linea;

                    while ((linea = leer.ReadLine()) != null)
                    {
                        AlumnoDto alumno = new AlumnoDto();
                        string[] separa = linea.Split(";");
                        alumno.Dni = separa[0];
                        alumno.Nombre = separa[1];
                        alumno.Apellido1 = separa[2];
                        alumno.Apellido2 = separa[3];
                        alumno.Direccion = separa[4];
                        alumno.Telefono = separa[5];
                        alumno.Email = separa[6];
                        DateTime fechaNacimiento = DateTime.Parse(separa[7]);
                        alumno.FechaNac = fechaNacimiento;

                        Program.alumno.Add(alumno);
                    }


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la carga de alumnos " + ex.Message);


            }
        }
        public void actualizaFichero()
        {
            string rutaCarpetaAlumnos = "C:\\Users\\Carlos\\Desktop\\Programación\\EduRecuperacionC\\alumnos.txt";

            try
            {
                using(StreamWriter actualiza = new StreamWriter(rutaCarpetaAlumnos, false))
                {
                    foreach(AlumnoDto alumno in Program.alumno)
                    {
                        actualiza.WriteLine(alumno.ToString());
                    }
                }
                Console.WriteLine("La lista de alumnos se ha actualizado correctamente.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la lista de alumnos " + ex.Message);
            }

        }

    }
}
