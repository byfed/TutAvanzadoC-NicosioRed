using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic01
{
    class Program
    {
        static void Main(string[] args)
        {
            //forma de invocar a miembros cuando se usa dynamic.
            //Notar que el intellisense no actua, cuidado con eso.

            //Creamos cadena de texto con dynamic
            dynamic texto = "hola";

            //Podemos invocar un método
            texto = texto.ToUpper();

            //Podemos obtener una propiedad
            int n = texto.Length;

            Console.WriteLine("{0}, {1}", n, texto);

            //Con dynamic no se verifica el error de sintaxis en el momento de compilación.
            //El error aparecerá cuando se ejecute.
            //n = texto.length;

            //Podemos incluso invocar a métodos inexistentes sin error de compilación.
            //texto.mono(47);

            //Todo esto es porque dynamic puede cambiar de tipo durante la ejecución


            //FORMA CORRECTA DE USAR CODIGO CON DYNAMIC
            //simepre hay que usar try y catch

            dynamic texto2  = "Fede";
            try
            {
                n = texto2.Length;
                texto2.ToUpper();
                Console.WriteLine("{0},{1}",n,texto2);
                //texto2.toUpper();

                CConDynamic objeto = new CConDynamic();

                objeto.propiedad = 5;
                objeto.imprime();
                objeto.propiedad = " Holaaaa"; 
                objeto.imprime();

                objeto.recibe(57.6);
                objeto.recibe("un string cualquiera");

                dynamic regreso = objeto.regresa(10);
                Console.WriteLine(regreso);


            } catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);

            }



            Console.ReadKey();
        }
    }
}
