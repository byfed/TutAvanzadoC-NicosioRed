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

            //invertir orden de la lista
            valores.Reverse();
            foreach (int valor in valores)
                Console.WriteLine(valor);
            Console.WriteLine("-------------");


            //Para ordenar cuando los elementos son objetos, la clase tiene que tener implementado el interfaz
            //IComparable.
            valores.Sort();
            foreach (int valor in valores)
                Console.WriteLine(valor);
            Console.WriteLine("-------------");

            //Creamos una lista con nobjetos de nuestra propia clase

            List<CPunto> listaPuntos = new List<CPunto>();

            listaPuntos.Add(new CPunto(5, 3));
            listaPuntos.Add(new CPunto(6, 2));
            listaPuntos.Add(new CPunto(7, 1));
            listaPuntos.Add(new CPunto(8, 39));

            //Para poder impirmir, se ha sobreescrito el método tostring
            foreach (CPunto punto in listaPuntos)
            {
                Console.WriteLine(punto);
            }

            //Para ordenar, hay que implementar IComparable
            //Si no, da una excepción.
            listaPuntos.Sort();


            Console.ReadKey();
        }


    }
}
