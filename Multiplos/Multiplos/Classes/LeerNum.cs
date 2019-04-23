using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Multiplos.Classes
{
    class LeerNum
    {
        string lineas = File.ReadAllText(@"C:\Users\sebas\Source\Repos\multiplos\Multiplos\Multiplos\Num.txt");

    

        //Leer todo el texto en ves de columnas 
        public string[] divlin()
        {

            string[] arreglo = lineas.Split(new char[]{'\t', '\n'});
            //partir el arreglo con split

            

            return arreglo;


        }

    }
}
