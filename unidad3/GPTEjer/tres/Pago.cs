using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres
{
    internal class Pago : IPago, IComparable<IPago>
    {
        //atributos
        private double monto;

        //propiedades
        public double Monto
        {
            get { return monto; }
            set
            {
                if (value > 0)
                    monto = value;
                else
                    monto = 0; // o lanzar excepción
            }
        }


        //metodos de Interfas IPago

        public virtual double CalculaTotal()
        {
            return Monto;
            
        }

       

        public virtual string ObtenerDetalle()
        {
            return "El monto es: " + Monto.ToString();
            
        }

        //metodo de Icomparable
        public int CompareTo(IPago other)
        {
            return this.CalculaTotal().CompareTo(other.CalculaTotal());
            
        }
    }
}
