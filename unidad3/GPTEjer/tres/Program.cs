using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PagoEfectivo pf = new PagoEfectivo();
            pf.Monto = 35.5;
            PagoEfectivo pf2 = new PagoEfectivo();
            pf2.Monto = 33.5;
            PagoEfectivo pf3 = new PagoEfectivo();
            pf3.Monto = 37.5;
            PagoTarjeta pt = new PagoTarjeta(7);
            pt.Monto = 40;

            List<IPago> pagos = new List<IPago>();
            pagos.Add(pf);
            pagos.Add(pf2);
            pagos.Add(pf3);
            pagos.Add(pt);

            pagos.Sort(); // Ordenamiento de la lista Sort //Sort  //Sort

            double Total = 0;
            double Max = 0; ;

            foreach (IPago p in pagos)
            {
                Total += p.CalculaTotal();
                Console.WriteLine(p.ObtenerDetalle());
                if (p.CalculaTotal() > Max ) Max = p.CalculaTotal();   
            }

            Console.WriteLine("El total pagado es: " + Total);
            if (Max != 0) Console.WriteLine("El Total mas grande es: " + Max); else Console.WriteLine("No se ingresaron datos");
        }
    }
}
