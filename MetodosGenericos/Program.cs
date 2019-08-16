using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 8;

            Console.WriteLine("x={0},y={1}", x, y);
            swap<int>(ref x, ref y);
            Console.WriteLine("x={0},y={1}", x, y);

            Console.WriteLine("---------------------");

            string saludo = "hola";
            string despedida = "adios";

            Console.WriteLine(saludo + "," + despedida);
            swap<string>(ref saludo, ref despedida);
            Console.WriteLine(saludo + "," + despedida);

            Console.WriteLine("---------------------");

            Console.ReadKey();
        }

        //Ojo a la definición del método. En este caso, estamos usando ref T, para referirnos al puntero que apunta a la variable. 
        //El tipo es independiente.
        public static void swap<T>(ref T a, ref T b)
        {
            T temporal;
            temporal = a;
            a = b;
            b = temporal;

        }
    }
}
