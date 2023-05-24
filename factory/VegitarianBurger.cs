using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.factory
{
    public class VegitarianBurger : KitchenProduct
    {
        public override void Create() => Console.WriteLine("Preparing Vegitarian burger!");
    }
}
