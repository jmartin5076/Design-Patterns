using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class Adapter : Target
    {
        Adaptee adaptee = new Adaptee();

        public override double request(double dollar)
        {
            return adaptee.specificRequest(dollar);
        }
    }
}
