using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCsharpSamples
{
    class DelegateSample
    {

        public static int GetIndexOfFirstNonEmptyBin(int[] bins)
        {
            return Array.FindIndex(bins, IsGraterThanZero);
        }

        private static bool IsGraterThanZero(int value)
        {
            return value > 0;
        }
    }
}
