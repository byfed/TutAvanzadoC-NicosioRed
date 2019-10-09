using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.IO;

namespace Dynamic03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hay un runtime complementario conocido como DLR (Dynamic Language Runtime), que permite descurbir los tipos
             * en tiempo de ejecución sin chequeos poa parte del compilador.
             * Permite tener código muy flexible, también se puede trabajar con diferentes plataformas y lenguajes de programación.
             * Permite adicionar o remover tipos de memoria en tiempo de ejecución.
             * 
             * Hacemos uso de dynamic para simplificar la reflexión en el late binding.
             */
            Assembly asm = null;

            try
            {
                //Cargamos el assembly
                asm = Assembly.Load("AritmeticaAtributos");

                //Obtenemos el tipo.
                Type mates = asm.GetType("AritmeticaAtributos.MisMates");

                //creamos el objeto
                dynamic objeto = Activator.CreateInstance(mates, new object[] { 5, 6 });
                Console.WriteLine("Tenemos instancia de {0}", objeto);

                //Hay que notar la simpliviación de la sistaxis.
                //Comparar con el proyecto dynamic03
                //se invoca directamente, sin llamar a invoke.
                objeto.suma();

                //trabajamos con la propiedad
                double r = objeto.R;
                Console.WriteLine("El resultado es {0}",r);
                    

            }
            catch (Exception ex)
            {
                Console.ReadKey();
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
