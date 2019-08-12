using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable tabla = new Hashtable();

            //Añadir elementos
            //Key es paramatro unico. Puede guardar cualquier tipo de objeto.
            //Tanto la llave como valor, pueden ser cualquier objeto.
            //No pueden existir elementos con la misma llave
            tabla.Add(123, "hola");
            tabla.Add(45, "Edad");
            tabla.Add(49, "Programacion");
            tabla.Add(1024, "C#");

            //Recorrer elementos
            foreach (DictionaryEntry elemento in tabla)
            {
                Console.WriteLine("{0} - {1} - ", elemento.Key, elemento.Value);
            }
            //Cantidad de elementos
            Console.WriteLine("Cantidad de elementos: " + tabla.Count.ToString());
            Console.WriteLine("-----------");

            //Recuperación de elemento según llave
            Console.WriteLine(tabla[1024]);

            //Colocar un elemento en una llave particular
            Console.WriteLine("-----------");
            listar(tabla);
            tabla[45] = "La edad";
            listar(tabla);
            //Si la llave no existe, es como un ADD
            tabla[300] = "Federico";
            listar(tabla);

            //Comrpboar si existe un elemento
            Console.WriteLine(tabla.Contains(300));
            Console.WriteLine(tabla.Contains(399));


            //Eliminar un elemento
            listar(tabla);
            tabla.Remove(300);
            listar(tabla);
            //Si intentamos borrar una llave que no existe, no se produce excepción.

            //listado de llaves:
            //ojo con el tipo de la llave
            foreach (int llave in tabla.Keys)
            {
                Console.WriteLine(llave);
            }
            Console.WriteLine("-----------");

            //listado de valores:
            //ojo con el tipo del valor
            foreach (string valor in tabla.Values)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine("-----------");




            Console.ReadKey();
        
        }

        public static void listar (Hashtable tabla)
        {
            foreach (DictionaryEntry elemento in tabla)
            {
                Console.WriteLine("{0} - {1} - ", elemento.Key, elemento.Value);
            }
            Console.WriteLine("-----------");
        }

    }


}
