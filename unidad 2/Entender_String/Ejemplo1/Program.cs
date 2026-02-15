using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            nombre = Console.ReadLine(); // no requiere convert o Try.Parse

            nombre = "Hola como estas " + nombre;

            int cant = nombre.Length;
            Console.WriteLine(nombre.Length);

            Console.WriteLine(nombre.ToUpper());
            Console.ReadKey();

            Console.WriteLine(nombre.Replace('a', 'e'));
        }


    }
}
