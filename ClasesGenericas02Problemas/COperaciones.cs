using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas02Problemas
{
    class COperaciones<T>
    {
        public T Suma(T a, T b)
        {
            //El compilador nos informa de que el operador + no se puede aplcicar al tipo genérico T
            //return a + b;
            //Eso es porque T puede ser cualquier tipo y no se puede estar seguro de que cualquier tipo tenga implementado estos operadores.
            //dynamic no soluciona el problema completamente, pero al menos deja compilar.
            dynamic da = a, db = b;
            return da + db;
        }

        public T Resta(T a, T b)
        {
            //return a - b;
            dynamic da = a, db = b;
            return da - db;

        }
    }
}
