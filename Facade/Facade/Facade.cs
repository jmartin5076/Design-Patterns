using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public delegate void TacticsStateChangedEventHandler(object sender, EventArgs e);

     public class Facade //this is the facade class
    {
        public enum Warrior {Attack,Defend,Abilites,Escape}
        public enum Rogue {Attack,Defend,Steal,Escape}
        public enum White_Mage {Whtie_Magic,Heal,Buff}
        public enum Black_Mage {Black_Magic,Defend,Debuff,Escape}
        private Warrior _WarriorState;
        private Rogue _RogueState;
        private White_Mage _WhiteMageState;
        private Black_Mage _BlackMageState;

        public Warrior m_WarriorState
        {
            get { return _WarriorState; }
            set
            {
                _WarriorState = value;
                if (TacticsStateChanged != null)
                    TacticsStateChanged(this, new EventArgs());
            }
        }

        public Rogue m_RogueState
        {
            get { return _RogueState; }
            set
            {
                _RogueState = value;
                if (TacticsStateChanged != null)
                    TacticsStateChanged(this, new EventArgs());
            }
        }

        public White_Mage m_WhiteMageState
        {
            get { return _WhiteMageState; }
            set
            {
                _WhiteMageState = value;
                if (TacticsStateChanged != null)
                    TacticsStateChanged(this, new EventArgs());
            }
        }

        public Black_Mage m_BlackMageState
        {
            get { return _BlackMageState; }
            set
            {
                _BlackMageState = value;
                if (TacticsStateChanged != null)
                    TacticsStateChanged(this, new EventArgs());
            }
        }

        public event TacticsStateChangedEventHandler TacticsStateChanged;

        public bool Offensive()
        {
            m_WarriorState = Warrior.Attack;
            m_RogueState = Rogue.Attack;
            m_WhiteMageState = White_Mage.Whtie_Magic;
            m_BlackMageState = Black_Mage.Black_Magic;

            return true;
        }

        public bool Defensive()
        {
            m_WarriorState = Warrior.Defend;
            m_RogueState = Rogue.Defend;
            m_WhiteMageState = White_Mage.Heal;
            m_BlackMageState = Black_Mage.Defend;

            return true;
        }

        public bool Utility()
        {
            m_WarriorState = Warrior.Abilites;
            m_RogueState = Rogue.Steal;
            m_WhiteMageState = White_Mage.Buff;
            m_BlackMageState = Black_Mage.Debuff;

            return true;
        }

        public bool Survive()
        {
            m_WarriorState = Warrior.Escape;
            m_RogueState = Rogue.Escape;
            m_WhiteMageState = White_Mage.Heal;
            m_BlackMageState = Black_Mage.Escape;

            return true;
        }
    }
}
