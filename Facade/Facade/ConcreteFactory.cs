using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ConcreteFactory : Factory
    {
        protected override Party factoryMethod(Warrior.WarriorState m_WarriorState, Rogue.RogueState m_RogueState, White_Mage.WhiteMageState m_WhiteMageState, Black_Mage.BlackMageState m_BlackMageState)
        {
            return new ConcreteParty(m_WarriorState,m_RogueState,m_WhiteMageState,m_BlackMageState);
        }
    }
}
