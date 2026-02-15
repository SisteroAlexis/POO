using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Moto : Vehiculo
    {


        public Motor M1 { get; set; } //Agregacion que puedo agregar despues los datos del motor


        public Chasis C1 { get; }

        //constructor 
        public Moto ()
        {
            C1 = new Chasis ();     //Esto es composicion
        }

    }
}
