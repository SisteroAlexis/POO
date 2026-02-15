using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gptejer2List
{
    internal class Curso
    {
        private static int cont = 0;

        //atributos-prop
        public int Id { get; }
        public string Nombre { get; }
        public Alumno AlumnoInscripto { get; private set; }


        //constructo
        public Curso(string NombreInicial)
        {
            cont++;
            Id = cont;
            Nombre = NombreInicial;
        }

        //metodos
        public void InscribirAlumno (Alumno alumno)
        {
            AlumnoInscripto = alumno;
        }

        public string Mostrar()
        {
            // mostrar curso + alumno o "sin alumno"
            if (AlumnoInscripto == null)
            {
                return "Info del curso: \n" +
                      "Id: " + Id.ToString() +
                      "\nNombre: " + Nombre +
                      "\n No hay alumnos en este curso";
            }
            else 
            {
                return "Info del curso: \n" +
                       "Id: " + Id.ToString() +
                       "\nNombre: " + Nombre + "\n" +
                        AlumnoInscripto.Mostrar();
            }


        }

        }
}
