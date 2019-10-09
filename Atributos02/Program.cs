using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Añadir el using correspondientes
using AritmeticaAtributos;

namespace Atributos02
{
    class Program
    {
        static void Main(string[] args)
        {
            //usaremos reflexion con early binding

            //obtenemos el tipo de la clase (ojo!!!. sólo trabajamos por clases)
            Type t = typeof(MisMates);

            //obtenemos la lista de atributos
            object[] atributos = t.GetCustomAttributes(false);

            //Mostramos los atributos
            foreach (DatosAttribute atributo in atributos)
                //Dato es el atributo que hemos puesto en la biblioteca
                Console.WriteLine(atributo.Dato);

            Console.ReadKey();
        }
    }
}
