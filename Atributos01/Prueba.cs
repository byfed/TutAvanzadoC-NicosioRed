using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos01
{
    //[Obsolete]
    [Obsolete("Esto está viejo")]
    class Prueba
    {
        public Prueba() {
            Console.WriteLine("version 1");
        }

    }

    [Datos("Clase por Nicosio")]
    class Prueba2
    {
        public Prueba2()
        {
            Console.WriteLine("versión 2");
        }
    }
}
