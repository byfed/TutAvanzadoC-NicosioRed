using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class CTelevisor: IElectronico
    {
        string marca;

        public CTelevisor(string pMarca)
        {
            marca = pMarca;
        }

        public override string ToString()
        {
            return string.Format("El televisor es marca {0}", marca);
        }

        public void Encender(bool pInterruptor)
        {
            if (pInterruptor)
            {
                Console.WriteLine("Encencido");
            } else
            {
                Console.WriteLine("Apagado");
            }
        }
    }
}
