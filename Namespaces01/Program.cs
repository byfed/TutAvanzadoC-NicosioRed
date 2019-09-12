using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using LasClases;
//using OtrasClases;

//Creamos un alias con las clases que nos dan conflicto.
using principal = LasClases.Clase1;
using secundario = OtrasClases.Clase1;


//Por defecto se crea un namespace con el mismo nombre del proyecto.
namespace Namespaces01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hay que añadir el namespace para que reconozca la clase Clase1
            //Clase1 ob1 = new Clase1();

            //También se puede calificar totalmente la clase (solo si los namespaces están en el mismo proyecto)
            //LasClases.Clase2 ob2 = new LasClases.Clase2();

            //Cuando dos namespaces tienen una clase con el mismo nombre, se produce un error en el nombre de la case, porque es ambigua.
            //La forma más sencilla es usar nombres completamente cualificdo
            //LasClases.Clase1 ob1 = new LasClases.Clase1();
            //OtrasClases.Clase1 ob2 = new OtrasClases.Clase1();

            //Tabmién se puede solucinar con alias. (Ver al inicio del archivo), haciencdo using alias = clase_con_conflicto;

            principal ob1 = new principal();
            secundario ob2 = new secundario();
            Console.WriteLine(typeof(principal));

            //El anidamiento permite organizar las clases de forma más detallada.


            Console.ReadKey();  
            
        }
    }
}
