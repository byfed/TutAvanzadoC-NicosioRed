using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inerfaces03
{
    class Program
    {
        static void Main(string[] args)
        {
            CCuadrado bobEsponja = new CCuadrado(12);

            //Indicar de formar esplícita en la llamada al método, usando typecast.
            //Si buscamos los métodos del objeto, no sale la opción  Calcular (el intellisense no va en estos casos).
            ((IPerimetro)bobEsponja).Calcular();
            ((IArea)bobEsponja).Calcular();

            Console.ReadKey();
        }
    }
}
