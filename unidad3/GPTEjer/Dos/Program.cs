using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creo la lista listE
            List<Empleado> listE = new List<Empleado>();

            //Agrego la cantidad de elementos en este caso empleado a las lista "3"
            for (int i = 0; i < 3; i++)
            {
                listE.Add(new Empleado());
            }

            //Cargo los datos de cada empleado
            foreach (Empleado e in listE)
            {
                Console.WriteLine("Ingrese los datos del empleado");
                Console.WriteLine("DNI");
                e.Dni = int.Parse(Console.ReadLine());
                Console.WriteLine("Nombre");
                e.Nombre = (Console.ReadLine());
                Console.WriteLine("Edad");
                e.Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Legajo");
                e.Legajo = int.Parse(Console.ReadLine());
                Console.WriteLine("Sueldo Base");
                e.Sueldobase = double.Parse(Console.ReadLine());
                Console.WriteLine("Antiguedad");
                e.Antiguedad = int.Parse(Console.ReadLine());

            }

            foreach (Empleado e in listE)
            {
                Console.WriteLine(e.Mostrar());
            }
            string nombre = " ";
            double mayorSueldo = 0;
            double sueldoTotal = 0;
            foreach (Empleado e in listE)
            {
                if (e.SueldoFinal() > mayorSueldo ) { mayorSueldo = e.SueldoFinal(); nombre = e.Nombre; }
                sueldoTotal += e.SueldoFinal();
            }

            Console.WriteLine("El sueldo total es: " + sueldoTotal);
            Console.WriteLine("El mayor sueldo es: " + mayorSueldo + "de " + nombre);

            foreach (Empleado e in listE)
            {
                if (e.Antiguedad > 5) e.Mostrar();
            }

        }
    }
}
