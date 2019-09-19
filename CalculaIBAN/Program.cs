using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIBAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entidad: {0}","1432");
            Console.WriteLine("Sucursal: {0}","0154");
            Console.WriteLine("cuenta: {0}","7422504551");
            IBANCalculator ibc = new IBANCalculator("1432", "0154", "49", "7422504551");
            Console.WriteLine("dc = {0}",ibc.digitosControlCalculator(1432, 0154, 7422504551));
            Console.ReadKey();
        }

    }
}
