using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    class MiInt : ISaludador
    {
        private int a;

        public MiInt(int pA)
        {
            a = pA;
        }

        public override string ToString()
        {
            return string.Format("Tu int es {0}", a);
        }

        public void saludar()
        {
            Console.WriteLine("Hola desde int {0}",a);
        }
    }
}
