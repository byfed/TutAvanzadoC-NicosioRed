using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();

            int n = 0;
            int r = 0;

            valores.Add(7);
            valores.Add(1);
            valores.Add(3);
            valores.Add(2);
            valores.Add(5);

            //Recorremos la lista con ciclo for
            for (n = 0; n < valores.Count; n++)
            {
                //Atento al detalle: No se usa typecast para la siguiente asignación.
                r = valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("-------------");


            //DEtectar exsistencia de elemento. Contains hay que especificar el tipo.
            Console.WriteLine(valores.Contains<int>(5));
            Console.WriteLine(valores.Contains<int>(17));
            Console.WriteLine("-------------");

            //Obtener el indice de un elmento
            Console.WriteLine(valores.IndexOf(3));
            Console.WriteLine(valores.IndexOf(54));
            Console.WriteLine("-------------");

            //inserción en una posición.
            valores.Insert(2, 55);

            //recorrido con foreach
            foreach (int valor in valores)
                Console.WriteLine(valor);
            Console.WriteLine("-------------");

            //Elimminamos en una posicion
            valores.RemoveAt(2);
            foreach (int valor in valores)
                Console.WriteLine(valor);
            Console.WriteLine("-------------");

            //Eliminamos por valor o instancia en particula
            //Se elimina la primera ocurrencia
            valores.Remove(5);
            foreach (int valor in valores)
                Console.WriteLine(valor);
            Console.WriteLine("-------------");


            Console.ReadKey();
        }


    }
}
