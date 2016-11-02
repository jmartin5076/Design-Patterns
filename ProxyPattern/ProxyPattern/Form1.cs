using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPattern
{
    public partial class Form1 : Form
    {
        Proxy proxy;

        public Form1()
        {
            InitializeComponent();
            proxy = new Proxy();
            m_cbCells.Items.Insert(0, "White Blood Cell");
            m_cbCells.Items.Insert(1, "Red Blood Cell");
            m_cbCells.Items.Insert(2, "Mitochondria");
            m_cbCells.Items.Insert(3, "Nucleus");
            m_cbCells.Items.Insert(4, "Rough ER");
            m_cbCells.Items.Insert(5, "Smooth ER");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proxy.showComponent(m_cbCells.Text);
        }
    }
}
