﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteIterator : Iterator // this is the ConcreteIterator class
    {
        Aggregate aggregate;
        int CurrentIndex;

        public ConcreteIterator(Aggregate agg)
        {
            aggregate = agg;
        }

        public override object currentItem()
        {
            if(isDone())
            {
                return null;
            }
           return aggregate.Members[CurrentIndex];
        }

        public override object first()
        {
            CurrentIndex = 0;
            return currentItem();
        }

        public override bool isDone()
        {
            return (CurrentIndex > aggregate.Members.Count - 1);
        }

        public override object next()
        {
            if(!isDone())
            {
                CurrentIndex++;
            }
            return currentItem();
        }
    }
}
