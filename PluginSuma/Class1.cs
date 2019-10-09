using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Hay que copiar la dll a la carpeta debug y después añadir la referencia, para que el plugin pueda conocer
//los tipos y la interfaz
using TiposPlugIn01;

namespace PluginSuma
{
    //Comolacomos el atributo
    [CInfoPlugIn(Creador ="Federico", Informacion ="suma de dos doubles")]

    //Implementa la interfaz que hemos definido de comunicación con los plugins.
    public class CSuma: IPlugInMates
    {
        public double Calcular(double pA, double pB)
        {
            double r = pA + pB;
            return r;
        }
    }
}
