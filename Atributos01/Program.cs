using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En este nivel se colocan atributos que se colocarán en todos los elementos
[assembly: CLSCompliant(true)]


namespace Atributos01
{
    class Program
    {
        static void Main(string[] args)
        {
            Prueba miPrueba = new Prueba();

            Prueba2 miPrueba2 = new Prueba2();

            Console.ReadKey();
        }
    }
}
