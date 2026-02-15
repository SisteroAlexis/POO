using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Vehiculo
    {

        //Atributos
        public string Motor { get; set; }
        public string Color { get; set; }

        //metodos
        public override string ToString()
        {
            return Motor.ToString();
        }

        public virtual int Temperatura ()
        {
            return 10;
        }
    }
}
