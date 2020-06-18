using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathService
{
    public class MathService : IMathService
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Subtract(double x, double y)
        {
            y = y == 0 ? 1 : y;
            return x / y;
        }
    }
}
