using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.factory
{
    public class KingBurger : KitchenProduct
    {
        public override void Create() => Console.WriteLine("Preparing King Burger!");
    }
}
