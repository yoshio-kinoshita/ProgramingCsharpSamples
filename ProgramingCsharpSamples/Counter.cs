using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCsharpSamples
{
    public class Counter
    {
        private readonly int _count;
        private static int _totalcount;

        public Counter() 
        {
            _count = 0;
        }

        private Counter(int count)
        {
            _count = count;
        }

        public Counter GetNextValue()
        {
            _totalcount += 1;
            return new Counter(_count + 1);
        }

        public static Counter operator ++(Counter input)
        {
            return input.GetNextValue();
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public static int TotalCount
        {
            get
            {
                return _totalcount;
            }
        }
    }
}
