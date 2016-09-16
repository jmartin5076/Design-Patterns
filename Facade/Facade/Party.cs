using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade
{
    public partial class Party : Form //this is the Product class
    {
        public Party()
        {

        }

        public Party(Warrior.WarriorState m_WarriorState, Rogue.RogueState m_RogueState, White_Mage.WhiteMageState m_WhiteMageState, Black_Mage.BlackMageState m_BlackMageState)
        {
            InitializeComponent();
            m_tbWarrior.Text = m_WarriorState.ToString();
            m_tbRogue.Text = m_RogueState.ToString();
            m_tbWhiteMage.Text = m_WhiteMageState.ToString();
            m_tbBlackMage.Text = m_BlackMageState.ToString();
        }
    }
}
