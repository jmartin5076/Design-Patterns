using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter_Pattern
{
    public partial class Form1 : Form
    {
        Adapter adapter;

        public Form1()
        {
            InitializeComponent();
            adapter = new Adapter();
        }

        private void m_btnAdapt_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(m_tbUSD.Text);

            m_tbEuro.Text = adapter.request(x).ToString();
        }
    }
}
