using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Metodos_Ordenamiento
{
    public  class Pokemon : IComparable<Pokemon>
    {
        public string Nombre { get; set; }
        public int Numero {  get; set; }
        public int CompareTo(Pokemon other)
        {
            int resultado = this.Numero - other.Numero;

            return resultado;
        }
    }
}
