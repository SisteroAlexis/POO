using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotes
{
    internal class Productos
    {

        //atributos
        private int cArticulo;
        private double precio { get; set; }
        private int cMarca;


        //propiedades

        public double Precio
        { get { return (double)precio; } set { precio = value; }  }

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

        public string CMarca
        {
            get { return cMarca.ToString(); }
            set
            {
                int aux;
                if (int.TryParse(value, out aux))
                {
                    if (aux > 0 && aux <= 10)
                        cMarca = aux;
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

        //Metodos

        public void Mostrar ()
        {
           
            
            Console.WriteLine("El  codigo de articulo es: " + cArticulo);
            Console.WriteLine("El  precio es: " + Precio);
            Console.WriteLine("El  codigo de marca es: " + cMarca);
        }
    }
}
