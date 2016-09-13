using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public delegate void BlackMageStateChangedEventHandler(object sender, EventArgs e);

     public class Black_Mage
    {
        public event BlackMageStateChangedEventHandler BlackMageStateChanged;
        public enum BlackMageState { Black_Magic,Debuff,Defend,Escape }

        private BlackMageState _BlackMageState;

        public BlackMageState m_BlackMageState
        {
            get
            {
                return _BlackMageState;
            }
            set
            {
                _BlackMageState = value;
                if (BlackMageStateChanged != null)
                    BlackMageStateChanged(this, new EventArgs());
            }
        }
    }
}
