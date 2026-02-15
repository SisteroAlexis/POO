using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dasafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t = new Telefono("Redmin", "Xiamo");

            t.NumeroTelefonico = "478518103";
            t.CodigoOperador = 2;

            Console.WriteLine(t.mostrar());
            Console.ReadKey();

            Console.WriteLine(t.Llamar());
            Console.ReadKey();

            Console.WriteLine(t.Llamar("Pedro"));
            Console.ReadKey();
        }
    }
}
