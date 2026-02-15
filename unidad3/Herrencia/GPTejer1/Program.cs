using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Practica gpt
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            List<Camioneta> ListaC = new List<Camioneta>();

            c1.Marca = "Toyota";
            c1.Anio = 1985;
            c1.Disponible = true;
            c1.Patente = "kjh025";

            c2.Marca = "Toyota";
            c2.Anio = 1925;
            c2.Disponible = false;
            c2.Patente = "Pjf025";

            c3.Marca = "Toyota";
            c3.Anio = 2015;
            c3.Disponible = true;
            c3.Patente = "SWD852";

            ListaC.Add(c1);
            ListaC.Add(c2);
            ListaC.Add(c3);
            //ListaC.Max();

            Console.WriteLine("N° de camionetas: " + ListaC.Count());
            Console.WriteLine("");

            foreach (Camioneta c in ListaC)
            {
                if (c.Disponible == true) Console.WriteLine(c.Mostrar());

            }

            BuscarPatente("SWD852", ListaC);



            
                for (int i = ListaC.Count()-1 ; i<= 0; i++  )
               {
                if (ListaC[i].Disponible == false)
                ListaC.RemoveAt(i);

               }   //Lo remueve? usar el foreach



            Console.WriteLine(ListaC.Count());
            Console.ReadKey();
            //

            /* Practica para entender tipo valor tipo referencia.

            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();

            c1.Patente = "Pepe";
            c1 = c2;

            c2.Patente = "Juan";

            Console.WriteLine(c1.Patente); // como c1=c2 los 2 apuntan al mismo objeto y 
                                          // me muestra como resultado Juan
            */
        }

        //funsion
        static public void BuscarPatente(string Patente, List<Camioneta> ListaC)
        {
            int x = 0;
            foreach (Camioneta c in ListaC)
            {  
                if (c.Patente == Patente) { Console.WriteLine(c.Mostrar()); x++; }
            }

            if (x == 0) Console.WriteLine("No se a encontrado datos de esa patente");
        }
    }
}
