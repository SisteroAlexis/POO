using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Motor
    {
        public string color {  get; set; }

        public static implicit operator string(Motor v)
        {
            throw new NotImplementedException();
        }
    }
}
