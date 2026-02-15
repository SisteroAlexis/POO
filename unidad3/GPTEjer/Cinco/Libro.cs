using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinco
{
    internal class Libro
    {
        private static int contador = 0;
        private bool estado=false;

        //atributos
        private int id;
        public string titulo { get; }
        public Persona personaPrestada { get; set; }

        //constructor
        public Libro(string tituloinicial)
        {
            contador++;
            id = contador;
            titulo = tituloinicial;
            //Persona personaPrestada = new Persona();
        }

        //Metodo
        public void PrestarA(Persona p)
        {
            personaPrestada = p;
            estado = true;

        }

        public void regresado() { estado = false; }

        public string Mostrar ()
        {
            if (estado)
            {
                return "Libro: " + id.ToString() +
                   "\n Titulo: " + titulo +
                   "\n El libro fue prestado a: " +
                   "\n  " + personaPrestada.nombre;
            }else
            {
                return "Libro: " + id.ToString() +
                   "\n Titulo: " + titulo +
                   "\n El libro no fue prestado ";
            }
        }
        public virtual int conta (int contador)
            { return contador; }

    }
}
