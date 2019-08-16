using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _var_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //var se usa para declarar implícitamente una variable.
            //El tipo lo escoge el compilador según el valor que se asigna
            //Solo se permite en variables locales. No se puede usar como atributos o tipos de retorno.
            //No se recomienda su uso.
            //Tienen utilidad especial cuando se trabaja con Linq, donde una query puede dar un resultado dinámicamente creado (no se conoce el tipo
            //previamente)

            //las variables de tipo var, deben incluir valor en el momento de declararlo. Además, el valor no puede ser null.
            //Ojo. No es un variant. Una vez que se asigna el tipo no puede cambiár.

            var a = 5;
            var b = "Esto es un string";
            var c = 15.86;
            //var e = null;
            var d = false;
            //d = 13;
            //Si c tiene valor, lo siguiente está permitido.
            var f = c;

            //Imprimimos y usamos reflexion para conocer el tipo.
            Console.WriteLine("a vale {0} y es de tipo {1}", a, a.GetType().Name);
            Console.WriteLine("b vale {0} y es de tipo {1}", b, b.GetType().Name);
            Console.WriteLine("c vale {0} y es de tipo {1}", c, c.GetType().Name);
            Console.WriteLine("d vale {0} y es de tipo {1}", d, d.GetType().Name);
            Console.WriteLine("f vale {0} y es de tipo {1}", f, f.GetType().Name);
            Console.WriteLine("---------------------------");


            //Tipos Nulleables
            //los tipos "normales" no puede tener valor null. Por ejemplo
            //int valor = null;

            //Si necesitamos esa funcionalidad (por ejemplo, al recuperar datos de una base de datos).  Un nulleable es como el tipo tradicional
            //pero admiten null.  Por ejemplo:
            // Realmente es una instancia de System.nulleable
            int? dato = 5;
            Console.WriteLine("dato vale {0}", dato);

            double? precio = null;
            precio = 6.7;
            Console.WriteLine("precio vale {0}", precio);


            //String no es  un tipo nulleable. No se puede hacer
            //string? nombre ="paco";
            //se puede hacer directamente con 
            string nombre = null;

            //como saber si una variable es nula.
            if (precio.HasValue)
            {
                Console.WriteLine("precio vale {0}", precio.Value);
            } else
            {
                Console.WriteLine("No tiene valor");
            }
            Console.WriteLine("---------------------------");

            //El operador ?? nos permite asignar un valor en caso de que tenga null.
            //En el caso siguiente por ejemplo, numero se define como un double que puede ser nulo. Si la función asignador le devuelve un nulo,
            //entonces le asigna un valor de 5.5 (es como un valor por defecto)
            double? numero = asignador() ?? 5.5;
            Console.WriteLine("numero vale {0}", numero);




            Console.ReadKey();
        }

        public static double? asignador()
        {
            return 3.8;
            return null;
        }
    }
}
