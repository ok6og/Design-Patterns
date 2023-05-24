using designPattterns.command;
using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns
{
    public class Restourant
    {
        private static Restourant _instance;
        private MainChef chef;
        private Cashier cashier;

        private Restourant() { }

        public static Restourant getInstance()
        {
            if (_instance == null) { _instance = new Restourant(); }
            return _instance;
        }
        public void Open()
        {
            Console.WriteLine("Restaurant is open!");
        }

        public void Close()
        {
            Console.WriteLine("Restaurant is closed!");
        }
        public void personal(MainChef chef,Cashier cashier)
        {
            this.chef = chef;
            this.cashier = cashier;

        }
        public MainChef getChef()
        {
            return chef;
        }
        public Cashier getCashier()
        {
            return cashier;
        }
    }
}
