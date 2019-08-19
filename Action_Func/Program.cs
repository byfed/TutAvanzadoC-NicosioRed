using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            //Es una forma "abreviada" de crear un delegado, para un máximo de 16 de parámetros
            //En el caso de Action, el método debe ser void
            int n = 5;
            string m = "Hola a todos";

            //usamos action para registrar el handler con el delegado 
            //ojo, admite 16 tipos.
            Action<string, int> delAction = new Action<String, int>(RepiteMensaja);

            //invocamos el delegado
            delAction(m, n);

            //Func es como el Action, pero con tipo de retorno
            int x = 5;
            int y = 6;

            //Definicmos el delegado, el ultimpo tipo listado es siempre el tipo de retonro
            Func<int, int, int> delFunc = new Func<int, int, int>(suma);

            //Invocacion
            Console.WriteLine(delFunc(4,3));

            Console.ReadKey();

        }

        static void RepiteMensaja(String pMensaje, int pVeces)
        {
            for (int i = 0; i < pVeces; i++)
            {
                Console.WriteLine(pMensaje);

            }
        }

        //Handler para func
        static int suma(int a, int b)
        {
            return a + b;
        }

    }
}
