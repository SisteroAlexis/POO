using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Botella
    {
        //capacidad maxima 100
        //capacidad actual inicia en 0
        //metodo de recarga: recarga al 100 y devuelve el costo (50 cada 100)

        //atributos
        private int  capacidad;
        private string color;
        private string material;
        private int capActual;

        //constructores
        public Botella (string colorInicial, string materialInicial)
        {
            capacidad = 100;
            capActual = 0;
            color = colorInicial;
            material = materialInicial;
        }

        //sobrecarga de constructor
        public Botella() { }

        //propiedades
        public int Capacidad { get { return capacidad; } }
        public int CapActual { get { return capActual; } }

        //metodos
        public double recarga()
        {

            if (capActual > 0)
            {
                int dif = capacidad - capActual;

                double monto = (dif * 50) / 100;
                capActual = 100;
                return monto;

            }
            capActual = 100;
            return 50;

        }

        public double recarga ( int cant)
        {

            if (capActual + cant <= 100)
            {
                capActual = capActual + cant;
                return (cant * 50) / 100;
            }
            else return 0;
        }
    }
}
