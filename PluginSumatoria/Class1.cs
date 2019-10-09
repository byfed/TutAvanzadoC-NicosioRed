using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TiposPlugIn01;

namespace PluginSuma
{
    //Comolacomos el atributo
    [CInfoPlugIn(Creador = "Federico", Informacion = "Suma los A primeros numeros")]

    //Implementa la interfaz que hemos definido de comunicación con los plugins.
    public class CSuma : IPlugInMates
    {
        public double Calcular(double pA, double pB)
        {
            int n = 0;
            double sumatoria = 0;
            for (n = 1; n <= pA; n++)
            {
                sumatoria += n;
            }
            return sumatoria;
        }
    }
}