using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Persona
    {
        //atributos
        private int edad;
        private string nombre;
        private double sueldo;

        //propiedades
        public int Edad { get { return edad; } set { edad = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double Sueldo { get { return sueldo; } set { sueldo = value; } }

        //metodos
        public string Saludar()
        {
            return "hola soy: " + Nombre;
        }

        public string Saludar( string persona)
        {
            return "hola soy: " + Nombre + " Como estas " +persona;
        }

    }
}
