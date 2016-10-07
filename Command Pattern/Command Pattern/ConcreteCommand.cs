using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class ConcreteCommand : Command
    {
        Reciever rec = new Reciever();

        public override void execute(string piece,string start,string end)
        {
            rec.action(piece, start, end);
        }

        public override void unexecute(string piece,string start)
        {
            rec.redo(piece, start);
        }
    }
}
