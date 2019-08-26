using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizableDisposable
{
    class CPrueba: IDisposable
    {
        private int a;
        private bool usoDispose = false;

        public CPrueba (int pA)
        {
            a = pA;
        }

        public override string ToString()
        {
            return string.Format("El valor es {0}", a);
        }

        ~CPrueba()
        {
            //Problemas:
            //En primer lugar, hay duplicidad de código
            //Si se ha llamado en algun momento a Dispose, al ejecutarse el destructor, puede que se intente de nuevo ejecutar la liberación
            //puede generar excepciones y fallos.

            //Para evitar la duplicidad de código, lo metemos en un método propio
            //Console.WriteLine("Estamos en el destructor. Aquí liberamos lo no administrado {0}",a);
            limpieza();
        }

        public void Dispose()
        {
            //Console.WriteLine("Estamos en Dispose, aqui liberamos lo no administrado {0}",a);
            limpieza();
            
            
            //Si se usa dispose, no debemos usar el destructor
            GC.SuppressFinalize(this);
                
        }

        private void limpieza()
        {
            //Con la variable booleana controlamos si el código ya fue ejecutado
            if (usoDispose == false)
            {
                Console.WriteLine("Estamos en el destructor. Aquí liberamos lo no administrado {0}", a);
            }
            usoDispose = true;
            
        }
    }
}
