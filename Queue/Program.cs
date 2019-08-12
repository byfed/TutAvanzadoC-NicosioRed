using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cola tipo FIFO
            Queue cola = new Queue();

            //Añadir objetos
            //vale para cualquier objeto.
            cola.Enqueue("Manzana");
            cola.Enqueue("Fresa");
            cola.Enqueue("Pera");

            //Iteracion (ojo al tipo del elemento temporal, en esta caso string)
            foreach (string fruta in cola)
            {
                Console.WriteLine(" ->{0}", fruta);
            }

            Console.WriteLine("--------------");

            // con DeQueue() saca un objeto de la cola 
            Console.WriteLine("Dequeue {0}:", cola.Dequeue());
            Console.WriteLine("Dequeue {0}:", cola.Dequeue());
            listar(cola);

            //Volvemos añadir elementos
            cola.Enqueue("platano");
            cola.Enqueue("Mango");
            cola.Enqueue("Ciruela");

            listar(cola);

            //Peek: Devuelve el primer elemento, pero no lo elimina de la cola
            Console.WriteLine("Primer elemento: {0}", cola.Peek());
            listar(cola);

            //contar elementos
            Console.WriteLine("Hay {0} elementos en la cola", cola.Count);

            //Verificar si existe elemento
            Console.WriteLine(cola.Contains("Piña"));
            Console.WriteLine(cola.Contains("Mango"));


            Console.ReadKey();
        }

        public static void listar (Queue cola)
        {
            foreach (string fruta in cola)
            {
                Console.WriteLine(" ->{0}", fruta);
            }

            Console.WriteLine("--------------");
        }
    }
}
