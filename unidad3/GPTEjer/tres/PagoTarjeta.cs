using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres
{
    internal class PagoTarjeta : Pago
    {
        //atributos
        private double recargo; //no tiene ni set ni get
        private int cuotas;

        //constructor
        public PagoTarjeta (int cuotasInicial) { recargo = 0.05 + 1; Cuotas = cuotasInicial; }

        //propiedades
        public int Cuotas {get { return cuotas; } set { cuotas = value; } }
            
        //metodos sobrecargados
        public override double CalculaTotal()
        {
            if (Cuotas < 6) return base.CalculaTotal();
            else return base.CalculaTotal()* recargo;
          
        }

        public override string ObtenerDetalle()
        {


            if (Cuotas < 6) return base.ObtenerDetalle();
            else { return base.ObtenerDetalle() + " y tienes una recarga del 5%" +
                    "\nSu total a pagar es: " + CalculaTotal().ToString(); }
              
        }

       
    }
}
