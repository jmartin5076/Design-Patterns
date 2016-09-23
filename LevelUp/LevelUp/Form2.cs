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
    public partial class Form2 : Form
    {

        public delegate void QuestCompleteEventHandler(object sender, QuestEventArgs e);

        public event QuestCompleteEventHandler QuestComplete;

        public Form2()
        {
            InitializeComponent();
        }

        private void m_btnCompleteQuest_Click(object sender, EventArgs e)
        {
            if (QuestComplete != null)
            {
                QuestComplete(this, new QuestEventArgs("25","0"));
            }
            this.Close();
        }
    }
}

/// <summary>
/// QuestEventArgs provides a class for the event arguement used
/// by the QuestCompleteEventHandler style events. This allows us to pass
/// EXP and the level through the event handler back to the subscribers
/// </summary>
public class QuestEventArgs : EventArgs
{
    private string _EXP;

    public string m_EXP
    {
        get { return _EXP; }
        set { _EXP = value; }
    }

    private string _Level;

    public string m_Level
    {
        get { return _Level; }
        set { _Level = value; }
    }

    public QuestEventArgs(string Exp, string Level)
    {
        m_EXP = Exp;
        m_Level = Level;
    }
}