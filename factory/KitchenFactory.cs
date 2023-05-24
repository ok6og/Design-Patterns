using designPattterns.decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.factory
{
    public abstract class KitchenFactory
    {
        public abstract KitchenProduct createProduct(string burgerName);
        public KitchenProduct produceBurger(string burgerName)
        {
            KitchenProduct burger = createProduct(burgerName);
            burger.Create();
            return burger;
        }
    }
}
