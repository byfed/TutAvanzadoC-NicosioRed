using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una expresión lambda es como un método anónimo, pero su ejecución depende del contexto en el que se encuentra. 
            //Vamos a hacer lo mismo que en el programa anterior (proyecto lambda01), pero usando expresión lambda en lugar de métodos anónimos.

            //se pueden utilizar siempre que pudieramos utilizar un método anónimo o un delegado fuertemente tipificado.
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1,2,3,4,5,6,7,8,9,10});

            //Nos quedamos solo con los números pares, pero usando una expresión lambda
            //i es el parámetro de la expresión lambda. De forma explícita, se puede poner int i. En el ejemplo siguiente se pone de forma 
            //implícita. Se podrían listar varios parámetros. Si la expresión se cumple, devuelve un true.. que es usado por findall, para 
            //seleccionar el número y se añade a la lista pares.
            List<int> pares = numeros.FindAll(i => (i % 2) == 0);

            //mostramos lista
            foreach (int n in pares)
                Console.WriteLine(n);

            Console.WriteLine("---------------");

            Console.ReadKey();

        }
    }
}
