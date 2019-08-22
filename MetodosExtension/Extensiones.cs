using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    //La clase de extensión debe ser estática
    static class Extensiones
    {
        //El método que estiende debe ser estático. El primer parámetro lleva this y representa al tipo que estamos extendiendo
        //i es el objeto desde el que se llama al método extendido.
        public static bool EsPar(this int i)
        {
            if (i % 2 == 0)
                return true;
            else
                return false;
        }

        //extensión a double
        public static double Doblar(this double d)
        {
            return 2.0 * d;
        }

        //Estension de clases que implementan la interfaz ISaludador.
        public static void beeper(this ISaludador s)
        {
            Console.WriteLine("beep");
        }
    }
}
