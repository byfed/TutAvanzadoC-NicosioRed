using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces04
{
    class CSuma: ICalcular
    {
        private int a;
        private int b;
        private int r;

        //Implementación de ICalcular
        public int Calculo(int pa, int pb)
        {
            a = pa;
            b = pb;
            r = a + b;
            return r;
        }

        //Ademnás, hay que implementar IMostrar, porque ICalcular tiene jerarquía.
        public void MostrarDatos()
        {
            Console.WriteLine("{0} + {1} = {2}",a,b,r);
        }
    }
}
