using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetGenericoNS
{
    class Program
    {
        static void Main(string[] args)
        {
            //La clase punto, se ha modificado para ser comparable, implementando la interfaz ICoparable

            SortedSet<CPunto> puntos = new SortedSet<CPunto>();
            puntos.Add(new CPunto(3, 7));
            puntos.Add(new CPunto(5, 3));
            puntos.Add(new CPunto(2, 11));
            puntos.Add(new CPunto(1, 9));

            foreach(CPunto p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }
            Console.WriteLine("--------------");

            puntos.Add(new CPunto(1, 1));
            puntos.Add(new CPunto(15, 1));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }
            Console.WriteLine("--------------");


            Console.ReadKey();
        }
    }
}
