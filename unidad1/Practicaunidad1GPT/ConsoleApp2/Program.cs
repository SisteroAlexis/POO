using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            string input = Console.ReadLine();
            int numero;

            if (int.TryParse(input, out numero))
            {
                if (numero > 0)
                    Console.WriteLine("Positivo");
                else
                {
                    if (numero < 0) { Console.WriteLine("Negativo"); }
                    else Console.WriteLine("Es cero");
                }

            }
            else { Console.WriteLine("Ingreso de dato no valido"); }

            Console.ReadKey();

            Console.WriteLine("Ingrese un numero y vea que dia de la semana es");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1: Console.WriteLine("lunes"); break;
                case 2: Console.WriteLine("martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sabado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: Console.WriteLine("Ingreso de dato no valido"); break;


            }
            Console.ReadKey();

            Console.WriteLine("ingrese 2 numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            double suma = n1 + n2;
            double resta = n1 - n2;
            double divicion = (double)n1 / n2;
            double multiplicacion = n1 * n2;

            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(divicion);
            Console.WriteLine(multiplicacion);

            Console.ReadKey();
            Console.WriteLine("ingrese una letra para generar un error");
            int n3 = int.Parse(Console.ReadLine()); //error hay que meterle un if (int.TryParse(n3,out numero))

            Console.ReadKey();

            Console.WriteLine("ingrese su edad");
            string input2 = Console.ReadLine();
            int edad;

            if (int.TryParse(input2, out edad))
            {
                if (edad >= 18) { Console.WriteLine("Mayor"); }
                else { Console.WriteLine("Menor"); }
            }


            Console.ReadKey();

            //mini calculadora
            Console.WriteLine("Menu de calculadora ingrese un numero para realizar las siguientes posibles operaciones");
            Console.WriteLine(" 1 Sumar");
            Console.WriteLine(" 2 restar");
            Console.WriteLine(" 3 multiplicar");
            Console.WriteLine(" 4 dividir");
            string verificar = Console.ReadLine();
            int entrada;

            if (int.TryParse(verificar, out entrada)) { Calculadora(entrada); }
            else { Console.WriteLine("Eror de ingreso de datos"); }


            Console.ReadKey();

        }

        static void Calculadora(int entrada)
        {
            Console.WriteLine("Ingrese 2 numero para la operacion");
            string verificar1 = Console.ReadLine();
            string verificar2 = Console.ReadLine();

            int n1; int n2;
            bool con1, con2;

            if (int.TryParse(verificar1, out n1)) { con1 = true; } else { con1 = false; }
            if (int.TryParse(verificar2, out n2)) { con2 = true; } else { con2 = false; }

            if (con1 && con2)
            {
                switch (entrada)
                {
                    case 1: double suma = (double)n1 + n2; Console.WriteLine("El resultado es: " + suma); break;
                    case 2: double resta = (double)n1 - n2; Console.WriteLine("El resultado es: " + resta); break;
                    case 3: double multiplicacion = (double)n1 * n2; Console.WriteLine("El resultado es: " + multiplicacion); break;
                    case 4: double divicion = (double)n1 / n2; Console.WriteLine("El resultado es: " + divicion); break;
                    default: Console.WriteLine("Error de ingreso de ops"); break;
                }

            }
            else { Console.WriteLine("Eror de ingreso de numeros"); }


        }
    }
}
