using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinco
{
    internal class Persona
    {
        //static constantes para constructore
        private static int contador = 0; //para iniciar id en 0 


        //atributos
        private int id;
        public string nombre { get; }
        public int edad { get; }

        //constructor
        public Persona(string nombreinicial, int edadinicial)
        {
            contador++;
            id = contador;
            nombre = nombreinicial;
            edad = edadinicial;

        }
        //metodo
        public string Mostrar()
        {
            return "Id: " + id.ToString() +
                   "\n Nombre: " + nombre +
                   "\n Edad: " + edad.ToString();
        }

        

    }
}
