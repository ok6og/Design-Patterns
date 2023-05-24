using designPattterns.command;
using designPattterns.factory;
using static designPattterns.factory.ConstantsBurgerTypes;
using static designPattterns.factory.ConstantsSauces;
using System;
using designPattterns.decorator;

namespace designPattterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restourant restourant = Restourant.getInstance();
            Cashier cashier = new Cashier();
            MainChef chef = new MainChef();
            restourant.personal(chef,cashier);

            restourant.Open();

            TakeOrderCommand OrderClassicBurgerWithKetchupSauce = new TakeOrderCommand(restourant.getCashier(), classicBurger,ketchupSauce);
            restourant.getChef().setCommand(OrderClassicBurgerWithKetchupSauce);
            restourant.getChef().cookOrder();
            restourant.getChef().cancelOrder();

            TakeOrderCommand OrderKingBurgerWithoutSauce = new TakeOrderCommand(restourant.getCashier(), kingBurger, null);
            restourant.getChef().setCommand(OrderKingBurgerWithoutSauce);
            restourant.getChef().cookOrder();

            TakeOrderCommand OrderVegitarianWithGarlicSauce = new TakeOrderCommand(restourant.getCashier(), vegBurger, garlicSauce);
            restourant.getChef().setCommand(OrderVegitarianWithGarlicSauce);
            restourant.getChef().cookOrder();

            restourant.Close();
        }
    }
}
