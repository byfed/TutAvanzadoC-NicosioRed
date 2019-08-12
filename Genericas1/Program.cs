using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericas1SN
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
                Console.WriteLine(valores[n]);
            }

            Console.ReadKey();

        }
    }
}
