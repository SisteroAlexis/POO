using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dasafio
{
    internal class Telefono
    {

        //atributos
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;  //(1, 2 o 3).

        //constructor

        public Telefono(string modeloInicial, string marcaInicial)
        {
            modelo = modeloInicial; marca = marcaInicial;
        }

        public Telefono () { }

        //propiedades
        public string Modelo { get { return modelo; } }
        public string Marca { get { return marca; } }
        public string NumeroTelefonico { get { return numeroTelefonico; } set { numeroTelefonico = value; } }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value == 1 || value == 2 || value == 3) codigoOperador = value;
                else codigoOperador = 0;
            }

        }

        //metodos
        public string mostrar()
        {
            return "Modelo: " + Modelo +
                   "\nMarca: " + Marca +
                   "\nNumeroTelefonico: " + NumeroTelefonico +
                   "\nCodigoOperador: " + CodigoOperador;
            //ctrl + alt + ? = \
        }

        public string Llamar()
        {
            return "Realizando llamada";
        }

        public string Llamar(string contacto)
        {
            return "Realizando llamada a " + contacto;
        }

    }
}
