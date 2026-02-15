using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotes
{
    internal class Ventas
    {
        private int cArticulo;
        private int cantidad;
        private int cCliente;


        public string Cantidad
        {
            get { return cantidad.ToString(); }
            set
            {

                bool flag = true;
                while (flag)
                {
                    int aux;
                    if (int.TryParse(value, out aux)) {cantidad = aux; flag = false; }
                 else
                    {
                        Console.WriteLine("Error en el ingreso de codigo"); Console.WriteLine("Ingreselo nuevamente: ");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        public string CCliente
        {
            get { return cCliente.ToString(); }
            set
            {
                bool flag = true;
                while (flag)
                {
                    int aux;
                    if (int.TryParse(value, out aux)) {cCliente = aux; flag = false; }
                 else
                    {
                        Console.WriteLine("Error en el ingreso de codigo"); Console.WriteLine("Ingreselo nuevamente: ");
                        value = Console.ReadLine();
                    }
                }
            }   
        }
        public string CArticulo
        {
            get { return cArticulo.ToString(); }
            set
            {
                bool flag = true;
                while (flag)
                {
                    int aux;
                    if (int.TryParse(value, out aux))
                    {
                        if (aux > 0 && aux < 999)
                        { cArticulo = aux; flag = false; }
                        else
                        {
                            Console.WriteLine("Error en el ingreso de codigo"); Console.WriteLine("Ingreselo nuevamente: ");
                            value = Console.ReadLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Error en el ingreso de codigo"); Console.WriteLine("Ingreselo nuevamente: ");

                        value = Console.ReadLine();
                    }

                }
            }

        }


        
    }
}









