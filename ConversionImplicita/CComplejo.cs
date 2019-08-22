using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionImplicita
{
    class CComplejo
    {
        //a+bi
        private int a;
        private int b;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public CComplejo(int pa, int pb)
        {
            a = pa;
            b = pb;
        }

        public override string ToString()
        {
            return string.Format("{0}+{1}*i", a, b);
        }

        //Creamos una conversión explícita a reales
        //Es como si estuvieramos definiendo un operador llamado CReal.
        /*
        public static explicit operator CReal(CComplejo pi)
        {
            CReal temp = new CReal();
            temp.R = pi.a;
            return temp;
        }
        */
    }
}
