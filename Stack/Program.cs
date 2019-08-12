using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSN
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack(); //Cola de tipo LIFO

            //Agregar elementos. (en este caso strings, pero puede ser cualquier objeto)
            pila.Push("Federico");
            pila.Push("Carmen");
            pila.Push("Ruth");
            pila.Push("Dani");

            //ITeramos el stack
            //Atentos al tipo del elemento temporal
            foreach (string elemento in pila)
            {
                Console.WriteLine("->{0}", elemento);
            }
            Console.WriteLine("-------------");


            //Hacemos pop, que regresa un object, así que hay que hacer typecast habitualmente.
            //En este caso, está implícito.
            Console.WriteLine(pila.Pop());
            listar(pila);

            //Peek, permite consultar el primer elemento de lapila (el próximo que saldría al hacer pop, pero 
            //no saca el elemento)
            Console.WriteLine(pila.Peek());
            listar(pila);


            //contar elementos.
            Console.WriteLine("Hay {0} elementos", pila.Count);



            Console.ReadKey();
        }

        public static void listar(Stack pila)
        {
            foreach (string elemento in pila)
            {
                Console.WriteLine("->{0}", elemento);
            }
            Console.WriteLine("-------------");

        }

    }
}
