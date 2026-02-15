using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conver
            Console.WriteLine("Ingrese 2 numeros");
            int b = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese un numero ");
            string input = Console.ReadLine();

            int numero;

            if (int.TryParse(input, out numero))
            {
                Console.WriteLine("Numero valido " + numero);

            }
            else { Console.WriteLine("numero no valido"); }
            Console.ReadKey();
        }
    }
}
