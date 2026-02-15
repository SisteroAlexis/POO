using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinco
{
    internal class libro2 : Libro
    {
        public libro2(string tituloinicial) : base(tituloinicial)
        {

        }

        public override int conta(int contador)
        {
            contador++;
            return (contador);
        }
    }
}
