using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
     public class ConcreteIteratorLeastImport : Iterator
    {
        Aggregate aggregate;
        int CurrentIndex;

        public ConcreteIteratorLeastImport(Aggregate agg)
        {
            aggregate = agg;
        }

        public override object currentItem()
        {
            if (isDone())
            {
                return null;
            }
            return aggregate.Members[CurrentIndex];
        }

        public override object first()
        {
            CurrentIndex = aggregate.Members.Count -1;
            return currentItem();
        }

        public override bool isDone()
        {
            return (CurrentIndex < 0);
        }

        public override object next()
        {
            if (!isDone())
            {
                CurrentIndex--;
            }
            return currentItem();
        }
    }
}
