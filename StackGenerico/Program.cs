using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGenericoNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<CPunto> puntos = new Stack<CPunto>();

            puntos.Push(new CPunto(3, 12));
            puntos.Push(new CPunto(8, 4));
            puntos.Push(new CPunto(5, 6));
            puntos.Push(new CPunto(3, 11));

            foreach(CPunto p in puntos)
            {
                Console.WriteLine("->{0}", p);
   
            }
            Console.WriteLine("-------------");

            //Hacemos un peek (no sale de stack)
            Console.WriteLine("Peek {0}",puntos.Peek());

            foreach (CPunto p in puntos)
            {
                Console.WriteLine("->{0}", p);

            }
            Console.WriteLine("-------------");

            //Hacemos un par de pops (salen de stack)
            Console.WriteLine("Pop {0}", puntos.Pop());
            Console.WriteLine("Pop {0}", puntos.Pop());

            foreach (CPunto p in puntos)
            {
                Console.WriteLine("->{0}", p);

            }
            Console.WriteLine("-------------");



            Console.ReadKey();
        }
    }
}
