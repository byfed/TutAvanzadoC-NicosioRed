using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inerfaces03
{
    //La clase implementa dos interaces que tienen un método qu ese llaman igual, con el mismo tipo de rtorno y los mismos parámetros
    class CCuadrado : IArea, IPerimetro
    {
        private int lado;

        public CCuadrado (int pLado)
        {
            lado = pLado;
        }

        //Esta es la forma explícita de referencia a los métodos. Así no hay problema.
        //ojo. El acceso es público. Además, no se puede poner. Si se pone, da error.
        void IArea.Calcular()
        {
            Console.WriteLine("Se calcula el área: {0}", lado*lado);
        }

        void IPerimetro.Calcular()
        {
            Console.WriteLine("Se calcula el perímetro {0}", 4*lado);
        }


    }
}
