using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres
{
    internal class PagoEfectivo : Pago
    {
        public override double CalculaTotal()
        {
            return Monto * 0.9;
        }

        public override string ObtenerDetalle()
        {
            return base.ObtenerDetalle() + " y tienes un decuento de 10%" +
                "\n Por lo que en total que tenes que pagar: " + (CalculaTotal().ToString());
        }

        
    }
}
