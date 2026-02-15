using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dos
{
    internal class Empleado : Persona
    {
        //atributos
        private int legajo;
        private double sueldobase;
        private int antiguedad; //años trabajados
        //propiedades

        public int Legajo { get { return legajo; } set { if (value > 0) legajo = value; } }
        public double Sueldobase { get { return sueldobase; } set { if (value > 0) sueldobase = value; } }
        public int Antiguedad { get { return antiguedad; } set { if (value > 0) antiguedad = value; } }

        //metodo
        public double SueldoFinal()
        {
            //3% por año y no puede ser 150% mayor que  el sueldo base
            double result = 0;

            if (antiguedad < 17) result = (1 + (Antiguedad * 0.03)) * Sueldobase;
            else result = Sueldobase * 1.5;
            return result;
        }

        //sobreescriturade metodo. es una persona
        public override string Mostrar()
        {
            return "El DNI es: " + Dni + " el nombre: " + Nombre + " su edad es: " + Edad +
                   " el legajo es: " + Legajo + " el sueldo base: " + Sueldobase + " su antiguedad es: " + Antiguedad +
                   "\n y su sueldo final " + SueldoFinal();
        }
    }
}
