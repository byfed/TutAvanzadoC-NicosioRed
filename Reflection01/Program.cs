using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Necesitamos el Linq y el de Reflection.
using System.Reflection;

namespace Reflection01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Type t = Type.GetType("System.Console");
                Type t = Type.GetType("System.Collections.ArrayList");

                CaracteristicasTipo(t);
                Console.WriteLine();
                EncuentraCampos(t);
                Console.WriteLine();
                EncuentraPropiedades(t);
                Console.WriteLine();
                EncuentraMetodos(t);
                Console.WriteLine();
                EncuentraInterfaces(t);

            }

            catch (Exception)
            {

                Console.WriteLine("Verificar el tipo");
            }
            Console.ReadKey();
        }

        public static void CaracteristicasTipo(Type t)
        {
            //imprimios caracteristicas principales del tipo
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las caracteristicas que tiene son: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Clase base: {0}", t.BaseType);
            Console.WriteLine("Abstracta: {0}", t.IsAbstract);
            Console.WriteLine("Sellada: {0}", t.IsSealed);
            Console.WriteLine("Genérica: {0}",t.IsGenericTypeDefinition);
        }

        public static void EncuentraCampos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los campos enctontrados son:");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from f in t.GetFields() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}",nombre);
            }
        }

        public static void EncuentraPropiedades(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las propiedades enctontrados son:");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from f in t.GetProperties() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }
        public static void EncuentraMetodos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los metodos enctontrados son:");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from f in t.GetMethods() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }

        public static void EncuentraInterfaces(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las Interfaces enctontrados son:");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from f in t.GetInterfaces() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }
    }
}
