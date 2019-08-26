using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloVidaObjeto
{
    class CPrueba
    {
        private int a;
        public CPrueba(int pA){
            a = pA;
        }

        public override string ToString()
        {
            return string.Format("el valor es {0}", a);
        }

        //Object el el supertipo de todas las clase. Tiene un método virtual llamado Finalize(), que es el que se invoca cuando
        //se finaliza el objeto (libera recursos) No se puede ejecutar directamente, porque está protegido. Lo ejecuta el GC antes de 
        //eliminar el objeto.
        //No se puede sobreescribir (override)
        //Esto no se suele hacer, savo que se estén usando recursos no administrados (COM, Pinvoke)

        //Podemos llamar a finalice con un método destructor
        ~CPrueba()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se destruye el objeto y se liberar recursos no administrados");
            Console.Beep();
        }


    }
}
