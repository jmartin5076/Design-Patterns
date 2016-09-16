using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
     public class ConcreteParty : Party
    {
        public Party party;

        public ConcreteParty()
        {
        }

        public ConcreteParty(Warrior.WarriorState m_WarriorState, Rogue.RogueState m_RogueState, White_Mage.WhiteMageState m_WhiteMageState, Black_Mage.BlackMageState m_BlackMageState)
        {
            party = new Party(m_WarriorState,m_RogueState,m_WhiteMageState,m_BlackMageState);
            party.Visible = true;
        }
    }
}
