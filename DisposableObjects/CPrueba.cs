using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableObjects
{
    class CPrueba: IDisposable
    {
        private int a;
        public CPrueba (int pA)
        {
            a = pA;
        }

        public override string ToString()
        {
            return string.Format("El valor es {0}", a);
        }

        //Este es el método que provoca la liberación de recursos no administraodos.
        //Aquí se colocarían cierres de conexiones, ficheros, etc.
        //cuando se hace una llamada por ejemplo a archivo.close, el método dispose se invoca automáticamente. 
        public void Dispose()
        {
            Console.WriteLine("Estamos en Dispose, aqui liberamos lo no administrado {0}",a);
        }
    }
}
