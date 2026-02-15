using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunsionesSuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1; int b = 2;
            int c = Sumar (a, b);

            int g= 29;  int h= 30;
            int z = Sumar(g, h);


            Console.WriteLine("Ingresar edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Validar(edad);
        }

      static  int  Sumar (int n1, int n2)
        {
            return (n1 + n2);
        }

        static void Validar(int n) 
        {
            if (n >= 18)
            Console.WriteLine("Es mayor");
            else Console.WriteLine("Es menor");
        }

    }
}
