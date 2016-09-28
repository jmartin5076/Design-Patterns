using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ChevyFactory : AbstractCarFactory // this is the ConcreteFactory1 class
    {
        public enum BodyType { Sports, Sedan, Truck }
        public enum Engine { FourCylinder, V6, V8 }
        public enum Tires { Sports, Regular, HeavyDuty }
        public enum Brand { Chevy, Ford }
        private BodyType _BodyPart;
        private Engine _EnginePart;
        private Tires _TirePart;
        private Brand _BrandType;

        public BodyType m_BodyPart
        {
            get { return _BodyPart; }
            set
            {
                _BodyPart = value;
            }
        }

        public Engine m_EnginePart
        {
            get { return _EnginePart; }
            set
            {
                _EnginePart = value;
            }
        }

        public Tires m_TirePart
        {
            get { return _TirePart; }
            set
            {
                _TirePart = value;
            }
        }

        public Brand m_BrandType
        {
            get { return _BrandType; }
            set
            {
                _BrandType = value;
            }
        }

        public override ChevyCamaro createCamaro(ChevyFactory.BodyType m_BodyPart, ChevyFactory.Engine m_EnginePart, ChevyFactory.Tires m_TirePart, ChevyFactory.Brand m_BrandType)
        {
            return new ChevyCamaro(m_BodyPart, m_EnginePart, m_TirePart, m_BrandType);
        }

        public override ChevyMalibu createMalibu(ChevyFactory.BodyType m_BodyPart, ChevyFactory.Engine m_EnginePart, ChevyFactory.Tires m_TirePart, ChevyFactory.Brand m_BrandType)
        {
            return new ChevyMalibu(m_BodyPart, m_EnginePart, m_TirePart, m_BrandType);
        }

        public override ChevySilverado createSilverado(ChevyFactory.BodyType m_BodyPart, ChevyFactory.Engine m_EnginePart, ChevyFactory.Tires m_TirePart, ChevyFactory.Brand m_BrandType)
        {
            return new ChevySilverado(m_BodyPart, m_EnginePart, m_TirePart, m_BrandType);
        }

        public override FordMustang createMustang(FordFactory.BodyType m_BodyPart, FordFactory.Engine m_EnginePart, FordFactory.Tires m_TirePart, FordFactory.Brand m_BrandType)
        {
            throw new NotImplementedException();
        }

        public override FordFusion createFusion(FordFactory.BodyType m_BodyPart, FordFactory.Engine m_EnginePart, FordFactory.Tires m_TirePart, FordFactory.Brand m_BrandType)
        {
            throw new NotImplementedException();
        }

        public override FordF150 createF150(FordFactory.BodyType m_BodyPart, FordFactory.Engine m_EnginePart, FordFactory.Tires m_TirePart, FordFactory.Brand m_BrandType)
        {
            throw new NotImplementedException();
        }
    }
}
