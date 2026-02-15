using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos_Ordenamiento;

namespace ejemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ordenaliento de una lista
            List<Pokemon> lista = new List<Pokemon>();
            

            for (int i = 0; i < 5; i++)
            {
                Pokemon poke = new Pokemon();
                Console.WriteLine("Ingrese los datos del pokemon. Nombre y Numero");
                poke.Nombre = Console.ReadLine();
                poke.Numero = int.Parse(Console.ReadLine());
                lista.Add(poke);
            }
            lista.Sort();

            foreach (Pokemon p in lista)
            {
                Console.WriteLine("El nombre del pokemon es: " + p.Nombre + " Y su numero " + p.Numero);
            }
            */

            //ordenamiento de una vector
            int[] v = { 8, 18, 3, 1, 5, 7 };
            int n = v.Length;


            v = burbuja(v, n);

            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine(v[i]);
            }

        }

        //funcion metodo de la burbuja
        static int[] burbuja(int[] v ,int n)
        {

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        int aux;
                        aux = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = aux;
                    }

                }
            }
            return v;
        }
    }
}
