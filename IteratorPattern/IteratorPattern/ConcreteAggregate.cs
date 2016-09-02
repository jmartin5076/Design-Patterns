using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteAggregate : Aggregate // this is the ConcreteAggregate class
    {
        public ConcreteAggregate()
        {
            Members = new List<string>();
        }

        public override Iterator createIterator()
        {
            return new ConcreteIterator(this);
        }
        
        public override Iterator createIteratorLeastImport()
        {
            return new ConcreteIteratorLeastImport(this);
        }
    }
}
