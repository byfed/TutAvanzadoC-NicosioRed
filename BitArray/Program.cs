using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArraySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //LECCION 3
            //Se meten bytes como si fueran bits. (de 8 en 8)
            //Ojo se rellena el array con el bit menos significativo de cada byte
            BitArray bits = new BitArray(new byte[] { 1, 2, 4, 8, 16 });

            //Contar elementos.
            Console.WriteLine(bits.Count);
            listar(bits, "bits");
            Console.WriteLine("-------");

            //Obtener un bit en particular (según posicion)
            Console.WriteLine(bits.Get(0));
            Console.WriteLine(bits.Get(1));
            Console.WriteLine("-------");

            //Establecer valor de un bit según su posicion
            bits.Set(4, true);
            listar(bits, "bits");


            //LECCION 4
            //Clonación de bitarray (se necesita hacer un cast porque devuelve un objeto)
            BitArray bits2 = (BitArray)bits.Clone();
            Console.WriteLine("-------");
            listar(bits, "bitArray original");
            listar(bits2, "bitArray clonado");

            //invertimos arreglo con not
            Console.WriteLine("-------");
            listar(bits2,       "bits2    ");
            listar(bits2.Not(), "not bits2"); //al hacer el not, se cambia el valor de bits2.
            listar(bits2, "bits2    ");

            //Otro arrayBit para hacer operaciones con el
            BitArray bits3 = new BitArray(new byte[] { 5, 7, 9, 13, 15 });
            BitArray temp;

            //OR
            Console.WriteLine("-------");
            temp = new BitArray(new byte[] { 4, 8, 19, 11, 15 }); 
            listar(temp,    "temp     "); 
            listar(bits3,   "bits3    ");
            listar(temp.Or(bits3), "OR       ");

            //AND
            Console.WriteLine("-------");
            temp = new BitArray(new byte[] { 4, 8, 19, 11, 15 });
            listar(temp, "temp     ");
            listar(bits3, "bits3    ");
            listar(temp.And(bits3), "AND      ");

            //XOR
            Console.WriteLine("-------");
            temp = new BitArray(new byte[] { 4, 8, 19, 11, 15 });
            listar(temp, "temp     ");
            listar(bits3, "bits3    ");
            listar(temp.Xor(bits3), "XOR      ");


            Console.ReadKey();
        }

        public static void listar(BitArray bits, string nombre="")
        {
            int c = 0;
            Console.Write("{0}\t", nombre);
            foreach (bool b in bits)
            {
                c++;
                if (b)
                {
                    Console.Write("1");
                } else
                {
                    Console.Write("0");
                }
                if (c % 8 == 0)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
    }
}
