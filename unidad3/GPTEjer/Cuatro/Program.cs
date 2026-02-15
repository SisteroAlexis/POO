using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Cliente> clientes = new Queue<Cliente>();     // orden de atención 
            // pedidos.Sort();                                   //ordenamiento por prioridad--monto

            //cargo todos los clientes
            int ncliente = 0;
            Console.WriteLine("Ingrese la cantidad de clientes");
            ncliente = int.Parse(Console.ReadLine());
            ncliente = IntValidar(ncliente);



            Cliente[] cliente = new Cliente[ncliente];
            for (int i = 0; i < ncliente; i++)
            {

                Console.WriteLine("Ingrese los datos del cliente N° " + (i + 1));
                Console.WriteLine("Id del cliente: ");
                int id = int.Parse(Console.ReadLine());
                cliente[i] = new Cliente(id);
                do
                {
                    Console.WriteLine("Ingrese el nombre: ");
                    cliente[i].Nombre = Console.ReadLine();
                } while (cliente[i].Nombre == null);


                Console.WriteLine("Ingrese la edad: ");
                while (!cliente[i].TryEdad(Console.ReadLine()))
                { Console.WriteLine("Número inválido, reingrese:"); }

                clientes.Enqueue(cliente[i]);
            }


            //cargo los pedidos

            
            for (int i = 0; i < ncliente; i++)
            {
                
                Console.WriteLine("Ingrese la cantidad de pedidos entre 1-6 del cliente " + cliente[i].Nombre);
                while (!cliente[i].TryCanPedidos(Console.ReadLine()))
                {
                    Console.WriteLine("Error ingrese una cantidad de pedidos validos 1-6");
                }


                Pedido[,] p  = new Pedido [ncliente , cliente[i].CanPedidos];
                for (int ii = 0; ii < cliente[i].CanPedidos; ii++)
                {

                     p[i,ii] = new Pedido(cliente[i]);


                    Console.WriteLine("Datos del pedido N° " + (ii+1) +" de " + cliente[i].Nombre);
                    Console.WriteLine("Ingrese el monto");
                    while (!p[i, ii].TryMonto(Console.ReadLine())) { Console.WriteLine("Error reingrese el monto"); }
                    Console.WriteLine("Ingrese la prioridad 1-5");
                    while (!p[i, ii].TryPrioridad(Console.ReadLine())) { Console.WriteLine("Error reingrese la prioridad 1-5"); }
                    Console.WriteLine("Ingrese que objeto busca");
                    p[i, ii].Objeto = Console.ReadLine();

                    cliente[i].RealizarPedido(p[i, ii]);

                }
                cliente[i].OrdenarPedidos();   //ordenamiento por prioridad--monto
                foreach (Pedido item in cliente[i].Pedidos)
                {
                    Console.WriteLine(item.Mostrar());
                }
                

            }
















        }
        static int IntValidar(int n)
        {
            while (n <= 0 || n > 20)
            {
               Console.WriteLine("Ingrese un N° de clientes valido"); n = int.Parse(Console.ReadLine()); 
            }
            return n;
        }
    }
}
