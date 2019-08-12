using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListNS
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList lista = new SortedList();

            //Los elementos se van ordenando a medida que se añaden a la lista
            //Añadir elementos.
            //Es similar a HashTable, pero con orden. Trabaja con DirectoryEntries
            //Ademite todo tipo de obojetos, pero deben implementar el interfaz Comparable
            lista.Add(754, "Rubén");
            lista.Add(91, "Federico");
            lista.Add(93, "Raul");
            lista.Add(14, "Cristina");

            listar(lista);



            //Añado otro elemento
            lista.Add(16, "Felipe");
            Console.WriteLine("añado otro 16-Felipe" );
            listar(lista);

            //Contar elementos
            Console.WriteLine("Hay {0} elementos", lista.Count);

            //Contains (por clave)
            Console.WriteLine(lista.Contains(16));
            Console.WriteLine(lista.Contains(23));
            Console.WriteLine("--------------");

            //Contains (por valor)
            Console.WriteLine(lista.ContainsValue("Raul"));
            Console.WriteLine(lista.ContainsValue("Ramiro"));
            Console.WriteLine("--------------");

            //Obttención por índice
            //Obtiene la llave que se se encuentra en el indice 2
            Console.WriteLine(lista.GetKey(2));
            //obtiene el valor que se enecuntra en el indice 2
            Console.WriteLine(lista.GetByIndex(2));
            Console.WriteLine("--------------");

            listar(lista);

            Console.ReadKey();
        }

        public static void listar (SortedList lista)
        {
            foreach(DictionaryEntry elemento in lista)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }
            Console.WriteLine("--------------");
        }
    }
}
