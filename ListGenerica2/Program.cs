using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenerica2NS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de objetos con adición explícita
            List<CPunto> puntos = new List<CPunto>
            {
                new CPunto(2,3),
                new CPunto(5,11),
                new CPunto(7,9)

            };

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("-------------");

            //Añadimos un nuevo punto.
            puntos.Add(new CPunto(5, 61));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("-------------");

            //Inserción de un nuevo punto.
            puntos.Insert(2, new CPunto(100, 150));
            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("-------------");

            //Copiadmos de lista a arreglo
            CPunto[] arrayPuntos = puntos.ToArray();

            for (int n=0; n<arrayPuntos.Length; n++)
            {
                Console.WriteLine(arrayPuntos[n]);
            }
            Console.WriteLine("-------------");



            Console.ReadKey();
        }
    }
}
