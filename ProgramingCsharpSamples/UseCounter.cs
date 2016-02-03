using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCsharpSamples
{
    public class UseCounter
    {
        public static void Exec()
        {
            Counter c1 = new Counter();
            Counter c2 = c1;
            c1++;

            Console.WriteLine("c1: " + c1.Count);

        }

    }
}
