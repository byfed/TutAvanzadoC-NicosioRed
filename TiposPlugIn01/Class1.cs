using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPlugIn01
{
    //Primero se define una interfaz que se usará para que los plugins se puedan comunicar con la aplicacion

    public interface IPlugInMates
    {
        double Calcular(double pA, double PB);
    }

    //Creamos un atributo para dar información del plug-in
    //Definimos que sólo se usará en clases
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CInfoPlugIn: System.Attribute
    {
        private string creador;
        private string informacion;

        public string Creador { get { return creador; } set { creador = value;  } }
        public string Informacion {  get { return informacion; } set { informacion = value;  } }
    }
}
