using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Composite : Component
    {
        private string Ability;
        private List<Component> conditions = new List<Component>();


        public Composite(string ability,Component a1,Component a2)
        {
            Ability = ability;
            addComponent(a1);
            addComponent(a2);
        }

        public override string getCondition()
        {
            string totalConditions = "";

            foreach(Leaf l in conditions)
            {
                totalConditions += " "+l.getCondition();
            }

            return totalConditions;
        }

        public void addComponent(Component com)
        {
            conditions.Add(com);
        }

        public void removeComponent(Component com)
        {
            conditions.Remove(com);
        }

        public Component getChild(int index)
        {
            return conditions[index];
        }

        public override string ToString()
        {
            return Ability;
        }
    }
}
