using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Al importar la biblioteca se necesitará además de importarla, utilizar el namespace correspondiente.
namespace Aritmetica
{
    public class Mates
    {
        private double a, b, r;

        public Mates(double pA, double pB)
        {
            a = pA;
            b = pB;
            r =0;
        }

        public double R { get { return r; } }

        public double suma()
        {
            r = a + b;
           return r;
        }

        public double resta()
        {
            r = a - b;
            return r;
        }
    }
}
