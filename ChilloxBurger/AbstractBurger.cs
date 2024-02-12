using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilloxBurger
{
    public abstract class AbstractBurger : IBurger
    {
        protected string? burgerType;
        protected decimal chickenCost = 100;
        protected decimal beefCost = 120;
        protected decimal vegetableCost = 80;

        protected decimal BunCost;
        protected decimal CheeseCost;
        protected decimal SpicyCost;
        protected decimal FrenchFriesCost;
        protected decimal ShakesCost;

        protected decimal chickenBurgerCost;
        protected decimal beefBurgerCost;
        protected decimal vegetableBurgerCost;

        public abstract decimal cost(decimal cost);

        public virtual void display()
        {
            Console.WriteLine("Welcome to Chillox Burger.");
        }
    }
}
