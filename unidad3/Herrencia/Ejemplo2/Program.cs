using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Ejemplos con maxi
            Vehiculo v1 = new Vehiculo();

            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Color = "amarillo";
            c2.Color = "amarillo";
            c3.Color = "amarillo";


            List<Camioneta> listaC = new List<Camioneta>();
            listaC.Add(c1);
            listaC.Add(c2);
            listaC.Add(c3);
            // Console.WriteLine(listaC.Count);

            //puedo cambiar el color
            listaC[1].Color = "Negro";
            // Console.WriteLine(listaC[1].Color);

            //remover objetos
            listaC.Remove(c3);
            // Console.WriteLine(listaC.Count);

            //foreach (Camioneta c in listaC)
            //{
            //    Console.WriteLine(c.Color);
            //}

            Queue<Camioneta> Lis = new Queue<Camioneta>();
            Lis.Enqueue(c1); Lis.Dequeue(); Lis.Enqueue(c2); Lis.Count(); Lis.Peek();

            Vehiculo vv = new Vehiculo();
            vv.Color = "Amarillo";
            vv.Motor = "dsdsd";

            Console.WriteLine(vv.ToString());

            Auto auto = new Auto();

            Console.WriteLine(auto.Temperatura());

            AutoDeportivo ad = new AutoDeportivo();
            Console.WriteLine(ad.Temperatura());

            List<Vehiculo> lisV = new List<Vehiculo>();


            lisV.Add(ad);
            lisV.Add(vv);
            lisV.Add(new Camioneta()); //Creo un objeto y lo gaurdo en la variable LisV[2]

            Moto mm = new Moto();
            mm.Motor = new Motor();
            */

            //Ejemplo de resumen1
            Tractor t1 = new Tractor();
            Motor mm = new Motor();
            mm.color = "Verde";

            t1.Motor = mm;
            t1.NRueda = 12;
            t1.Color = "Amarillo";

            string nombre = "Alexis";
            string apellido = nombre;

            nombre = "Pepe";
            Console.WriteLine(apellido);

        }
    }
}
