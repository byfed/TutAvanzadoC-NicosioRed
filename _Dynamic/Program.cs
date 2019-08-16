using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object es el supertipo. Cualquier cosa desciente de System.Object.
            //Diynamic es parecido. Puede guardar cualquier cosa. Object es fuertemente tipificado, pero dynamic no. Es decir, dynamic puede
            //Cambiar el tipo con el que trabaja.

            dynamic a = 5;
            Console.WriteLine("Tipo {0}, valor {1}", a.GetType(), a);

            a = "Ahora soy un string";
            Console.WriteLine("Tipo {0}, valor {1}", a.GetType(), a);

            Console.WriteLine("---------------");

            //dynamic solo conoce el tipo en tiempo de ejecución.
            //Se puede usar como tipo de retorno
            //No se puede usar en expresiones lambda o métodos anonimos 
            //Puede ser util si nos comunicamos con bibliotecas COM
            Console.ReadKey();
        }
    }
}
