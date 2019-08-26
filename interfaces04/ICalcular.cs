using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces04
{
    //Cualquier clase que implemente ICalcular, tendrá los métodos de IMostrar
    interface ICalcular: IMostrar
    {
        int Calculo(int a, int b);
    }
}
