using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita
{
    class Program
    {
        static void Main(string[] args)
        {
            //La conversión explícita se refiere a conversión entre clases creadas por nosotros.
            CComplejo comp1 = new CComplejo(2, 3);

            //Esto no se puede hacer:
            //CReal real1 = comp1;
            //este caso es el que se resuelve con la conversión explicita, indicando a la clase complejo qué regla se aplica para hacer la 
            //conversión.

            //El typecast invoca al método de conversión definidio explícitamente enla clase CComplejo.
            CReal real2 = (CReal)comp1;
            Console.WriteLine(comp1);
            Console.WriteLine(real2);

            Console.ReadKey(); ;

        }
    }
}
