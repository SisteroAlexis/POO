using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //funsiones
            //ref es para pasar parametro por referencias
            int a = 1; int b = 2;
            int c = sumar(a,ref b);

            Console.WriteLine(c);
            Console.ReadKey();

            Console.WriteLine(saludar("Pedro"));

        }

        static int sumar (int a, ref int b)
        { return (a + b); }

        static string saludar (string nombre)
        {
            return "Hola como estas " + nombre;
        }
    }
}
