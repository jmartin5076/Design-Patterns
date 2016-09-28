using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FordFactory : AbstractCarFactory // this is the ConcreteFactory2 class
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

        public override void createSedan()
        {
            throw new NotImplementedException();
        }

        public override void createSportsCar()
        {
            throw new NotImplementedException();
        }

        public override void createTruck()
        {
            throw new NotImplementedException();
        }
    }
}
