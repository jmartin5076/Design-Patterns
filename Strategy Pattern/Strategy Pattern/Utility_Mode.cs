using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Utility_Mode : Party_Tactics
    {
        Form2 f2 = new Form2();

        public override void partyCommand()
        {
            f2.m_tbWarrior.Text = "Use yer Shield";
            f2.m_tbMages.Text = "Cower and Cast";
            f2.m_tbRogue.Text = "Stealth";
            f2.Visible = true;
        }
    }
}
