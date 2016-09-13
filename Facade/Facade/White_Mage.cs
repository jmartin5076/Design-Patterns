using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public delegate void WhiteMageStateChangedEventHandler(object sender, EventArgs e);

     public class White_Mage
    {
        public event WhiteMageStateChangedEventHandler WhiteMageStateChanged;
        public enum WhiteMageState { White_Magic,Heal,Buff}

        private WhiteMageState _WhiteMageState;

        public WhiteMageState m_WhiteMageState
        {
            get
            {
                return _WhiteMageState;
            }
            set
            {
                _WhiteMageState = value;
                if (WhiteMageStateChanged != null)
                    WhiteMageStateChanged(this, new EventArgs());
            }
        }
    }
}
