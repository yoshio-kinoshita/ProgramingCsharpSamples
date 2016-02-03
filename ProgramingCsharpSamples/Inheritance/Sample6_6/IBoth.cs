using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCsharpSamples.Inheritance.Sample6_6
{
    interface IBoth: IBase1, IBase2
    {
        void Method3();
    }
}
