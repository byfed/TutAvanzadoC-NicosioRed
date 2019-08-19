using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAnonimosNS
{
    class CPunto
    {
        private int x;
        private int y;

        //Es la clase punto de siempre, pero le hemos definido un delegado
        public delegate void DelMensaje();

        public DelMensaje mensaje;
        //Observese que no se ha incluido la definición del método delegado. Esto se realiza desde el programa principal, usando un método anónimo

        public CPunto(int px, int py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format("x={0},y={1}", x, y);
        }
    }
}
