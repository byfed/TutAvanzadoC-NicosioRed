using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//después de colocar la referencia ponemos el namespace
using Aritmetica;

namespace UsoAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hay que importar la biblioteca y además, incluir el namespace.
            //Si la biblioteca cambia, hay que recompilarla y se genera de nuevo el dll.
            //Si se usa desde la misma solución, generalmente no hay problemas. Pero si se usan desde otra solución o proyecto, se recomienda
            //además, reimportar la biblioteca.
            Mates mismates = new Mates(5, 4);

            double resultado = mismates.suma();

            Console.WriteLine("El resultado de la suma es {0}",resultado);
            Console.ReadKey();
        }
    }
}
