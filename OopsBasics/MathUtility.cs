using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasics
{
    public static class MathUtility
    {
        public static decimal PIstatic = 3.14M;
        //public const decimal PI = 3.14M;

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

    }

    public class MyClass
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
