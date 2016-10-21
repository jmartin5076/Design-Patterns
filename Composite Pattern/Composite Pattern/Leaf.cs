using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Leaf : Component
    {
        private string Ability;
        private string Condition;

        public Leaf(string ability,string condition)
        {
            Ability = ability;
            Condition = condition;
        }

        public Leaf()
        {

        }

        public override string getCondition()
        {
            return Condition;
        }

        public override string ToString()
        {
            return Ability;
        }
    }
}
