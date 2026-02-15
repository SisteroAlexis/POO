using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    internal class Persona
    {
        //Atributos
        private int dni;
        private string nombre;
        private int edad;


        //propiedades
        public int Dni { get { return dni; } set { if(value >0) dni = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } } 
        public int Edad { get { return edad; } set { if (value >0 && value <120 )edad = value; } }

        //metodos

        public virtual string Mostrar ()
        {
            return "El DNI es: " +Dni+ " el nombre: " +Nombre+ " y su edad es: " +Edad;
        }


    }
}
