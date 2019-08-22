using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces02
{
    class Program
    {
        static void Main(string[] args)
        {

            //array de Interfaces
            //Todos los objetos del siguiente array implementan la misma interfaz.. no tienen porqué estar relacionados o pertenecer a la misma
            //cadena de herencia. Lo único que tienen en comun es que implementna la interfaz
            //Es un array con capacidades polimorficas
            IElectronico[] teles = { new CTelevisor("Sony"), new CTelevisor("Telefunken"), new CRadio("Panasonic"), new CRadio("Thompson") };
            IElectronico aparatoCreado = null;

            for (int i = 0; i < teles.Length; i++)
            {
                Console.WriteLine(teles[i]);
            }
            Console.WriteLine("----");

            //interfaces con métodos
            CTelevisor mitele = new CTelevisor("Sharp");
            CRadio miradio = new CRadio("RCB");

            Muestra(mitele);
            Muestra(miradio);
            Console.WriteLine("----");


            //Métodos que devuelven instancias de clases diferentes que implementan interfaz
            IElectronico aparato = CreaAparato();
            aparato.Encender(true);
            Console.WriteLine(aparato);


            Console.ReadKey();

        }

        //Este metodo puede recibir a cualquier objeto que implemente IElectronico
        static void Muestra(IElectronico aparato)
        {

            //Podemos distinguir un objeto u otro por su clase
            //también puede haber código común aplicable a cualquier objeto que implemente IEectronico
            aparato.Encender(true);

            if (aparato is CTelevisor)
            {
                Console.WriteLine("La tele es {0}",aparato);
            }

            if (aparato is CRadio)
            {
                Console.WriteLine("La Radio es {0}", aparato);
            }

        }
        
        //Podemos definir un método que devuelve un objeto que implemente una interfaz adecuada, sin especificar el tipo.
        static IElectronico CreaAparato()
        {
            IElectronico aparato = null;
            string dato = string.Empty;
            int opcion = 0;

            Console.WriteLine("1-crear tele, 2-crear radio");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Marca de la tele->");
                    dato = Console.ReadLine();
                    aparato = new CTelevisor(dato);
                    break;
                case 2:
                    Console.WriteLine("Marca de la Radio->");
                    dato = Console.ReadLine();
                    aparato = new CRadio(dato);
                    break;
            }

            return aparato;
        }
    }
}
