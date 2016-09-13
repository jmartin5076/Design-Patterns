using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public delegate void WarriorStateChangedEventHandler(object sender, EventArgs e);

     public class Warrior
    {
        public event WarriorStateChangedEventHandler WarriorStateChanged;
        public enum WarriorState {Attack,Defend,Abilities,Escape}

        private WarriorState _WarriorState;

        public WarriorState m_WarriorState
        {
            get
            {
                return _WarriorState;
            }
            set
            {
                _WarriorState = value;
                if (WarriorStateChanged != null)
                    WarriorStateChanged(this, new EventArgs());
            }
        }
    }
}
