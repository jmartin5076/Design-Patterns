using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Normal_Nature : Party_Tactics
    {
        Form2 f2 = new Form2();

        public override void partyCommand()
        {
            f2.m_tbWarrior.Text = "Punch it";
            f2.m_tbMages.Text = "Study it";
            f2.m_tbRogue.Text = "Stealth";
            f2.Visible = true;
        }
    }
}
