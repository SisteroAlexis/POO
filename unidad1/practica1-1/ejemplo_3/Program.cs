using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ciclos
            //while for do while
            //++ suma 1
            //-- resta - 
            //+= suma x numero 
            //-= resta x numero

            int a = 10;
            a += 5;
            Console.WriteLine(a);
            //  *= multiplica por x numero
            //  /= divide por x numero

            Console.ReadKey();

            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                
                while (x < 7 )
                {  Console.WriteLine(i);
                    x++;
                }
                x = 0;
            }


            Console.ReadKey();

            do
            {
                x = x + 1;
                int i = 7;
                Console.WriteLine(i);
            } while (x == 0);

        }
    }
}
