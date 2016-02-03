using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCsharpSamples.Inheritance.Sample6_1
{
    class AlsoDerived : SomeClass, IDisposable
    {
        public void Dispose() { }
    }
}
