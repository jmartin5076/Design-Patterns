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
    public partial class Form1 : Form
    {
        Warrior war;
        Rogue rg;
        White_Mage wm;
        Black_Mage bm;
        ConcreteParty concreteParty;
        Factory factory;
        
        public Form1()
        {
            InitializeComponent();
            war = new Warrior();
            rg = new Rogue();
            wm = new White_Mage();
            bm = new Black_Mage();
            concreteParty = new ConcreteParty();
            factory = new ConcreteFactory();
            war.WarriorStateChanged += new WarriorStateChangedEventHandler(war_WarriorStateChanged);
            rg.RogueStateChanged += new RogueStateChangedEventHandler(rg_RogueStateChanged);
            wm.WhiteMageStateChanged += new WhiteMageStateChangedEventHandler(wm_WhiteMageStateChanged);
            bm.BlackMageStateChanged += new BlackMageStateChangedEventHandler(bm_BlackMageStateChanged);
        }

        void war_WarriorStateChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        void rg_RogueStateChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        void wm_WhiteMageStateChanged(object sender,EventArgs e)
        {
            UpdateStatus();
        }

        void bm_BlackMageStateChanged(object sender,EventArgs e)
        {
            UpdateStatus();
        }

        public void UpdateStatus()
        {
            m_tbWarrior.Text = war.m_WarriorState.ToString();
            m_tbRogue.Text = rg.m_RogueState.ToString();
            m_tbWhiteMage.Text = wm.m_WhiteMageState.ToString();
            m_tbBlackMage.Text = bm.m_BlackMageState.ToString();
        }

        private void m_btnOffense_Click(object sender, EventArgs e)
        {
            war.m_WarriorState = Warrior.WarriorState.Attack;
            rg.m_RogueState = Rogue.RogueState.Attack;
            wm.m_WhiteMageState = White_Mage.WhiteMageState.White_Magic;
            bm.m_BlackMageState = Black_Mage.BlackMageState.Black_Magic;
            factory.createParty(war.m_WarriorState, rg.m_RogueState, wm.m_WhiteMageState, bm.m_BlackMageState);
        }

        private void m_btnDefense_Click(object sender, EventArgs e)
        {
            war.m_WarriorState = Warrior.WarriorState.Defend;
            rg.m_RogueState = Rogue.RogueState.Defend;
            wm.m_WhiteMageState = White_Mage.WhiteMageState.Heal;
            bm.m_BlackMageState = Black_Mage.BlackMageState.Defend;
            factory.createParty(war.m_WarriorState, rg.m_RogueState, wm.m_WhiteMageState, bm.m_BlackMageState);
        }

        private void m_btnUtility_Click(object sender, EventArgs e)
        {
            war.m_WarriorState = Warrior.WarriorState.Abilities;
            rg.m_RogueState = Rogue.RogueState.Steal;
            wm.m_WhiteMageState = White_Mage.WhiteMageState.Buff;
            bm.m_BlackMageState = Black_Mage.BlackMageState.Debuff;
            factory.createParty(war.m_WarriorState, rg.m_RogueState, wm.m_WhiteMageState, bm.m_BlackMageState);
        }

        private void m_btnSurvive_Click(object sender, EventArgs e)
        {
            war.m_WarriorState = Warrior.WarriorState.Escape;
            rg.m_RogueState = Rogue.RogueState.Escape;
            wm.m_WhiteMageState = White_Mage.WhiteMageState.Heal;
            bm.m_BlackMageState = Black_Mage.BlackMageState.Escape;
            factory.createParty(war.m_WarriorState, rg.m_RogueState, wm.m_WhiteMageState, bm.m_BlackMageState);
        }
    }
}
