using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge_Pattern
{
    public partial class Form1 : Form
    {
        AbstractionImp AbsImp;

        public Form1()
        {
            InitializeComponent();
        }

        private void m_btnAdmin_Click(object sender, EventArgs e)
        {
            AbsImp = new AbstractionImp(new AdminUser());
            AbsImp.changeUser();
        }

        private void m_btnRegular_Click(object sender, EventArgs e)
        {
            AbsImp = new AbstractionImp(new RegularUser());
            AbsImp.changeUser();
        }
    }
}
