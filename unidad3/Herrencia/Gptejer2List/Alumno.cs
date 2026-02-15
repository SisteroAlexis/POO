using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gptejer2List
{
    internal class Alumno
    {
        //Creacion de constante incremental para el Id
        private static int cont = 0;

        //Atributo-Prop
       public int Id { get;  }
       public string Nombre { get; }
       public int  Edad {  get; }

        //constructor
        public Alumno (string NombreInicial, int EdadInicial)
        {
            cont++;
            Id = cont;
            Nombre = NombreInicial;
            Edad = EdadInicial;
        }

        //metodo
        public string Mostrar()
        {
            // devolver info
            return "Informacion del alumno: \n" +
                   "Id: " + Id + "\n" +
                   "Nombre: " + Nombre + "\n" +
                   "Edad: " + Edad;
        }


    }
}
