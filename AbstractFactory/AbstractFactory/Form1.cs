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
    public partial class Form1 : Form
    {
        ChevyFactory factory1;
        FordFactory factory2;
        ChevyCamaro camaro;
        ChevyMalibu malibu;
        ChevySilverado silverado;
        FordMustang mustang;
        FordFusion fusion;
        FordF150 f150;

        public Form1()
        {
            InitializeComponent();
            factory1 = new ChevyFactory();
            factory2 = new FordFactory();
            camaro = new ChevyCamaro();
            malibu = new ChevyMalibu();
            silverado = new ChevySilverado();
            mustang = new FordMustang();
            fusion = new FordFusion();
            f150 = new FordF150();
        }

        private void m_btnCamaro_Click(object sender, EventArgs e)
        {
            factory1.m_BodyPart = ChevyFactory.BodyType.Sports;
            factory1.m_EnginePart = ChevyFactory.Engine.V8;
            factory1.m_TirePart = ChevyFactory.Tires.Sports;
            factory1.m_BrandType = ChevyFactory.Brand.Chevy;
            factory1.createCamaro(factory1.m_BodyPart, factory1.m_EnginePart, factory1.m_TirePart, factory1.m_BrandType);
        }

        private void m_btnMalibu_Click(object sender, EventArgs e)
        {
            factory1.m_BodyPart = ChevyFactory.BodyType.Sedan;
            factory1.m_EnginePart = ChevyFactory.Engine.FourCylinder;
            factory1.m_TirePart = ChevyFactory.Tires.Regular;
            factory1.m_BrandType = ChevyFactory.Brand.Chevy;
            factory1.createMalibu(factory1.m_BodyPart, factory1.m_EnginePart, factory1.m_TirePart, factory1.m_BrandType);
        }

        private void m_btnSilverado_Click(object sender, EventArgs e)
        {
            factory1.m_BodyPart = ChevyFactory.BodyType.Truck;
            factory1.m_EnginePart = ChevyFactory.Engine.V6;
            factory1.m_TirePart = ChevyFactory.Tires.HeavyDuty;
            factory1.m_BrandType = ChevyFactory.Brand.Chevy;
            factory1.createSilverado(factory1.m_BodyPart, factory1.m_EnginePart, factory1.m_TirePart, factory1.m_BrandType);
        }

        private void m_btnMustang_Click(object sender, EventArgs e)
        {
            factory2.m_BodyPart = FordFactory.BodyType.Sports;
            factory2.m_EnginePart = FordFactory.Engine.V8;
            factory2.m_TirePart = FordFactory.Tires.Sports;
            factory2.m_BrandType = FordFactory.Brand.Ford;
            factory2.createMustang(factory2.m_BodyPart, factory2.m_EnginePart, factory2.m_TirePart, factory2.m_BrandType);
        }

        private void m_btnFusion_Click(object sender, EventArgs e)
        {
            factory2.m_BodyPart = FordFactory.BodyType.Sedan;
            factory2.m_EnginePart = FordFactory.Engine.FourCylinder;
            factory2.m_TirePart = FordFactory.Tires.Regular;
            factory2.m_BrandType = FordFactory.Brand.Ford;
            factory2.createFusion(factory2.m_BodyPart, factory2.m_EnginePart, factory2.m_TirePart, factory2.m_BrandType);
        }

        private void m_btnF150_Click(object sender, EventArgs e)
        {
            factory2.m_BodyPart = FordFactory.BodyType.Truck;
            factory2.m_EnginePart = FordFactory.Engine.V6;
            factory2.m_TirePart = FordFactory.Tires.HeavyDuty;
            factory2.m_BrandType = FordFactory.Brand.Ford;
            factory2.createF150(factory2.m_BodyPart, factory2.m_EnginePart, factory2.m_TirePart, factory2.m_BrandType);
        }
    }
}
