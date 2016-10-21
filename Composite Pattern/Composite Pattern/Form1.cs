using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite_Pattern
{
    public partial class Form1 : Form
    {
        static List<Component> abilityList = new List<Component>()
        {
            new Leaf("Stomp","Stun"),
            new Leaf("Charge","Daze"),
            new Leaf("Interrupt","Silence"),
            new Leaf("Blaze","Burn"),
            new Leaf("Freeze","Chill"),
            new Leaf("Shock","Paralyze")
        };

        static List<Component> comboList = new List<Component>()
        {
            new Composite("Leap",abilityList[1],abilityList[0]),
            new Composite("Tremor",abilityList[0],abilityList[0]),
            new Composite("Flash Freeze",abilityList[4],abilityList[4]),
            new Composite("Frostbite",abilityList[4],abilityList[3]),
            new Composite("Lightningbolt",abilityList[5],abilityList[2])
        };

        public Form1()
        {
            InitializeComponent();

            m_rbAbility.Checked = true;
            populate(m_cbList, abilityList);
        }

        private void populate(ComboBox cb, List<Component> l)
        {
            cb.Items.Clear();
            
            foreach(Component c in l)
            {
                cb.Items.Add(c);
            }

            cb.SelectedItem = l[0];
        }

        private void m_rbCombo_CheckedChanged(object sender, EventArgs e)
        {
            populate(m_cbList, comboList);
        }

        private void m_rbAbility_CheckedChanged(object sender, EventArgs e)
        {
            populate(m_cbList, abilityList);
        }

        private void m_btnAbility_Click(object sender, EventArgs e)
        {
            Component ability = (Component)m_cbList.SelectedItem;
            string condition = "";

            if (ability.getCondition()=="Stun")
            {
                condition = "Stunned";
            }
            if (ability.getCondition() == "Daze")
            {
                condition = "Dazed";
            }
            if (ability.getCondition() == "Silence")
            {
                condition = "Silenced";
            }
            if (ability.getCondition() == "Burn")
            {
                condition = "Burned";
            }
            if (ability.getCondition() == "Chill")
            {
                condition = "Chilled";
            }
            if (ability.getCondition() == "Paralyze")
            {
                condition = "Paralyzed";
            }
            if(ability.getCondition() == " Daze Stun")
            {
                condition = "Dazed and Stunned";
            }
            if (ability.getCondition() == " Stun Stun")
            {
                condition = "Unconscious";
            }
            if (ability.getCondition() == " Chill Chill")
            {
                condition = "Frozen";
            }
            if (ability.getCondition() == " Chill Burn")
            {
                condition = "Chilled and Burned";
            }
            if (ability.getCondition() == " Paralyze Silence")
            {
                condition = "Paralyzed and Silenced";
            }

            m_tbLog.Text += "You used " + ability + " and the creature is now " + condition + Environment.NewLine;
        }
    }
}
