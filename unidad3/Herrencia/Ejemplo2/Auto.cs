using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Auto : Vehiculo, IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        

        //metodo
        public override int Temperatura ()
            {
            return 12;
            }



    }
}
