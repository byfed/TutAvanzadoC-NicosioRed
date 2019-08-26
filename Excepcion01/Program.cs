using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion01
{
    class Program
    {
        static void Main(string[] args)
        {
            CCaldera micaldera = new CCaldera("fagor", 20);

            //Código que podría generar una excepción
            // VERSION 1
            //for (int i = 0; i < 10; i++)
            //{
            //    micaldera.Trabajar(20);

            //}

            //VERSION 2
            try
            {
                //Aquí va el código que puede generar la excepción.
                for (int i = 0; i < 10; i++)
                {
                    micaldera.Trabajar(20);
                }
            } //Cazamos una excepción del tipo que hemos enviado (El tipo que se va a capturar)
            catch (Exception e)
            {
                Console.WriteLine("Sucedió una excepción");
                //Información acerca de la excepción
                Console.WriteLine("En este método: {0}", e.TargetSite);
                //Es el mensaje que se mete cuando se usa un throw
                Console.WriteLine("Mensaje de error: {0}",e.Message);
                //aplicación que generó el error
                Console.WriteLine("Fuente: {0}",e.Source);

                Console.WriteLine("Clase donde ha ocurrido: {0}",e.TargetSite.DeclaringType);
                //Lo generó un método, o una operación, o qué.
                Console.WriteLine("Tipo de miembro: {0}",e.TargetSite.MemberType);

                Console.WriteLine("Track {0}",e.StackTrace);
                Console.WriteLine("Helplink: {0}",e.HelpLink);

                //Mostramos los datos prpios.

                if (e.Data != null){
                    foreach (DictionaryEntry dato in e.Data)
                    {
                        Console.WriteLine("-> {0} -> {1}",dato.Key, dato.Value);
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
