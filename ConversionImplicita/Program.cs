using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConversionImplicita
{
    class Program
    {
        static void Main(string[] args)
        {
            //A diferencia de la conversión explícita, no será necesario el uso de typecast y se puede asignar directamente con un =.
            CComplejo comp1 = new CComplejo(2, 3);

            //Como antes, no se puede hacer
            //CReal real1 = comp1;

            //Hasta que se coloque el explicit en la clase CComplejo, tampoco se puede hacer:
            //CReal real2 = (CReal)comp1;

            //La conversión implícita se define en la clase real (en este caso). En general es en la clase de origen.
            CReal real3 = new CReal(3.8);

            //Aquí es donde se está realizando la conversión implícita (definida en real)
            CComplejo comp2 = real3;

            Console.WriteLine(real3);
            Console.WriteLine(comp2);

            Console.ReadKey();





        }
    }
}
