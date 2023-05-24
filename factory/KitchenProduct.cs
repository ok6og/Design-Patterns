using designPattterns.decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.factory
{
    public abstract class KitchenProduct : IBurger
    {
        private double price;
        public double getPrice() => price;
        public void setPrice(double price) => this.price = price;
        public abstract void Create();
    }
}
