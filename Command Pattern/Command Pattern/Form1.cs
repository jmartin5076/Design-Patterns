using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command_Pattern
{
    public partial class Form1 : Form
    {
        string Piece;
        string Start;
        string End;
        ConcreteCommand com;

        public Form1()
        {
            InitializeComponent();
            com = new ConcreteCommand();
        }

        private void m_btnMove_Click(object sender, EventArgs e)
        {
            Piece = m_tbPiece.Text;
            Start = m_tbStart.Text;
            End = m_tbEnd.Text;
            com.execute(Piece,Start,End);
        }

        private void m_tbUndo_Click(object sender, EventArgs e)
        {
            Piece = m_tbPiece.Text;
            Start = m_tbStart.Text;
            com.unexecute(Piece, Start);
        }

        private void m_tbRedo_Click(object sender, EventArgs e)
        {
            Piece = m_tbPiece.Text;
            Start = m_tbStart.Text;
            End = m_tbEnd.Text;
            com.execute(Piece, Start, End);
        }
    }
}
