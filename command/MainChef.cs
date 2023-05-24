using designPattterns.decorator;
using designPattterns.factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.command
{
    public class MainChef
    {
        private TakeOrderCommand command;

        public void setCommand(TakeOrderCommand command)
        {
            this.command = command;
        }

        public void cookOrder()
        {
            if (this.command == null)
            {
                Console.WriteLine("There is no order!");
                return;
            }

            KitchenFactory burgerFactory = new BurgerFactory();
            IBurger burger = burgerFactory.produceBurger(command.order);
            if (command.sauce != null)
            {
                SauceDecorator burgerWithSauce = new SauceDecorator(burger, command.sauce);
                burgerWithSauce.Create();
            }
            
            this.command.Execute();
        }
        public void cancelOrder()
        {
            if (this.command == null)
            {
                Console.WriteLine("There is no such order to be Canceled!");
                return;
            }
            this.command.Undo();
        }
    }
}
