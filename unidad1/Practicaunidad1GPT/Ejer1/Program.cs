using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            float b = 5f;
            double c = a + (double)b;

            double bb = 4;

            c = a + bb;

            Console.WriteLine(c);
            Console.ReadKey();

            /*
Ejercicio 1 – Declaración básica

Declará 5 variables:
un int
un float
un double
un bool
un string

            */

            int numero1 = 1; float numero2 = 2; double numero3 = 3; bool numero0 = false; string palabra = "palabra";

            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
            Console.WriteLine(numero0);
            Console.WriteLine(palabra);

            Console.ReadKey();


            int aaa = 1; float bbb = 2.5f; double ccc = aaa + (Double)bbb;
            Console.WriteLine(ccc);
            Console.ReadKey();

            int z = 5; int x = 2; double y = (double)z / x;
            Console.WriteLine(y);
            Console.ReadKey();

            int edad = 25;
            Console.WriteLine("Mi edad es:" + edad);
            Console.ReadKey();
            Console.WriteLine("En 5 años tendre: " + (edad + 5));
            Console.ReadKey();


            int numeros = 10; bool estado = true;
            //error
            //int resultado = numeros + estado;
        }
    }
}
