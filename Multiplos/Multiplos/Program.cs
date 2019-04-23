using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multiplos.Classes;
using System.IO;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            LeerNum arch = new LeerNum();

            //uso el metodo publico
            
            string[] arr2 = arch.divlin();

            int a = 0;

            foreach (string s in arr2)
            {
                //convierto strings a numeros para comparar con 0 
                int y = int.Parse (s) % 10
                    ;
                if ( y == 0)
                {
                      a++; 
                }

            }
            Console.WriteLine(a);
        }
    }
}
