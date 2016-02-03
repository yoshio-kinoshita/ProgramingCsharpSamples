using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCsharpSamples.Inheritance.Sample6_6
{
    class Impl : IBoth
    {
        public void Method3()
        {
            throw new NotImplementedException();
        }

        public void Base2Method()
        {
            throw new NotImplementedException();
        }
    }
}
