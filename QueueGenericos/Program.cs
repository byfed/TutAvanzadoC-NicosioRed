using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGenericoSN
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<CPunto> puntos = new Queue<CPunto>();

            puntos.Enqueue(new CPunto(3,5));
            puntos.Enqueue(new CPunto(8, 15));
            puntos.Enqueue(new CPunto(-3, -1));
            puntos.Enqueue(new CPunto(8, 9));

            foreach(CPunto p in puntos)
            {
                Console.WriteLine(p);

            }
            Console.WriteLine("----------------");

            //Hacemos un peek. (muestra el primer elemento pero no le saca)
            Console.WriteLine("peek {0}", puntos.Peek());
            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);

            }
            Console.WriteLine("----------------");


            //Hacemos un par de dequeues. (muestra el primer elemento pero no le saca)
            Console.WriteLine("dequeue {0}", puntos.Dequeue());
            Console.WriteLine("dequeue {0}", puntos.Dequeue());
            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);

            }
            Console.WriteLine("----------------");


            Console.ReadKey();
        }
    }
}
