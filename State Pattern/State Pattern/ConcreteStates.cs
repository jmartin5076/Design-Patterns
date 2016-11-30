using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public class Normal : State // these are the ConcreteState classes
    {
        Random rand = new Random();
        int Attack;

        public override string handleAttack()
        {
            Attack = rand.Next() % 100 + 1;
            return "You deal " + Attack.ToString() + " damage to the enemy.";
        }
    }

    public class Stunned : State
    {
        Random rand = new Random();

        public override string handleAttack()
        {
            return "You are stunned and cannot act on this turn.";
        }
    }

    public class Poisoned : State
    {
        Random rand = new Random();
        int Attack;

        public override string handleAttack()
        {
            Attack = rand.Next() % 100 + 1;
            return "You deal " + Attack.ToString() + " damage to the enemy.";
        }
    }

    public class Burned : State
    {
        Random rand = new Random();
        int Attack;

        public override string handleAttack()
        {
            Attack = rand.Next() % 100 + 1;
            return "You deal " + Attack.ToString() + " damage to the enemy.";
        }
    }

    public class Paralyzed : State
    {
        Random rand = new Random();
        int Attack;
        int AttackChance;

        public override string handleAttack()
        {
            AttackChance = rand.Next() % 100 + 1;

            if(AttackChance>75)
            {
                Attack = rand.Next() % 100 + 1;
                return "You deal " + Attack.ToString() + " damage to the enemy.";
            }
            else
            {
                return "You are paralyzed and cannot attack this turn.";
            }
        }
    }
}
