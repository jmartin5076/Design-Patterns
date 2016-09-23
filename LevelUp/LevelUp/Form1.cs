using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelUp
{
    public partial class Form1 : Form
    {
        int EXP = 0;
        int Level = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void m_btnQuest_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.QuestComplete += new Form2.QuestCompleteEventHandler(f2_QuestComplete);
            f2.Show();
        }

        void f2_QuestComplete(object sender, QuestEventArgs e)
        {
            m_tbStatus.Text = "You gained " + e.m_EXP + " Experience." + 
                                Environment.NewLine + 
                                m_tbStatus.Text;

            EXP += 25;

            if(EXP==100)
            {
                Level += 1;
                LevelUp();
                EXP -= 100;
            }

            m_tbLevel.Text = Level.ToString();
        }

        void LevelUp()
        {
            m_tbStatus.Text = "You are now level " + Level.ToString() + " Your stats have increased!" + 
                                Environment.NewLine + 
                                m_tbStatus.Text;
        }
    }
}
