using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Reflection02
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = null;

            //carga dinámica del assembly
            try
            {
                //Lo busca en la misma carpeta donde está el ejecutable
                asm = Assembly.Load("Aritmetica");
                EncuentraTipos(asm);

            } catch (FileNotFoundException ex)
            {
                Console.WriteLine("Assmebly no encontrado");
                Console.WriteLine(ex.Message);
                return;
            }

            if (asm != null)
            {
                //Obtenemso el tipo
                Type mates = asm.GetType("Aritmetica.Mates");

                try
                {
                    //Creamnos instancia con el tipo que acabamos de recuperar
                    //se indica el tipo de la instancia y los parámetros se pasan con un array de objetos
                    object obj = Activator.CreateInstance(mates, new object[] { 5, 3 });
                    Console.WriteLine("Tenemos instancia de {0}", obj);

                    //Obtenemos el método
                    MethodInfo suma = mates.GetMethod("suma");

                    //obtenemos  propiedad
                    PropertyInfo resultado = mates.GetProperty("R");

                    double r = 0;

                    //para invocar el método se usa invoke.
                    //El primer parámetro indica la instancia sobre la que se va a ejecutar el método. 
                    //El segundo parámetro son los parámetros (en este caso no se necesitan). Si no, se pasaría como en CreateInstancie (con 
                    //array de objetos).
                    suma.Invoke(obj, null);

                    //invocamos la propiedad
                    r = (double)resultado.GetValue(obj);

                    Console.WriteLine("El resultado es {0}",r);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); 
                }
            }

            Console.ReadKey();
        }

        public static void EncuentraTipos (Assembly asm)
        {
            Console.WriteLine("Los tipos encontrados en {0}",asm.FullName);

            Type[] tipos = asm.GetTypes();

            foreach (Type t in tipos)
            {
                Console.WriteLine(t);
            }
        }
    }
}
