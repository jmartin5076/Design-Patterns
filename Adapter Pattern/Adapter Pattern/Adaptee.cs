using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class Adaptee
    {
        public double specificRequest(double dollar)
        {
            return (dollar * .91);
        }
    }
}
