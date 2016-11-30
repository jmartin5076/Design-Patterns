using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State_Pattern
{
    public partial class Form1 : Form
    {
        string State;
        State s;
        Random rand = new Random();
        int Health;
        int Damage;

        public Form1()
        {
            InitializeComponent();
            m_lblHealth.Text = "HP:   200/200";
            m_lblStatus.Text = "Status:   Normal";
            Health = 200;
        }

        private void m_btnAttack_Click(object sender, EventArgs e)
        {
            if(m_rbNormal.Checked)
            {
                s = new Normal();
                State = "Normal";
                m_lblStatus.Text = "Status:   " + State;
                m_tbBattleLog.Text = s.handleAttack() + Environment.NewLine + m_tbBattleLog.Text;
            }
            else if(m_rbStunned.Checked)
            {
                s = new Stunned();
                State = "Stunned";
                m_lblStatus.Text = "Status:   " + State;
                m_tbBattleLog.Text = s.handleAttack() + Environment.NewLine + m_tbBattleLog.Text;
            }
            else if(m_rbPoisoned.Checked)
            {
                s = new Poisoned();
                State = "Poisoned";
                m_lblStatus.Text = "Status:   " + State;
                m_tbBattleLog.Text = s.handleAttack() + "You take " + calculateDamage() + " damage." + Environment.NewLine + m_tbBattleLog.Text;
                if (Health <= 0)
                {
                    State = "Dead";
                    m_lblStatus.Text = "Status:   " + State;
                    m_tbBattleLog.Text = "You have died. Try again mortal!";
                }
            }
            else if(m_rbBurned.Checked)
            {
                s = new Burned();
                State = "Burned";
                m_lblStatus.Text = "Status:   " + State;
                m_tbBattleLog.Text = s.handleAttack() +"You take "+ calculateDamage()+" damage." + Environment.NewLine + m_tbBattleLog.Text;
                if (Health <= 0)
                {
                    State = "Dead";
                    m_lblStatus.Text = "Status:   " + State;
                    m_tbBattleLog.Text = "You have died. Try again mortal!";
                }
            }
            else if(m_rbParalyzed.Checked)
            {
                s = new Paralyzed();
                State = "Paralyzed";
                m_lblStatus.Text = "Status:   " + State;
                m_tbBattleLog.Text = s.handleAttack() + Environment.NewLine + m_tbBattleLog.Text;
            }

            if(State=="Dead")
            {
                m_tbBattleLog.Text = "You can't do that while you're dead." + Environment.NewLine + m_tbBattleLog.Text;
            }
        }

        private string calculateDamage()
        {
            if(State=="Poisoned")
            {
                Damage = rand.Next() % 20 + 1;
            }
            if(State=="Burned")
            {
                Damage = rand.Next() % 10 + 1;
            }

            Health -= Damage;
            if (Health>-19)
            {
                m_lblHealth.Text = "HP:   " + Health.ToString() + "/200";
            }
            return Damage.ToString();
        }
    }
}
