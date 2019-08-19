using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas02Problemas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Con la clase oepraciones no es posible compilar. 
            //Usamos dynamic para resolverlo.

            COperaciones<int> miOperacion = new COperaciones<int>();
            //esto funciona sin problemas
            Console.WriteLine(miOperacion.Suma(5,4));

            COperaciones<string> miOpS = new COperaciones<string>();
            //esto parece que funciona bien..
            Console.WriteLine(miOpS.Suma("hola"," a todos"));
            //Pero cuando probamos esto: 
            Console.WriteLine(miOpS.Resta("hola", " a todos"));
            //Hay un error porque la clase string no tiene sobrecarga del operador -
            //Habría que controlar desde la propia clase el comportamiento con el operador typeof...


            Console.ReadKey();
        }
    }
}
