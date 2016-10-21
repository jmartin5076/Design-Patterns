using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public abstract class Target
    {
        public abstract double request(double dollar);
    }
}
