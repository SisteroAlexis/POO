using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace practica1_1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double tri = Math.Pow(3,3);
            Console.WriteLine(tri);
            Console.ReadKey();
            Console.WriteLine("hola mundo");
            Console.ReadKey();

            //sintaxis de c# videos 1.8 maxi

            //declaracion de variables 

            int a; int b, c, d;
            int e = 0;
            //tipo de datos: int float bool char; el int esta de 10 en ves de el float usare double, bool de 10 y string para palabras
            int z; double monedas; bool cero; string palabras;

            // otros double, decimal, long, short, datetime

            long largo;

            //asignacion de valores

            a = 10; b = 10; c = a + b;

            Console.WriteLine("ingrese un numero");

            d = int.Parse(Console.ReadLine());

            Console.WriteLine(d);

            Console.ReadKey();

            //puedo pedir + - * / SQRT

            double numero = 16;

            double raiz = Math.Sqrt(numero);
            double cuadrado = Math.Pow(numero, 2);
            //Math Math Math Math Math Math Math Math Math Math Math Math Math Math

            Console.WriteLine(raiz);     // 4
            Console.WriteLine(cuadrado); // 256

            //normalmente en c# sigue las reglas matematicas estandar, pero siempre nos podemos asegurrar con 
            //el correcto uso de funsiones o los ()




        }
    }
}
