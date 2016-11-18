using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ConcreteSundae : Sundae // this is the ConcreteComponent class
    {
        public override string orderSundae(string s)
        {
            s += " one sundae with";
            return s;
        }
    }
}
