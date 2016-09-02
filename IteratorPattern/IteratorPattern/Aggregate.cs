using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class Aggregate // this is the Aggregate class
    {
        public List<string> Members;

        public abstract Iterator createIterator();
        public abstract Iterator createIteratorLeastImport();
    }
}
