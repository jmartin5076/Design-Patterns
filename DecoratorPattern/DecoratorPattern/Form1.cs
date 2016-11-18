using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern
{
    public partial class Form1 : Form
    {
        Sundae sundae;
        string s;

        public Form1()
        {
            InitializeComponent();
            s = "You have ordered";
        }

        private void m_btnOrder_Click(object sender, EventArgs e)
        {
            sundae = new ConcreteSundae();
            s = sundae.orderSundae(s);

            if(m_rbVanilla.Checked)
            {
                sundae = new Vanilla();
            }
            else if(m_rbChocolate.Checked)
            {
                sundae = new Chocolate();
            }
            else if(m_rbStrawberry.Checked)
            {
                sundae = new Strawberry();
            }
            else if(m_rbTwist.Checked)
            {
                sundae = new Twist();
            }
            else if(m_rbNeo.Checked)
            {
                sundae = new Neopolitan();
            }
            s = sundae.orderSundae(s);

            if(m_cbSprinkles.Checked)
            {
                sundae = new Sprinkles();
                s = sundae.orderSundae(s);
            }
            if(m_cbChocoSyrup.Checked)
            {
                sundae = new ChocolateSyrup();
                s = sundae.orderSundae(s);
            }
            if(m_cbHotFudge.Checked)
            {
                sundae = new HotFudge();
                s = sundae.orderSundae(s);
            }
            if(m_cbPeanuts.Checked)
            {
                sundae = new Peanuts();
                s = sundae.orderSundae(s);
            }
            if(m_cbCaramel.Checked)
            {
                sundae = new Caramel();
                s = sundae.orderSundae(s);
            }
            if(m_cbGummyBears.Checked)
            {
                sundae = new GummyBears();
                s = sundae.orderSundae(s);
            }
            if(m_cbPeppermints.Checked)
            {
                sundae = new Peppermints();
                s = sundae.orderSundae(s);
            }
            if(m_cbButterscotch.Checked)
            {
                sundae = new Butterscotch();
                s = sundae.orderSundae(s);
            }
            if(m_cbReese.Checked)
            {
                sundae = new Reeses();
                s = sundae.orderSundae(s);
            }
            if(m_cbOreo.Checked)
            {
                sundae = new Oreo();
                s = sundae.orderSundae(s);
            }

            m_tbOrderLog.Text = s+"."+Environment.NewLine+m_tbOrderLog.Text;
            s = "You have ordered";
        }
    }
}
