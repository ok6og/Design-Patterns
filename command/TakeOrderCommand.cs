using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.command
{
    public class TakeOrderCommand : ICommand
    {
        private Cashier cashier;
        public string order;
        public string sauce;

        public TakeOrderCommand(Cashier cashier,string order,string sauce)
        {
            this.cashier = cashier;
            this.order = order;
            this.sauce = sauce;
            Console.WriteLine("Order taken successfully!");
        }
        public void Execute()
        {
            this.cashier.TakeOrder(order);
        }

        public void Undo()
        {
            this.cashier.RemoveOrder(order);
        }
    }
}
