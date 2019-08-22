using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tiene uso cuando se quieren encapsular datos sin necesidad de definir una clase.
            //Un tipo anónimo esuna clase que solo tienen atributos, propiedades, toString, pero no métodos. Es como un tipo temporal.

            //Internamente se trata de una clase. Pero está sellada. Al no tener nombre, no se puede aplicar herencia, ni usar interfaces, ni nada.
            //Solo es como una estructura de datos.

            var miCompu = new { procesador = "i5", memoria = 16, graficos = "integrados" };

            //impirmir la variable (tostring automático)
            Console.WriteLine(miCompu);

            //impirmir una propiedad:
            Console.WriteLine(miCompu.procesador);

            //No se puede modificar el atributo
            //miCompu.procesador = "i7";

            Console.ReadKey();

        }
    }
}
