using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Persona persona = new Persona();
            Empleado p = new Empleado();
            persona.Dni = 39951692;
            persona.Nombre = "Alexis";
            persona.Edad = 29;

            p.Dni = 39951692;
            p.Nombre = "Alexis";
            p.Edad = 29;
            p.Legajo = 257496;
            p.Sueldobase = 10;
            p.Antiguedad = 15;

            Console.WriteLine(persona.Mostrar());
            Console.ReadKey();

            Console.WriteLine(p.Mostrar());
            Console.ReadKey();
        }
    }
}
