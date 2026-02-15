using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTejer1
{
    internal class Camioneta
    {
        //atributos
        public string Marca { get; set; }
        public int Anio { get; set; }
        public bool Disponible { get; set; }
        public string Patente { get; set; }

        //constructor
        public Camioneta(string MarcaInicial, int AnioInicial, bool DisponibleInicial, string PatenteInicial)

        {
            Marca = MarcaInicial;
            Anio = AnioInicial;
            Disponible = DisponibleInicial;
            Patente = PatenteInicial;
        }


        public Camioneta()

        {

        }

        //metodo
        public string Mostrar()
        {
            string disponible;
            if (Disponible) disponible = "Disponible";
            else disponible = "En uso";

            return "La patente es: " + Patente + "\nLa Marca es: " + Marca + "\nEs del año: " + Anio + "\nLa camioneta esta: " + disponible + "\n";
        }

     

    }
}
