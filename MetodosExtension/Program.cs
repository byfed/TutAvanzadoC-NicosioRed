using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Métodos de extension permite añadir métodos a clases, sin modificar clases. Puede ser adecuado cuando queremos añadir un comportamiento
            //a una clase, que tiene su propia cadena de herencia. Los métodos de extensión no interfieren con la clase, por lo cual no tienen
            //impacto en las clases hijas.

            //ejemplo. Los tipos numéricos son clases.  Extenderemos el tipo int.
            int numero = 55;

            //Queremos extender para poder hacer:
            bool par = numero.EsPar();

            Console.WriteLine("{0} es {1}",numero,par);

            //Extensión de double
            double num = 33.11;
            Console.WriteLine("el doble de {0} es {1}",num, num.Doblar());

            //He definido una clase MiInt que implementa el interfaz ISaludador. Ahora vemos como extender una clase que implementa un interfaz concreto 
            //Solo afecta a las clases que usan la interfaz.. y no al resto.

            MiInt minumero = new MiInt(7);
            Console.WriteLine(minumero);
            minumero.saludar();

            //beeper es un método de extensión asociado a la interfaz Isaludador
            minumero.beeper();

            Console.ReadKey();
        }
    }
}
