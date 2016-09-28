using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractCarFactory // this is the AbstractFactory class
    {
        public abstract void createSportsCar();
        public abstract void createSedan();
        public abstract void createTruck();
    }
}
