using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gptejer2List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Practica con List y asosiasion.

            //creacion de 2 listas

            List<Alumno> alumnos = new List<Alumno>();
            List<Curso> cursos = new List<Curso>();

            Alumno a1 = new Alumno("Pelu",29);
            //Console.WriteLine(a1.Mostrar());  //chequeo de metodo
            Alumno a2 = new Alumno("Gra", 70);
            Alumno a3 = new Alumno("Mayu", 17);

            alumnos .Add(a1);
            alumnos .Add(a2);
            alumnos .Add(a3);

            Curso c1 = new Curso("Robotica");
            Curso c2 = new Curso("Gasista");
            Curso c3 = new Curso("Ingles");
            cursos .Add(c1);    
            cursos .Add(c2);
            cursos .Add(c3);

            c1.InscribirAlumno(a1);
            c1.InscribirAlumno(a3); //aca desaparece el a1 y se guarda el a3 creo
            c3.InscribirAlumno(a2);

            foreach (Curso c in cursos)
            {
               Console.WriteLine( c.Mostrar());

            }
            Console.ReadKey();
        }
    }
}
