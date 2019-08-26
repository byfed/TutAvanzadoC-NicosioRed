using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloVidaObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //usamos la clase GC de Garbage Collector.
            //Obtenemos la cantidad de bytes en el heap administrado.
            long bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine("El heap usa {0} bytes", bytesHeap);

            //Obtenemos la cantidad de generaciones, basado en 0 por eso +1
            int maximaGeneracion = GC.MaxGeneration + 1;
            Console.WriteLine("Se tienen {0} generaciones",maximaGeneracion);

            //creamos instancia
            CPrueba prueba1 = new CPrueba(5);
            bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine("El heap usa {0} bytes", bytesHeap);

            //Generación de la instanacia
            int generacionInstancia = GC.GetGeneration(prueba1);
            Console.WriteLine("LA generacion de la instancia es {0}",generacionInstancia);

            //Forzar la recolección de basura (generalmente no se suele ocupar elprograma)
            //Solo hacerlo en situaciones epeciales.
            // Cuando la aplicación entra a un bloque de codigo queno debe ser interrumpido por la recolección.
            //Cuando vamos a entrar a un bloque que queremos que se ejecute rapidamente y sin interrupciones, es mejor recolectar antes (solo se aplica para códigos críticos).
            //La apliación creo una gran cantidad de instancia y se necesita liberar la mayor cantidad de memoria posible

            GC.Collect();
            GC.WaitForPendingFinalizers();

            //Para recolectar una generación en particular:
            GC.Collect(0);
            GC.WaitForPendingFinalizers();


            //Console.ReadKey();
        }
    }
}
