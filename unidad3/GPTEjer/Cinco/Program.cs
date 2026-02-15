using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Ejercicio
            List<Persona> personas = new List<Persona>();
            List<Libro> libros = new List<Libro>();

            Persona p1 = new Persona("Pepe", 15);
            Persona p2 = new Persona("Juan", 18);
            Persona p3 = new Persona("Lucia", 21);
            Persona p4 = new Persona("Marta", 17);

            personas.Add(p1);
            personas.Add(p2);
            personas.Add(p3);
            personas.Add(p4);

            Libro l1 = new Libro("Paris");
            Libro l2 = new Libro("La sombra del viento");
            Libro l3 = new Libro("Romeo y Julieta");
            Libro l4 = new Libro("Mundo");
            Libro l5 = new Libro("Tierra");
            Libro l6 = new Libro("Bibliea");

            libros.Add(l1);
            libros.Add(l2);
            libros.Add(l3);
            libros.Add(l4);
            libros.Add(l5);
            libros.Add(l6);

            libros[0].PrestarA(personas[1]);
            libros[1].PrestarA(personas[0]);
            libros[3].PrestarA(personas[2]);
            libros[0].regresado();

            foreach (Libro l in libros)
            {
               Console.WriteLine( l.Mostrar());
            }
            */

            // prueba de herencia
            libro2 l2 = new libro2("Juana de arco");

            Console.WriteLine(l2.conta(1));

            //

            Console.ReadKey();

        }
    }
}
