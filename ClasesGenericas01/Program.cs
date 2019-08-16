using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas01
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia de clase genérica trabajando como int
            CPunto<int> puntoEntero = new CPunto<int>(3, 5);

            //instancia de clase genérica trabajando como double.
            CPunto<double> puntoDouble = new CPunto<double>(6.7, 1.2);

            //instancia de clase genérica trabajando como float (ojo a la f al final para indicar que lo interprete como float)
            CPunto<double> puntoFloat = new CPunto<double>(1.1f, 2.2f);

            Console.WriteLine(puntoEntero);
            Console.WriteLine(puntoDouble);
            Console.WriteLine(puntoFloat);

            //usamos valores por defecto
            puntoEntero.Reset();
            Console.WriteLine(puntoEntero);

            puntoDouble.Reset();
            Console.WriteLine(puntoDouble);

            puntoFloat.Reset();
            Console.WriteLine(puntoFloat);

            puntoEntero.EncuentraTipo();
            puntoFloat.EncuentraTipo();

            Console.ReadKey();

        }
    }
}
