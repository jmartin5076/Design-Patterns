using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{ // these are the ConcreteProductB classes
    public class ChevyMalibu : AbstractSedan
    {
        public ChevyMalibu()
        {

        }

        public ChevyMalibu(ChevyFactory.BodyType m_BodyPart, ChevyFactory.Engine m_EnginePart, ChevyFactory.Tires m_TirePart, ChevyFactory.Brand m_BrandType)
        {
            Form2 f2 = new Form2(m_BodyPart, m_EnginePart, m_TirePart, m_BrandType);
            f2.Visible = true;
        }
    }

    public class FordFusion : AbstractSedan
    {
        public FordFusion()
        {

        }

        public FordFusion(FordFactory.BodyType m_BodyPart, FordFactory.Engine m_EnginePart, FordFactory.Tires m_TirePart, FordFactory.Brand m_BrandType)
        {
            Form2 f2 = new Form2(m_BodyPart, m_EnginePart, m_TirePart, m_BrandType);
            f2.Visible = true;
        }
    }
}
