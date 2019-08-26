using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces04
{
    class Program
    {
        //jerarquía de interfaces. Se usa una interfaz que a su vez depende de otra interfaz.

        static void Main(string[] args)
        {
            CSuma misuma = new CSuma();

            //método de la interfaz ICalcular
            misuma.Calculo(3, 2);

            //método de la interfaz IMostrar
            misuma.MostrarDatos();

            Console.ReadKey();
        }
    }
}
