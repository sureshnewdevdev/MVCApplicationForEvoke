using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasics
{
    public class FunctionExamples
    {
        public int SumAndAvg(int x, int y, ref int avg, out int big)
        {
            avg = (x + y)/2;
            big = (x>y)?x:y;
            return x + y;
        }
    }
}
