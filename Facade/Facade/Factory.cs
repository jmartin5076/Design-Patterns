using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public abstract class Factory //this is the Factory class
    { 
        public void createParty(Warrior.WarriorState m_WarriorState, Rogue.RogueState m_RogueState, White_Mage.WhiteMageState m_WhiteMageState, Black_Mage.BlackMageState m_BlackMageState)
        {
            Party party = factoryMethod(m_WarriorState,m_RogueState,m_WhiteMageState,m_BlackMageState);
        }

        protected abstract Party factoryMethod(Warrior.WarriorState m_WarriorState, Rogue.RogueState m_RogueState, White_Mage.WhiteMageState m_WhiteMageState, Black_Mage.BlackMageState m_BlackMageState);
    }
}
