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
                asm = Assembly.Load("Aritmetica");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            if (asm != null)
            {
                //Obtenemos el tipo.
                Type mates = asm.GetType("Aritmetica.Mates");

                try
                {
                    //creamos la instancia
                    object obj = Activator.CreateInstance(mates, new object[] { 5, 3 });
                    Console.WriteLine("Tenemos instancia de {0}", obj);

                    //obtenemos el método
                    MethodInfo suma = mates.GetMethod("suma");

                    //obtenemos la propiedad
                    PropertyInfo resultado = mates.GetProperty("R");

                    double r = 0;

                    //Invocamos el método
                    suma.Invoke(obj, null);

                    //Ejemplo de invocacion si el método usara parámetros
                    //suma.Invoke(obj, new object[] {7,3});

                    //inovamos la propieddad
                    r = (double)resultado.GetValue(obj);

                    Console.WriteLine("El resultado es {0}", r);
                    Console.ReadKey();

                }
                catch (Exception ex)
                {

                }
            }


        }
    }
}

