using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public abstract class State // this is the State class
    {
        public abstract string handleAttack();
    }
}
