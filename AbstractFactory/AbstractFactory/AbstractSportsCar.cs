using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractSportsCar // this is the AbstractProduct1 class
    {
        public abstract void createChevy(ChevyFactory.BodyType m_BodyPart, ChevyFactory.Engine m_EnginePart, ChevyFactory.Tires m_TirePart, ChevyFactory.Brand m_BrandType);
        public abstract void createFord(FordFactory.BodyType m_BodyPart, FordFactory.Engine m_EnginePart, FordFactory.Tires m_TirePart, FordFactory.Brand m_BrandType);
    }
}
