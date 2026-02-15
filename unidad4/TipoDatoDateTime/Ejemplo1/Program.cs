using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(1996,12,20);
            DateTime ahora = DateTime.Now;

            Console.WriteLine(fecha.ToShortDateString());
            Console.WriteLine(fecha.ToString("dddd dd/MM/yy"));

            int años = ahora.Year - fecha.Year;

            if (fecha > ahora.AddYears(-años))
            {
                años--;
            }

            Console.WriteLine("Años: " + años);

            

            Console.ReadKey();
        }
    }
}
