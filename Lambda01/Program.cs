using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda01
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJEmplo con delegados
            //System.Preditcate<T> es un delegeado genérico que representa un método que va a definir un criterio y dice que si
            //el objeto cumple o no con ese criterio.

            //Por ejemplo, sobre la lista de número sisguientes, querremos un predicado que nos devuelva los numeros pares
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2,3, 4, 5, 6, 7, 8, 9, 10 });

            //Indicamos el delegado
            Predicate<int> delegado = new Predicate<int>(Pares);

            //Invocamos al método
            List<int> numerosPares = numeros.FindAll(delegado);

            
            //Mostramos la lista 
            foreach (int n in numerosPares)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------");

            //Numeros en rango
            Predicate<int> otrodelegado = new Predicate<int>(Rango);
            List<int> enrango = numeros.FindAll(otrodelegado);
            //Mostramos la lista 
            foreach (int n in enrango)
            {
                Console.WriteLine(n);
            }

            //como FindAll, tenemos también RemoveAll para borrar todos los que cumplen el criterio. 


            Console.ReadKey();
        }

        static bool Pares(int n)
        {
            if (n%2==0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static bool Rango(int n)
        {
            if (n>3 && n<7) return true;
            return false;
        }
    }
}
