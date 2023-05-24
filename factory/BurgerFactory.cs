using System;
using System.Collections.Generic;
using System.Text;
using static designPattterns.factory.ConstantsBurgerTypes;

namespace designPattterns.factory
{
    public class BurgerFactory : KitchenFactory
    {
        public override KitchenProduct createProduct(string burgerName)
        {
            if (burgerName == vegBurger)
            {
                return new VegitarianBurger();
            }
            if (burgerName == classicBurger)
            {
                return new ClassicBurger();
            }
            if (burgerName == kingBurger)
            {
                return new KingBurger();
            }
            Console.WriteLine("There is no such burger!");
            return null;
        }
    }
}
