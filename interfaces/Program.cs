using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //En ocasiones nos interesa conocer si un objeto implementa una interfaz, para en ese caso, hacer llamadas a los métodos de la
            //interfaz.

            CTelevisor mitele = new CTelevisor("Phillips");
            CPelota mipelota = new CPelota("Grande");
            //variable del tipo de la interfaz.
            //Objeto puede referenciar a cualquier objeto que implemente IElectronico
            IElectronico objeto = null;

            //*************** Primer método: Fuerza bruta: Generar una excepción
            try
            {
                Console.WriteLine("Probamos la tele");
                //Si la tele implementa la interfaz electronico, la siguiente asignación vale, si no, salta una excepcion
                objeto = (IElectronico)mitele;
                objeto.Encender(true);
            } catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            //repetimos con la pelota y vemos que salta la excepción.
            try
            {
                Console.WriteLine("Probamos la pelota");
                objeto = (IElectronico)mipelota;
                objeto.Encender(true);
            } catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("--------------------");

            //*************** Segundo método: Uso de "as"
            Console.WriteLine("Probamos la tele");

            objeto = mitele as IElectronico;

            if (objeto != null)
            {
                objeto.Encender(true);
            } else
            {
                Console.WriteLine("No implementa IElectronico");
            }

            objeto = mipelota as IElectronico;

            if (objeto != null)
            {
                objeto.Encender(true);
            }
            else
            {
                Console.WriteLine("Pelota No implementa IElectronico");
            }

            Console.WriteLine("--------------------");

            //*************** Tercer método: Uso de "is"

            Console.WriteLine("Probamos la tele");

            if (mitele is IElectronico)
                mitele.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            if ( mipelota is IElectronico)
                Console.WriteLine("Pelota electronica"); 
            else
                Console.WriteLine("Pelota No implementa IElectronico");

            Console.WriteLine("--------------------");

            Console.ReadKey();
        }
    }
}
