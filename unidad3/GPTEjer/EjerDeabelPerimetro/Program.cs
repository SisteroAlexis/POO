using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerDeabelPerimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largo = 0; int ancho = 0; int sumador = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el largo y el ancho");
               largo = int.Parse(Console.ReadLine());
               ancho = int.Parse(Console.ReadLine());
               int r = Perimetro(largo, ancho);
                sumador += r;

            }
            Mostrar(sumador);
        }
        static int Perimetro (int x, int y)
        { return x + y; }
        static void Mostrar(int x)
        {
            if (x <= 20) Console.WriteLine("Aceptable " +x );
            else Console.WriteLine("Muy caro " + x);
        }
    }
}
