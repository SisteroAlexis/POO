using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella b1 = new Botella("Rojo", " Plastico"); //En new Botella (); invoca el constructor lo que hay dentro de () nos permite pasar parametros a la clase
                                                           //c# dentro de VS y con el framework .net crea la clase objet que es la "mama-papa" de todos las clases y hereda ciertas funcionalidades



            Console.WriteLine(b1.CapActual);

           Console.WriteLine("Costo de recarga " + b1.recarga());

            Console.WriteLine(b1.CapActual);

            int f = Sumar();

        }
        static int   Sumar ()
        { return 0; }
       static int Sumar (int a, int b)
         { int c; return c = a + b ; }
    }
}
