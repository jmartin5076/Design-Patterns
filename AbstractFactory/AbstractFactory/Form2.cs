using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
        }

        public Form2(ChevyFactory.BodyType m_BodyPart, ChevyFactory.Engine m_EnginePart, ChevyFactory.Tires m_TirePart, ChevyFactory.Brand m_BrandType)
        {
            InitializeComponent();
            m_tbBody.Text = m_BodyPart.ToString();
            m_tbEngine.Text = m_EnginePart.ToString();
            m_tbTires.Text = m_TirePart.ToString();
            m_tbLogo.Text = m_BrandType.ToString();
        }

        public Form2(FordFactory.BodyType m_BodyPart, FordFactory.Engine m_EnginePart, FordFactory.Tires m_TirePart, FordFactory.Brand m_BrandType)
        {
            InitializeComponent();
            m_tbBody.Text = m_BodyPart.ToString();
            m_tbEngine.Text = m_EnginePart.ToString();
            m_tbTires.Text = m_TirePart.ToString();
            m_tbLogo.Text = m_BrandType.ToString();
        }
    }
}
