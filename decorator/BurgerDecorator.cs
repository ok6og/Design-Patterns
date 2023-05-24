using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.decorator
{
    public abstract class BurgerDecorator : IBurger
    {
        protected IBurger decoratedBurger;

        public BurgerDecorator(IBurger decoratedBurger)
            :base()
        {
            this.decoratedBurger = decoratedBurger;
        }

        public virtual void Create() => this.decoratedBurger.Create();
        
    }
}
