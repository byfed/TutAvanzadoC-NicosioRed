using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces02
{
    class CRadio : IElectronico
    {
        string marca;

        public CRadio(string pMarca)
        {
            marca = pMarca;
        }

        public override string ToString()
        {
            return string.Format("La radio es de marca {0}", marca);
        }

        public void Encender(bool pInterruptor)
        {
            if (pInterruptor)
            {
                Console.WriteLine("Encencido");
            }
            else
            {
                Console.WriteLine("Apagado");
            }
        }

    }
}
