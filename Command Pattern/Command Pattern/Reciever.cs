using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class Reciever
    {
        Form2 f2 = new Form2();

        public void action(string piece,string start,string end)
        {
            string MovePiece = "The " + piece + " has been moved to " + end + " from " + start + Environment.NewLine;
            f2.m_tbLog.Text += MovePiece;
            f2.Visible = true;
        }

        public void redo(string piece,string start)
        {
           string RemovePiece = "The " + piece + " has been returned to " + start + Environment.NewLine;
           f2.m_tbLog.Text += RemovePiece;
           f2.Visible = true;
        }
    }
}
