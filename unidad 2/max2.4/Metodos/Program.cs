using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();

            Console.WriteLine("Ingrese los datos dela persona, nombre, edad, sueldo");
            p.Nombre = Console.ReadLine();
            p.Edad = int.Parse(Console.ReadLine());
            p.Sueldo = double.Parse(Console.ReadLine());

            Console.WriteLine(p.Saludar());

            Console.ReadKey();
            Console.WriteLine(p.Saludar("Marta"));

            Console.ReadKey();

            float valor = 1.3333332f;
            Console.WriteLine(valor.ToString("0.00"));

            Console.ReadKey();



        }
    }
}
