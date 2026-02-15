using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres
{
    internal interface IPago : IComparable<IPago>
    {

       
        

         double CalculaTotal();


        string ObtenerDetalle();
      
    }
}

