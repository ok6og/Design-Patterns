using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.command
{
    public class Cashier
    {

        public void TakeOrder(string order)
        {
            Console.WriteLine("Serving burger!");

        }
        public void RemoveOrder(string order)
        {
            Console.WriteLine("Order was canceled Successfully!");
        }
    }
}
