using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se necesita:
            // - una clase que representa los detalles de la excepcion
            // - un miembro que lanza la instancia de la excepción
            // - un bloque que invoca el código que puede generar la excepción
            // - un bloque catch que captura la excepción cuando ocurre

            CCaldera miCaldera = new CCaldera("fagor", 20);
            Random rnd = new Random();

            while (miCaldera.Funciona)
            {
                try
                {
                    //valor aleatorio entre 0 y 10
                    miCaldera.Trabajar(rnd.Next(10)-5);
                }

                //Catch específico para la excepción creada por nosotros, con acceso al resto de datos
                catch (CalderaExcepcion e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Momento);
                    Console.WriteLine(e.Causa);
                }
                //Si encadenamos varios bloques catch, para capturar distintos tipos de excepción, el catch de Exception debe ir al final, 
                //puesto que es el más genérico de todos. Siempre se listan de la más particular a la más genérico
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    //Captura de excepciones estándar, que mostrará el mensaje que nosotros hemos definido
                    Console.WriteLine("El mensaje: {0}", e.Message);
                }
                //Nota: 
                // con catch sin especificar ningun tipo de excepción, se captura de manera genérico. El problema es que no se tiene información 
                // de la excepción.

            }

            Console.WriteLine("-----------");
            CCaldera miCaldera2 = new CCaldera("thompson", 25);

            try
            {
                //forzamos excepción de fuera de rango
                miCaldera2.Trabajar(-5);

                //Excepciones anindadas
                try
                {
                    miCaldera2.Trabajar(200);
                }
                catch (CalderaExcepcion e)
                {
                    Console.WriteLine(e.Message);
                }

            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                Console.WriteLine("Código cómun, que se ejecuta tanto si hay excepción como si no");
            }
            Console.ReadKey();
        }
    }
}
