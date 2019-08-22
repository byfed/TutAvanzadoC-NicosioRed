using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punteros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se  usan poco. Las direcciones de memoria son administradas automáticamente. Pero si se necesita se puede hacer.
            //Por defecto, el código que usa punteros, se considera no seguro, por lo que hay que especificar un bloque unsafe.

            //indica específicamente que vamos a gestionar nosotros la memoria.
            //Para poder compilar hay que ir a proyecto->propiedades->Permitir codigo no seguro
            unsafe
            {
                int valor = 5;

                //creo el puntero.
                int* p;

                //hago que apunte a la dirección de la valor
                //el operador & se lee "direccion de ".

                p = &valor;

                Console.WriteLine(*p);

                //cambiamos el valor
                *p = 67;
                //*P se puede leer como "adonde apunta p"
                Console.WriteLine(*p);
                Console.WriteLine(valor);
                    
            }
            //fuera del unsfe
            Console.WriteLine("------swap con punteros------");

            int a = 3, b = 5;
            Console.WriteLine("a={0}, b={1}",a,b);

            //la invocación del método tiene que estar en un bloque unsafe
            unsafe
            {
                swap(&a, &b);
            }

            Console.WriteLine("a={0}, b={1}", a, b);

            Console.ReadKey();
        }

        //método que usa punteros, por lo que tiene que definirse con el modificador unsafe
        unsafe public static void  swap( int* a , int* b)
        {
            int temp = *a;
            *a = *b;
            *b = temp;

        }
    }
}
