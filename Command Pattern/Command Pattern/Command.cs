using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public abstract class Command
    {
        public abstract void execute(string piece,string start,string end);
        public abstract void unexecute(string piece, string start);
    }
}
