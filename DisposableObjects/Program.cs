using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si deseamos que se liberen los recursos no administrados tan pronto como sea posible, en lugar de esperar al recolector
            //de basura, podemos implementar la interfaz IDisposible.
            //Se invoca a Dispose, se liberan los recursos, aunque el objeto sigue existiendo.

            CPrueba objeto = new CPrueba(5);
            //Console.WriteLine(objeto);
            //objeto.Dispose();

            //Una mejor forma de hacerlo es
            //if (objeto is IDisposable)
            //    objeto.Dispose();

            //una forma de garantizar de que Dispose es invocado
            //try
            //{
            //    Console.WriteLine(objeto);
            //}
            //finally
            //{
            //    objeto.Dispose();
            //}

            //Con esta tecnica Dispose es invocado automáticamente cuando termine el método de using
            //Se pueden listar varios objetos en el using
            using  (CPrueba prueba2 = new CPrueba(7))
            {
                Console.WriteLine(prueba2);
            }

            Console.ReadKey();


        }
    }
}
