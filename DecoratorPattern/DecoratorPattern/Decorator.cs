using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Decorator : Sundae // this is the Decorator class
    {
        public abstract override string orderSundae(string s);
    }
}
