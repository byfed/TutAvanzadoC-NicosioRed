using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoGenerico
{
    class Program
    {
        //creamos el delegado genérico
        public delegate void miDelegado<T>(T p);

        static void Main(string[] args)
        {
            miDelegado<string> delCadena = new miDelegado<string>(HandlerString);
            delCadena("hola");

            //Registramos y usamos el double
            miDelegado<double> delDoble = new miDelegado<double>(HanderlDouble);
            delDoble(33.8);

            Console.ReadKey();
        }

        //Un delegado genérico puede manejar varios tipos, según el número de parámetros.
        //Tenemos que definir un handler en cada caso.

        //Handler para el caso string
        static void HandlerString(string p)
        {
            Console.WriteLine("Uso string como tipo y el valor es {0}",p);
        }

        //Handler para el caso double
        static void HanderlDouble(double p)
        {
            Console.WriteLine("Uso double como tipo y el valor es {0}", p);
        }


    }
}
