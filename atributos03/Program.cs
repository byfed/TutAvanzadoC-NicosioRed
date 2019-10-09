using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace atributos03
{
    class Program
    {
        static void Main(string[] args)
        {
            //usamos reflexion con late binding. El dll está copiado en la carpeta
            try
            {
                //Cargamos el assembly
                Assembly asm = Assembly.Load("AritmeticaAtributos");

                //Obtenemos el tipo del atributo
                Type datoAt = asm.GetType("AritmeticaAtributos.DatosAttribute");

                //Obtenemos la propiedad
                PropertyInfo datoProp = datoAt.GetProperty("Dato");

                //Obtenemos la lisa de tipos en el assembly
                Type[] tipos = asm.GetTypes();

                //Para cada tipo obtenemos el atributo
                foreach (Type t in tipos)
                {
                    //cada tipo puede tener varios atributos, por eso se usa  un array
                    object[] objetos = t.GetCustomAttributes(datoAt, false);

                    foreach(object obj in objetos)
                    {
                        Console.WriteLine("{0}, {1}",t.Name, datoProp.GetValue(obj,null));
                    }
                }

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
