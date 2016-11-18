using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Vanilla : Sundae //these are the ConcreteDecorator classes
    {
        public override string orderSundae(string s)
        {
            s += " vanilla ice cream";
            return s;
        }
    }

    public class Chocolate : Sundae
    {
        public override string orderSundae(string s)
        {
            s += " chocolate ice cream";
            return s;
        }
    }

    public class Strawberry : Sundae
    {
        public override string orderSundae(string s)
        {
            s += " strawberry ice cream";
            return s;
        }
    }

    public class Twist : Sundae
    {
        public override string orderSundae(string s)
        {
            s += " twist ice cream";
            return s;
        }
    }

    public class Neopolitan : Sundae
    {
        public override string orderSundae(string s)
        {
            s += " neopolitan ice cream";
            return s;
        }
    }
}
