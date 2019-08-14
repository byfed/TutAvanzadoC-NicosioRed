using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollectionNS
{
    class CPunto : IComparable<CPunto>
    {
        private int x;
        private int y;

        public CPunto(int px, int py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format("x={0},y={1} (m={2:0.00})", x, y,Math.Sqrt(x*x+y*y));
        }

        public int CompareTo(CPunto b)
        {
            double maga = Math.Sqrt(x * x + y * y);
            double magb = Math.Sqrt(b.x * b.x + b.y * b.y);

            if (maga > magb) return 1;

            if (maga < magb)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
