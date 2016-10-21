using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy_Pattern
{
    public partial class Form1 : Form
    {
        Power_Move pm;
        Normal_Nature nn;
        Utility_Mode um;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            pm = new Power_Move();
            nn = new Normal_Nature();
            um = new Utility_Mode();
        }

        private void m_btnAttack_Click(object sender, EventArgs e)
        {
            pm.partyCommand();
        }

        private void m_btnNormal_Click(object sender, EventArgs e)
        {
            nn.partyCommand();
        }

        private void m_btnUtility_Click(object sender, EventArgs e)
        {
            um.partyCommand();
        }

        private void m_btnRandom_Click(object sender, EventArgs e)
        {
            int randNum;
            randNum=rand.Next() % 10;

            if(randNum<=3)
            {
                um.partyCommand();
            }
            if(randNum>3 && randNum<=6)
            {
                nn.partyCommand();
            }
            if(randNum>7 && randNum<=9)
            {
                pm.partyCommand();
            }
        }
    }
}
