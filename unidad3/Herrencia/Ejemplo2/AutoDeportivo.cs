using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class AutoDeportivo : Auto , IAcelerar
    {

        //metodo
        public string acelerar ()
        {
            return "Acelerar";
        }
    }
}
