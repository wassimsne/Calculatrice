using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class CalculSimple
    {
        public int add(int x, int y)
        {
            if (x == int.MaxValue || y == int.MaxValue)
                throw new ArgumentException("Limite atteinte");
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x + y;   
        }
        public int devide(int x, int y)
        {
            if ( y == 0)
                throw new ArgumentException("Limite infini");
            return x/y;
        }
        public int Multiplication(int x, int y)
        {
            if (x == int.MaxValue || y == int.MaxValue)
                throw new ArgumentException("Limite infini");
            return x*y;
        }
    }
}
