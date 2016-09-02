using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IteratorPattern
{
    public partial class Form1 : Form
    {
        Aggregate agg = new ConcreteAggregate();
        Iterator iterator;

        public Form1()
        {
            InitializeComponent();
            PrepareAggWithIter();
        }

        private void PrepareAggWithIter()
        {
            agg.Members.Add("Dave");
            agg.Members.Add("Susie");
            agg.Members.Add("Jim");
            agg.Members.Add("Jerry");
            agg.Members.Add("Tim");
            agg.Members.Add("Tom");
            agg.Members.Add("Betty");
            agg.Members.Add("John");
            agg.Members.Add("George");
        }

        private void m_btnIterate_Click(object sender, EventArgs e)
        {
            m_lbMembers.Items.Clear();
                iterator.first();
                while (!iterator.isDone())
                {
                    m_lbMembers.Items.Add(iterator.currentItem());
                    iterator.next();
                }
        }

        private void m_rbMostImport_CheckedChanged(object sender, EventArgs e)
        {
            iterator = agg.createIterator();
        }

        private void m_rbLeastImport_CheckedChanged(object sender, EventArgs e)
        {
            iterator = agg.createIteratorLeastImport();
        }
    }
}
