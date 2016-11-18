using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Sprinkles : Decorator // these are the ConcreteDecorator classes
    {
        public override string orderSundae(string s)
        {
            s += " and sprinkles";
            return s;
        }
    }

    public class ChocolateSyrup : Decorator
    {
        public override string orderSundae(string s)
        {
            s += " and chocolate syrup";
            return s;
        }
    }

    public class HotFudge : Decorator
    {
        public override string orderSundae(string s)
        {
            s += " and hot fudge";
            return s;
        }
    }

    public class Peanuts : Decorator
    {
        public override string orderSundae(string s)
        {
            s += " and peanuts";
            return s;
        }
    }

    public class Caramel : Decorator
    {
        public override string orderSundae(string s)
        {
            s += " and caramel sauce";
            return s;
        }
    }

    public class GummyBears : Decorator
    {
        public override string orderSundae(string s)
        {
            s += " and gummy bears";
            return s;
        }
    }

    public class Peppermints : Decorator
    {
        public override string orderSundae(string s)
        {
            s += " and peppermints";
            return s;
        }
    }

    public class Butterscotch : Decorator
    {
        public override string orderSundae(string s)
        {
            s += " and butterscotch syrup";
            return s;
        }
    }

    public class Reeses : Decorator
    {
        public override string orderSundae(string s)
        {
            s += " and Reese's Pieces";
            return s;
        }
    }

    public class Oreo : Decorator
    {
        public override string orderSundae(string s)
        {
            s += " and Oreo pieces";
            return s;
        }
    }
}
