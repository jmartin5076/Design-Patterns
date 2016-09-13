using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public delegate void RogueStateChangedEventHandler(object sender, EventArgs e);

     public class Rogue
    {
        public event RogueStateChangedEventHandler RogueStateChanged;
        public enum RogueState { Attack, Defend, Steal, Escape }

        private RogueState _RogueState;

        public RogueState m_RogueState
        {
            get
            {
                return _RogueState;
            }
            set
            {
                _RogueState = value;
                if (RogueStateChanged != null)
                    RogueStateChanged(this, new EventArgs());
            }
        }
    }
}
