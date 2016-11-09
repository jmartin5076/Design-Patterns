using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class AbstractionImp : Abstraction
    {
        public Implementor Imp;

        public AbstractionImp(Implementor imp)
        {
            Imp = imp;
        }

        public override void changeUser()
        {
          Imp.chooseUser();
        }
    }
}
