using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.decorator
{
    public class SauceDecorator : BurgerDecorator
    {
        private string sauce;
        public SauceDecorator(IBurger decoratedBurger, string sauce) : base(decoratedBurger)
        {
            this.sauce = sauce;
        }

        public override void Create()
        {
            this.addSauce();
        }

        private void addSauce()
        {
            Console.WriteLine($"Adding {this.sauce} to {decoratedBurger.GetType().Name}");
        }
    }
}
