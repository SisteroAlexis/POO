using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Productos[] p = new Productos[10];





            for (int i = 0; i < 3; i++)
            {
                p[i] = new Productos();
                Console.WriteLine("Ingrese los datos del producto:");
                Console.Write("Codigo de articulo: ");
                p[i].CArticulo = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Precio: "); p[i].Precio = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Codigo de marca: "); p[i].CMarca = Console.ReadLine();
                Console.WriteLine();
            }

            // chequeo de carga.
            // p[2].Mostrar();
            // Console.ReadLine();
            //cargado el vector completo

            Ventas[] v = new Ventas[10];
            int x = 0;
            int y = 0;
            do
            {
                y++;
                x++;
                v[x] = new Ventas();
                Console.WriteLine("Ingrese los datos de la venta");
                Console.Write("Codigo de articulo: "); v[x].CArticulo = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Cantidad: "); v[x].Cantidad = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Codigo de cliente: "); v[x].CCliente = Console.ReadLine();
                Console.WriteLine();



            } while (Convert.ToInt32(v[x].CCliente) != 0 && y < 3);



            Console.ReadLine();
            Console.WriteLine("Parte logica");

            Console.WriteLine("Ingrese el articulo que quiere buscar");
            int buscador = int.Parse(Console.ReadLine());

            int contador = 0;
            int guardado = 0; ;
            double subTotal=0;

            for (int i = 0; i < 3; i++)
            {
                v[i] = new Ventas();

                if (Convert.ToInt32(v[i].CArticulo) == buscador)
                {
                    guardado = i;
                    contador = contador + (Convert.ToInt32(v[i].Cantidad));
                }


            }
            subTotal = p[guardado].Precio * contador;


            Console.WriteLine(" El codigo de articulo es: " + buscador);
            Console.WriteLine(" La cantidad vendidad es:" + contador);
            Console.WriteLine(" El precio unitario es: " + p[guardado].Precio);
            Console.WriteLine(" El sub total del producto es: " + subTotal);
        }



        /*
        Código de artículo
        Cantidad vendida
        Precio unitario
        Subtotal de la venta (cantidad * precio)
        */



    }
}
