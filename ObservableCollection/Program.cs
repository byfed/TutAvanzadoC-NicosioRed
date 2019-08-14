using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; //Necesario para el Observable
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollectionNS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collecion observable. PErmite asociar un handler a la colección para monitorizar sus cambios.

            ObservableCollection<CPunto> puntos = new ObservableCollection<CPunto>()
            {
                new CPunto(10,10),
                new CPunto(8,4)
            };

            //se añade el handler (delegados y handlers, ojo)
            puntos.CollectionChanged += puntos_CollectionChanged;

            //Cambiamos la colección
            puntos.Add(new CPunto(5, 5));

            //Cambios otra vez
            CPunto mipunto = new CPunto(3, 3);

            puntos.Add(mipunto);

            puntos.Remove(mipunto);


            Console.ReadKey();
        }

        //Este es el handler
        static void puntos_CollectionChanged(object sender, 
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //Qué tipo de evento ocurrio
            Console.WriteLine("El evento es {0}", e.Action);

            //Si se añadio un elmleento
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Elementos nuevos");
                foreach (CPunto p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }

            //Si se borró un elmleento
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Elementos Afectados por el cambio");
                foreach (CPunto p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }


        }
    }
}
