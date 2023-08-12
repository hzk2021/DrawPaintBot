using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBot
{
    static class Maths
    {
        public static int getDist(int r1, int r2, int g1, int g2, int b1, int b2)
        {
            return (int)Math.Sqrt
            (
                Math.Pow(r1 - r2, 2) +
                Math.Pow(g1 - g2, 2) +
                Math.Pow(b1 - b2, 2)
            );
        }

    }
}
