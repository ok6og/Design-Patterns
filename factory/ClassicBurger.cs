using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.factory
{
    public class ClassicBurger : KitchenProduct
    {
        public override void Create() => Console.WriteLine("Preparing Classic Burger!");
    }
}
