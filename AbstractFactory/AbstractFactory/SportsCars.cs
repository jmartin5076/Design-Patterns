using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{ // these are the ConcreteProductA classes
    public class ChevyCamaro : AbstractSportsCar
    {
        public Form2 f2;

        public override void createChevy(ChevyFactory.BodyType m_BodyPart, ChevyFactory.Engine m_EnginePart, ChevyFactory.Tires m_TirePart, ChevyFactory.Brand m_BrandType)
        {
            f2 = new Form2(m_BodyPart, m_EnginePart, m_TirePart, m_BrandType);
            f2.Visible = true;
        }

        public override void createFord(FordFactory.BodyType m_BodyPart, FordFactory.Engine m_EnginePart, FordFactory.Tires m_TirePart, FordFactory.Brand m_BrandType)
        {
           
        }
    }

    public class FordMustang : AbstractSportsCar
    {
        public Form2 f2;

        public override void createChevy(ChevyFactory.BodyType m_BodyPart, ChevyFactory.Engine m_EnginePart, ChevyFactory.Tires m_TirePart, ChevyFactory.Brand m_BrandType)
        {
            
        }

        public override void createFord(FordFactory.BodyType m_BodyPart, FordFactory.Engine m_EnginePart, FordFactory.Tires m_TirePart, FordFactory.Brand m_BrandType)
        {
            f2 = new Form2(m_BodyPart, m_EnginePart, m_TirePart, m_BrandType);
            f2.Visible = true;
        }
    }
}
