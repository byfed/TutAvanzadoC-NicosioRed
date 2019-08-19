using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAnonimosNS
{
    class Program
    {
        static void Main(string[] args)
        {
            CPunto mipunto = new MetodosAnonimosNS.CPunto(4, 5);

            //Creamos el método anónimo para el delegado
            mipunto.mensaje += delegate ()
            {
                Console.WriteLine("Esto es un método anónimo");
            };

            //invocamos el mensaje
            mipunto.mensaje();

            //Añadimos otro método anónimo
            mipunto.mensaje += delegate ()
            {
                Console.WriteLine("Esto es otro método anónomio");
            };

            //nueva invocación (ejecutará los dos métodos anónimos que se han definido)
            mipunto.mensaje();

            Console.ReadKey();
        }
    }
}
